using System;

namespace Lab3_1
{
    class Program
    {


        static bool nextQuestion()
        {
            while (true)
            {
                Console.WriteLine("Would you like to learn more about this student? ( enter 'y' or 'n' )");
                string resp = Console.ReadLine();
                resp = resp.ToLower();

                if (resp == "y" || resp == "yes")
                {
                   
                    return true;
                    
                }
                else if (resp == "n" || resp == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }

            }
        }



        static bool Continue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to learn about another student? ( enter 'y' or 'n' )");
                string resp = Console.ReadLine();
                resp = resp.ToLower();

                if (resp == "y" || resp == "yes")
                {
                    return true;
                }
                else if (resp == "n" || resp == "no")
                {
                    return false;
                    
                }
                else
                {
                   
                    Console.WriteLine("Please enter y or n");
                }

            }
        }   

        static void Main(string[] args)
        {
            do
            {
                //Lab 3.1
                //Provide information about students in a class
                //Prompt the user to ask about a particular student
                //Give proper responses according to user-submitted information
                //Ask if user would like to learn about another student

                string[] studentNames = { "undefined", "Asia", "John", "Sue", "Greg", "Sam" };
                string[] favFood = { "undefined", "Pizza", "Tacos", "Salad", "Elote", "Caprese Salad" };
                string[] prevTitle = { "undefined", "Underwriter", "Astronaut", "CEO", "Doctor", "Business Owner" };

                Console.Write("Welcome to our Dev.Build class. Which student would you like to learn more about? (Please enter a number 1-5):  ");
                int selection = int.Parse(Console.ReadLine());

                //take user selection and list approriate name food and title

                do
                {
                    Console.Write($"Student number {selection} is {studentNames[selection]}. What would you like to know about {studentNames[selection]}? Options: 'favorite food' or 'previous title':  ");
                
                    string moreInfo = (Console.ReadLine());
                    if (moreInfo == "favorite food")
                    {
                        Console.WriteLine($"{studentNames[selection]}'s favoite food is {favFood[selection]}.");
                    }
                    else if (moreInfo == "previous title")
                    {
                        Console.WriteLine($"{studentNames[selection]}'s previus Title was {prevTitle[selection]}.");
                    }
                    else
                    {
                        Console.WriteLine("Oops! Please enter either 'favorite food' or 'previous title'. ");
                    }
                } while (nextQuestion());
            } while (Continue());

            Console.WriteLine("Thank you for using the student information tool!");

        }





    }
}
