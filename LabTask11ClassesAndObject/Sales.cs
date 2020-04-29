using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask11ClassesAndObject
{
    class Sales
    {
        public string MedCode { get; set; }
        private int quantitySold;
        private decimal sales;
        private decimal actualSales;
        public string Region { get; set; }

        public Sales(string medCode, int quantSold, decimal sales, decimal actualSales, string region)
        {
            MedCode = medCode;
            QuantitySold = quantSold;
            PlannedSales = sales;
            ActualSales = actualSales;
            Region = region;
        }
       
        public int QuantitySold
        {
            get { return quantitySold; }
            private set
            {
                if (value >= 0)
                {
                   quantitySold = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please the quantiity of items sold be less than 0");
                }
            }
        }
        public decimal PlannedSales
        {
            get { return sales; }
            private set
            {
                if (value > 0)
                {
                    sales = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please the planned sales cannot be 0");
                }
                
            }
        }
        public decimal ActualSales
        {
            get { return actualSales; }
            private set
            {
                if (value > 0)
                {
                    actualSales =  value;   //QuantitySold - Quantity
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please the planned sales cannot be 0");
                }
                
            }
        }
        
        public void Display()
        {
            Console.WriteLine($"Medicine Code: {MedCode}\nQuantity sold: {QuantitySold}\nPlanned sales: {PlannedSales}\nActual sales: {ActualSales}\nRegion: {Region}");
        }
        public void Display(decimal PlannedSales, decimal ActualSales)
        {
            Console.WriteLine($"Planned sales: {PlannedSales}\nActual Sales: {ActualSales}: the difference between the planned sales and the actual sales is {PlannedSales - ActualSales}");
        }
       
    }
}
