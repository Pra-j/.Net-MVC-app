using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvc_1.Models;

namespace mvc_1.Controllers
{
    public class HomeController : Controller
    {
        private static List<Product> products = new List<Product>
       {
           new Product {Id = 1, Name  = "Laptop", Price = 1000},
           new Product {Id = 2, Name = "Phone", Price = 500}
       };
        public IActionResult Index()
        {
            return View(products);

        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);

        }
        public IActionResult Create()
        {
            return View();
        }

        //POST: Home/Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = products.Max(p => p.Id) + 1;
                products.Add(product);
                return RedirectToAction("Index");

            }
            return View(product);

        }
        //Post : Home/Edit
        public IActionResult Edit(Product updatedProduct) {
            if (ModelState.IsValid)
            {
                var product = products.FirstOrDefault(p => p.Id == updatedProduct.Id);
                if (product != null)
                {
                    product.Name = updatedProduct.Name;
                    product.Price = updatedProduct.Price;
                }
                return RedirectToAction("Index");
            }
            return View(updatedProduct);
        }

        //GET: Home/Delete/1
        public IActionResult Delete(int id) {
            var product = products.FirstOrDefault(product => product.Id == id);
            if(product == null) return NotFound();
            return View(product);
        }

        //POST: Home/Delete/1
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                products.Remove(product);
            }
            return RedirectToAction();
        }
    }
}
