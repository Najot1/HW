Fox fennec = new Fennec() { Shape = "Small" };
Fox arctic = new Arctic() { Shape = "Big" };

PrintFruit(apple);
PrintFruit(banana);

void BuyFox(Fox fox)
{
    if (fox == null) throw new ArgumentException();

    Console.WriteLine(fruit.Shape);
    Console.WriteLine(fruit.Color);
    Console.WriteLine(fruit.Name);
}
// Абстракция - возможность создать какую нибудь идею в виде абстрактных классов которые
 //содержат в себе методы которых могут унаследовать дочерние классы.
public abstract class Fox
{
    public abstract string Color { get; }
    public abstract string Shape { get; set; }
    public abstract string WhereLives { get; }
}
// Наследование - возможность создания новых абстракций на основе уже существующих абстракций.
// Полиморфизм - возможность реализации свойств или методов наследованных от абстракций.
public sealed class Fennec : Fox
{
    public override string Shape { get; set; }
    public override string Color => "Yellow";
    public override string WhereLives => "Dust";
}


// Инкапсуляция - возможность объединение классов и методов и их скрытие от внешного воздействия .
public sealed class Arctic : Fox
{
    private string? _shape;
    public override string Color
    {
        get => _shape ?? string.Empty;
        set => _shape = value;
    }
    public override string Color => "White";
    public override string WhereLives => "Arctica";
}

// Exeption
int a = Console.ReadLine();
int b = Console.ReadLine();
if (a is not {Length: > 0})
    throw new ArgumentNullException(nameof(a));
if (b is not {Length: > 0})
    throw new ArgumentNullException(nameof(b));

try
{
    a + b
}
catch(Exception ex)
{
    if (a && b is string)
    throw ex;
}
finally
{
    Console.WriteLine(a + b)
}

class HwExection : Exeption
{
    public MyCustomException() { }
    public MyCustomException(string message) : base(message) { }
    public MyCustomException(string message, System.Exception inner) : base(message, inner) { }
}

