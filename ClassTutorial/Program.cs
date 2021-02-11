using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            var Andrea = new Student();
            Andrea.Name = "Andrea";
            Andrea.Address = "4900 Parkway Dr";
            Andrea.GPA = 4.0m;
            Andrea.Major = "Underwater Basket Weaving";
            Console.WriteLine($"Name: {Andrea.Name}, GPA: {Andrea.GPA}, Major: {Andrea.Major}");

            var Jonathan = new Student();
            Jonathan.Name = "Jonathan";
            Jonathan.Address = "4900 Parkway Dr";
            Jonathan.GPA = 4.0m;
            Jonathan.Major = "Abovewater Basket Weaving";
            Console.WriteLine($"Name: {Jonathan.Name}, GPA: {Jonathan.GPA}, Major: {Jonathan.Major}");
        }
    }
}
