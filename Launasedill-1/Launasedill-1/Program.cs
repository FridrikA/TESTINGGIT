using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launasedill_1
{
    class Program
    {

        







        static void Main(string[] args)
        {   
            decimal TaxPer1 = 0.3713m, TaxPer2 = 0.3835m, TaxPer3 = 0.4625m;
            decimal TaxAmount1 = 0m, TaxAmount2 = 0m, TaxAmount3 = 0m, TaxTotal = 0m;
            decimal TaxStep1 = 336035m, TaxStep2n3 = 836990m;
            decimal PensPer = 0.04m, Pens = 0m;
            decimal UnionPer = 0.01m, Union = 0m;
            decimal Salary = 0m, SalaryAfterTax = 0m;
            decimal Personal = 51920m;
            decimal SalaryAfterPens = 0m;
            decimal Extra = 0m, ExtraPer = 0.02m;
            
            Console.Write("Stimplaðu inn laun, engar kommur plís: ");
            Salary = Convert.ToDecimal(Console.ReadLine());

            Pens = Salary * PensPer;
            Extra = Salary * ExtraPer;
            SalaryAfterPens = Salary - Pens - Extra;



            
            
            if (SalaryAfterPens < TaxStep1)
                TaxAmount1 = SalaryAfterPens * TaxPer1;
            else if ((SalaryAfterPens > TaxStep1) && (SalaryAfterPens < TaxStep2n3))
            {
                TaxAmount1 = TaxStep1 * TaxPer1;
                TaxAmount2 = (SalaryAfterPens - TaxStep1) * TaxPer2;
            }
            else if (SalaryAfterPens > TaxStep2n3)
            {
                TaxAmount1 = TaxStep1 * TaxPer1;
                TaxAmount2 = (TaxStep2n3 - TaxStep1) * TaxPer2;
                TaxAmount3 = (SalaryAfterPens - TaxStep2n3) * TaxPer3;
            }

            
            //  Báðar virka. Þarf að velja hvor.
            //  Á bara eftir að henda inn viðbótarsparnaði ezpz
            //  ---------YAY----------------------


            /*
            if (SalaryAfterPens > TaxStep1)
            {
                if (SalaryAfterPens > TaxStep2n3)
                {
                    TaxAmount1 = TaxStep1 * TaxPer1;
                    TaxAmount2 = (TaxStep2n3 - TaxStep1) * TaxPer2;
                    TaxAmount3 = (SalaryAfterPens - TaxStep2n3) * TaxPer3;

                }
                else
                {
                    TaxAmount1 = TaxStep1 * TaxPer1;
                    TaxAmount2 = (SalaryAfterPens - TaxStep1) * TaxPer2;
                }
            }
            else
                TaxAmount1 = SalaryAfterPens * TaxPer1;
            */

            
            

            Union = Salary * UnionPer;
            TaxTotal = TaxAmount1 + TaxAmount2 + TaxAmount3 - Personal;
            SalaryAfterTax = SalaryAfterPens - TaxTotal - Union;



            
            Console.WriteLine("SKATTÞREP 1 {0}", TaxAmount1);
            Console.WriteLine("SKATTÞREP 2 {0}", TaxAmount2);
            Console.WriteLine("SKATTÞREP 3 {0}", TaxAmount3);
            

            Console.WriteLine("Greitt í lífseyrissjóð: {0}", Math.Round(Pens));
            Console.WriteLine("Greitt í stéttarfélag: {0}", Math.Round(Union));
            Console.WriteLine("Skattstofn {0}", Math.Round(SalaryAfterPens));
            Console.WriteLine("Skattur eftir frádrátt persónuafsláttar {0}", Math.Round(TaxTotal));
            Console.WriteLine("Útborguð laun eru {0} ", Math.Round(SalaryAfterTax));
            
            Console.ReadLine();




            // 37,13% 0-336035
            // 38,35% 336.036 – 836.990
            // 46,25% Yfir 836.990 krónum

            /*              Heima

                Tímakaup
                Yfirvinna
                Viðbótarsparnaður
                Persónuafsláttur

                 //Find the total tax paid
   
                 //Find the pension amount
   
                 //Find the union amount
   
                 //Find add savings amount


            */


        }
    }
}

