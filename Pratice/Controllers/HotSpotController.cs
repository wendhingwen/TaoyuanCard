using Newtonsoft.Json;
using Pratice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Pratice.Controllers
{
    public class HotSpotController : Controller
    {
        private int pageSize = 5;
        // GET: HotSpot
        public async Task<ActionResult> Index(int page =1)
        {
            int currentPage = page < 1 ? 1 : page;
            string targetUri = "https://card.tycg.gov.tw/ashx/taolecardeventopendata.ashx";
            HttpClient client = new HttpClient();
            client.MaxResponseContentBufferSize = Int32.MaxValue;
            var response = await client.GetStringAsync(targetUri);
            var collection = JsonConvert.DeserializeObject<IEnumerable<Class1>>(response);
            //ViewBag.Result = response;
            return View(collection);
        }
    }
}