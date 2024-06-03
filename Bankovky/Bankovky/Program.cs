

namespace Bankovky
{

    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Zadejte částku");
            int castka = Convert.ToInt32(Console.ReadLine());
            int vysledek = 0;
            int pettisicbankovky = 0;
            int dvatisicebankovky = 0;
            int tisicbankovky = 0;
            int petsetbankovky = 0;
            int dvestebankovky = 0;
            int stobankovky = 0;
            
            // 5000   
            while (castka > vysledek)
            {
                vysledek = vysledek + 5000;
                // Console.WriteLine("+5000");
                pettisicbankovky = pettisicbankovky + 1;
            }
            
            // if (castka < vysledek) Console.WriteLine("-5000");
            if (castka < vysledek) pettisicbankovky = pettisicbankovky - 1;
            if (castka < vysledek) vysledek = vysledek - 5000;

            // Console.WriteLine("-------------");
            // Console.WriteLine(vysledek);
            //
            // Console.WriteLine("");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // Console.WriteLine(vysledek);
            
            // 2000
            while (castka > vysledek)
            {
                vysledek = vysledek + 2000;
                // Console.WriteLine("+2000"); 
                dvatisicebankovky = dvatisicebankovky + 1;
            }
            
            // if (castka < vysledek) Console.WriteLine("-2000");
            if (castka < vysledek) dvatisicebankovky = dvatisicebankovky - 1;
            if (castka < vysledek) vysledek = vysledek - 2000;

            // Console.WriteLine("-------------");
            // Console.WriteLine(vysledek);
            //             
            // Console.WriteLine("");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // Console.WriteLine(vysledek);
            
            // 1000
            
            while (castka > vysledek)
            {
                vysledek = vysledek + 1000;
                // Console.WriteLine("+1000");   
                tisicbankovky = tisicbankovky + 1;
            }
            
            // if (castka < vysledek) Console.WriteLine("-1000");
            if (castka < vysledek) tisicbankovky = tisicbankovky - 1;
            if (castka < vysledek) vysledek = vysledek - 1000;

            // Console.WriteLine("-------------");
            // Console.WriteLine(vysledek);
            //
            //             
            // Console.WriteLine("");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // Console.WriteLine(vysledek);
            
            // 500
            while (castka > vysledek)
            {
                vysledek = vysledek + 500;
                // Console.WriteLine("+500"); 
                petsetbankovky = petsetbankovky + 1;
            }
            
            // if (castka < vysledek) Console.WriteLine("-500");
            if (castka < vysledek) petsetbankovky = petsetbankovky - 1;
            if (castka < vysledek) vysledek = vysledek - 500;

            // Console.WriteLine("-------------");
            // Console.WriteLine(vysledek);
            //
            //             
            // Console.WriteLine("");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // Console.WriteLine(vysledek);
            
            // 200
            while (castka > vysledek)
            {
                vysledek = vysledek + 200;
                // Console.WriteLine("+200"); 
                dvestebankovky = dvestebankovky + 1;
            }
            
            // if (castka < vysledek) Console.WriteLine("-200");
            if (castka < vysledek) dvestebankovky = dvestebankovky - 1;
            if (castka < vysledek) vysledek = vysledek - 200;
            
            // Console.WriteLine("-------------");
            // Console.WriteLine(vysledek);
            //
            //             
            // Console.WriteLine("");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // Console.WriteLine(vysledek);

            // 100
            while (castka > vysledek)
            {
                vysledek = vysledek + 100;
                // Console.WriteLine("+100");
                stobankovky = stobankovky + 1;
            }   
            
            // if (castka < vysledek) Console.WriteLine("-100");
            if (castka < vysledek) stobankovky = stobankovky - 1;
            if (castka < vysledek) vysledek = vysledek - 100;
            
            // Console.WriteLine("-------------");
            // Console.WriteLine(vysledek);
            //             
            // Console.WriteLine("");
            // Console.WriteLine("");
            // Console.WriteLine("");
            //
            // Console.WriteLine(vysledek);
            
            Console.WriteLine("{0}x 5000", pettisicbankovky);
            Console.WriteLine("{0}x 2000", dvatisicebankovky);
            Console.WriteLine("{0}x 1000", tisicbankovky);
            Console.WriteLine("{0}x 500", petsetbankovky);
            Console.WriteLine("{0}x 200", dvestebankovky);
            Console.WriteLine("{0}x 100", stobankovky);
            Console.WriteLine("{0} CZK", vysledek);
            
            Console.ReadLine();

        }
        
        
    }
    
}
