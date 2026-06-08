namespace class0608
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1=new Student (60,70);
            Student s2 = new Student(75, 80);
            Student savg = s1 + s2;
            Console.WriteLine(savg.Mid + "" + savg.Final);
        }
    }
}
