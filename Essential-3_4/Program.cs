
namespace Essential_3_4;

class Program
{
    static void Main()
    {
        Printer printer = new Printer();
        ColorPrinter colorPrinter = new ColorPrinter();

        printer.Print("This is a message from the Printer class");
        colorPrinter.Print("This is a message from the ColorPrinter class");
    }
}
