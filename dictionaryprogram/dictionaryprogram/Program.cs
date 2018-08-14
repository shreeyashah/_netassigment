using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace dictionaryprogram
{
    class Program
    {
        private static short key;

        static void Main(string[] args)
        {
            Dictionary<string, int> president = new Dictionary<string, int>
            {
                { " i Atal Bihari Vajpayee", 1998 },
                { " ii.	Narendra Modi", 2014 },
                { " iii Manmohan Singh", 2004 }
            };



            if (president.ContainsValue(2014))
            {


                Console.WriteLine(true);




                foreach (KeyValuePair<string, int> author in president)
                {
                    Console.WriteLine("Key: {0}, Value: {1}",
                        author.Key, author.Value);
                }
                president.Add("iiii narendramodi", 2018);
                foreach (KeyValuePair<string, int> author in president)
                {
                    Console.WriteLine("Key: {0}, Value: {1}",
                        author.Key, author.Value);
                }


                president = president.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);


                Console.WriteLine("assendind order of year");
                foreach (KeyValuePair<string, int> author in president)
                {

                    Console.WriteLine(" Key: {0}, Value: {1}",
                        author.Key, author.Value);
                }
                Console.ReadKey(true);
            }
        }
    }
}