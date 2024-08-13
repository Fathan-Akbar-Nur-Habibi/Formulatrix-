using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst;



public class Product
{
	public int ProductId { get; set; }
	public string ProductName { get; set; }
	public int CategoryId { get; set; }
	public string Description { get; set; }
	public Category Category { get; set; }
	// Approximation use atribut
	[Column(TypeName = "Money")]
	public int UnitPrice { get; set; }
	[Column(TypeName = "DateTime")]
	public DateTime CreateTime { get; set; }
}
