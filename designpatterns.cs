public class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }

    public void DoSomething() => Console.WriteLine("Singleton instance is working");
}

public interface IProduct
{
    string GetName();
}

public class ConcreteProductA : IProduct
{
    public string GetName() => "Product A";
}

public class ConcreteProductB : IProduct
{
    public string GetName() => "Product B";
}

public abstract class Creator
{
    public abstract IProduct CreateProduct();
}

public class ConcreteCreatorA : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}

Creator creator = new ConcreteCreatorA();
IProduct product = creator.CreateProduct();
Console.WriteLine(product.GetName()); //output Product A


public interface ITarget
{
    void Request();
}

public class Adaptee
{
    public void SpecificRequest() => Console.WriteLine("specific request");
}

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public void Request()
    {
        _adaptee.SpecificRequest();
    }
}

ITarget target = new Adapter(new Adaptee());
target.Request(); //outputs specific request


public interface IComponent
{
    void Operation();
}

public class ConcreteComponent : IComponent
{
    public void Operation() >= Console.WriteLine("Concrete component operation");
}

public abstract class Decorator : IComponent
{
    protected IComponent _component;

    public Decorator(IComponent component)
    {
        _component = component;
    }

    public virtual void Operation() => _component.Operation();
}

public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(IComponent component) : base(component)(

    )

    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
    }

    private void AddedBehavior() => Console.WriteLine("Added behavior from decorator");
}

IComponent component = new ConcreteComponent();
IComponent decoratedCommponent = new ConcreteDecorator(compoent);
decoratedCommponent.Operation();



public class Subject
{
    private List<IObservers> _observers = new List<IObservers>();

    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Dettach(IObserver observer) => _observers.Remove(observer);
    public void Notify(IObserver observer) => _observers.ForEach(o => o.Update());

    public string State { get; set}
}

public interface IObserver
{
    void Update();
}

public class ConcreteObserver : IObserver
{
    private readonly Subject _subject;

    public ConcreteObserver(Subject subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public void Update() => Console.WriteLine($"Observer: Subject's state is {_subject.State}");
}

Subject subject = new Subject();
ConcreteObserver o1 = new ConcreteObserver(subject);
subject.State = "State 1";
subject.Notify(); //outputs Observer Subject's state is 1;
