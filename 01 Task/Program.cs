//Напишете израз, който да проверява дали дадено цяло число е четно
//или нечетно.

namespace _01_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, reminder;
            Console.WriteLine("Please enter a interger value: ");
            number = Convert.ToInt32(Console.ReadLine());
            reminder = number % 2;
            if (reminder == 0)
            {
                Console.WriteLine("{0} is an even number", number);
            }
            else
            {
                Console.WriteLine("{0} is an odd number", number);
            }
        }
    }
}