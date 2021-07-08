using FormTestClient.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTestClient.Controllers
{
    [Route("/WHUpdate")]
    public class WebHookListnerController
    {
        [HttpGet]
        public IActionResult Get()
        {
            var name = "John Doe";
            var greeting = "Hello " + name;
            return new JsonResult(greeting);
        }

        [HttpPost]
        public IActionResult Post(WHOrderUpdate orderUpdate)
        {
            //Program.Form.NameText = name;
            //Program.Form.txtBoxUpdate.Text = "*****UPDATED!****";

            //Program.Form.txtBoxUpdate.Invoke(new MethodInvoker(delegate { name = textbox1.text; }));
            Program.Form.BeginInvoke((Action)(()=> Program.Form.RefreshOrders()));
            return new NoContentResult();
        }
    }
}
