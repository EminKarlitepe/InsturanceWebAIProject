using InsuranceWebAIProject.Models.DataModel;
using InsuranceWebAIProject.Models.ViewModel;
using System.Linq;
using System.Web.Mvc;

namespace InsuranceWebAIProject.Controllers.Admin
{
    public class TeamController : Controller
    {
        InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        // Tam sayfa ekip listesi
        public ActionResult TeamList()
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

            return View(teams);
        }

        // Partial view için (ana sayfada vs kullanılacak)
        [ChildActionOnly]
        public PartialViewResult TeamPartial()
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

            return PartialView("_TeamPartial", teams);
        }

        [HttpGet]
        public ActionResult CreateTeam()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTeam(Team model)
        {
            if (!ModelState.IsValid) return View(model);

            db.Team.Add(model);
            db.SaveChanges();

            return RedirectToAction("TeamList");
        }

        [HttpGet]
        public ActionResult UpdateTeam(int id)
        {
            var team = db.Team.Find(id);
            if (team == null) return HttpNotFound();

            return View(team);
        }

        [HttpPost]
        public ActionResult UpdateTeam(Team model)
        {
            if (!ModelState.IsValid) return View(model);

            var team = db.Team.Find(model.Id);
            if (team == null) return HttpNotFound();

            team.Name = model.Name;
            team.Position = model.Position;
            team.ImageUrl = model.ImageUrl;
            team.FacebookUrl = model.FacebookUrl;
            team.TwitterUrl = model.TwitterUrl;
            team.LinkedInUrl = model.LinkedInUrl;
            team.InstagramUrl = model.InstagramUrl;

            db.SaveChanges();
            return RedirectToAction("TeamList");
        }

        public ActionResult DeleteTeam(int id)
        {
            var team = db.Team.Find(id);
            if (team == null) return HttpNotFound();

            db.Team.Remove(team);
            db.SaveChanges();

            return RedirectToAction("TeamList");
        }
    }
}
