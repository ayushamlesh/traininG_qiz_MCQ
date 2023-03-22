using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket   //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        public static SortedDictionary<String, long> stockDetails = new SortedDictionary<string, long>();

        //Implement the methods as per the description
       
        public static SortedDictionary<String, long> UpdateStockPrice(string stockName, long price)
        {
            SortedDictionary<string, long> val = new SortedDictionary<string, long>();
            if (stockDetails.ContainsKey(stockName))
            {
                stockDetails[stockName] = price;
                val.Add(stockName, price);
            }
            return val;
        }
        public static SortedDictionary<String, long> SortByStockName()
        {
            return stockDetails;
        }
        public static SortedDictionary<String, long> SearchStock(String stockName)
        {
            SortedDictionary<string, long> result = new SortedDictionary<string, long>();
            if (stockDetails.ContainsKey(stockName))
            {
                result.Add(stockName, stockDetails[stockName]);
            }
            return result;
        }

        public static void Main(string[] args) //DO NOT change the method signature
        {
            stockDetails.Add("Tata power", 250);
            stockDetails.Add("Maruthi suzuki", 9200);
            stockDetails.Add("Axis bank", 800);
            stockDetails.Add("ICICI securities", 790);
            stockDetails.Add("SBI", 510);

            //Implement code here
            int choice;
            do
            {
                Console.WriteLine("1. Search by stock name");
                Console.WriteLine("2. Update stock price");
                Console.WriteLine("3.Sort stocks price");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the stock name");
                        string stockName = Console.ReadLine();
                        SortedDictionary<string, long> op1 = SearchStock(stockName);
                        if (op1.Count > 0)
                        {
                            foreach (var stock in op1)
                            {
                                Console.WriteLine("{0} {1}", stock.Key, stock.Value);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Stock Not Found");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the stock name");
                        string stockName2 = Console.ReadLine();
                        Console.WriteLine("Enter the stock price");
                        long price = long.Parse(Console.ReadLine());
                        SortedDictionary<string, long> re2 = UpdateStockPrice(stockName2, price);
                        if (re2.Count > 0)
                        {
                            foreach (var stock in re2)
                            {
                                Console.WriteLine("{0}{1}", stock.Key, stock.Value);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Stock Not Found");
                        }
                        break;
                    case 3:
                        SortedDictionary<string, long> result3 = SortByStockName();
                        foreach (var stock in result3)
                        {
                            Console.WriteLine("{0}{1}", stock.Key, stock.Value);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thank You");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            } while (choice != 4);
        }

    }
}
