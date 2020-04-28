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

            Sales sales = new Sales("che", 78, 15000m, 7000m, "Africa");
            Medicine medicine = new Medicine("hcl", "Panadol", "Levintis", 60m, 500, mdate, xdate, 6789);

            Console.WriteLine("Novertis Pharma Ltd.");

            Console.WriteLine("All the items in store");
            medicine.Print();

            Console.WriteLine("===============================");
            Console.WriteLine("Quantity of products for sale");
            medicine.Print(500);

            Console.WriteLine("All the sales item");
            sales.Display();

            string diff = sales.Display(17000m, 10000m);
            Console.WriteLine("The difference between the actual sales and planned sales is {0}", diff);
        }
    }
}
