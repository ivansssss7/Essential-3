

namespace Essential_3
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil is studying. ");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil is reading.");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil is writing.");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil is relaxing.");
        }
    }
}
