
/*
Role playing game battle challenge
In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys". Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score. Once either character's health reaches zero, they lose the game.

In this challenge, we boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, they generate a random value that is subtracted from the monster's health. If the monster's health is greater than zero, they take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle resumes.

*/
int hero = 10;
int monster = 10;
Random dice = new Random();

// Generate speeds
int heroSpeed = dice.Next(1, 21);
int monsterSpeed = dice.Next(1, 21);

Console.WriteLine($"Hero Speed: {heroSpeed}");
Console.WriteLine($"Monster Speed: {monsterSpeed}");
Console.WriteLine(heroSpeed >= monsterSpeed ? "Hero attacks first!\n" : "Monster attacks first!\n");

bool heroAttacksFirst = heroSpeed >= monsterSpeed;

do
{
    if (heroAttacksFirst)
    {
        // Hero attacks first
        int roll = dice.Next(1, 11);
        monster -= roll;
        if(monster < 0) monster = 0;
        Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");
        if (monster <= 0) continue;
        
        // Monster attacks second
        roll = dice.Next(1, 11);
        hero -= roll;
        if(hero < 0) hero = 0;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
    }
    else
    {
        // Monster attacks first
        int roll = dice.Next(1, 11);
        hero -= roll;
        if (hero < 0) hero = 0;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
        if (hero <= 0) continue;
        
        // Hero attacks second
        roll = dice.Next(1, 11);
        monster -= roll;
        if (monster < 0) monster = 0;
        Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");
    }
    
} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

















/*
Write a do-while statement to break when a certain random number is generated
Let's write code that will keep generating random numbers between 1 and 10 until we generate the number 7. It could take just one iteration to get a 7, or it could take dozens of iterations.
*/


// Random random = new Random();

// int current = random.Next(1, 11);

// int current = 0;

// do
// {
//     current = random.Next(1, 11);
    
//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);


// Write a while statement that iterates only while a random number is greater than some value
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");