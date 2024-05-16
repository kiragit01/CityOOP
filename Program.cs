using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityOOP
{
    class Program
    {
        static void Main()
        {
            Building hospital = new Hospital
                (
                title: "Скорая помощь", 
                persons: 500, 
                patients: 350
                );
            hospital.Print();

            Building residence = new Residence
                (
                persons: 200, 
                president: "Вася Пупкин"
                );
            residence.Print();

            Building police = new Police
                (
                title: "Защита мира",
                persons: 120,
                criminals: 30
                );
            police.Print();

            Console.ReadKey();
        }
    }
}
