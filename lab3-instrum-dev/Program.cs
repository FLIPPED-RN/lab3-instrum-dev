Printer printer = new Printer(new LaserPrintStrategy());
printer.Print("дарова");

printer.SetStrategy(new InkjetPrintStrategy());
printer.Print("фото.пнг");

printer.SetStrategy(new ThreeDPrintStrategy());
printer.Print("модель.stl");

//-------------------------------------------
interface IPrintStrategy
{
    void Print(string message);
}

class LaserPrintStrategy : IPrintStrategy
{
    public void Print(string message)
    {
        Console.WriteLine($"лазерная печать: {message}");
    }
}

class InkjetPrintStrategy : IPrintStrategy
{
    public void Print(string message)
    {
        Console.WriteLine($"струйная печать: {message}");
    }
}

class ThreeDPrintStrategy : IPrintStrategy
{
    public void Print(string message)
    {
        Console.WriteLine($"3D печать: {message}");
    }
}

class Printer
{
    private IPrintStrategy _printStrategy;
    public Printer(IPrintStrategy printStrategy)
    {
        _printStrategy = printStrategy;
    }

    public void SetStrategy(IPrintStrategy printStrategy)
    {
        _printStrategy = printStrategy;
    }
    public void Print(string message)
    {
        _printStrategy.Print(message);
    }
}