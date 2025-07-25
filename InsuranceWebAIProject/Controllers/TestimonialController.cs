using InsuranceWebAIProject.Models.DataModel;
using System.Linq;
using System.Web.Mvc;

namespace InsuranceWebAIProject.Controllers
{
    public class TestimonialController : Controller
    {
        InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        public ActionResult TestimonialList()
        {
            var testimonials = db.Testimonial.ToList();
            return View(testimonials);
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTestimonial(Testimonial model)
        {
            if (!ModelState.IsValid) return View(model);

            db.Testimonial.Add(model);
            db.SaveChanges();

            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var testimonial = db.Testimonial.Find(id);
            if (testimonial == null) return HttpNotFound();

            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateTestimonial(Testimonial model)
        {
            if (!ModelState.IsValid) return View(model);

            var testimonial = db.Testimonial.Find(model.TestimonialId);
            if (testimonial == null) return HttpNotFound();

            testimonial.TestimonialName = model.TestimonialName;
            testimonial.TestimonialSurname = model.TestimonialSurname;
            testimonial.TestimonialJob = model.TestimonialJob;
            testimonial.TestimonialPoint = model.TestimonialPoint;
            testimonial.TestimonialComment = model.TestimonialComment;
            testimonial.TestimonialImageUrl = model.TestimonialImageUrl;

            db.SaveChanges();

            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var testimonial = db.Testimonial.Find(id);
            if (testimonial == null) return HttpNotFound();

            db.Testimonial.Remove(testimonial);
            db.SaveChanges();

            return RedirectToAction("TestimonialList");
        }
    }
}
