using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class dictionary
    {
        public static void dict_class()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Player5");
            dict.Add(2, "Player1");
            dict.Add(3, "Player3");
            dict.Add(4, "Player2");
            dict.Add(5, "Player4");
            foreach (KeyValuePair<int, string> user in dict)
            {
                Console.WriteLine(user.Key + "," + user.Value);
            }
            int n = dict.Count;
            Console.WriteLine("Number of players in the race are {0}",n);
            Console.WriteLine("****************");
            Console.WriteLine("After updating the dictionary");
            dict[1] = "player4";
            dict[5] = "Player5";
            foreach (KeyValuePair<int, string> user in dict)
            {
                Console.WriteLine(user.Key + "," + user.Value);
            }
            Console.WriteLine("winner is {0}", dict[1]);
            Console.WriteLine("Loser is {0}", dict[5]);
            dict.Clear();
            Console.WriteLine("After the clear operation : ");
            int total = dict.Count;
            Console.WriteLine("The number of key value pairs in the dictionary dict are {0}", total);

        }
        

    }
}
