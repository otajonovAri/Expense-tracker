using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expense_tracker
{
    public struct TotalPrice
    {
         public int orderId;
        private decimal orderPrice;

        public int OrderCount
        {
            get => orderId;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Order count must be greater than zero.");
                orderId = value;
            }
        }

        public decimal OrderPrice
        {
            get => orderPrice;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Order price must be greater than zero.");
                orderPrice = value;
            }
        }

        public TotalPrice(int orderCount, decimal orderAmmount)
        {
            orderId = orderCount;
            orderPrice = orderAmmount;
        }

        public decimal TotalAmount()
        {
            return OrderPrice * OrderCount;
        }
    }
}