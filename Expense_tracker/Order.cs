using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_tracker
{
    public class Order
    {
        public int OrderId { get; set; }
		public string OrderName;
		public decimal OrderPrice;
		public string DateTime;
		public int OrderCount;
		public decimal TotalAmmount;
		public Order(int id , string name , decimal price , string dateTime , int count , decimal total)
		{
			OrderId = id;
			OrderName = name;
			OrderPrice = price;
			DateTime = dateTime;
			OrderCount = count;
			TotalAmmount = total;
		}
		public override string ToString()
		{
			return $"| {OrderId,-5} | {OrderName,-15} | {OrderPrice,10:F2} | {DateTime,10} | {OrderCount,5} | {TotalAmmount,10:F2} |";
		}
    }
}