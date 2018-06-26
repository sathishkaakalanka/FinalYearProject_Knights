using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonRepositorie;

namespace CommonBL
{
    public class ValueChangeAlgorithm
    {
        StockMarket ctx = new StockMarket();
        private float StockSherePriceGenerator(int events)
        {
            Random Trends = new Random();
            int MarketTrendsValue = Trends.Next(-3, 4);
            int SectorTrendsValue = 0;
            float PresentageofStockmarket=0;
            int BustEvent = 0;
            int BoomEvent = 0;
            int Profit_WarningEvent = 0;
            int TakeOverEvent = 0;
           int ScandalEvent = 0;
            var StockPrice = new ValueChangeReposirory(ctx).GetAllCompanysDetails();
            string sector="";
            for (var j = 0; j < StockPrice.Count; j++)
            {
                var sectorname = StockPrice[j].SectorName;
               
                if (sector == ""||sector!=sectorname)
                {
                    if (events == 0 || events == 1 || events == 2 || events == 3)
                    {
                        //event checker
                        Random SectorEvents = new Random();
                        int sectorevents = Trends.Next(0, 1);
                        if (sectorevents == 0)
                        {
                            //boom
                            Random Boom = new Random();
                             BoomEvent = Trends.Next(1, 6);
                        }
                        else if(sectorevents == 1)
                        {
                            //bust
                            Random Bust = new Random();
                             BustEvent = Trends.Next(-6,-1);
                        }

                    }
                    sector = sectorname;
                    SectorTrendsValue = Trends.Next(-3, 4);
                    
                }
                else
                {
                    sector = "";
                   j-= 1;
                }

                if (sector == sectorname)
                    {
                 //   var SectorsValue = SectorTrendsValue;
                    for (var i = 0; i < StockPrice.Count; i++)
                        {
                        if (events == 4 || events == 5 || events == 6 || events == 7 || events == 8 || events == 9)
                        {
                            //event checker
                            Random StockEvents = new Random();
                            int stockevents = Trends.Next(0, 3);
                            if((stockevents==0|| stockevents == 1)&&(BoomEvent!=0|| BustEvent!=0))
                            {
                                //PROFIT_WARNING
                                Random PROFIT_WARNING = new Random();
                                Profit_WarningEvent = Trends.Next(2, 4);
                            }
                            else if(stockevents == 2)
                            {
                                //TAKE_OVER
                                Random TAKE_OVER = new Random();
                                TakeOverEvent = Trends.Next(-1, -6);
                            }
                            else if (stockevents == 3)
                            {
                                //SCANDAL 
                                Random SCANDAL = new Random();
                                ScandalEvent = Trends.Next(-6,-3);
                            }
                        }
                        int RandomTrendsValue = Trends.Next(-2, 3);
                             PresentageofStockmarket = (RandomTrendsValue + MarketTrendsValue + SectorTrendsValue+ BoomEvent+ BustEvent+ Profit_WarningEvent+ TakeOverEvent+ ScandalEvent);
                        }
                    }
              
            }
            return PresentageofStockmarket;
        }
       private void StockmarketEvent()
        {
            Random Events = new Random();
            int events = Events.Next(0,9);
            StockSherePriceGenerator(events);
        }
       
    }
}
