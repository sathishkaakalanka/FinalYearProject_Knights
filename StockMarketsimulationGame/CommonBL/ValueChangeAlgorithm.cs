using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonBL
{
    public class ValueChangeAlgorithm
    {
        private int StockSherePriceGenerator()
        {
            Random Trends = new Random();
            int RandomTrendsValue = Trends.Next(-2, 3);
            int MarketTrendsValue = Trends.Next(-3, 4);
            int SectorTrendsValue = Trends.Next(-3, 4);
            
            return RandomTrendsValue;
        }
        //private int 
       
    }
}
