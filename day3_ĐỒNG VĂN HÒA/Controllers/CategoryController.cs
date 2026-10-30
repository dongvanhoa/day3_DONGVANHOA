using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using day3_ĐỒNG_VĂN_HÒA.Models;


namespace day3_ĐỒNG_VĂN_HÒA.Controllers
{
    public class CategoryController : Controller
    {
        //giả lập cơ sở dữ liệu
        private static List<Models.Category> _categories = new List<Models.Category>
        {
            new Models.Category { Id = 1, Name = "Category 1" },
            new Models.Category { Id = 2, Name = "Category 2" },
            new Models.Category { Id = 3, Name = "Category 3" }
        };
        // GET: CategoryController1
        public ActionResult Index()
        {
            return View(_categories);
        }

        // GET: CategoryController1/Details/5
        public ActionResult Details(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Category category)
        {
            if (ModelState.IsValid)
            {
                int newId = _categories.Any() ? _categories.Max(c => c.Id) + 1 : 1;
                _categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: CategoryController1/Edit/5
        public ActionResult Edit([FromRoute] int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            var existingCategory = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCategory == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                existingCategory.Name = category.Name;
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: CategoryController1/Delete/5
        // GET: CategoryController/Delete/5
        [HttpGet]
        public ActionResult Delete([FromRoute] int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            _categories.Remove(category);
            return RedirectToAction(nameof(Index));
        }
    }
    }
