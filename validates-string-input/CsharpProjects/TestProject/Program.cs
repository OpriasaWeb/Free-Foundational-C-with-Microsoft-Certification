


/*

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

- Your solution must use a Console.ReadLine() statement to obtain input from the user.
- Your solution must ensure that the value entered matches one of the three role options.
- Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
- Your solution should use the ToLower() method on the input value to ignore case.
- If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
- Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

*/

using System.IO.Pipelines;

string? readResult;
bool validString = false;
bool validRole = false;
Console.WriteLine("Enter a valid role name (Administrator, Manager, or User): ");
readResult = Console.ReadLine();

do
{
  if(readResult != null && (readResult.Trim().ToLower() == "administrator" || readResult.Trim().ToLower() == "manager" || readResult.Trim().ToLower() == "user"))
  {
    validString = true;
    validRole = true;

    Console.WriteLine($"Your input value ({readResult.Trim()}) has been accepted.");
  }
  else
  {
    Console.WriteLine($"The role name that you entered, \"{readResult?.Trim()}\" is not valid. Enter your role name (Administrator, Manager, or User): ");
    readResult = Console.ReadLine();
  }
} while (!validString || !validRole);