namespace Essential_3_3;


class Progra
{
    static void Main()
    {
        Console.WriteLine("Введіть номер ключа доступу (pro або exp):");
        string key = Console.ReadLine();

        DocumentWorker worker;

        if (key == "pro")
        {
            worker = new ProDocumentWorker();
        }
        else if (key == "exp")
        {
            worker = new ExpertDocumentWorker();
        }
        else
        {
            worker = new DocumentWorker();
        }

        // Виклик методів відповідно до створеного екземпляра
        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();

        Console.ReadKey();
    }
}