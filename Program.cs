//ari_conway
//Do-While Statements

int i = 0;
do //keep doing/ do/ repeat...
{
    //Console.WriteLine($"Iteration {++i}: Hello DoWhile!");
    Console.WriteLine($"Iteration {++i}: Hello DoWhile!");
    //break;

} while (false); //...as long as

Console.WriteLine($"This loop ran {i} times");

//repeat the play

char ans;
do
{
    Console.WriteLine("Please enter your name: ");
    string player1 = (Console.ReadLine());

    Console.WriteLine($"{player1}, enter your secret word: "); //a num between 1 and 20
    string secretWord = Console.ReadLine();

    Console.Clear();

    Console.WriteLine("Player 2, please enter your name: ");
    string player2 = Console.ReadLine();

    Console.WriteLine($"{player2}, guess the secret word!"); //a num between 1 and 20
    string guess = Console.ReadLine();

    Console.WriteLine(guess.Equals(secretWord) ? "Congrats! You won!" : "Sorry, you lost!");

    Console.WriteLine("Would you like to play again? (Y/N)");
    ans = Convert.ToChar(Console.ReadLine());
} while (ans == 'y'); //as long as the answer is yes...



//if (guess.Equals(secretWord)) //(guess == secretWord) 
//{
//    Console.WriteLine("Congrats! You won!");
//}
//else
//{
//    Console.WriteLine("Sorry, you lost!");
//}

//input validation

byte m;
do //keep prompting user for a month between 1 and 12
{
    Console.WriteLine("Please enter a month (1-12)");
    m = Convert.ToByte(Console.ReadLine());
} while (m<1 || m>12); //as long as there is an invalid input

bool validMonth = m >= 1 && m <= 12;
bool invalidMonth = !validMonth;

byte counter = 1;
do
{
    counter++;

} while (counter <= 5);

//0 - n times counted = N + 1 times
//1 - n times counted = N times