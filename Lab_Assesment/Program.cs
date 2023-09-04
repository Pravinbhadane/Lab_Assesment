public class Program
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int lastDigit = number % 10; int firstDigit = 0;
   
        int sum = 0;

        while (number > 0)
        {
            firstDigit=number % 10;

            number = number / 10;
        }
        sum = lastDigit + firstDigit;
        Console.WriteLine(sum);
    }
}