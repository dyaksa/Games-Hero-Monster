﻿string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox")) 
{
    Console.WriteLine("What dies the fox say?");
}

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

var total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice : {roll1} + {roll2} + {roll3}");
Console.WriteLine(total);

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total +=2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if(total >= 15) 
{
    Console.WriteLine("You Win!");
}

if(total < 15){
    Console.WriteLine("Sorry, you lose!");
}
