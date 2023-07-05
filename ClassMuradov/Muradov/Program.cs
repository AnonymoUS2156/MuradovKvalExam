using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMuradov;

namespace Muradov
{
    internal class Program
    {
        //Мурадов И.М.
        static void Main(string[] args)
        {
            Building bl = new Building("г. Москва", "Многоэтажный дом");
            bl.ShowAll();
            Apartment a1 = new Apartment(1, "Иванов И.А.");
            bl.Apartments.Add(a1);

            Apartment a4 = new Apartment(7, "Мурадов И.М.");
            bl.Apartments.Add(a4);
            Apartment a2 = new Apartment(9, "Абдурахимов Б.А.");
            bl.Apartments.Add(a2);
            Apartment a3 = new Apartment(5, "Залевский А.А.");
            bl.Apartments.Add(a3);

            bl.Apartments.Sort();
            foreach (Apartment a in bl.Apartments)
            {
                a.Show();
            }

            Console.ReadKey();
        }

    }
}
