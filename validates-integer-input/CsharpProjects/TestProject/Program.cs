
string? readResult;
int parsedValue;
bool validInteger = false;
Console.WriteLine("Enter a valid integer: ");
readResult = Console.ReadLine();

do
{
  validInteger = int.TryParse(readResult, out parsedValue);

  if (validInteger)
  {
    if(parsedValue >= 5 && parsedValue <= 10)
    {
      Console.WriteLine($"Your input value ({parsedValue}) has been accepted.");
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter an integer value between 5 and 10.");
      Console.WriteLine("Enter a valid integer: ");
      readResult = Console.ReadLine();
      validInteger = false; // Keep looping for out-of-range values
    }
  }
  else
  {
    Console.WriteLine("Invalid input. Please enter a valid integer.\n");

    Console.WriteLine("Enter a valid integer: ");
  
    readResult = Console.ReadLine();

  }
} while(validInteger == false);



  // - Your solution must use a Console.ReadLine() statement to obtain input from the user.
  // - Your solution must ensure that the input is a valid representation of an integer.
  // - If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
  // - Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.











// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");

// do
// {
//   readResult = Console.ReadLine();
//   if(readResult != null)
//   {
//     if(readResult.Length >= 3)
//     {
//       validEntry = true;
//     }
//     else
//     {
//       Console.WriteLine("Invalid input. Please enter a string containing at least three characters.");
//     }
//   }
// } while (validEntry == false);