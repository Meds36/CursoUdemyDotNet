using System;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 10;
                int b = 0;

                double result = a / b;

                Console.WriteLine(result);

            }
            catch (DivideByZeroException ex)
            {
                Console.Write("ERRO! " + ex.Message);
                throw;
            }

            catch (FormatException a)
            {
                Console.Write("ERRO! " + a.Message);
                throw;

            }
            finally
            {


            }



        }
    }
}
