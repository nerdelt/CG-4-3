using System;

namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            //tells user rules of raffle and asks for input
            Console.WriteLine("We are having a raffle. You can enter up to 30 contestants to choose from.");
            Console.WriteLine("Please press ENTER after each name. Once you are out of names, you can just press ENTER.");
            Console.WriteLine("Please enter the names of the contestants: ");

            //creates random to be choosen from later on
            Random namesPicker = new Random();

            //create and arrary with 30 contestant 
            string[] namesInput = new string[30];

            //I know we talked about not nesting this and adding a break if the user enters "",
            //but I tried this for like 10 hours and coudln't figure how not to nest. 
            //the program works, but I just can't figure out how to add a break when user presses "" 
            //without messing everything else up.
            for (int n = 0; n <= namesInput.Length; n++)
            {
                //adding to & printing array input
                namesInput[n] = Console.ReadLine();

                // picked a winner from the random, then writes who winner is 

                int winner = namesPicker.Next(0, namesInput[n].Length);

                // this is so the if line will work later....
                string w = Convert.ToString(namesInput[winner]);

                //if the user presses enter; I can't figure out how to add a break without 
                //causing the entire program not to work. 

                if (namesInput[n] == "")
                {
                    Console.WriteLine($"The winner is : {namesInput[winner]} !" + Environment.NewLine);

                    Console.WriteLine("Thank you for playing: " + Environment.NewLine);

                    //this is how I print out the losers, make sure its not winner and its not blank space 
                    foreach (string loser in namesInput)
                        if (loser != w && loser != "" && loser != null)
                        {
                            Console.WriteLine(loser);
                        }
                    Console.ReadLine();

                }
            }
        }
    }
}





          
       
    

