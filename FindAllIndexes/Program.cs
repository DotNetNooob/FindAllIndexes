using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllIndexes
{
    static class Program
    {
        static void Main(string[] args)
        {
            string body = @"This is a dummy string #[$deals-2-Name$] , Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry\'s #[$deals-2-Name$] standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it #[$deals-2-Name$] to #[$deals-2-Name$] make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing #[$deals-2-Name$] software like Aldus PageMaker including versions of Lorem Ipsum.";
            string entity = "deals";

            List<int> values = GetAllIndexes(body, entity);

            // Manipulate String



            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }



        public static List<int> GetAllIndexes(string str, string value)
        {
            value = "#[$" + value;

            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0; ; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}

// Initial Commit