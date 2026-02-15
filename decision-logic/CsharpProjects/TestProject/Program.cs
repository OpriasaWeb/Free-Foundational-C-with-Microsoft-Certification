
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));


// Logical negations: these two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

/*
Inequality operator versus logical negation
The inequality operator != includes a ! character, but should not be confused with logical negation. The inequality operator returns true if its operands aren't equal, and returns false if the operands are equal. For the operands of the built-in types, the expression x != y produces the same result as the expression !(x == y) (an example of logical negation).

*/

int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

// *NOTE: Conditional operator - <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");