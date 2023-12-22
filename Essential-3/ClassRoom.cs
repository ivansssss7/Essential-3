

namespace Essential_3
{
    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3 = null, Pupil pupil4 = null)
        {
            pupils = new Pupil[4];
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Classroom information:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Pupil {i + 1}:");
                if (pupils[i] != null)
                {
                    pupils[i].Study();
                    pupils[i].Read();
                    pupils[i].Write();
                    pupils[i].Relax();
                }
                else
                {
                    Console.WriteLine("No pupil in this position.");
                }
                Console.WriteLine();
            }
        }
    }
}
