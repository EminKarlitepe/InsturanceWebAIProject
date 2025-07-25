using InsuranceWebAIProject.Models.DataModel;
using System.Linq;
using System.Web.Mvc;

namespace InsuranceWebAIProject.Controllers
{
    public class FeatureController : Controller
    {
        InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        public ActionResult FeatureList()
        {
            var features = db.Feature.ToList();
            return View(features);
        }

        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFeature(Feature model)
        {
            if (!ModelState.IsValid) return View(model);

            db.Feature.Add(model);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        [HttpGet]
        public ActionResult UpdateFeature(int id)
        {
            var feature = db.Feature.Find(id);
            if (feature == null) return HttpNotFound();

            return View(feature);
        }

        [HttpPost]
        public ActionResult UpdateFeature(Feature model)
        {
            if (!ModelState.IsValid) return View(model);

            var feature = db.Feature.Find(model.FeatureId);
            if (feature == null) return HttpNotFound();

            feature.FeatureCardIcon = model.FeatureCardIcon;
            feature.FeatureCardTitle = model.FeatureCardTitle;
            feature.FeatureCardDescription = model.FeatureCardDescription;

            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public ActionResult DeleteFeature(int id)
        {
            var feature = db.Feature.Find(id);
            if (feature == null) return HttpNotFound();

            db.Feature.Remove(feature);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
    }
}
