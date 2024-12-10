using System;

namespace ProductPricing
{
    public class Product
    {
        public void GetProductPrices()
        {
            Console.Write("تعداد محصولات را وارد کنید: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.Write($"قیمت محصول {i + 1} را وارد کنید: ");
                decimal price = decimal.Parse(Console.ReadLine());

                if (price >= 1000)
                {
                    Console.WriteLine("Very Expensive");
                }
                else if (price >= 900)
                {
                    Console.WriteLine("Expensive");
                }
                else if (price >= 700)
                {
                    Console.WriteLine("Good");
                }
                else if (price >= 600)
                {
                    Console.WriteLine("Very Good");
                }
                else if (price >= 500)
                {
                    Console.WriteLine("Cheap");
                }
                else
                {
                    Console.WriteLine("Very Cheap");
                }
            }
        }
    }
}