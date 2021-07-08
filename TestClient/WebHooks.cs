using IO.Swagger.Api;
using IO.Swagger.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestClient
{
    public partial class WebHooks : Form
    {
        private string WebAddr = string.Empty;
        private string Instance = string.Empty;
        private string Session = string.Empty;

        WebHookSubscriptionDetails WebHookOrderUpdateDetails = null;
        public WebHooks(string webaddr, string instance, string session)
        {
            WebAddr = webaddr;
            Instance = instance;
            Session = session;
            InitializeComponent();
        }

        private void WebHooks_Load(object sender, EventArgs e)
        {
            try
            {
                WebhooksApi webHookApi = new WebhooksApi(WebAddr);

                List<WebHookSubscriptionDetails> lst = webHookApi.V1WebhooksInstanceSessionGet(Instance, Session);

                foreach (WebHookSubscriptionDetails whd in lst)
                {
                    if (whd.EventName == WebHoookEvent.OrderStateChanged.ToString() )
                    {
                        WebHookOrderUpdateDetails = whd;
                        txtBoxUrl.Text = whd.Url;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateWH_Click(object sender, EventArgs e)
        {

            try
            {
                WebhooksApi webHookApi = new WebhooksApi(WebAddr);

                List<WebHookSubscriptionDetails> lst = webHookApi.V1WebhooksInstanceSessionGet(Instance, Session);

                foreach (WebHookSubscriptionDetails whd in lst)
                {
                    if (whd.EventName == WebHoookEvent.OrderStateChanged.ToString())
                    {
                        webHookApi.V1WebhooksInstanceSessionIdDelete(Instance, Session, whd.WebHookId);
                    }
                }

                WebHookSubscription whs = new WebHookSubscription();
                whs.Instance = Instance;
                whs.SessionName = Session;
                whs.Url = txtBoxUrl.Text;

                whs.WebHoookEvent = WebHoookEvent.OrderStateChanged;

                webHookApi.V1WebhooksInstanceSessionPost(Instance, Session, whs);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            string strConnection = builder.Build().GetConnectionString("DbConnection");

            IConfigurationRoot configRoot = builder.Build();
            if(configRoot["Urls"] != null)
            {
                string strUrls = configRoot["Urls"];
                if (strUrls.Contains(";"))
                {
                    // Get first address:
                    txtBoxUrl.Text = strUrls.Substring(0, strUrls.IndexOf(";")) + "/WHUpdate";
                }
                else
                {
                    txtBoxUrl.Text = strUrls + "/WHUpdate";
                }

                this.Update();
            }


        }
    }
}
