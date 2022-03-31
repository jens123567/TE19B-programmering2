using System;

namespace intro
{
    class Person
    {
        public string Namn { get; set; }
        public string Mobil { get; set; }

        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
        }
    }

    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }

        public override void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"Årskurs: {Årskurs}, Program: {Program}");
        }
    }
    class Lärare : Person
    {
        public string Anställningsår { get; set; }
        public string Ämne { get; set; }

        public void VisaInfoLärare()
        {
            Console.WriteLine($"Namn: {Namn}, Mobil: {Mobil}");
            Console.WriteLine($"AnställningsÅr: {Anställningsår}, Ämne: {Ämne}");
        }
    }

    //create class test and create a method that takes a person as a parameter
    class Test : Person
    {
        //create constructor
        public Test(Person p)
        {
            Namn = p.Namn;
            Mobil = p.Mobil;
        }
        public void VisaInfoTest(Person p)
        {
            Console.WriteLine($"Namn: {p.Namn}, Mobil: {p.Mobil}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regestrera personer i skolan");

            /* while (true)
             {
                 // skapa en instans
                 Person person = new Person();

                 Console.WriteLine("Vad heter personen?");
                 string name = Console.ReadLine();
                 Console.WriteLine("Vad är mobilnummer?");
                 string mobil = Console.ReadLine();

                 Console.WriteLine("mata en till(j/n)?");
                 if (Console.ReadLine() != "j")
                     break;

             }*/
            while (true)
            {
                // skapa en instans
                Student student = new Student();
                //call class test   
                Test test = new Test(student);

                Console.WriteLine("Vad heter personen?");
                student.Namn = Console.ReadLine();
                Console.WriteLine("Vad är mobilnummer?");
                student.Mobil = Console.ReadLine();
                Console.WriteLine("Årskurs?");
                student.Årskurs = Console.ReadLine();
                Console.WriteLine("Program?");
                student.Program = Console.ReadLine();

                student.VisaInfo();

                Console.WriteLine("mata en till(j/n)?");
                if (Console.ReadLine() != "j")
                    break;

            }
        }
    }
}
