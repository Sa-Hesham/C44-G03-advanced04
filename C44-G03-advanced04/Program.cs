using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;

namespace C44_G03_advanced04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Given an array of integers, count the frequency of each element using a hash table.
            //int[] Arr = { 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 1, 2, 2, 3, 9, 9 };
            //Dictionary<int, int> freq = new Dictionary<int, int>();
            //foreach (int i in Arr) { 
            //if(freq.ContainsKey(i))
            //        freq[i]++;
            //else freq[i] = 1;

            //}

            //foreach(KeyValuePair<int ,int> value in freq)
            //{
            //    Console.WriteLine(value );

            //}
            #endregion


            #region Q2
            // You have a hashtable where its values are integers, find the key associated with the highest value.

            //int maxvalue = int.MinValue;
            //string key = default!;
            //Dictionary<String, int> MyGroup = new()
            //{

            //    {"A",121 },
            //    {"b",10 },
            //    {"c",20 },
            //    {"d",30 },




            //};

            //foreach(KeyValuePair<String, int> pair in MyGroup)
            //{
            //    if (pair.Value > maxvalue)
            //    {
            //        maxvalue = pair.Value;
            //        key= pair.Key;
            //    }
            //}

            //Console.WriteLine($" the key {key} has maxvalue {maxvalue}");

            #endregion





            #region Q3
            //You have a hashtable, the  user will enter targetValue find all keys that associated with a specific targetValue
            // Note : if the targetValue not found print(“Key not found”)
            //Dictionary<int ,string> table = new () {

            //    { 1,"sayed"},
            //    {2,"hesham" },
            //    {3,"mostafa" },
            //    {4,"mostafa" },
            //    {5,"sayed" },

            //};


            //Console.WriteLine("please enter the target value to search");
            //string inputvalue =Console.ReadLine()!.ToLower();
            //bool flag = false;
            //foreach (var search in table) {

            //    if (search.Value == inputvalue) { 
            //        flag = true;

            //        Console.WriteLine($" {search.Key} ");

            //    }



            //}

            //if (!flag)
            //{

            //    Console.WriteLine("key not found ");
            //}
            #endregion


        }
    }
}
