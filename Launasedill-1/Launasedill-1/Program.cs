using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launasedill_1
{
    class Program
    {
        static decimal TaxPer1 = 0.3713m, TaxPer2 = 0.3835m, TaxPer3 = 0.4625m;             // Skattprósenta af öllum þrepum
        static decimal TaxAmount1 = 0m, TaxAmount2 = 0m, TaxAmount3 = 0m, TaxTotal = 0m;    // Skattur úr Skattþrepum og total.
        static decimal TaxStep1 = 336035m, TaxStep2n3 = 836990m;                            // SkattÞrepin. Minna en 836.... er 
        static decimal PensPer = 0.04m, Pens = 0m;                                          // Lífeyrissjóðurinn + prósenta
        static decimal UnionPer = 0.01m, Union = 0m;                                        // Stéttarfélag + prósenta
        static decimal Salary = 0m, SalaryAfterTax = 0m;                                    // Laun og Laun eftir skatta
        static decimal Personal = 51920m;                                                   // Persónuafsláttur
        static decimal SalaryAfterPens = 0m;                                                // Skattstofn
        static decimal Extra = 0m, ExtraPer = 0.02m;                                        // Viðbótarlífeyrir + prósenta

        // Stack Overflow dúddarnir segja ALWAYS DECIMAL for financial. 






        static void Main(string[] args)
        {   
            
            Console.Write("Stimplaðu inn laun: ");
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

            Union = Salary * UnionPer;
            TaxTotal = TaxAmount1 + TaxAmount2 + TaxAmount3 - Personal;
            SalaryAfterTax = SalaryAfterPens - TaxTotal - Union;
            Console.Clear();
            
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Laun fyrir skatta: {0} kr", Math.Round(Salary));
            Console.WriteLine("");
            Console.WriteLine("Greitt í lífseyrissjóð: {0} kr", Math.Round(Pens));
            Console.WriteLine("");
            Console.WriteLine("Greitt í séreignarsparnað: {0} kr", Math.Round(Extra));
            Console.WriteLine("");
            Console.WriteLine("Greitt í stéttarfélag: {0} kr", Math.Round(Union));
            Console.WriteLine("");
            Console.WriteLine("Skattstofn {0} kr", Math.Round(SalaryAfterPens));
            Console.WriteLine("");
            Console.WriteLine("Skattur eftir frádrátt persónuafsláttar: {0} kr", Math.Round(TaxTotal));
            Console.WriteLine("");
            Console.WriteLine("Útborguð laun eftir alla skatta eru: {0} kr", Math.Round(SalaryAfterTax));
            Console.WriteLine("--------------------------------------------------------------------------------");
            
            Console.ReadLine();

        }

        // 37,13% 0-336035
        // 38,35% 336.036 – 836.990
        // 46,25% Yfir 836.990 krónum

        /*              CheckList

            Tímakaup                                                seinna
            Yfirvinna                                               seinna
            Viðbótarsparnaður                                       búið
            Persónuafsláttur                                        búið
            Error checks                                            Seinna
            Input frá notanda (t.d. viðbótarsparnaðarprósenta)      Seinna

             //Find the total tax paid 

             //Find the pension amount 

             //Find the union amount   

             //Find add savings amount 
            
             //


        */

    }
}

