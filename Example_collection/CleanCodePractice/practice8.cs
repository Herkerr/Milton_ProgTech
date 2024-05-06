public void PrintNumbers(int[] numbers)
{
    string result = "";
    foreach (int num in numbers)
    {
        result += num + ", ";
    }
    Console.WriteLine("Numbers: " + result);
}
