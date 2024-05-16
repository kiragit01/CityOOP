using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOOP
{
    class Building
    {
        public string Title {  get; set; }
        public int Persons { get; set; }

        public Building() : this("Unidentified", 0) { }
        public Building(string title) : this(title, 0) { }
        public Building(int persons) : this("Unidentified", persons) { }
        public Building(string title, int persons) 
        {
            Title = title;
            Persons = persons;
        }
        public virtual void Print()
        {
            Console.WriteLine($"\nВ здании \"{Title}\" находиться {Persons} человек.");
        }
    }

    class Hospital : Building
    {
        public int Patients { get; set; }
        public Hospital() { }
        public Hospital(string title, int persons, int patients) 
            : base(title, persons)
        {
            Patients = patients;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"На данный момент в \"{Title}\" лечатся {Patients} пациентов.");
        }
    }

    class Residence : Building
    {
        public string President { get; set; }
        public Residence() { }
        public Residence(int persons, string president) 
            : base("Резиденция", persons)
        {
            President = president;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Недавно был назначен новый президент: {President}.");
        }
    }

    class Police : Building
    {
        public int Criminals { get; set; }
        public Police() { }
        public Police(string title, int persons, int criminals)
            : base(title, persons)
        {
            Criminals = criminals;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"В этом полицейском участке находиться {Criminals} очень опасных преступников.");
        }
    }
}
