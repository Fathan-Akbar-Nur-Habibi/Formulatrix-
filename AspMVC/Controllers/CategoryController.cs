using Microsoft.AspNetCore.Mvc;
using AspMVC.Models;
using AspMVC.Databases;
using System.Security.Cryptography.X509Certificates;

namespace AspMVC.Controllers;

public class CategoryController : Controller

{
	private readonly DataContext _db;
	public CategoryController(DataContext db)
	{
		_db =db;
	}
	public IActionResult Index()
	{
		List<Category> categories = _db.Categories.ToList();
		return View(categories);
	}
	public IActionResult Create()// make create
	{
		return View();
	}
	[HttpPost]
	public IActionResult Update(int? id)
	{
		if (id is null)
		{
			return NotFound();
		}
		Category category = _db.Categories.Find(id);
		{
			if(category is null)
			{
				return NotFound();
			}
			return View(category);
		}
	}
	[HttpPost]
		public IActionResult Update(Category category)
		{
			_db.Categories.Update(category);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
}