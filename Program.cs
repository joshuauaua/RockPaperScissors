// See https://aka.ms/new-console-template for more information

//Create a score int
int score = 0;

//Create a while loop to keep the game going
bool gameOn = true;

while (gameOn)
{
    //Ask user for rock, paper, scissors
    Console.WriteLine("Rock, paper, scissors?");
    string answer = Console.ReadLine();
    string answerUpper = answer.ToUpper();
    
    //Create a random number generator which corresponds to rock, paper, scissors
    string choice;
    Random randomGenerator = new Random();
    int random = randomGenerator.Next(1, 4);
    if (random == 1)
    {
        choice = "Rock";
    }
    else if (random == 2)
    {
        choice = "Paper";
    }
    else
    {
        choice = "Scissors";
    }

    Console.WriteLine($"Computer plays {choice}");

    //Enter mechanics here using switch statement
    switch (answerUpper)
    {
        case "ROCK" when choice == "Rock":
            Console.WriteLine("You both played Rock. It's a draw");
            break;
        case "ROCK" when choice == "Paper":
            Console.WriteLine("Rock loses to paper. You lose a point");
            score--;
            break;
        case "ROCK" when choice == "Scissors":
            Console.WriteLine("Rock beats scissors. You win a point");
            score++;
            break;
        case "PAPER" when choice == "Rock":
            Console.WriteLine("Paper beats Rock. You win a point");
            score++;
            break;
        case "PAPER" when choice == "Scissors":
            Console.WriteLine("Paper loses to scissors. You lose a point");
            score--;
            break;
        case "PAPER" when choice == "Paper":
            Console.WriteLine("You both played Paper. It's a draw.");
            break;
        case "SCISSORS" when choice == "Rock":
            Console.WriteLine("Scissors loses to rock. You lose a point");
            score--;
            break;
        case "SCISSORS" when choice == "Paper":
            Console.WriteLine("Scissors beats paper. You win a point");
            score++;
            break;
        case "SCISSORS" when choice == "Scissors":
            Console.WriteLine("You both play scissors. It's a draw");
            break;
        default :
            Console.WriteLine("Wrong input. Try again.");
            break;
    }

    Console.WriteLine($"Your score is {score}");

    while (score < 0)
    {
        Console.WriteLine("Game over. Play again? Y/N");
        string playAgain = Console.ReadLine();
        if (playAgain.ToUpper() == "N")
        {
            gameOn = false;
        }
        else if (playAgain.ToUpper() == "Y")
        {
            score = 0;
        }
        else
        {
            Console.WriteLine("Incorrect answer. Play again? Y/N");
        }
        
    }
    

}




