using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace MyProject1
{
    public class DuplicateElementsInArray
    {

        public void DuplicateToEnd(int[] str)
        {
            List<int> lq = str.ToList();
            HashSet<int> set = str.ToHashSet();
            List<int> l = set.ToList();
            int[] count=new int[set.Count];
            for (int i =0; i < l.Count; i++)
            {
                 count[i] = lq.Count(r => r == l[i]);
            }
            int[] count1 = new int[lq.Count];
            for (int i = 0; i < lq.Count; i++)
            {
                count1[i] = lq.Count(r => r == lq[i]);
            }
            //Dictionary<int, int> hs = new Dictionary<int, int>();
            List<KeyValuePair<int,int>> valueWithoutDuplicate=new List<KeyValuePair<int, int>>();
            List<KeyValuePair<int, int>> valueWithDuplicate = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < lq.Count; i++)
            {
                if (count1[i] < 2)
                {
                    KeyValuePair<int, int> pair = new KeyValuePair<int, int>(lq[i], count1[i]);
                    valueWithoutDuplicate.Add(pair);
                }
                else
                {
                    KeyValuePair<int, int> pair = new KeyValuePair<int, int>(lq[i], count1[i]);
                    valueWithDuplicate.Add(pair);
                }

            }
            List<KeyValuePair<int, int>> newArray = valueWithoutDuplicate.Concat(valueWithDuplicate).ToList();
            //var sortedDict = from entry in valueWithoutDuplicate orderby entry.Value select entry;
            Console.WriteLine("\n Your new array is: ");
            foreach (var i in newArray)           
            {
                Console.Write(i.Key+" ");
            }
        }
    }
}