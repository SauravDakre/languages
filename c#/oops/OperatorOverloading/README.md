# Operator Overloading

An operator declaration must satisfy the following rules:

- It includes both a public and a static modifier.
- A unary operator has one input parameter. A binary operator has two input parameters. In each case, at least one parameter must have type T or T? where T is the type that contains the operator declaration.

source: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading