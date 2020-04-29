using System;

namespace LabTask11ClassesAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating object of the classes created.
            Date mdate = new Date(6, 8, 2015);
            Date xdate = new Date(7, 9, 2017);

            Sales sales = new Sales("C18H26CIN3", 78, 15000m, 7000m, "Africa");
            Medicine medicine = new Medicine("C8H9NO2", "Panadol", "Levintis", 60m, 0, mdate, xdate, 6789);

            Console.WriteLine("Novertis Pharma Ltd.");

            Console.WriteLine("All the items in store");
            medicine.Print();            
            
            Console.WriteLine("When the Quantity in stock is 0 order for {0}", medicine.Increase());

            Console.WriteLine("===============================");
            Console.Write("Quantity of products for sale is: ");
            medicine.Print(500);
            

            Console.WriteLine("All the sales item");
            sales.Display();

            sales.Display(17000m, 10000m);

            Console.ReadLine();
        }
    }
}
