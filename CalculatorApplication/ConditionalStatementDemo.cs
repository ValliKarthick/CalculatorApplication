using System;

namespace CalculatorApplication
{
    public class ConditionalStatementDemo
    {
        public void CheckForLoop()
        {
            //for(Declaring;condition;inc/dec)
            for (int number = 1; number <= 10; number++)
            {
                Console.WriteLine(number);
            }
            CheckDoWhileLoop();
        }

        public void CheckWhileLoop()
        {
            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        public void CheckDoWhileLoop()
        {
            int number = 5;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number > 10);
        }

        public void CheckForEachLoop()
        {
            int[] numbers = { 1, 2, 3, 4 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void CheckIfElse()
        {
            string menuOption = "Transfer";
            string beneficiary = "added";

            if (menuOption == "Transfer")
            {
                if (beneficiary == "added")
                    Console.WriteLine("Transfer can be done");
                else
                    Console.WriteLine("Add Beneficiary to transfer");
            }
            else if (menuOption == "Change contact")
            {
                Console.WriteLine("Contact changed !");
            }
            else
            {
                Console.WriteLine("Enter a Valid Menu option");
            }
        }

        public void CheckSwitchCase()
        {
            string menuOption = "Transfer";
            string beneficiary = "added";
            switch (menuOption)
            {
                case "Transfer":
                    if (beneficiary == "added")
                        Console.WriteLine("Transfer can be done");
                    else
                        Console.WriteLine("Add Beneficiary to transfer");
                    break;
                case "Change contact":
                    Console.WriteLine("Contact changed !");
                    break;
                default:
                    Console.WriteLine("Enter a Valid Menu option");
                    break;
            }
        }
        public string getUserMessage()
        {
            string messageFromUser;
            Console.WriteLine("Enter Message");
            messageFromUser = Console.ReadLine();
            return messageFromUser;

        }
    }
}
