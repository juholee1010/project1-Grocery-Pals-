<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VCNNetworkEquipment.Models;

namespace VCNNetworkEquipment.Controllers
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VCNNetworkEquipment.Models;

namespace VCNNetworkEquipment.Controllers
>>>>>>> 1b0fd60acba595427cb53534d15d821b76cf7348
{
	[Authorize]
	public class AdminController : Controller
	{

		private IProductRepository repository;
		public AdminController(IProductRepository repo)
		{
			repository = repo;
		}
		public ViewResult Index() => View(repository.Products);

		public ViewResult Edit(int productId) =>
			View(repository.Products
			.FirstOrDefault(p => p.ProductID == productId));
		[HttpPost]
		public IActionResult Edit(Product product)
		{
			if (ModelState.IsValid)
			{
				repository.SaveProduct(product);
				TempData["message"] = $"{product.Name} has been saved";
				return RedirectToAction("Index");
			}
			else
			{
				// there is something wrong with the data values
				return View(product);
			}
		}

		public ViewResult Create() => View("Edit", new Product());

		[HttpPost]
		public IActionResult Delete(int productId)
		{
			Product deletedProduct = repository.DeleteProduct(productId);
			if (deletedProduct != null)
			{
				TempData["message"] = $"{deletedProduct.Name} was deleted";
			}
			return RedirectToAction("Index");
		}
<<<<<<< HEAD
	}
=======
	}
>>>>>>> 1b0fd60acba595427cb53534d15d821b76cf7348
}