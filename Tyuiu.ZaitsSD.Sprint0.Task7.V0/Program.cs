using Tyuiu.ZaitsSD.Sprint0.Task7.V0.Lib;
namespace Tyuiu.ZaitsSD.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums1 = { 1, 2, 3, 4, 5 };
            int[] arrayNums2 = { 1, 2, 3, 4, 5 };
            int[] result = DataService.AdditionArrays(arrayNums1, arrayNums2);
            Console.WriteLine("Результат сложения массивов:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
    }
}
