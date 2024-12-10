using System;

public class MyArray
{
    private int[] numbers;

        public MyArray(int[] inputNumbers)
    {
        if (inputNumbers.Length == 0)
        {
            throw new ArgumentException("آرایه نمی‌تواند خالی باشد.");
        }
        numbers = inputNumbers;
    }

        public void Print()
    {
        BubbleSort();
        Console.WriteLine("اعضای آرایه به صورت صعودی:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("کوچک‌ترین عضو آرایه: " + FindMin());
    }

   
    private int FindMin()
    {
        int min = numbers[0];
        foreach (var number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        return min;
    }

   
    private void Swap(int index1, int index2)
    {
        int temp = numbers[index1];
        numbers[index1] = numbers[index2];
        numbers[index2] = temp;
    }

    private void BubbleSort()
    {
        int n = numbers.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    
                    Swap(j, j + 1);
                }
            }
        }
    }
}
