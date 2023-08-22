using System.Collections;

namespace ZadanieSrednia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key = ConsoleKey.Y;

            float a;

            float sum = 0;

            ArrayList liczby = new ArrayList();

            Console.WriteLine("Podaj liczy do średniej: ");

            Console.WriteLine("Po podaniu wszystkich liczb naduś ENTER aby wyliczyć Średnią ");
            do
            {

                float.TryParse(Console.ReadLine().Replace(".", ","), out a);


                liczby.Add(a);
                Console.WriteLine("ilość wprowadzonych liczb : " + liczby.Count);


            } while (a != 0);



            {
                foreach (var item in liczby)
                {
                    sum += (float)item;
                    //Console.WriteLine("suma liczb: " + sum); 
                  //  Console.WriteLine("wartość wprowadzonych liczb: " + item); 
                }
            }

            float srednia = sum / (liczby.Count - 1);
            Console.WriteLine($"Wynik Średniej to: {Math.Round(srednia, 2)}");


            Console.ReadKey();
        }


    }
}