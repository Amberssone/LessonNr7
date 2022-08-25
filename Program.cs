// Домашняя задание, урок 7
/* 1 Задание 
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int size = 10;
        int[,] arr = new int[size, size];
        for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            arr[i, j] = r.Next(0, 9);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
    }
}
*/

// 2 Задание 

/* 3 Задание


{
        static void Main(string[] args)
        {
            int[,] number = new int[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine("Please enter number");
                    number[x, i] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < 3; i++)
{
    int Avg = 0;
    for(int x = 0; x < 3; x++)
    {
        Console.Write(number[x, i] + " ");
        Avg += number[x, i];
    }
    Avg = Avg / 3;
    Console.Write("Average is" + Avg);
    Console.WriteLine(" ");
    Console.ReadLine();
}
        }
}
*/
