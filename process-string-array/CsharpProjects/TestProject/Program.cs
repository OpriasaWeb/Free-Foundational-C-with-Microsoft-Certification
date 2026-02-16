
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

for(int i = 0; i < myStrings.Length; i++)
{
  string myString = myStrings[i];
  periodLocation = myString.IndexOf(".");
  if(periodLocation != -1)
  {
    do
    {
      // Extract the substring from the beginning of the string to the period
      string sentence = myString.Substring(0, periodLocation);
      Console.WriteLine(sentence);

      // Remove the extracted sentence from the original string
      myString = myString.Remove(0, periodLocation + 1);

      // Remove any leading spaces
      myString = myString.TrimStart();

      periodLocation = myString.IndexOf(".");

    } while (periodLocation != -1);

    // Print any remaining text after the last period
    if(myString.Length > 0)
    {
      Console.WriteLine(myString);
    }
  } 
  else
  {
    Console.WriteLine(myString);
  }
}