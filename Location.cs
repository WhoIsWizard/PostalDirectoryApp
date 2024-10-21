// File: Location.cs
using System;

namespace PostalDirectoryApp
{
    public abstract class Location
    {
        // Protected змінні
        protected string continent;
        protected string country;
        protected string region;
        protected string district;
        protected string locality;

        // Абстрактний метод
        public abstract string GetFullLocation();

        // Віртуальний метод
        public virtual void DisplayLocation()
        {
            Console.WriteLine(GetFullLocation());
        }
    }
}
