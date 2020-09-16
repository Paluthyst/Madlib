using System;

namespace Project1MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcoming and asking for variables
            bool Madlib = true;
            while (Madlib)
            {
                //User input for words
                Console.WriteLine("WELCOME TO MADLIB");
                Console.WriteLine("Can I have 5 adjectives?");
                String adjective1 = InputAnswer();
                String adjective2 = InputAnswer();
                String adjective3 = InputAnswer();
                String adjective4 = InputAnswer();
                String adjective5 = InputAnswer();
                Console.WriteLine("Can I have 4 nouns?");
                String noun1 = InputAnswer();
                String noun2 = InputAnswer();
                String noun3 = InputAnswer();
                String noun4 = InputAnswer();
                Console.WriteLine("Can I have 2 verbs?");
                String verb1 = InputAnswer();
                String verb2 = InputAnswer();


                //story all put togeather
                Console.WriteLine("Our School Cafeteria has really " + adjective1 + " food. Just thinking about it makes my stomach " + verb1 + ". The bag lunch food is " + adjective2 + " and tastes like " + noun1 + ". One day, I swear one of my chicken sandwhiches started to " + verb2 + "! The turkey wraps are totally " + adjective3 + " and look kind of like old " + noun2 + ". My friend dana actually likes the pickles on the hamburgurs, even though they are " + adjective4 + " and " + adjective5 + ". I call it 'Mystery slices' and think it's really made out of " + noun3 + ". My dad said he'd make me lunches, but the first day he made 'fish and chips' out of " + noun4 + " and peanut butter! I think I'd rather take my chances with the cafeteria!");

                //play again loop
                Console.WriteLine("Do you want to play again? 1 for yes 2 for no:");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Madlib = true;
                }
                else
                {
                    Madlib = false;
                }
            }
        }
        //Cant give blank for an answer method
        public static string InputAnswer()
        {
            String input = Console.ReadLine();
            while (input == "")
            {
                Console.WriteLine("You can't give me blank for an answer sorry");
                input = Console.ReadLine();
            }
            return input;

        }


    }
}