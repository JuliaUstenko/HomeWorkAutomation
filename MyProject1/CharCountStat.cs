using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MyProject1
{
    public class CharCountStat
    {
        public void method(string str)
        {
            foreach (char c in str)
            {
                Console.Write(c);
            }
            char[] strToChar = str.ToCharArray();
           
            var cr = strToChar.OrderBy(i => strToChar).Distinct();           
            char[] crq = cr.ToArray();
            int[] count = new int[crq.Length];

            for (int i = 0; i < strToChar.Length; i++)
            {
                for (int j = 0; j < crq.Length; j++)
                {
                    if (strToChar[i]== crq[j])
                    {
                        count[j]++;
                    }
                }
            }

            Dictionary<char,int> qwer= new Dictionary<char, int>();
            for (int i = 0; i < crq.Length; i++)
            {
                qwer.Add(crq[i],count[i]);
            }

            foreach (var i in qwer)
            {
                Console.WriteLine(i);
            }
        }
        public static void getStatisticForChar(string str)
        {
            Console.WriteLine("Statistic for your line:\n");
            char[] strToChar = str.ToLower().Replace(" ","").ToCharArray();
            SortedSet<char> ch = new SortedSet<char>(strToChar);
            

            int[] count = new int[ch.Count];
            char[] che = ch.ToArray();

            for (int i = 0; i < strToChar.Length; i++)
            {
                for (var j = 0; j < che.Length; j++)
                {
                    if (strToChar[i] == che[j])
                    {
                        count[j]++;
                    }
                }
            }
            Dictionary<char, int> qwer = new Dictionary<char, int>();
            for (int i = 0; i < che.Length; i++)
            {
                qwer.Add(che[i], count[i]);
            }
            foreach (var i in qwer)
            {
                Console.WriteLine("Letter {0} occurs {1} times.", i.Key,i.Value );
            }
        }
    }
}