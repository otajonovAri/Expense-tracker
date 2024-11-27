using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_tracker
{
    public class OrderLibrary
    {
        private int idCounter;
		private List<Order> orders;
		public OrderLibrary()
		{
			idCounter = 0;
			orders = new List<Order>();
		}
		static bool isValidTime(string time)
		{
			return TimeSpan.TryParseExact(time, "hh\\:mm", null, out _);
		}
		static bool IsValedPrice(decimal price)
		{
			return price > 0;
		}
		public int IdCounter()
		{
			return ++idCounter;
		}
		public void AddOrder()
		{
			Console.Write("Expence Name: ");
			string name = Console.ReadLine();

			Console.Write("Expence Ammount: ");
			if (!decimal.TryParse(Console.ReadLine(), out decimal price) || !IsValedPrice(price))
			{
				Console.WriteLine("Invalid amount! Please enter a positive number.");
				return;
			}

			Console.Write("Order Count: ");
			int count = Convert.ToInt32(Console.ReadLine());

			Console.Write("Time (HH:MM): ");
			string time = Console.ReadLine();

			if(!isValidTime(time))
			{
				Console.WriteLine("Invalid time format! Please use HH:mm format.");
				return;
			}
			TotalPrice total = new TotalPrice(count , price);
			var order = new Order(IdCounter() , name, price, time , count , total.TotalAmount());
			orders.Add(order);
			Console.WriteLine("Order successfully added!");
		}
		public void SaveToFileOrder()
		{
			const string pathFile = @"D:\\HomeWork_PDP\\StringBuild\Order.txt";

			using (StreamWriter sw = new StreamWriter(pathFile))
			{
				sw.WriteLine(new string('-', 80));
				sw.WriteLine("| Id    | Expense         | Amount      | Time        | Count  | TotalSum    |");
				sw.WriteLine(new string('-', 80));

				foreach (var order in orders)
				{
					sw.WriteLine(order);
				}
				sw.WriteLine(new string('-', 80));
			}

			Console.WriteLine("All Order's saved to 'Order.txt' :)");
		}
    }
}