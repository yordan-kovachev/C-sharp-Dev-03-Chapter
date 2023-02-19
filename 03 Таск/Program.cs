//Напишете израз,
//който да проверява
//дали третата цифра
//(от дясно наляво)
//на дадено цяло число
//е 7

namespace _03_Таск
{
    internal class ThirdDigit
    {
        static void Main(string[] args)
        {
            //Ask the user to enter a whole number (this step can be seen as a console input)
            Console.WriteLine(" Please write a whole number: ");

            //Save that whole number in computer's memory of what the user entered (this is a user Input)
            int wholeNumber = Convert.ToInt32(Console.ReadLine());

            //Divide the whole number by 100 and then the resul by modulo 10 to find the reminder 
            int thirdDigit = (wholeNumber / 100)% 10;

            //Check if the reminder is equal to 7
            if (thirdDigit == 7)
            {
                Console.WriteLine(" The third digit IS 7.");
            }
            else 
            {
                Console.WriteLine(" The third digit IS Not 7.");
            }
        }
    }
}