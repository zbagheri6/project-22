// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int[] myNumbers = { 5, 3, 1, 4, 2 };
        MyArray myArray = new MyArray(myNumbers);
        myArray.Print();
    }
}