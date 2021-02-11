using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            var Andrea = new Student { 
            Name = "Andrea",
            Address = "4900 Parkway Dr",
            GPA = 4.0m,
            Major = "Underwater Basket Weaving"
            };
            Andrea.Print();


            var Jonathan = new Student { 
                Name = "Jonathan",
                Address = "4900 Parkway Dr",
                GPA = 4.0m,
                Major = "Abovewater Basket Weaving"
            };

            Jonathan.Print();

            var Jada = new Student("Jada");
            //Jada.Name = "Jada";
            Jada.Address = "4900 Parkway Dr";
            Jada.GPA = 4.5m;
            Jada.Major = "Ceramics";
            Jada.Graduated = true;
            Jada.NewGPA(4.8m);
            Jada.Print();

            //var ucName = Jada.UppercaseName();
            //Console.WriteLine($"ucName: {ucName}");

            var Math = new Major { 
                MDescription = "Math",
                MinSAT = 1000
            };

            Math.Print();

            var Science = new Major {
                MDescription = "Science",
                MinSAT = 1200
            };

            Science.Print();
            
        }
    }
}
