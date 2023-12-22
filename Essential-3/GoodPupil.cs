
namespace Essential_3
{
    class GoodPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil is studying. ");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil is reading..");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil is writing.");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil is relaxing.");
        }
    }
}
