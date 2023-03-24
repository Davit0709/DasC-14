using System;

class Program
{
    static void Main()
    {
     
        int[] numbers = new int[10];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100);
        }

    
        int maxIndex = 0;
        int minIndex = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[maxIndex])
            {
                maxIndex = i;
            }

            if (numbers[i] < numbers[minIndex])
            {
                minIndex = i;
            }
        }

        int maxNumber = numbers[maxIndex];
        int minNumber = numbers[minIndex];

    
        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = sum / numbers.Length;

        
        object[] info = new object[5];
        info[0] = maxNumber;
        info[1] = maxIndex;
        info[2] = minNumber;
        info[3] = minIndex;
        info[4] = average;

        Console.WriteLine("Исходный массив: ");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine();
        Console.WriteLine("Максимальный элемент: {0}, индекс: {1}", maxNumber, maxIndex);
        Console.WriteLine("Минимальный элемент: {0}, индекс: {1}", minNumber, minIndex);
        Console.WriteLine("Среднее арифметическое: {0}", average);
        Console.WriteLine();

 
        Array.Sort(numbers);

        double median;

        if (numbers.Length % 2 == 0)
        {
            int middleIndex = numbers.Length / 2;
            median = (numbers[middleIndex - 1] + numbers[middleIndex]) / 2.0;
        }
        else
        {
            int middleIndex = numbers.Length / 2;
            median = numbers[middleIndex];
        }

        Console.WriteLine("Медианное значение: {0}", median);
    }
}

