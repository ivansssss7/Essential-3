

namespace Essential_3_3
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматі");
        }
    }
}
