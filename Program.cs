using System;

namespace CS_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuInst = new Menu();

            menuInst.Intro();
            
        }
    }

    class Menu
    {

        public void Intro()
        {
            Console.WriteLine("Hello! Please enter the application name you would" +
            " like to use. \nYour choices are below. \n\nName Greeting | Rectagle Area" +
             " Calculator | Gas Mileage Calculator | Alice Search");

            string menuSelect = Console.ReadLine().ToLower();
            
            if (menuSelect == "name greeting")
            {
                Name();
            }
            else if (menuSelect == "rectangle area calculator")
            {
                RectArea();
            }
            else if (menuSelect == "gas mileage calculator")
            {
                GasMiles();
            }
            else if (menuSelect == "alice search")
            {
                Alice();
            }
            else if (menuSelect == "quit")
            {
                Quit();
            }
            else
            {
                Err();
            }
        }

        public void Name()
        {
            Console.WriteLine("Please enter your name.\n");
            string name = Console.ReadLine();
            Console.WriteLine("\nHello " + name + "!\n");

            Intro();
        }

        public void RectArea()
        {
            Console.WriteLine("\nWelcome to the Rectangle Area Calculaotr.\n" +
            "\nPlease enter the width of the rectangle in inches.");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPlease enter the length of the rectangle in inches.");
            double length = Convert.ToDouble(Console.ReadLine());

            double result = length * width;
            Console.WriteLine("\nRectangle Area: " + result + " inches.\n");

            Intro();
        }

        public void GasMiles()
        {
            Console.WriteLine("\nWelcome to the MPG Calculator.\n" +
            "\nPlease enter the amount of miles driven.");
            float miles = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nPlease enter the gallons of gas burned.");
            float gallons = Convert.ToSingle(Console.ReadLine());

            float result = miles / gallons;
            Console.WriteLine("\nMPG: " + result + ".\n");

            Intro();
        }

        public void Alice()
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the" +
            " book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures " +
            "or conversation?'";

            Console.WriteLine("\nPlease enter a term from the first sentence of Alice in Wonderland and I'll see " +
            "if it is truely there!");
            string term = Console.ReadLine().ToLower();

            if (alice.ToLower().Contains(term))
            {
                Console.WriteLine("\nYes this term exists in the first sentence.\n");
            }
            else
            {
                Console.WriteLine("\nIm sorry, this term does not exist in the first sentence.\n");
            }

            Intro();
        }
        
        public void Quit()
        {
            Console.WriteLine("\nThank you for using our app. Goodbye!");
            return;
        }

        public void Err()
        {
            Console.WriteLine("\nI'm sorry, this option is not valid. \nPlease try typing again.\n");
            Intro();

        }
    
    }
}
