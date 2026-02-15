# code-block

Exercise - Code blocks and variable scope
A code block is one or more C# statements that define an execution path. The statements outside of a code block affect when, if, and how often that block of code is executed at run time. The boundaries of a code block are typically defined by squiggly braces, {}.

In addition to their effect on execution path, code blocks can also affect the scope of your variables. The code samples that you examine during this exercise will help you understand the relationship between code blocks and variable scope.

Code blocks impact the scope of a variable declaration
Variable scope refers to a variable's visibility to the other code in your application. A locally scoped variable is only accessible inside of the code block in which it's defined. If you attempt to access the variable outside of the code block, you'll get a compiler error.

The remainder of this unit explores the relationship between code blocks and variable scope.