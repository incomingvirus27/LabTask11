using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask11ClassesAndObject
{
    class Medicine
    {
        private string medCode;
        private string medName;
        private string manName;
        private decimal unitPrice;
        private int quant;
        public Date ManDate { get; set; }
        public Date ExpDate { get; set; }
        private int batchNum;

        public Medicine(string medCode, string medName, string manName, decimal unitPrice, int quant, Date manDate, Date expDate, int batchNum)
        {
            MedCode = medCode;
            MedName = medName;
            ManName = manName;
            UnitPrice = unitPrice;
            Quantity = quant;
            ManDate = manDate;
            ExpDate = expDate;
            BatchNum = batchNum;
        }

        public string MedCode
        {
            get { return medCode; }
            set { medCode = value; }
        }
        public string MedName
        {
            get { return medName; }
            set { medName = value; }
        }
        public string ManName
        {
            get { return manName; }
            set { manName = value; }
        }

        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
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
            set 
            { 
                if(value >= 0)
                {
                    quant = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Please the quantiity of items cannot be less than 0");
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
            Console.WriteLine($"Medicine Code: {MedCode}\nMedicine Name: {MedName}\nManufacturer Name: {ManName}\nUnit Price: {UnitPrice:c}\nQuantity in stock: {Quantity}\nManufactured Date: {ManDate}\nExpiry Date: {ExpDate}\nBatch Number: {BatchNum}");
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
            if (Quantity == 0)
            {
                return Quantity + 50;
            }
            else return Quantity;
        }
    }
}
