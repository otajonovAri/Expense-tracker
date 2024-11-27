using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
internal class Program
{
    private static void Main(string[] args)
    {
      const string pathFile = @"D:\\HomeWork_PDP\\StringBulider\Order.txt";
			OrderLibrary orderLibrary = new OrderLibrary();
			while (true)
			{
				Console.WriteLine("Hit enter to add expense...");
				string input = Console.ReadLine()?.ToLower();
				if (input == "stop") break;

				if (input == "enter")
				{
					orderLibrary.AddOrder();
				}

				orderLibrary.SaveToFileOrder();
				Console.Clear();
			}
			using (StreamReader reader = new StreamReader(pathFile))
			{
				var linesOrder = reader.ReadToEnd();
				Console.WriteLine(linesOrder);
			}
			Console.WriteLine("Thank you for your purchase :)");
    }
}
