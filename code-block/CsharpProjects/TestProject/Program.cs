
// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

int total = 0;
bool found = false;

int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{

    total += number;

    if (number == 42)
    {
      found = true;
    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");



int firstInteger = 1;

if(firstInteger > 0)
{
    int secondInteger = 2;
    int sumOfTwoIntegers = firstInteger + secondInteger;
    Console.WriteLine($"The sum of the two integers is: {sumOfTwoIntegers}");
}

Console.WriteLine($"The first integer is: {firstInteger}");