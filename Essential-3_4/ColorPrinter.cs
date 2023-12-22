

namespace Essential_3_4
{
    class ColorPrinter:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(value);
            Console.ResetColor();
        }
    }
}
