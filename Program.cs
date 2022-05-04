public class Program
{

    public static void Main(string[] args)
    {
        int stuNum = 0;
        bool userAns = false;
        bool trueCat = false;
        string hTown = "hometown";
        string fFood = "favorite food";
        string y = "y";
        string yes = "yes";

        string[] names = new string[] { "Brian Johnson", "Andrew Clark", "John Bender", "Allison Reynolds", "Claire Standish" };
        string[] homeTown = new string[] { "Des Plaines, Illinois", "Des Plaines, Illinois", "Des Plaines, Illinois",
        "Des Plaines, Illinois", "Des Plaines, Illinois"};
        string[] favFood = new string[] {"pb&j (with the crusts cut off)", "anything but chicken", "alcohol",
        "Cap'n Crunch sandwiches", "caviar"};

        while (userAns == false)
        {
            Console.WriteLine($"Welcome, please enter the number of the student that you wish to reference (1-{names.Length}). " +
                "If you know the name of the student you wish to look up you may enter it instead. " +
                "(You may enter '6' to see a list of our current students.): ");
            string userAnswer = Console.ReadLine();
            userAns = int.TryParse(userAnswer, out stuNum);

            if (userAns == false)
            {
                Console.WriteLine("I'm sorry, I don't understand. Please try again.");
                Console.WriteLine();
            }
            else if (stuNum < 1 || stuNum > 6)
            {
                Console.WriteLine("I'm sorry, we don't have a student by that number. Please try again.");
                Console.WriteLine();
                userAns = false;
            }
            else if (stuNum == 6)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
                Console.WriteLine();
                userAns = false;
            }
            /*else if (names.Contains(userAnswer))
            {
                stuNum = Array.IndexOf(names, userAnswer) + 1;

                Console.WriteLine($"student {stuNum} is{names[stuNum - 1]}");
            }*/
            else if (stuNum >= 1 || stuNum <= 6)
            {
                while (trueCat == false)
                {
                    Console.WriteLine(names[stuNum - 1]);
                    Console.WriteLine();
                    Console.WriteLine("Would you like to see thier favorite food or know their hometown? ");
                    string userAnswerB = Console.ReadLine().ToLower();
                    userAnswerB.Trim();
                    userAnswerB = userAnswerB.Trim();

                    if (userAnswerB.Contains("home") || userAnswerB.Contains("town"))
                    {
                        Console.WriteLine(homeTown[stuNum - 1]);
                        Console.WriteLine();
                        trueCat = true;
                    }
                    else if (userAnswerB.Contains("food") || userAnswerB.Contains("fav"))
                    {
                        Console.WriteLine(favFood[stuNum - 1]);
                        Console.WriteLine();
                        trueCat = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, We don't have a category for that. Try one of our listed categories.");
                        trueCat = false;
                    }
                }

                Console.WriteLine("Would you like to learn about any of our other students? ");
                string keepAsk = Console.ReadLine().ToLower();
                keepAsk.Trim();
                keepAsk = keepAsk.Trim();

                if (keepAsk == y || keepAsk == yes)
                {
                    userAns = false;
                }
                else
                {
                    userAns = true;
                }
            }
        }
    }
}
