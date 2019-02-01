using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject
{
    class Program
    {
        static void Main(string[] args) //creating instences of students
        {    
            var greg = new Student("Greg", "Doud", 3.7);
            Console.WriteLine(greg.Print());
            Console.WriteLine(greg.Print("This is a new change."));

            var chris = new Student();
            chris.FirstName = "Chris";
            chris.LastName = "Caudill";
            chris.GPA = 3.5;
            chris.SAT = 1250;
            chris.Phone = "555-555-5555";
            Console.WriteLine(chris.Print());
            var chrisfullname = chris.FullName();

            var ken = new Student();
            ken.FirstName = "Ken";
            ken.LastName = "Doud";
            ken.GPA = 3.6;
            ken.SAT = 1300;
            ken.Phone = "555-555-5555";
            Console.WriteLine(ken.Print());
            var kenfullname = ken.FullName();

            var kellan = new Student();
            kellan.FirstName = "Kellan";
            kellan.LastName = "Arick";
            kellan.GPA = 2.5;
            kellan.SAT = 1150;
            kellan.Phone = "555-555-5555";
            Console.WriteLine(kellan.Print());
            var kellanfullname = kellan.FullName();

            var irena = new Student();
            irena.FirstName = "Irena";
            irena.LastName = "Futoransky";
            irena.GPA = 3.6;
            irena.SAT = 1375;
            irena.Phone = "555-555-5555";
            Console.WriteLine(irena.Print());
            var irenafullname = irena.FullName();

            var sammy = new Student();
            sammy.FirstName = "Sammy";
            sammy.LastName = "Amare";
            sammy.GPA = 3.3;
            sammy.SAT = 1400;
            sammy.Phone = "555-555-5555";
            Console.WriteLine(sammy.Print());
            var sammyfullname = sammy.FullName();

            var ben = new Student();
            ben.FirstName = "Ben";
            ben.LastName = "Peterson";
            ben.GPA = 3.0;
            ben.SAT = 1200;
            ben.Phone = "555-555-5555";
            Console.WriteLine(ben.Print());
            var benfullname = ben.FullName();

            var seth = new Student();
            seth.FirstName = "Seth";
            seth.LastName = "Philips";
            seth.GPA = 2.7;
            seth.SAT = 1120;
            seth.Phone = "555-555-5555";
            Console.WriteLine(seth.Print());
            var seethfullname = seth.FullName();
        }
    }
}
