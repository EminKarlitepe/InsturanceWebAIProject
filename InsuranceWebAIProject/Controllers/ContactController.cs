using InsuranceWebAIProject.Models.DataModel;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace InsuranceWebAIProject.Controllers
{
    public class ContactController : Controller
    {
        private InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        public ActionResult ContactList()
        {
            var contacts = db.Contact.ToList();
            return View(contacts);
        }

        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contact.Add(contact);
                db.SaveChanges();
                return RedirectToAction("ContactList");
            }
            return View(contact);
        }

        public ActionResult UpdateContact(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var contact = db.Contact.Find(id);
            if (contact == null) return HttpNotFound();
            return View(contact);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ContactList");
            }
            return View(contact);
        }
    }
}
