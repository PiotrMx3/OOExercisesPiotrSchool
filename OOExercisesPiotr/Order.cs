using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOExercisesPiotr
{
    internal class Order
    {
		private uint _number;
		private double _unitPrice;

		public Order(uint amount, double price)
		{
			this._number = amount;
			this._unitPrice = price;
		}

		public virtual double TotalPrice
		{
			get { return this.Number * this._unitPrice; }
		}

		public uint Number
		{
			get { return _number; }
			set { _number = value; }
		}

	}
}
