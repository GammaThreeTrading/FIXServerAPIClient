using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestClient
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        private string Instance = string.Empty;

        public Form1()
        {
            InitializeComponent();
            txtBoxServer.Text = Properties.Settings.Default.Server;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            if(!string.IsNullOrEmpty(txtBoxServer.Text))
            {

                btnConnect_Click(sender, e);

            }
        }

        public void RefreshOrders()
        {
            try
            {
                if(!string.IsNullOrEmpty(txtBoxServer.Text) && lstBoxSessions.SelectedItem != null)
                {
                    NewOrderSingleApi ordersApi = new NewOrderSingleApi(txtBoxServer.Text);

                    List<NewOrderSingleDetails> ords = ordersApi.V1NewOrderSingleOrdersOutInstanceSessionGet(Instance, lstBoxSessions.SelectedItem.ToString());

                    List<OrderData> gridData = new List<OrderData>();
                    foreach (NewOrderSingleDetails o in ords)
                    {
                        OrderData rowData = new OrderData();
                        if (!string.IsNullOrEmpty(o.VmOrdStatus))
                        {
                            if (o.VmOrdStatus == "0")
                                rowData.Status = "New";
                            else if (o.VmOrdStatus == "1")
                                rowData.Status = "Partially Filled";
                            else if (o.VmOrdStatus == "2")
                                rowData.Status = "Filled";
                            else if (o.VmOrdStatus == "3")
                                rowData.Status = "DoneForDay";
                            else if (o.VmOrdStatus == "4")
                                rowData.Status = "Cancelled";
                            else if (o.VmOrdStatus == "5")
                                rowData.Status = "Replaced";
                            else if (o.VmOrdStatus == "6")
                                rowData.Status = "PendingCancel";
                            else if (o.VmOrdStatus == "7")
                                rowData.Status = "Stopped";
                            else if (o.VmOrdStatus == "8")
                                rowData.Status = "Rejected";
                            else if (o.VmOrdStatus == "9")
                                rowData.Status = "Suspended";
                            else
                                rowData.Status = o.VmOrdStatus;
                        }

                        rowData.AvgPx = o.VmAvgPx;
                        rowData.ClOrdId = o.ClOrdId;
                        rowData.OrderQty = o.Quantity.GetValueOrDefault(0);
                        rowData.QtyExecuted = o.VmQtyExecuted;
                        rowData.Side = o.Side;
                        rowData.Symbol = o.Symbol;
                        rowData.NewOrderSingleId = o.NewOrderSingleId.GetValueOrDefault(0);
                        rowData.LeavesQty = o.VmLeavesQty;

                        gridData.Add(rowData);

                    }
                    dgOrders.DataSource = gridData;
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                InstanceApi instanceApi = new InstanceApi(txtBoxServer.Text);

                bindingSource1.Clear();


                Instance = instanceApi.V1InstanceGet();
                lblInstance.Text = Instance;
                lblInstance.Update();

                SessionsApi sessionAPi = new SessionsApi(txtBoxServer.Text);

                Properties.Settings.Default.Server = txtBoxServer.Text;
                Properties.Settings.Default.Save();
                lstBoxSessions.Items.Clear();
                List<SessionInfo> info = sessionAPi.V1SessionsInstanceGet(Instance);

                foreach (SessionInfo i in info)
                {
                    lstBoxSessions.Items.Add(i.SessionName);

                }

                if (lstBoxSessions.Items.Count > 0)
                {
                    lstBoxSessions.SelectedIndex = 0;
                }


                lstBoxSessions.Update();

                RefreshOrders();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.WaitCursor;

        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            if(lstBoxSessions.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid FIX Session");
                lstBoxSessions.Focus();
                return;
            }
            string server = txtBoxServer.Text;
            string i = lblInstance.Text;
            string s = lstBoxSessions.SelectedItem.ToString();
            OrderForm of = new OrderForm(server, i, s);
            of.ShowDialog();


            RefreshOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshOrders();
        }

        private void dgOrders_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                //ContextMenuStrip m = new ContextMenuStrip();
                //m.Items.Add("Cut");
                //m.Items.Add("Copy");
                //m.Items.Add("Paste");

                int currentMouseOverRow = dgOrders.HitTest(e.X, e.Y).RowIndex;

                if(dgOrders.SelectedRows.Count > 0)
                {
                    
                    currentMouseOverRow = dgOrders.SelectedRows[0].Index;
                    //if (currentMouseOverRow >= 0)
                    //{
                    //    contextMenuStrip1.Items.Add(string.Format("Do something to row {0}", currentMouseOverRow.ToString()));
                    //}

                    contextMenuStrip1.Show(dgOrders, new Point(e.X, e.Y));
                }

            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            if(e.ClickedItem.Text == "Cancel")
            {
                if (dgOrders.SelectedRows.Count > 0)
                {
                    string server = txtBoxServer.Text;
                    string i = lblInstance.Text;
                    string s = lstBoxSessions.SelectedItem.ToString();

                    foreach (DataGridViewRow row in dgOrders.SelectedRows)
                    {
                        IO.Swagger.Api.OrderCancelRequestApi cancelApi = new OrderCancelRequestApi(txtBoxServer.Text);
                        OrderCancelRequest ocr = new OrderCancelRequest();

                        OrderData order = (OrderData)row.DataBoundItem;
                        ocr.ClOrdId = order.ClOrdId;
                        ocr.ExternalId = order.ClOrdId;
                        ocr.NewOrderSingleId = order.NewOrderSingleId;
                        try
                        {
                            cancelApi.V1OrderCancelRequestInstanceSessionPost(i, s, ocr);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }

            }
            else if (e.ClickedItem.Text == "Delete")
            {
                if (dgOrders.SelectedRows.Count > 0)
                {
                    string server = txtBoxServer.Text;
                    string i = lblInstance.Text;
                    string s = lstBoxSessions.SelectedItem.ToString();


                    foreach (DataGridViewRow row in dgOrders.SelectedRows)
                    {
                        IO.Swagger.Api.NewOrderSingleApi orderApi = new NewOrderSingleApi(txtBoxServer.Text);
                        OrderData order = (OrderData)row.DataBoundItem;

                        try
                        {
                            orderApi.V1NewOrderSingleInstanceSessionClordidDelete(i, s, order.ClOrdId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }



                    RefreshOrders();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnWebhooks_Click(object sender, EventArgs e)
        {
            if(lstBoxSessions.SelectedItem != null)
            {
                WebHooks dlgWebHooks = new WebHooks(txtBoxServer.Text, Instance, lstBoxSessions.SelectedItem.ToString());
                dlgWebHooks.ShowDialog();

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
