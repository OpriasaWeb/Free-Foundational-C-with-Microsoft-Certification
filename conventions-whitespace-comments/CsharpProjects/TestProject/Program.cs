string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


// Multiple line of comments
/*

string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


/*

Code readability challenge
In this challenge, you'll use the techniques you learned in this module to improve the readability of a code sample. 
You are provided with a code sample that is poorly styled and commented. 
Your goal is to update the code using style guidelines for variable names, code comments, and whitespace to improve code readability.

*/

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int x = 0;

foreach (char i in message) { 
  if (i == 'o') { 
    x++; 
  } 
}

// convert it back to a string
string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");