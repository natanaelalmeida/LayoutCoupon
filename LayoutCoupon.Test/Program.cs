using System;

namespace LayoutCoupon.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var relatorio = new Coupon(41).Separator("=")
                 .DrawCenter("Company Test").Separator("-")
                 .DrawCenter("Date: 18/05/2017").Separator("=")
                 .DrawCenter("PRODUCTION ORDER").Separator(" -")
                 .Draw(new Title("Sector...: BAR PREPARO"))
                 .Draw(new Title("Order..: 6")).Separator("-")
                 .Draw(new Title("Operator: JOSANA"))
                 .Draw(new Title("Command.: 6", 0, 15), new Title("Table: 6")).Separator("-")
                 .Draw(new Title("Quantity", 0, 15), new Title("PRODUCT", 0, 20))
                 .Draw(new Title("1,000", 10, 15), new Title("CHOPP PILSEN ARTESANAL").IsWordCut(6)).Separator("-")
                 .Draw(new Title("Total Items.....: 1"))
                 .Draw(new Title("Total quantity.....: 1,000")).Jumpline(2)
                 .DrawCenter("Teste Footer (16) 11111-7777").ToString();            

            Console.Write(relatorio);
            Console.ReadKey();            
        }
    }
}
