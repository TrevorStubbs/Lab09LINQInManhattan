using System;
using System.Collections.Generic;
using System.IO;
using Lab09LINQInManhattan.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Lab09LINQInManhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fileFromData = GetJsonStream();

            Root deserilazedClass = JsonConvert.DeserializeObject<Root>(fileFromData);

            var queryableObject = deserilazedClass.Features;

            // 1. Output all of the neighborhoods in this data list(Final Total: 147 neighborhoods)
            var query = from Neighborhood in queryableObject
                        select Neighborhood;

            int counter = 1;
            foreach (var item in query)
            {
                Console.WriteLine($"{counter++}. {item.Properties.Neighborhood}");
            }

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            // 2. Filter out all the neighborhoods that do not have any names (Final Total: 143)
            var challenge2 = query.Where(hood => hood.Properties.Neighborhood.Length > 0);

            counter = 1;
            foreach (var item in challenge2)
            {
                Console.WriteLine($"{counter++}. {item.Properties.Neighborhood}");
            }

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            // 3. Remove the duplicates (Final Total: 39 neighborhoods)
            var challenge3 = challenge2.Select(x => x.Properties.Neighborhood).Distinct();               

            counter = 1;
            foreach (var item in challenge3)
            {
                Console.WriteLine($"{counter++}. {item}");
            }

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            // 4. Rewrite the queries from above and consolidate all into one single query.
            var challenge4 = queryableObject.Where(hood => hood.Properties.Neighborhood.Length > 0)
                                            .Select(x => x.Properties.Neighborhood).Distinct();

            counter = 1;
            foreach (var item in challenge4)
            {
                Console.WriteLine($"{counter++}. {item}");
            }

            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();

            // 5. Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vice versa.)




        }

        static string GetJsonStream()
        {
            try
            {
                using (StreamReader sr = File.OpenText(@"../../../data.json"))
                {
                    string content = sr.ReadToEnd();
                    return content;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
