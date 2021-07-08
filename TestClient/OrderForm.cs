using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormTestClient
{

    public partial class OrderForm : Form
    {
        private string Server { get; set; }
        private string Instance { get; set; }
        private string Session { get; set; }
        public OrderForm(string server, string instance, string session)
        {
            Server = server;
            Instance = instance;
            Session = session;

            InitializeComponent();

            ComboboxItem b = new ComboboxItem();
            b.Text = "Buy";
            b.Value = "1";

            ComboboxItem s = new ComboboxItem();
            s.Text = "Sell";
            s.Value = "2";

            ComboboxItem ss = new ComboboxItem();
            ss.Text = "Sell Short (5)";
            ss.Value = "5";

            cmbSide.Items.Add(b);
            cmbSide.Items.Add(s);
            cmbSide.Items.Add(ss);

            cmbSide.SelectedIndex = 0;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = DateTime.Now.Ticks.ToString();

            txtSymbol.Text =  "IBM";

            numQty.Value = 1000;

        }


        private void btnOk_Click(object sender, EventArgs e)
        {

            if(cmbSide.SelectedItem == null)
            {
                MessageBox.Show("Select a Side Code");
                return;
            }
            NewOrderSingleApi ap = new NewOrderSingleApi(Server);

            NewOrderSingle o = new NewOrderSingle();
            o.ExternalId = txtOrderId.Text;
            o.Quantity = (double)numQty.Value;
            ComboboxItem sel = (ComboboxItem)cmbSide.SelectedItem;
            o.Side = sel.Value.ToString();
            o.Symbol = txtSymbol.Text;

            try
            {
                ap.V1NewOrderSingleOrdersOutInstanceSessionPost(Instance, Session, o);
            }
            catch (ApiException apiEx)
            {
                MessageBox.Show(apiEx.Message);
            }
            

        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
