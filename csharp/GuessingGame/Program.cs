// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Guess the secret number:");
// string? input=Console.ReadLine(); //"Converting null literal or possible null value to non-nullable type" error: so ? needed
// int secretNumber = 42;
//  if (input != null){
//     int guess = int.Parse(input); //"Possible null reference argument for parameter 's' in 'int int.Parse(string s)'" so if (input != null){ needed
//     //Console.WriteLine($"Your guess is: {guess}");
//     if (guess==secretNumber){
//     Console.WriteLine("You guessed it!");
//     }

// using System;

void GuessingGame(){
int attempts;
while (true)
{
// Prompt the user for the difficulty level and read their input
Console.WriteLine("Select difficulty level: Easy, Medium, Hard, Cheater");
string? difficulty = Console.ReadLine()?.ToLower();

// int attempts=4;

// Determine the number of attempts based on the difficulty level
//switch expression that operates on the difficulty variable. It evaluates the value of difficulty and returns a corresponding value based on the specified cases.
//=> is "goes to" operator, map case value to the corresponding result.
if (difficulty == "easy" || difficulty == "medium" || difficulty == "hard" || difficulty == "cheater")
{
 attempts = difficulty switch
{
    "easy" => 8, //"case value" => result.---if difficulty is "easy", the result will be 8 attempts.
    "medium" => 6,
    "hard" => 4,
    "cheater" => int.MaxValue, // Cheater level gives unlimited attempts
    //_ => 4 // Default to 4 attempts if the input is invalid.  _ is a discard pattern, used to match any value that doesn't fit any of the specified case labels.
};
break;
}
else
            {
                Console.WriteLine("Invalid difficulty level. Please enter 'easy', 'medium', 'hard', or 'cheater'.");
            }
}         
int currentAttemptNumber=1;

//int secretNumber = 42; //want to use random num:
int SecretNumber = new Random().Next(1, 100);
//Console.WriteLine(SecretNumber) //to check working

while (attempts>0){ 
Console.WriteLine("Guess the secret number");
Console.WriteLine($"Your guess ({currentAttemptNumber})>");
string? input=Console.ReadLine(); //"Converting null literal or possible null value to non-nullable type" error: so ? needed

 if (input != null){
    int guess = int.Parse(input); //"Possible null reference argument for parameter 's' in 'int int.Parse(string s)'" so if (input != null){ needed
    //Console.WriteLine($"Your guess is: {guess}");
    if (guess==SecretNumber){
        //isGuessed = true;
    Console.WriteLine("You guessed it!");
    break; // Exit loop if guessed correctly
    }
  else //if guess!=secretNumber:
  {
    attempts--; //attempts - 1 
    currentAttemptNumber++;
    if (attempts > 0) //still can guess
    {
        if (guess<SecretNumber)
        {
            Console.WriteLine("Your guess was too low.");
            }
        else
        { 
            Console.WriteLine("Your guess was too high."); 
            }
        Console.WriteLine("Please try again.");
        Console.WriteLine($"You have {attempts} attempts left.");
    }
    else// no more attempts left
    {
        if (guess<SecretNumber)
        {
            Console.WriteLine("Your guess was too low.");
            }
        else
        { 
            Console.WriteLine("Your guess was too high."); 
            }
    Console.WriteLine("Sorry, you've run out of attempts.The secret number was " + SecretNumber + ".");
    }
  }}
}

}



GuessingGame();