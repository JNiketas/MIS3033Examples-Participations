using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Receipt
    {
        public int CustomerID { get; set; }
        public int CogQuantity { get; set; }
        public int GearQuantity { get; set; }
        public DateTime SaleDate { get; set; }
        private double SalesTaxPercent;
        private double CogPrice;
        private double GearPrice;

        public Receipt()
        {
            CustomerID = 0;
            CogQuantity = 0;
            GearQuantity = 0;
            SaleDate = DateTime.Now;
            SalesTaxPercent = 0.089;
            CogPrice = 79.99;
            GearPrice = 250.00;
        }

        public Receipt(int id, int cog, int gear)
        {
            id = CustomerID;
            cog = CogQuantity;
            gear = GearQuantity;
        }

        public double CalculateTotal()
        {
            double Total = CalculateNetAmount() + CalculateTaxAmount();
            return Total;
        }
        public void PrintReceipt()
        {
            Console.WriteLine($"# of Cogs: {CogQuantity}");
            Console.WriteLine($"# of Gears: {GearQuantity}");
            Console.WriteLine($"Net Amount: {CalculateNetAmount()}");
            Console.WriteLine($"Tax Amount: {CalculateTaxAmount()}");
            Console.WriteLine($"Grand Total: {CalculateTotal()}");

        }
        private double CalculateTaxAmount()
        {
            
            double taxAmount = SalesTaxPercent * CalculateNetAmount();
            return taxAmount;
        }
        private double CalculateNetAmount()
        {
            
            double netAmount = 0;

            if (CogQuantity + GearQuantity >= 16)
            {
                CogPrice = CogPrice * 1.125;
                GearPrice = GearPrice * 1.125;
            }
            else if (CogQuantity > 10)
            {
                CogPrice = CogPrice * 1.125;
                GearPrice = GearPrice * 1.15;
            }
            else if (GearQuantity > 10)
            {
                CogPrice = CogPrice * 1.15;
                GearPrice = GearPrice * 1.125;
            }
            else
            {
                CogPrice = CogPrice * 1.15;
                GearPrice = GearPrice * 1.15;
            }

            netAmount = (CogQuantity * CogPrice) + (GearQuantity * GearPrice);

            return netAmount;
        }


    }
}
