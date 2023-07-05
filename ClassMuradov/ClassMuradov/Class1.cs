using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMuradov
{
    //Мурадов И.М.
    public class Building
    {
        public string Address { get; set; }

        public string Description { get; set; }
        public List<Apartment> Apartments = new List<Apartment>();

        public Building(string address, string description)
        {
            Address = address;
            Description = description;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Строение Адрес {Address} Описание {Description}");
        }
            
    }

    public class Apartment: IComparable<Apartment>
    {
        public int Number { get; set; }

        public string Owner { get; set; }

        public Apartment(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        public void Show()
        {
            Console.WriteLine ($"Номер квартиры: {Number}\nВладелец: {Owner}");
        }
        public int CompareTo(Apartment other)
        {
            if (this.Number < other.Number) return -1;
            if (this.Number > other.Number) return 1;
            else return 0;
        }    
    }
}
