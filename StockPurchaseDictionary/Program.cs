using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AA", "Alcoa Corp");
            stocks.Add("AUY", "Yamana Gold");
            stocks.Add("AVTR", "Avantor Inc");
            stocks.Add("ATCO", "Atlas Corp.");
            stocks.Add("BEST", "Best Inc");
            stocks.Add("BMO", "Bank of Montreal");
            stocks.Add("BNS", "Bank of Nova Scotia");
            stocks.Add("BOX", "Box Inc");

            string GM = stocks["GM"]; // this should return General Motors
            Console.WriteLine(GM);
            Console.ReadLine();

            // Create list of ValueTuples that represents stock purchases. Properties will be ticker, shares, price.
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "AA", shares: 150, price: 23.21));
            purchases.Add((ticker: "AA", shares: 32, price: 17.87));
            purchases.Add((ticker: "AA", shares: 80, price: 19.02));
            // Add more for each stock you added to the stocks dictionary

            purchases.Add((ticker: "GM", shares: 17, price: 12.02));
            purchases.Add((ticker: "GM", shares: 19, price: 19.02));
            purchases.Add((ticker: "GM", shares: 36, price: 36.02));

            purchases.Add((ticker: "CAT", shares: 34, price: 45.02));
            purchases.Add((ticker: "CAT", shares: 25, price: 29.02));
            purchases.Add((ticker: "CAT", shares: 20, price: 25.02));

            purchases.Add((ticker: "BEST", shares: 32, price: 34.02));
            purchases.Add((ticker: "BEST", shares: 48, price: 50.02));
            purchases.Add((ticker: "BEST", shares: 56, price: 58.02));

            //Create a total ownership report that computes the total value of each stock that you have purchased.
            //This is the basic relational database join algorithm between two tables.

            /*
             * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
             * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
            */

            Dictionary<string, double> totalPurchase = new Dictionary<string, double>();
            // Iterate over the purchases and update the valuation for each stock
            foreach (var (ticker, shares, price) in purchases)
            {
                if (totalPurchase.ContainsKey(ticker) == false)
                {
                    totalPurchase.Add(ticker, 0);
                }
                else if (ticker == "AA")
                {
                    double allPrice = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.price).Sum();
                    double allShares = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.shares).Sum();
                    var purchaseInfo = allPrice * allShares;
                    totalPurchase[ticker] = Math.Round(purchaseInfo);
                }
                else if (ticker == "GM")
                {
                    double allPrice = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.price).Sum();
                    double allShares = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.shares).Sum();
                    var purchaseInfo = allPrice * allShares;
                    totalPurchase[ticker] = Math.Round(purchaseInfo);
                }
                else if (ticker == "CAT")
                {
                    double allPrice = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.price).Sum();
                    double allShares = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.shares).Sum();
                    var purchaseInfo = allPrice * allShares;
                    totalPurchase[ticker] = Math.Round(purchaseInfo);
                }
                else if (ticker == "BEST")
                {
                    double allPrice = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.price).Sum();
                    double allShares = purchases.Where(purchase => purchase.ticker == ticker).Select(purchase => purchase.shares).Sum();
                    var purchaseInfo = allPrice * allShares;
                    totalPurchase[ticker] = Math.Round(purchaseInfo);
                }
                // Does the company name key already exist in the report dictionary?
                // If it does, update the total valuation
                // If not, add the new key and set its value
            }
            var comp1 = totalPurchase["GM"];
            var comp2 = totalPurchase["AA"];
            var comp3 = totalPurchase["CAT"];
            var comp4 = totalPurchase["BEST"];
            string AA = stocks["AA"];
            string CAT = stocks["CAT"];
            string BEST = stocks["BEST"];
            Console.WriteLine($"Totals = {GM}: ${comp1}, {AA}: ${comp2}, {CAT}: ${comp3}, {BEST}: ${comp4}");
            Console.ReadLine();

        }
    }
}
