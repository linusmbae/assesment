using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Exercise01
    {
        // extension method 
        public static string oneToHundred(int i)
        {
            String str = "";
            while (i!=0)
            {
                if (i == 1)
                {
                    str = str + "One ";
                    i = 0;
                }
                else if (i == 2)
                {
                    str = str + "Two ";
                    i = 0;
                }
                else if (i == 3)
                {
                    str = str + "Three ";
                    i = 0;
                }
                else if (i == 4)
                {
                    str = str + "Four ";
                    i = 0;
                }
                else if (i == 5)
                {
                    str = str + "Five ";
                    i = 0;
                }
                else if (i == 6)
                {
                    str = str + "Six ";
                    i = 0;
                }
                else if (i == 7)
                {
                    str = str + "Seven ";
                    i = 0;
                }
                else if (i == 8)
                {
                    str = str + "Eight ";
                    i = 0;
                }
                else if (i == 9)
                {
                    str = str + "Nine ";
                    i = 0;
                }
                else if (i == 10)
                {
                    str = str + "Ten ";
                    i = 0;
                }
                else if (i == 11)
                {
                    str = str + "Eleven ";
                    i = 0;
                }
                else if (i == 12)
                {
                    str = str + "Twelve ";
                    i = 0;
                }
                else if (i == 13)
                {
                    str = str + "Thirteen ";
                    i = 0;
                }
                else if (i == 14)
                {
                    str = str + "Fourteen ";
                    i = 0;
                }
                else if (i == 15)
                {
                    str = str + "Fifteen ";
                    i = 0;
                }
                else if (i == 16)
                {
                    str = str + "Sixteen ";
                    i = 0;
                }
                else if (i == 17)
                {
                    str = str + "Seventeen ";
                    i = 0;
                }
                else if (i == 18)
                {
                    str = str + "Eighteen ";
                    i = 0;
                }
                else if (i == 19)
                {
                    str = str + "Nineteen ";
                    i = 0;
                }
                else if (i >= 20 && i<30)
                {
                    str = str + "Twenty ";
                    i = i-20;
                }
                else if (i >= 30 && i < 40)
                {
                    str = str + "Thirty ";
                    i = i - 30;
                }
                else if (i >= 40 && i < 50)
                {
                    str = str + "Fourty ";
                    i = i - 40;
                }
                else if (i >= 50 && i < 60)
                {
                    str = str + "Fifty ";
                    i = i - 50;
                }
                else if (i >= 60 && i < 70)
                {
                    str = str + "Sixty ";
                    i = i - 60;
                }
                else if (i >= 70 && i < 80)
                {
                    str = str + "Seventy ";
                    i = i - 70;
                }
                else if (i >= 80 && i < 90)
                {
                    str = str + "Eighty ";
                    i = i - 80;
                }
                else if (i >= 90 && i < 100)
                {
                    str = str + "Ninety ";
                    i = i - 90;
                }
            }
            return str;
        }

        // Towards method
        public string Towards(int i)
        {
            String str = "";

            while (i != 0)
            {
                
                if (i >= 1 && i < 100)
                {
                    str = str + oneToHundred(i);
                    i = 0;
                }
                //with integers like 100...200...300
                else if (i >= 100 && i < 101 || i >= 200 && i < 201 || i >= 300 && i < 301 ||
                         i >= 400 && i < 401 || i >= 500 && i < 501 || i >= 600 && i < 601 ||
                         i >= 700 && i < 701 || i >= 800 && i < 801 || i >= 900 && i < 901
                          )
                {
                    str = str + oneToHundred(i / 100);
                    str = str + "Hundred";
                    i = i % 100;
                }
                //from 101 to 1000
                else if (i >= 101 && i < 1000)
                {
                    str = str + oneToHundred(i / 100);
                    str = str + "Hundred And ";
                    i = i % 100;
                }

                 //with integers like  1000...2000...3000
                else if (i >= 1000 && i < 1001 || i >= 2000 && i < 2001 || i >= 3000 && i < 3001 ||
                         i >= 4000 && i < 4001 || i >= 5000 && i < 5001 || i >= 6000 && i < 6001 ||
                         i >= 7000 && i < 7001 || i >= 8000 && i < 8001 || i >= 9000 && i < 9001
                    )
                {
                    str = str + oneToHundred(i / 1000);
                    str = str + "Thousand";
                    i = i % 1000;
                }
                //10000
                else if (i >= 10000 && i < 10001)
                {
                    str = str + oneToHundred(i / 1000);
                    str = str + "Thousand";
                    i = i % 1000;
                }
                //for integers like 10,000...17,000...20,000....29,000...30,000 etc
                else if (
                    //10,000 to 20,000
                    i >= 11000 && i < 11001 || i >= 12000 && i < 12001 || 
                    i >= 13000 && i < 13001 || i >= 14000 && i < 14001 ||
                    i >= 15000 && i < 15001 || i >= 16000 && i < 16001 ||
                    i >= 17000 && i < 17001 || i >= 18000 && i < 18001 || 
                    i >= 19000 && i < 19001 || i >= 20000 && i < 20001 ||
                    //20,000 to 30,000
                    i >= 21000 && i < 21001 || i >= 22000 && i < 22001 ||
                    i >= 23000 && i < 23001 || i >= 24000 && i < 24001 ||
                    i >= 25000 && i < 25001 || i >= 26000 && i < 26001 ||
                    i >= 27000 && i < 27001 || i >= 28000 && i < 28001 ||
                    i >= 29000 && i < 29001 || i >= 30000 && i < 30001 ||
                    //30,000 to 40,000
                    i >= 31000 && i < 31001 || i >= 32000 && i < 32001 ||
                    i >= 33000 && i < 33001 || i >= 34000 && i < 34001 ||
                    i >= 35000 && i < 35001 || i >= 36000 && i < 36001 ||
                    i >= 37000 && i < 37001 || i >= 38000 && i < 38001 ||
                    i >= 39000 && i < 39001 || i >= 40000 && i < 40001 ||
                    //40,000 to 50,000
                    i >= 41000 && i < 41001 || i >= 42000 && i < 42001 ||
                    i >= 43000 && i < 43001 || i >= 44000 && i < 44001 ||
                    i >= 45000 && i < 45001 || i >= 46000 && i < 46001 ||
                    i >= 47000 && i < 47001 || i >= 48000 && i < 48001 ||
                    i >= 49000 && i < 49001 || i >= 50000 && i < 50001 ||
                    //50,000 to 60,000
                    i >= 51000 && i < 51001 || i >= 52000 && i < 52001 ||
                    i >= 53000 && i < 53001 || i >= 54000 && i < 54001 ||
                    i >= 55000 && i < 55001 || i >= 56000 && i < 56001 ||
                    i >= 57000 && i < 57001 || i >= 58000 && i < 58001 ||
                    i >= 59000 && i < 59001 || i >= 60000 && i < 60001 ||
                    //60,000 to 70,000
                    i >= 61000 && i < 61001 || i >= 62000 && i < 62001 ||
                    i >= 63000 && i < 63001 || i >= 64000 && i < 64001 ||
                    i >= 65000 && i < 65001 || i >= 66000 && i < 66001 ||
                    i >= 67000 && i < 67001 || i >= 68000 && i < 68001 ||
                    i >= 69000 && i < 69001 || i >= 70000 && i < 70001 ||
                    //70,000 to 80,000
                    i >= 71000 && i < 71001 || i >= 72000 && i < 72001 ||
                    i >= 73000 && i < 73001 || i >= 74000 && i < 74001 ||
                    i >= 75000 && i < 75001 || i >= 76000 && i < 76001 ||
                    i >= 77000 && i < 77001 || i >= 78000 && i < 78001 ||
                    i >= 79000 && i < 79001 || i >= 80000 && i < 70001 ||
                    //80,000 to 90,000
                    i >= 81000 && i < 81001 || i >= 82000 && i < 82001 ||
                    i >= 83000 && i < 83001 || i >= 84000 && i < 84001 ||
                    i >= 85000 && i < 85001 || i >= 86000 && i < 86001 ||
                    i >= 87000 && i < 87001 || i >= 88000 && i < 88001 ||
                    i >= 89000 && i < 89001 || i >= 90000 && i < 90001 ||
                    //90,000 to 100,000
                    i >= 91000 && i < 91001 || i >= 92000 && i < 92001 ||
                    i >= 93000 && i < 93001 || i >= 94000 && i < 94001 ||
                    i >= 95000 && i < 95001 || i >= 96000 && i < 96001 ||
                    i >= 97000 && i < 97001 || i >= 98000 && i < 98001 ||
                    i >= 99000 && i < 99001 || i >= 100000 && i < 100001)
                {
                    str = str + oneToHundred(i / 1000);
                    str = str + "Thousand";
                    i = i % 1000;
                }
                //from 1001 to 10000
                else if (i >= 1001 && i < 10000)
                {
                    str = str + oneToHundred(i / 1000);
                    str = str + "Thousand And ";
                    i = i % 1000;
                }
                //from 10001 to 100000
                else if (i >= 10001 && i < 100000)
                {
                    str = str + oneToHundred(i / 1000);
                    str = str + "Thousand, ";
                    i = i % 1000;
                }
               
            }

            return str;
        }


    }
}
