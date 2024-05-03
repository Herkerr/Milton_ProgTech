public void FindMax(int[] numbers)
{
    int max = 0;
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    Console.WriteLine("Max number is: " + max);
}
