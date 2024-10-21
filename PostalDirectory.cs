// File: PostalDirectory.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace PostalDirectoryApp
{
    public class PostalDirectory
    {
        private List<PostalDirectoryEntry> entries;

        public PostalDirectory()
        {
            entries = new List<PostalDirectoryEntry>();
        }

        // Метод для додавання нового запису
        public void AddEntry(PostalDirectoryEntry entry)
        {
            entries.Add(entry);
        }

        // Метод для видалення запису
        public void RemoveEntry(PostalDirectoryEntry entry)
        {
            entries.Remove(entry);
        }

        // Метод для очищення всіх записів
        public void ClearEntries()
        {
            entries.Clear();
        }

        // Метод для отримання всіх записів
        public List<PostalDirectoryEntry> GetAllEntries()
        {
            return entries;
        }

        // Метод для зворотного пошуку за поштовим індексом
        public List<PostalDirectoryEntry> ReverseLookup(string postalCode)
        {
            return entries.Where(e => e.PostalCode.Equals(postalCode, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Метод для пошуку за критеріями
        public List<PostalDirectoryEntry> Search(string continent = null, string country = null,
                                                 string region = null, string district = null,
                                                 string locality = null, bool? isSafeLocality = null)
        {
            var query = entries.AsQueryable();

            if (!string.IsNullOrEmpty(continent))
                query = query.Where(e => e.Continent.Equals(continent, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(country))
                query = query.Where(e => e.Country.Equals(country, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(region))
                query = query.Where(e => e.Region.Equals(region, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(district))
                query = query.Where(e => e.District.Equals(district, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(locality))
                query = query.Where(e => e.Locality.Equals(locality, StringComparison.OrdinalIgnoreCase));

            if (isSafeLocality.HasValue)
                query = query.Where(e => e.IsSafeLocality == isSafeLocality.Value);

            return query.ToList();
        }
    }
}
