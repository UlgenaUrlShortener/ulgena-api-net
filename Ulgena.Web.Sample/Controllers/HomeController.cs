using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;
using UlgenaApi;

namespace Ulgena.Web.Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("LinkCreate")]
        [HttpGet]
        public ActionResult LinkCreate()
        {
            return View("LinkCreate");
        }

        [Route("LinkCreate")]
        [HttpPost]
        public async Task<ActionResult> LinkCreatePost(string apiKey, string apiTitle, string apiStrategy,
            string apiDestination)
        {
            var ulgena = new UlgenaApi.Ulgena(apiKey);

            var strategy = UlgenaLink.ParseEnum<UlgenaLinkStrategy>(apiStrategy);

            var linkResponse = await ulgena.LinkCreate(strategy, apiTitle, apiDestination);

            ViewData["link_result"] = JsonConvert.SerializeObject(linkResponse, Formatting.Indented);

            return View("LinkCreate");
        }

        [Route("LinkList")]
        public ActionResult LinkList()
        {
            return View("LinkList");
        }

        [Route("LinkList")]
        [HttpPost]
        public async Task<ActionResult> LinkListPost(string apiKey)
        {

            var ulgena = new UlgenaApi.Ulgena(apiKey);

            var linkResponse = await ulgena.LinkList();

            ViewData["link_result"] = JsonConvert.SerializeObject(linkResponse, Formatting.Indented);

            return View("LinkList");
        }
    }
}