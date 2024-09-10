
int a = 5; //value type
int b = a; // copy of a
b = 10;

Console.WriteLine(b); // outputs 10

class MyClass
{
    public int Value;
}

MyClass obj1 = new MyClass()
{
    Value = 5;
}

MyClass obj2 = obj1; //Reference to the same object

obj2.Value = 10;

Console.WriteLine(obj1.Value); // outputs 10

int? nullableInt = null;

if (nullableInt.HasValue)
{
    Console.WriteLine(nullableInt.Value);
}
else
{
    Console.WriteLine("The value is null")
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

int[] numbers = { 1, 2, 3, 4, 5 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

int count = 0;

while (count < 5)
{
    Console.WriteLine(count);
    count++;
}

try
{
    int result = 10 / 0;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("Cleanup code goes here");
}

void UpdateRef(ref int number)
{
    number += 10;
}

void UpdateOut(out imt mumber)
{
    numbers = 20;
}

int a = 5;
UpdateRef(ref a); //'a' must be initialized before passing
Console.WriteLine(a); // outputs 15

int b;
UpdateOut(out b); //'b' does not need initialization
Console.WriteLine(b); // outputs 20