
//Encapsulation

class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set ( name = value; )
    }
}

//inheritance
class Animal
{
    public virtual void Eat() { Console.WriteLine("Eating...");}
}

class Dog : Animal
{

    public override void Eat() { Console.WriteLine("Dog Eating...");}
}

Animal a = new Dog();
a.Eat();

abstract class Vehicle
{
    public abstract void Move();
}

class Car : Vehicle{
    public override void Move()
    {
        Console.WriteLine("The car is moving").
    }
}

class PointClass //reference type
{
    public int X;
    public int Y;
}

struct PointStruct //value type
{
    public int X;
    public int Y;
}

PointClass pc1 = new PointClass() { X = 10, Y =20};
PointClass pc2 = pc1;
pc2.X = 30;

Console.WriteLine(pc1.X); //output 30 (reference type)

PointStruct ps1 = new PointStruct() { X = 10, Y = 20};
PointStruct ps2 = ps1;
ps2.X = 30;
Console.WriteLine(ps1.X); //output 10 (value type)

