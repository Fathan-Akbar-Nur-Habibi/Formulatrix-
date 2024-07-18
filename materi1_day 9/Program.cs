public int price;//variable
public readonly int price2;//variable readonly, harus dibuat instance nya dahulu lewat constructor
public const int price3 = 2 ; //nilai price3 harus ada nilainya kalau tidak error 
public Car (int price2){
this.price2 = price2;
this.price = price;
}

class Program {
 void Main()
{
	Car car = new(); 
	car.price2;
	Car.price3;
}
}