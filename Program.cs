using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Dictionary that contains information about several members of your family. Use the following example as a template:

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mom", new Dictionary<string, string>(){
                {"name", "Carol"},
                {"age", "58"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Angelo"},
                {"age", "62"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Kai"},
                {"age", "35"}
            });

            // Next, iterate over each item in myFamily and produce the following output
                // EXAMPLE: Krista is my sister and is 42 years old

            foreach (KeyValuePair<string, Dictionary<string, string>> person in myFamily)
            {
                // STORES EACH ITERATION "person" VALUE FOR READABILITY 
                Dictionary<string, string> personValues = person.Value;

                // INITIALIZING VARIABLES WITH NULL
                string personName = null; 
                string personAge = null;
                foreach (KeyValuePair<string, string> item in personValues)
                {
                    if (item.Key.Contains("name"))
                    {
                        personName = item.Value;
                    }
                    else if (item.Key.Contains("age"))
                    {
                        personAge = item.Value;
                    }
                    if (personName != null && personAge != null)
                    { 
                        Console.WriteLine($"{personName} is my {person.Key} and is {personAge} years old"); 
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
