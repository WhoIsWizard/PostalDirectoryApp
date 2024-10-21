// File: PostalDirectoryEntry.cs
using System;

namespace PostalDirectoryApp
{
    public class PostalDirectoryEntry : Location, IComparable<PostalDirectoryEntry>
    {
        // Приватні змінні
        private string postalCode;
        private bool isSafeLocality;
        private int population;
        private double area;

        // Геттери та сеттери
        public string Continent
        {
            get { return continent; }
            set { continent = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string District
        {
            get { return district; }
            set { district = value; }
        }

        public string Locality
        {
            get { return locality; }
            set { locality = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public bool IsSafeLocality
        {
            get { return isSafeLocality; }
            set { isSafeLocality = value; }
        }

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        // Конструктор без параметрів
        public PostalDirectoryEntry() : this("Unknown", "Unknown", "Unknown", "Unknown", "Unknown", "00000", false, 0, 0.0)
        {
        }

        // Конструктор з параметрами (делегування конструктора)
        public PostalDirectoryEntry(string continent, string country, string region,
                                    string district, string locality, string postalCode,
                                    bool isSafeLocality, int population, double area)
        {
            this.continent = continent;
            this.country = country;
            this.region = region;
            this.district = district;
            this.locality = locality;
            this.postalCode = postalCode;
            this.isSafeLocality = isSafeLocality;
            this.population = population;
            this.area = area;
        }

        // Реалізація абстрактного методу
        public override string GetFullLocation()
        {
            return $"{locality}, {district}, {region}, {country}, {continent}";
        }

        // Реалізація інтерфейсу IComparable
        public int CompareTo(PostalDirectoryEntry other)
        {
            return this.locality.CompareTo(other.locality);
        }

        // Перевантаження методу ToString
        public override string ToString()
        {
            return $"Континент: {continent}, Країна: {country}, Область: {region}, " +
                   $"Район: {district}, Населений пункт: {locality}, Поштовий індекс: {postalCode}, " +
                   $"Безпечний Н/П: {(isSafeLocality ? "Так" : "Ні")}, Населення: {population}, Площа: {area} км²";
        }

        // Статичний поліморфізм (перевантаження методу)
        public void DisplayInfo()
        {
            Console.WriteLine(ToString());
        }

        public void DisplayInfo(bool showArea)
        {
            if (showArea)
                Console.WriteLine($"{ToString()}, Площа: {area} км²");
            else
                Console.WriteLine(ToString());
        }

        // Динамічний поліморфізм (перевизначення методу)
        public override void DisplayLocation()
        {
            Console.WriteLine($"Повна адреса: {GetFullLocation()}");
        }
    }
}
