namespace Essential_3;

class Program
{
    static void Main()
    {
        Pupil pupil1 = new ExcelentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();

        ClassRoom classroom = new ClassRoom(pupil1, pupil2, pupil3);

        classroom.ShowInfo();

        Console.ReadLine();
    }
}
