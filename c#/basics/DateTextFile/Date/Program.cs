// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// date time
DateTime dateTime = new DateTime(2020, 1,30);
Console.WriteLine(dateTime);

var now = DateTime.Now;
Console.WriteLine(now);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Today);

// DateTime is immutable
var tomorrow = now.AddDays(1);
Console.WriteLine( tomorrow);

var yesterday = now.AddDays(-1);
Console.WriteLine(yesterday);

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());

Console.WriteLine(now.ToString());
Console.WriteLine(now.ToString("yyyy-MM-dd hh-mm"));

// timespan
Console.WriteLine("---- timespan ----");
var dt1 = DateTime.Now;
var dt2 = dt1.AddMinutes(5);
var ts1 = dt2 - dt1; // returns timespan
Console.WriteLine(ts1);

var ts2 = new TimeSpan(1, 0, 0);
var ts5 = TimeSpan.FromHours(1); ; //ts2 & ts5 are same

// TimeSpan is immutable
// add subtract
var ts3 = ts2.Add(ts1);
Console.WriteLine(ts3.TotalMinutes);
Console.WriteLine(ts2.Subtract(ts1).TotalMinutes);

// string
Console.WriteLine(ts1.ToString());

// parse
Console.WriteLine(TimeSpan.Parse("01:59:59"));