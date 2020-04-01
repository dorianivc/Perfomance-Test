using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Net.Http;
using System.Web.Mvc;
using System.Data;


namespace Try_Best.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()//RAM
        {
            ViewBag.Message = "Your application description page.";
            About();
            return View();
        }

        public ActionResult Contact()//CPU
        {
            while (true)
            {
                Console.WriteLine("Interrumpcion");
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public async System.Threading.Tasks.Task<ActionResult> SalidaAsync()//TCP
        {
            while (true)
            {
                //TcpClient tcpClient = new TcpClient();
                //IPAddress ipAddress = Dns.GetHostEntry("www.google.com").AddressList[0];
                //IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 80);
                //tcpClient.Connect(ipEndPoint);
                string webpage = "http://www.google.com";
                var uri = new Uri(webpage);
                var hc = new HttpClient();
                var result = await hc.GetStringAsync(uri);
            }

        }
    }
}

