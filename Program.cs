using System;

namespace semana_3_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                int num = 10;
            double result = Math.Sqrt(num);
            Console.WriteLine(result);
            Console.Write($"es la raiz cuadrada de su numero" );
            
            }   catch(Exception ex){
                Console.Write(ex.Message);

            }Console.ReadKey();
        }
    }
}

