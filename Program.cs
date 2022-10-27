// John Magpantay
// 10-20-22
// Restaurant picker, 
// I'm going to make a program that would let the user randomize the place they would want to eat, I would be using arrays because that's what i think is the 
// best
// Peer review by Daniel Decoito: The code works really well and meets the criteria for the assignment. However there are some issues with easy fixes. The prompt for incorrect input is incorrect. I really liked how you used the .Length to determine the max range for the random number genertor. 


Console.Clear();

            string choice;
            //pickAgain while loop
            string chooseAgain = "";

    
            while (chooseAgain != "no")
            {

                // I didnt have the user lower it last ttime
                Console.WriteLine("What are you feeling today? : Italian, American or Mexican food?");
                choice = Console.ReadLine();
                choice = choice.ToLower();

                // different catagories 
                string[] italian = { "Davids Pizza", "Eddies Pizza", "Angelina's", "De Vega Bros", "Express pizza", "Olive Garden", "Mezzos", "Dantes Pizza", "Romano's Grill", "Little Ceasars" };
                string[] american = { "BJ's", "AppleBees", "Denny's", "Chuck's", "Chili's", "Kosmos", "Cocoro", "Burger King", "BlackBear Diner", "HuckleBerry" };
                string[] mexican = { "Maria's Taqueria", "El Pollo Loco", "La Mesa", "Adalbertos", "Tacos El Rey", "Don Luis", "Chipotle", "Taco Bell", "Tacos Time", "Octavios" };

                //states that their input was invalid
                while (choice != "italian" && choice != "american" && choice != "mexican")
                {
                    Console.WriteLine("You entered in an invalid choice.");
                    Console.WriteLine("Please pick from italian, american, or mexican");
                    choice = Console.ReadLine();
                }
                //Would output what the user chose, and then it'll randomize it. 
                //Console.WriteLine("We're going to "+ choice);
                
                Random randomChoice = new Random();
                //randomizes choice, after they choose the category from the selection
                if (choice == "italian")
                {
                    int sCode = randomChoice.Next(0, italian.Length);
                    Console.WriteLine("You should go to " + italian[sCode] + " !");
                }
                else if (choice == "american")
                {
                    int sCode = randomChoice.Next(0, american.Length);
                    Console.WriteLine("You should go to " + american[sCode] + " !");
                }
                else if (choice == "mexican")
                {
                    int sCode = randomChoice.Next(0, mexican.Length);
                    Console.WriteLine("You should go to " + mexican[sCode] + " !");
                }
                Console.WriteLine("Would you like to pick again? yes or no");
                chooseAgain = Console.ReadLine();
                chooseAgain = chooseAgain.ToLower();

            }
            Console.WriteLine("So I guess we're eating home");

        //


//

