using System;
using System.ComponentModel;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {



        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        static void ExamineQueue()
        {
            Queue<string> items = new Queue<string>();

            while (true)
            {
                Console.WriteLine("Chose one option: ");
                Console.WriteLine("1.Enqueue");
                Console.WriteLine("2.Dequeue");
                Console.WriteLine("3.Exit");

                if (int.TryParse(Console.ReadLine(), out int choice)) ;//i return the string to the int and,take it with out and put it in choice
                switch (choice)
                {
                    case 1:

                        Enqueue(items);
                        break;
                    case 2:
                        Dequeue(items);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:

                        Console.WriteLine(" you add the wrong option! Enter between 1,2,3 options. ");
                        break;
                }



            }
            static void Enqueue(Queue<string> items)

            {

                Console.WriteLine("Enter your name: ");
                string customer = Console.ReadLine();
                items.Enqueue(customer);

                Console.WriteLine($"{customer} added to the list.");


            }

            static void Dequeue(Queue<string> items)

            {
                if (items.Count == 0)// we check if the list is empty.
                {
                    Console.WriteLine("no name is in the list");
                }

                string customer2 = items.Dequeue();
                Console.WriteLine($"{customer2}is dequeued from the queue");

            }


            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        static void ExamineStack()

        {
            Stack<string> mycutomer = new stack<string>();

            while (true)
            {
                Console.WriteLine("Chose one option: ");
                Console.WriteLine("1.push");
                Console.WriteLine("2.pop");
                Console.WriteLine("3.Exit");

                if (int.TryParse(Console.ReadLine(), out int choice)) ;//i return the string to the int and,take it with out and put it in choice
                switch (choice)
                {
                    case 1:

                        push(mycutomer);
                        break;
                    case 2:
                        pop(mycutomer);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:

                        Console.WriteLine(" you add the wrong option! Enter between 1,2,3 options. ");
                        break;
                }



            }
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        private static void push(Stack<string> mycutomer)
        {
            Console.WriteLine("Add your name:");
            string cusomer1 = Console.ReadLine();

            mycutomer.Push(cusomer1);
            Console.WriteLine($" {cusomer1} added to the list)");


            foreach (string customer in mycutomer)
            { Console.WriteLine(customer); }


        }

        private static void pop(Stack<string> mycutomer)
        {
            Console.WriteLine("add the name :");
            string customer2 = Console.ReadLine();

            while (mycutomer.Count != 0)
            {
                mycutomer.Push(customer2.pop())
        //    }

        static void CheckParanthesis()
        {
                    static bool IfParanthesisAreCorrect(string input);
                    {
                        stack<char> parantes = new stack<char>();
                        foreach (char item in parantes )
                        {
                            if (item =='('|| item=='['|| item == '{')
                            {
                                parantes.Push(item);
                            }
                            else if (item==')'|| item==']'|| item =='}')
                            {
                                parantes.
                            }
                        }
                    }
                   
                    
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }



       