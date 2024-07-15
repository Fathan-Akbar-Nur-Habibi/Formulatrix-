// property 
class Car { 
	private int _price; //variable
	
	public int GetPrice ()
	{
		return _price ; 
	}
	public void SetPrice (int price)// price disini berupa value
	{
		_price = price ;// price disini berupa value 
	}
}

class CarWProperty { 
	public int Price { get; private set;} //private dapat diganti public, protected. sesuai penggunaanya 
}