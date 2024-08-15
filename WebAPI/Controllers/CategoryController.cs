using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

public class CategoryController : ControllerBase
{
	private static readonly List<string> myCategories = new() {"Electronics", "Fruit"};
	
	[HttpGet]
	public IActionResult GetAll () 
	{
		return Ok(myCategories);
	} 
	[Route("{id}")]
	[HttpGet]
	public IActionResult GetAll(int id) { 
		if (id > myCategories.Count)
		{
			return NotFound("Not Found");
		}
		return Ok(myCategories[id]);
	}
	[HttpPost]
	public IActionResult Add(string data)
	
	{
		//myCategories.Add(data);
		return Ok(myCategories);
	}
	//[Route("{id}")]
	//[HttpPost]
	
	[Route("{id}")]
	[HttpDelete]
	public IActionResult Delete(int id)
	{
		if(id > myCategories.Count) 
		{
			return NotFound("Not Found");
		}
		myCategories.RemoveAt(id);
		return Ok(myCategories);
	}
	
}
