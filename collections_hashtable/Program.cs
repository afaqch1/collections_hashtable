using System;
using System.Collections;
using System.Collections.Generic;


namespace collections_hashtable
{
    class Program
    {
        static void display(Hashtable hash)
        {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("Population\t\tCities");
            System.Console.WriteLine("---------------------------------------");
            foreach (DictionaryEntry i in hash)
            {
                System.Console.WriteLine(i.Key + "\t\t" + i.Value);

            }
            System.Console.WriteLine("---------------------------------------");

        }
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(12642000, "Lahore");
            h.Add(16094000, "Karachi");
            h.Add(11290000, "Islamabad");
            h.Add(10090000, "Quetta");
            h.Add(21190000, "Peshawar");
            h.Add(10290000, "Multan");
            display(h);

            System.Console.WriteLine("////////////Try to get hashcode against key////////////////");
            int hash=h.GetHashCode();
            System.Console.WriteLine("Hashcode is = " + hash);

            h.Remove(11290000);
            display(h);

            System.Console.WriteLine("Total count of entities" + h.Count);

            System.Console.WriteLine("////////////create dic and add it in hashtable////////////////");
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(23, "Afaq");
            d.Add(24, "Wamik");
            d.Add(22, "Umair");

            Hashtable h2 = new Hashtable(d);
            display(h2);



        }
    }
}
