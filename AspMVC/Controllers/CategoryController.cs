using Microsoft.AspNetCore.Mvc;

namespace AspMVC.Controllers;

public class CategoryController : Controller
{
	public IActionResult Index()
	{
		List<Category> categories = new()
		{
			new Category ()
			{
				CategoryId = 1,
				CategoryName = "Electronic"
			},
			new Category ()
			{
				CategoryId = 2,
				CategoryName = "Mechanical"
			}
		};
		return View(categories);
	}
}
