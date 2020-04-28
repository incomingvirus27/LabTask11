using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask11ClassesAndObject
{
    class Sales
    {
        private string medCode;
        private int quantitySold;
        private decimal sales;
        private decimal actualSales;
        private string region;

        public Sales(string medCode, int quantSold, decimal sales, decimal actualSales, string region)
        {
            MedCode = medCode;
            QuantitySold = quantitySold;
            PlannedSales = sales;
            ActualSales = actualSales;
            Region = region;
        }
        public string MedCode
        {
            get { return medCode; }
            set { medCode = value; }
        }
        public int QuantitySold
        {
            get { return quantitySold; }
            set
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
            set
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
            set
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
        public string Region
        {
            get { return region; }
            set { region = value; }
        }
        public void Display()
        {
            Console.WriteLine($"Medicine Code: {MedCode}\nQuantity sold: {QuantitySold}\nPlanned sales: {PlannedSales}\nActual sales: {ActualSales}\nRegion: {Region}");
        }
        public string Display(decimal PlannedSales, decimal ActualSales)
        {
            return  $"Planned sales: {PlannedSales}\nActual Sales: {ActualSales}: {PlannedSales - ActualSales}";
        }
       
    }
}
