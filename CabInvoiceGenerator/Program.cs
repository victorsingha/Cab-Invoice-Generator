using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");

            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(4.0, 5), new Ride(3.0, 7) };
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            double[] result = summary.GetData();
            Console.WriteLine($"Total Rides: {result[0]}");
            Console.WriteLine($"Total Fare: {result[1]}");
            Console.WriteLine($"Average Fare: {result[2]}");
        }
    }
}
