using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial
{
    class Major
    {
        private static int NextId { get; set; } = 1;
        public int Id { get; set; }

        public string MDescription { get; set; }
        public int MinSAT {get; set;}

        public void Print() {
            Console.WriteLine($"ID: {Id} | Major: {MDescription} | MinSAT: {MinSAT}");
        }

        public Major()
        {
            Id = NextId;
            NextId = NextId + 1;
        }
    }
}
