using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class FoodPurchase
    {
		private bool _refrigerate;
		private string _productName;
		private int _number;
		private double _unitPrice;


		public FoodPurchase(string productName, byte number, double unitPrice, bool refrigerate)
		{

			if(unitPrice <= 0 || unitPrice > 5000)
			{
                Console.WriteLine("Ongeldige eenheidsprijs !");
                return;
            }

			if(number <= 0)
			{
				Console.WriteLine("Ongeldig aantaal !");
				return;
			}


			ProductName = productName;
			Number = number;
			UnitPrice = unitPrice;
			Refrigerate = refrigerate;
		}

		public double CalculateTotalPrice()
		{
			return UnitPrice * Number;
		}
        public DateTime ExpirationDate
		{
			get { return DateTime.Today.AddMonths(2); }
		}


		public double UnitPrice
		{
			get { return _unitPrice; }
			private set { _unitPrice = value; }
		}


		public int Number
		{
			get { return _number; }
			private set { _number = value; }
		}


		public string ProductName
		{
			get { return _productName; }
			private set { _productName = value; }
		}


		public bool Refrigerate
		{
			get { return _refrigerate; }
			private set { _refrigerate = value; }
		}


	}
}
