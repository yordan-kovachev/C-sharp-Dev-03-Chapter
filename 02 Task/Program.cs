//Напишете булев израз,
//който да проверява дали дадено цяло число се
//дели и на 5,
//и на 7
//без остатък.

namespace _02_Task
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Ask the user to enter a whole number (this step can be seen as a console input)
            Console.WriteLine("Please write a whole number: ");

            //Save that whole number in computer's memory of what the user entered (this is a user Input)
            int wholeNumber = Convert.ToInt32(Console.ReadLine());
            
            //declare int verible number of 5 and 7
            int devisibleByFive = 5;
            int devisibleBySeven = 7;

            //Divide user's entered wholeNumber by 5 and 7. To find its reminder for each variable if it is true(x && y = 0) or false(x && y > 0)
            int x = wholeNumber % devisibleByFive;
            int y = wholeNumber % devisibleBySeven;

            //Quick test for x and y returned calculated value from line25 and 26
            Console.WriteLine(" reminder of x is {0} and reminder of y is {1}", x, y);

            //Check if both numbers equal to reminder of 0 for true and print that to the user
            if ((x == 0) && (y == 0))
            {
                Console.WriteLine(" {0} is devisible by 5 and 7", wholeNumber);
            }
            else
            {
                Console.WriteLine(" {0} is not devisible by 5 and 7", wholeNumber);
            }
        }
    }
}