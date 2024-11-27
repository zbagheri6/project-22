using System.Globalization;
namespace MyFirstApp
{
  public class Product
  {
    public void GetProductPrices()
    {
      Console.Write(" Enter number of Products:");
      int numberofProducts = int.Parse(Console.ReadLine());

      for (int i = 0; i < numberofProducts; i++)
      {
        Console.Write($"decimal price{i + 1}:");
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
          Console.WriteLine(" Very Cheap");
        }
      }
    }
  }
}