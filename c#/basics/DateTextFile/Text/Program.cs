// See https://aka.ms/new-console-template for more information

using System.Text;

Console.WriteLine("Hello, World!");

var name = " harry sandu \t \n";
Console.WriteLine(name.Trim());
Console.WriteLine(name.Trim().ToUpper());

var index = name.Trim().IndexOf(" ");
Console.WriteLine($"fn: {name.Trim().Substring(0, index)}, ln: {name.Trim().Substring(index + 1)}");

Console.WriteLine($"fn: {name.Trim().Split(" ")[0]}, ln: {name.Trim().Split(" ")[1]}");

Console.WriteLine($"{name.Replace("sandu", "potter")}");

Console.WriteLine($"{string.IsNullOrEmpty(null)}, {string.IsNullOrEmpty("")}, {string.IsNullOrEmpty(" ")}");
Console.WriteLine($"{string.IsNullOrWhiteSpace(null)}, {string.IsNullOrWhiteSpace("")}, {string.IsNullOrWhiteSpace(" ")}"); // return true for all 3

Console.WriteLine(Convert.ToByte("20"));
Console.WriteLine(99.99f.ToString("C0"));


// string builder
var builder = new StringBuilder("string builder example");
builder
    .AppendLine()
    .Append('-', 10)
    .AppendLine()
    .Append("hello world")
    .AppendLine()
    .Append('-', 10);
Console.WriteLine(builder);

builder
    .Remove(0, 10)
    .Insert(0, new String('*', 10));
Console.WriteLine(builder);

Console.WriteLine(builder[15]);