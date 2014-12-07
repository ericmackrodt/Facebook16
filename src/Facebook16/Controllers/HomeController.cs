using Facebook;
using Facebook16.Models;
using Facebook16.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Facebook16.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public Uri RedirectUri
        {
            get
            {
                var builder = new UriBuilder("http://localhost");
                builder.Query = null;
                builder.Fragment = null;
                builder.Path = Url.Action("AuthenticationRedirect");
                return builder.Uri;
            }
        }
               

        public ActionResult Index()
        {
            var client = new FacebookClient();
            ViewBag.AuthUrl = client.GetLoginUrl(new
            {
                client_id = "222231427987739",
                client_secret = "4e8a80227bdc78525c43d5df77ac2e3c",
                redirect_uri = RedirectUri.AbsoluteUri,
                response_type = "code",
                scope = "email,user_likes,public_profile,publish_actions,user_friends,user_about_me,user_activities,user_status"
            });

            var token = "CAADKHklSuRsBAEs1hCePkNptZCXsqTO7PfLmF826Mnk9Et69XnnVdZCHo6ndiR8IrVb0T9FiWUEXk9IWKGx0NXzwKLwQ9d3JVoIEXEyWRupiyhtKm5SmGdhUt6IySplyG6ZA4u6d3E90fAHlmt17LlJdlfhLf7XapBeNuewAfmJzRANgG3GDSl10hPwTLIZD";

            var user = GetProfile(token);
            var posts = GetPosts(token);

            return View(new MainPageViewModel()
            {
                Profile = user,
                Posts = posts.Posts
            });
        }

        [HttpPost]
        public ActionResult Index(string message)
        {
            return View(new MainPageViewModel());
        }

        private FacebookProfilePosts GetPosts(string token)
        {
            var cli = new FacebookClient(token);
            SetAuth(token);
            return cli.Get<FacebookProfilePosts>("me/home");
        }

        private FacebookUser GetProfile(string token)
        {
            var cli = new FacebookClient(token);
            SetAuth(token);
            return cli.Get<FacebookUser>("me");
        }

        public ActionResult AuthenticationRedirect(string code)
        {
            var client = new FacebookClient();
            dynamic result = client.Post("oauth/access_token", new
            {
                client_id = "222231427987739",
                client_secret = "4e8a80227bdc78525c43d5df77ac2e3c",
                redirect_uri = RedirectUri.AbsoluteUri,
                code = code
            });

            SetAuth(result.access_token);

            return RedirectToAction("Index");
        }

        private bool IsAuthenticated()
        {
            var token = Request.Cookies.Get("AccessToken");
            return token != null;
        }

        private void SetAuth(string accessToken)
        {
            Response.Cookies.Add(new HttpCookie("AccessToken", accessToken));
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
