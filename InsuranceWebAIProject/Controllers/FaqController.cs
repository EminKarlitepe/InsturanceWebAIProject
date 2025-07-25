using InsuranceWebAIProject.Models.DataModel;
using InsuranceWebAIProject.Models.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace InsuranceWebAIProject.Controllers
{
    public class FaqController : Controller
    {
        InsureWebAIDbEntities db = new InsureWebAIDbEntities();

        public ActionResult FaqList()
        {
            var faqs = db.FAQs.ToList();
            return View(faqs);
        }

        [HttpGet]
        public ActionResult CreateFaq()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFaq(FAQs model)
        {
            if (!ModelState.IsValid) return View(model);
            db.FAQs.Add(model);
            db.SaveChanges();
            return RedirectToAction("FaqList");
        }

        [HttpGet]
        public ActionResult UpdateFaq(int id)
        {
            var faq = db.FAQs.Find(id);
            if (faq == null) return HttpNotFound();
            return View(faq);
        }

        [HttpPost]
        public ActionResult UpdateFaq(FAQs model)
        {
            if (!ModelState.IsValid) return View(model);
            var faq = db.FAQs.Find(model.QuestionId);
            if (faq == null) return HttpNotFound();
            faq.Questioon = model.Questioon;
            faq.Answer = model.Answer;
            db.SaveChanges();
            return RedirectToAction("FaqList");
        }

        public ActionResult DeleteFaq(int id)
        {
            var faq = db.FAQs.Find(id);
            if (faq == null) return HttpNotFound();
            db.FAQs.Remove(faq);
            db.SaveChanges();
            return RedirectToAction("FaqList");
        }

        [HttpPost]
        public async Task<JsonResult> GenerateAIQuestion(string topic)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(topic))
                    return Json(new { error = "Lütfen önce bir soru girin." }, JsonRequestBehavior.AllowGet);

                string prompt = topic.Trim();
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://chatgpt-42.p.rapidapi.com/YOUR_MODEL_PATH"),
                    Headers =
                    {
                        { "x-rapidapi-key", "Your Api" },
                        { "x-rapidapi-host", "Your Api Host" },
                    },
                    Content = new StringContent($"{{\"messages\":[{{\"role\":\"user\",\"content\":\"{prompt}\"}}],\"temperature\":0.9,\"top_k\":5,\"top_p\":0.9,\"max_tokens\":256}}")
                    {
                        Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
                    }
                };
                using (var response = await client.SendAsync(request))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    response.EnsureSuccessStatusCode();
                    var json = JObject.Parse(body);
                    string aiContent = json["result"]?.ToString();
                    if (string.IsNullOrEmpty(aiContent) && json["choices"] != null)
                        aiContent = json["choices"][0]["message"]["content"]?.ToString();
                    return Json(new { answer = aiContent?.Trim() }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
