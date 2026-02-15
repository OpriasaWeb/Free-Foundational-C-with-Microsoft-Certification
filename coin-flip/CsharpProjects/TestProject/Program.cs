using System;

// Generates a random number between 1 and 2 to simulate a coin flip
Random random = new Random();
int randomFlip = random.Next(1, 3); // generates between 1 and 2

Console.WriteLine($"Coin flip result: {(randomFlip == 1 ? "Heads" : "Tails")}");