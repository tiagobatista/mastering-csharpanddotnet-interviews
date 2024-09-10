
delegate void PrintMesage(string message); //delegate declaration

void PrintToConsole(string message)
{
    Console.WriteLine(message);
}

//use the delegate
PrintMesage printDelegate = PrintToConsole;
printDelegate("Hello world!"); // output Hello world!

var numbers = new List<int> { 1, 2, 3, 4, 5 };
var query = numbers.Where(n => n > 3); //query defined but not executed

foreach (var number in query)
{
    PrintToConsole.WriteLine(number); //ouput 4, 5
}
