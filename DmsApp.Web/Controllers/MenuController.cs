using DmsApp.Web.Models;
using DmsApp.Web.Models.ViewModel;
using DmsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DmsApp.Web.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _service;
        public MenuController(IMenuService service)
        {
            _service = service;
        }
        public IActionResult Dashboard()
        {
            var items = _service.GetAll();
            return View(items);
        }

        public IActionResult Details(int id)
        {
            var item = _service.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        public IActionResult Create()
        {
            var model = new MenuItem { LastUpdate = DateTime.UtcNow.Date };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MenuItem model)
        {
            if (ModelState.IsValid) return View(model);
            _service.Create(model);
            return RedirectToAction(nameof(Dashboard));
        }

        public IActionResult Edit(int id)
        {
            var item = _service.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, MenuItem model)
        {
            Console.WriteLine("Model Edit: " + model);

            if (id != model.Id) return NotFound();
            if (ModelState.IsValid) return View(model);

            var success = _service.Update(model);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Dashboard));
        }

        public IActionResult Delete(int id)
        {
            var item = _service.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var success = _service.Delete(id);
            if (!success) return NotFound();
            return RedirectToAction(nameof(Dashboard));
        }

        public IActionResult Scoring()
        {
            var model = new InformasiApplikasiViewModel();
            //model = informasiApplikasiView;

            //Console.WriteLine("Model Applikasi: " + model);


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Scoring(InformasiApplikasiViewModel model)
        {
            TempData["ScoringData"] = JsonSerializer.Serialize(model);

            return RedirectToAction("ViewScoring");
        }

        public IActionResult ViewScoring()
        {
            if (TempData["ScoringData"] is not string json)
            {
                return RedirectToAction("Scoring");
            }

            var model = JsonSerializer.Deserialize<InformasiApplikasiViewModel>(json);

            if (model == null)
            {
                return RedirectToAction("Scoring");
            }
            return View(model);
        }
    }
}
