using System.Reflection.Metadata;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Database;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Data.Common;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase,IControllerActivator<Category>
{
	private DataContext _db;
	public CategoryController(DataContext _db)
	{
		_db = db;
	}
	
}
