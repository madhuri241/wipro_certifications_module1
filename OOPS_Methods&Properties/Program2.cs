using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Methods_Properties
{
   public class Stock
    {
        string stockName;
        string stockSymbol;
        double prevstockPrice;
        double currentStockPrice;
        public Stock(string stockName, string stockSymbol, double prevstockPrice, double currentStockPrice)
        {
            this.stockName = stockName;
            this.stockSymbol = stockSymbol;
            this.prevstockPrice = prevstockPrice;
            this.currentStockPrice = currentStockPrice;
        }
        public void getChangePercentage()
        {
            double changePercentage = ((currentStockPrice - prevstockPrice) / prevstockPrice) * 100;
            Console.WriteLine($"The change percentage for {stockName} ({stockSymbol}) is {changePercentage:F2}%");
        }
    }
    public class Program2
    {
       static void Main(string[] args)
        {
            Stock stock1 = new Stock("Apple Inc.", "AAPL", 150.00, 155.00);
            stock1.getChangePercentage();
            Stock stock2 = new Stock("Microsoft Corp.", "MSFT", 280.00, 275.00);
            stock2.getChangePercentage();
            
        }
    }
}
