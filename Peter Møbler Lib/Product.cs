namespace Peter_Møbler_Lib
{
	public class Product
	{
		private int _productNo;
		private int _price;
		private string _name;

		public Product()
		{ 
		_productNo = 0;
		_price = 0;
		_name = "abcdgefg";
		}
		public Product(int productNo, int price, string name)
		{
		ProductNo =productNo;
		Price=price;
		Name=name;
		}	

		public int ProductNo
		{
		get { return _productNo; }
		set {
				if (value < 0)
				{
					throw new ArgumentException("ProductNumber cant be negative");
							}
		
		_productNo = value; }
		}

		public int Price
		{
			get { return _price; }
			set {
			if (value < 10)
			{
					throw new ArgumentException("Price must be higher than 10 DKK");
			}
			_price = value; }

		}
		public string Name
		{
		get { return _name; }
		set {
		if (value == null || value.Length < 7)
		{
					throw new ArgumentException("name must be longer than 7 characters");
		}
		_name = value; }
		}


		public override string ToString()
		{
		return " ProductNo: " + _productNo + ", Price: " + _price + ", Name: " + _name;
		}
	}
}
