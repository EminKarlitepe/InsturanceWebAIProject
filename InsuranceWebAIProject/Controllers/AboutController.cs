using InsuranceWebAIProject.Models.DataModel;
using System.Linq;
using System.Web.Mvc;

namespace InsuranceWebAIProject.Controllers.Admin
{
    public class AboutController : Controller
    {
        InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        public ActionResult AboutList()
        {
            var abouts = db.About.ToList();

            return View(abouts);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About model)
        {
            if (!ModelState.IsValid) return View(model);

            db.About.Add(model);
            db.SaveChanges();

            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var about = db.About.Find(id);
            if (about == null) return HttpNotFound();

            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About model)
        {
            if (!ModelState.IsValid) return View(model);

            var about = db.About.Find(model.AboutId);
            if (about == null) return HttpNotFound();

            about.AboutTitle = model.AboutTitle;
            about.AboutSubtitle = model.AboutSubtitle;
            about.AboutDescription1 = model.AboutDescription1;
            about.AboutDescription2 = model.AboutDescription2;
            about.AboutSlogan1 = model.AboutSlogan1;
            about.AboutSlogan2 = model.AboutSlogan2;
            about.AboutSlogan3 = model.AboutSlogan3;
            about.InsurancePoliciesCount = model.InsurancePoliciesCount;
            about.AwardsCount = model.AwardsCount;
            about.SkilledAgentsCount = model.SkilledAgentsCount;
            about.TeamMembersCount = model.TeamMembersCount;
            about.ImageUrl = model.ImageUrl;

            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult DeleteAbout(int id)
        {
            var about = db.About.Find(id);
            if (about == null) return HttpNotFound();

            db.About.Remove(about);
            db.SaveChanges();

            return RedirectToAction("AboutList");
        }
    }
}
