int[,] mas = new int[5, 5];
Random r = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        mas[i, j] = r.Next(-9, 9);
        if (mas[i, j] < 0) mas[i, j] = 0;
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}