using System;

namespace Lab8
{
    class Program
    {

        static void Main(string[] args)

        {
            string[] names = { "Jake", "Chris", "Jess", "Paula", "Levi" };
            string[] hometown = { "Flushing", "Flint", "Ferndale", "Livonia", "Novi" };
            string[] favortieFood = { "Steak", "Pizza", "Hamburger", "Pasta", "Burrito" };
            double[] gpa = { 3.9, 3.4, 2.5, 3.1, 2.7, };
            string[] major = { "Computer Science", "Chemistry", "Biology", "Supply Chain Management", "Economics" };


            try
            {

                PrintNames(names);
                int number1 = ValidateUserChoice("Validate");
                AskForMoreInfo(number1, names, hometown, favortieFood, gpa, major);
                AskForOtherStudent();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void PrintNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(i + 1 + "-" + names[i]);
            }
            Console.WriteLine();
        }


        public static string AskUserforStudent(string[] names)
        {

            Console.WriteLine("Which student would you like to know more about? (type in corresponding number)");
            string userChoice = Console.ReadLine();
            return userChoice;

        }

        public static int ValidateUserChoice(string message)
        {
            string[] names = { };
            string input = AskUserforStudent(names);
            int userChoice;
            if (int.TryParse(input, out userChoice) && (userChoice > 0 && userChoice < 6))
            {
                return userChoice - 1;
            }

            else
            {
                return ValidateUserChoice("Please enter a number 1-5");
            }

        }
        public static void AskForMoreInfo(int nameInput, string[] names, string[] hometown, string[] favoritefood, double[] gpa, string[] major)
        {
            bool askAgainLoop = true;
            while (askAgainLoop) //Setting up a loop to keep asking for more info, until user declines
            {

                Console.WriteLine("What would you like to know about " + names[nameInput] + "?\n(Enter hometown, favorite food, gpa, major or none)");
                string moreInfo = Console.ReadLine().ToLower();

                switch (moreInfo)
                {
                    case "hometown":
                        Console.WriteLine(names[nameInput] + "'s hometown is " + hometown[nameInput]);
                        break;

                    case "favorite food":
                        Console.WriteLine(names[nameInput] + "'s favorite food is " + favoritefood[nameInput]);
                        break;

                    case "gpa":
                        Console.WriteLine(names[nameInput] + "'s gpa is " + gpa[nameInput]);
                        break;

                    case "major":
                        Console.WriteLine(names[nameInput] + "'s major is " + major[nameInput]);
                        break;

                    case "none":
                        AskForOtherStudent();
                        break;

                    default:
                        Console.WriteLine("That wasn't a valid option");
                        continue;
                }

                Console.WriteLine("Would you like to know more?(yes or no)");
                string evenMoreInfo = Console.ReadLine();
                if (evenMoreInfo == "yes")
                {
                    askAgainLoop = true;
                }

                else
                {
                    AskForOtherStudent();
                }

            }

        }

        public static void AskForOtherStudent()
        {
            //Copying main method 

            Console.WriteLine("Would you like to look up another student? (yes or no)");
            string userAnswer = Console.ReadLine().ToLower();
            if (userAnswer == "yes")
            {
                string[] names = { "Jake", "Chris", "Jess", "Paula", "Levi" };
                string[] hometown = { "Flushing", "Flint", "Ferndale", "Livonia", "Novi" };
                string[] favortieFood = { "Steak", "Pizza", "Hamburger", "Pasta", "Burrito" };
                double[] gpa = { 3.9, 3.4, 2.5, 3.1, 2.7, };
                string[] major = { "Computer Science", "Chemistry", "Biology", "Supply Chain Management", "Economics" };


                PrintNames(names);
                int number1 = ValidateUserChoice("Validate");
                AskForMoreInfo(number1, names, hometown, favortieFood, gpa, major);
                AskForOtherStudent();
            }

            else if (userAnswer == "no")
            {
                Console.WriteLine("Have a good day");
                System.Environment.Exit(1);
            }

            else
            {
                Console.WriteLine("Invalid input");
                AskForOtherStudent();
            }

        }

    }
}
