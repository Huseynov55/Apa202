using System;
using System.Collections.Generic;
using System.Text;

namespace _10_GenericTypesCollections.Library_System
{
    internal class Library<T>
    {
        public string LibraryName { get; set; }

        public List<T> Items;

        public Library(string name)
        {
            LibraryName = name;
            Items = new List<T>();
        }

        public void Add(T item)
        {
            Items.Add(item);
            Console.WriteLine("Elave edildi.");
        }

        public void Remove(T item)
        {
            Items.Remove(item);
            Console.WriteLine("Silindi");
        }

        public List<T> GetAll()
        {
            return Items;
        }

        public int Count()
        {
            return Items.Count;
        }

        public T FindByIndex(int index)
        {
            if (index >= 0 && index < Items.Count)
            {
                return Items[index];
            }
            return default(T);
        }


    }

}
