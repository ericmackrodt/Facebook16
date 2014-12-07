using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook16.Common;
using System.Net.Http;
using System.Threading.Tasks;

namespace Facebook16.Controllers
{
    public class PictureController : Controller
    {
        public async Task<ActionResult> Profile(string id)
        {
            var cli = new HttpClient();
            var result = await cli.GetStreamAsync("https://graph.facebook.com/" + id + "/picture?access_token=" + GetAccessToken());//+ "CAAJr8t6oR3MBAEJSbFThHhGz1xOWrfrZA7UvtlGxvRDRv5FzEUjn5rhTthoPaGX13Gn1sbDsRCjI4Sx5LPM9BLfZAkC7PlzLzZCrqZB84N2ziSxICE4sBcZAo53F2457VZCaixAkhSVOld1PWgpm9Ug5ZAU51GeQnJd5pvUvVYsks6Iaqm7438j0aOjduxQ9RoZD");
            return this.Image(result, "image/jpg");
        }
        private string GetAccessToken()
        {
            var cookie = Request.Cookies.Get("AccessToken");
            if (cookie != null)
                return cookie.Value;

            return null;
        }
    }
}
