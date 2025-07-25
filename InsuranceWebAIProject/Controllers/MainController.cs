using InsuranceWebAIProject.Models.DataModel;
using InsuranceWebAIProject.Models.ViewModel;
using InsuranceWebAIProject.Models.ViewModels;
using InsuranceWebAIProject.Services;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Globalization;
using System.Threading;
using System.Web;
using System;

namespace InsuranceWebAIProject.Controllers
{
    public class MainController : Controller
    {
        private readonly TwitterService _twitterService;
        private readonly InstagramService _instagramService;

        public MainController()
        {
            _twitterService = new TwitterService();
            _instagramService = new InstagramService();
        }

        private InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        public async Task<ActionResult> Index()
        {
            string twitterUserId = "";
            string instagramUserId = "";

            int twitterFollowers = await _twitterService.GetFollowersCountAsync(twitterUserId);
            int instagramFollowers = await _instagramService.GetFollowersCountAsync(instagramUserId);

            ViewBag.TwitterFollowers = twitterFollowers;
            ViewBag.InstagramFollowers = instagramFollowers;

            return View();
        }

        public ActionResult ChangeLanguage(string lang)
        {
            if (!string.IsNullOrEmpty(lang))
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                HttpCookie cookie = new HttpCookie("Language");
                cookie.Value = lang;
                cookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cookie);
            }
            return Redirect(Request.UrlReferrer != null ? Request.UrlReferrer.ToString() : Url.Action("Index", "Main"));
        }

        public PartialViewResult _SliderPartial()
        {
            var model = db.Slider.Select(x => new SliderViewModel
            {
                SliderId = x.SliderId,
                SliderTitle = x.SliderTitle,
                SliderSubtitle = x.SliderSubtitle,
                SliderDescription = x.SliderDescription,
                SliderImageUrl = x.SliderImageUrl
            }).ToList();

            return PartialView("~/Views/Shared/UIPartialView/_SliderPartial.cshtml", model);
        }

        public PartialViewResult _FeaturePartial()
        {
            var model = db.Feature.Select(x => new FeatureViewModel
            {
                FeatureCardIcon = x.FeatureCardIcon,
                FeatureCardTitle = x.FeatureCardTitle,
                FeatureCardDescription = x.FeatureCardDescription
            }).ToList();

            return PartialView("~/Views/Shared/UIPartialView/_FeaturePartial.cshtml", model);
        }

        public PartialViewResult _AboutPartial()
        {
            var model = db.About.Select(x => new AboutViewModel
            {
                AboutId = x.AboutId,
                AboutTitle = x.AboutTitle,
                AboutSubtitle = x.AboutSubtitle,
                AboutDescription1 = x.AboutDescription1,
                AboutDescription2 = x.AboutDescription2,
                AboutSlogan1 = x.AboutSlogan1,
                AboutSlogan2 = x.AboutSlogan2,
                AboutSlogan3 = x.AboutSlogan3,
                InsurancePoliciesCount = x.InsurancePoliciesCount,
                AwardsCount = x.AwardsCount,
                SkilledAgentsCount = x.SkilledAgentsCount,
                TeamMembersCount = x.TeamMembersCount,
                ImageUrl = x.ImageUrl
            }).ToList();

            return PartialView("~/Views/Shared/UIPartialView/_AboutPartial.cshtml", model);
        }

        public PartialViewResult _ServicePartial()
        {
            var model = db.Services.Select(x => new ServiceViewModel
            {
                ServicesId = x.ServicesId,
                ServicesCardImageUrl = x.ServicesCardImageUrl,
                ServicesCardTitle = x.ServicesCardTitle,
                ServicesCardDescription = x.ServicesCardDescription,
                ServicesCardIcon = x.ServicesCardIcon
            }).ToList();

            return PartialView("~/Views/Shared/UIPartialView/_ServicePartial.cshtml", model);
        }

        public PartialViewResult _FaqsPartial()
        {
            var model = db.FAQs.Select(x => new FaqViewModel
            {
                FaqId = x.QuestionId,
                Questioon = x.Questioon,
                Answer = x.Answer
            }).ToList();

            return PartialView("~/Views/Shared/UIPartialView/_FaqsPartial.cshtml", model);
        }

        public PartialViewResult _BlogPartial()
        {
            return PartialView("~/Views/Shared/UIPartialView/_BlogPartial.cshtml");
        }

        public PartialViewResult _TeamPartial()
        {
            var teams = db.Team.Select(t => new TeamViewModel
            {
                Name = t.Name,
                Position = t.Position,
                ImageUrl = t.ImageUrl,
                FacebookUrl = t.FacebookUrl,
                TwitterUrl = t.TwitterUrl,
                LinkedInUrl = t.LinkedInUrl,
                InstagramUrl = t.InstagramUrl
            }).ToList();

            return PartialView("~/Views/Shared/UIPartialView/_TeamPartial.cshtml", teams);
        }

        public PartialViewResult _TestimonialPartial()
        {
            var model = db.Testimonial.Select(x => new TestimonialViewModel
            {
                TestimonialId = x.TestimonialId,
                TestimonialName = x.TestimonialName,
                TestimonialSurname = x.TestimonialSurname,
                TestimonialJob = x.TestimonialJob,
                TestimonialPoint = x.TestimonialPoint,
                TestimonialComment = x.TestimonialComment,
                TestimonialImageUrl = x.TestimonialImageUrl
            }).ToList();

            return PartialView("~/Views/Shared/UIPartialView/_TestimonialPartial.cshtml", model);
        }

        public PartialViewResult _ContactPartial()
        {
            var data = db.Contact.Select(x => new ContactViewModel
            {
                CommunicationId = x.CommunicationId,
                Adress = x.Adress,
                Mail = x.Mail,
                Telephone = x.Telephone
            }).FirstOrDefault();

            return PartialView("~/Views/Shared/UIPartialView/_ContactPartial.cshtml", data);
        }
    }
}