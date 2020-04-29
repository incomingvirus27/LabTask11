using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask11ClassesAndObject
{
    class Medicine
    {
        public string MedCode { get; set; }
        private string MedName { get; set; }
        public string ManCode { get; set; }
        private decimal unitPrice;
        private int quant;
        public Date ManDate { get; set; }
        public Date ExpDate { get; set; }
        private int batchNum { get; set; }

        public Medicine(string medCode, string medName, string manCode, decimal unitPrice, int quant, Date manDate, Date expDate, int batchNum)
        {
            MedCode = medCode;
            MedName = medName;
            ManCode = manCode;
            UnitPrice = unitPrice;
            Quantity = quant;
            ManDate = manDate;
            ExpDate = expDate;
            BatchNum = batchNum;
        }
        public decimal UnitPrice
        {
            get { return unitPrice; }
            private set
            {
                if (value > 0)
                {
                    unitPrice = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please the quantiity of items cannot be 0");
                }
            }
        }
        public int Quantity
        {
            get { return quant; }
            private set 
            { 
                if(value >= 0)
                {
                    quant = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please the quantity of items cannot be less than 0");
                }
            }
        }
        
        public int BatchNum
        {
            get { return batchNum; }
            set { batchNum = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Medicine Code: {MedCode}\nMedicine Name: {MedName}\nManufacturer Name: {ManCode}\nUnit Price: {UnitPrice:c}\nQuantity in stock: {Quantity}\nManufactured Date: {ManDate}\nExpiry Date: {ExpDate}\nBatch Number: {BatchNum}");
        }
        public void Print(int Quantity)
        {
            Console.WriteLine(Quantity);
            //return Quantity;
        }
        public void Print(Date ManDate, Date ExpDate)
        {
            Console.WriteLine("The manufacture date is {0} and the expriry date is {1}", ManDate, ExpDate);
        }
        public int Increase()
        {
            int ItemsQuantity = 0;
            if (Quantity == 0)
            {
                ItemsQuantity =  Quantity + 50;
            }
               return ItemsQuantity;           
        }
      
    }
}
