using InsuranceWebAIProject.Models;
using InsuranceWebAIProject.Models.DataModel;
using InsuranceWebAIProject.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace InsuranceWebAIProject.Controllers
{
    public class SliderController : Controller
    {
        InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        public ActionResult SliderList()
        {
            var sliders = db.Slider.ToList();
            return View(sliders);
        }

        [HttpGet]
        public ActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSlider(Slider model)
        {
            if (!ModelState.IsValid) return View(model);

            db.Slider.Add(model);
            db.SaveChanges();

            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public ActionResult UpdateSlider(int id)
        {
            var slider = db.Slider.Find(id);
            if (slider == null) return HttpNotFound();

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateSlider(Slider model)
        {
            if (!ModelState.IsValid) return View(model);

            var slider = db.Slider.Find(model.SliderId);
            if (slider == null) return HttpNotFound();

            slider.SliderTitle = model.SliderTitle;
            slider.SliderSubtitle = model.SliderSubtitle;
            slider.SliderDescription = model.SliderDescription;
            slider.SliderImageUrl = model.SliderImageUrl;

            db.SaveChanges();

            return RedirectToAction("SliderList");
        }

        public ActionResult DeleteSlider(int id)
        {
            var slider = db.Slider.Find(id);
            if (slider == null) return HttpNotFound();

            db.Slider.Remove(slider);
            db.SaveChanges();

            return RedirectToAction("SliderList");
        }
    }
}
