using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class RoomController : Controller
    {
        // GET: RoomController
        public ActionResult Index()
        {
            // Allies User: As a message posting user, I want to create rooms for categorizing conversations.
            //Hiba's User Story 2B here
            return View();
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {
            // Allies User: As a message posting user, I want to create rooms for categorizing conversations.
            return View();
        }

        // GET: RoomController/Create
        public ActionResult Create()
        {
            // Allies User: As a message posting user, I want to create rooms for categorizing conversations.
            //Hiba's User Story 2B again!
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            //TAKU: "As a system admin, I want to be able to set a limit to the number of users in any one room."
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            // Allies User: As a message posting user, I want to create rooms for categorizing conversations.
            return View();
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            //TAKU: "As a system admin, I want to be able to set a limit to the number of users in any one room."
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            // Allies User: As a message posting user, I want to create rooms for categorizing conversations.
            return View();
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            //Your favorite students were here 
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
