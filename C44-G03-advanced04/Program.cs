
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

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



            #region Q5

            //Given an array of integers, check if the array contains any duplicates.
            //int[] arr = { 1, 2, 3, 4, 5, 2 };

            //HashSet<int> hash = new HashSet<int>();
            //bool hasDuplicate = false;

            //foreach (int num in arr)
            //{
            //    if (hash.Contains(num))
            //    {
            //        hasDuplicate = true;
            //        break;
            //    }
            //    else
            //    {
            //        hash.Add(num);
            //    }
            //}

            //if (hasDuplicate)
            //    Console.WriteLine("Array contains duplicates.");
            //else
            //    Console.WriteLine("No duplicates found.");

            #endregion




            #region Q6
            //Implement a SortedDictionary that stores student IDs(int) and their names(string).
            //    Perm operations like adding, removing, and retrieving student names.

            //Student student1 = new Student() 
            //{ 
            //    ID = 1, 
            //    Name ="sayed"
            //};
            //Student student2 = new Student()
            //{
            //    ID = 2,
            //    Name = "helmy"
            //};
            //Student student3 = new Student()
            //{
            //    ID = 3,
            //    Name = "mohamed"
            //};
            //Student student4 = new Student()
            //{
            //    ID = 4,
            //    Name = "ali"
            //};
            //SortedDictionary<Student, int> student = new()
            //{
            //    {student1,20 },
            //    {student2,30},
            //    {student3,40}, 
            //    {student4,50},



            //};

            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}

            //student.TryAdd(new Student(6, "mahmoud"),60);
            //student.TryAdd(new Student(2, "helmy"),30);

            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}

            //student.Remove(student3);
            #endregion



            #region Q7
            //Create an employee directory where employee IDs(int) are keys and employee names(string) are values. 
            //    Use a SortedList to manage and retrieve employees in order of their IDs.

            //SortedList<int, string> employees = new SortedList<int, string>();
            //employees.Add(104, "Helmy");
            //employees.Add(102, "Mohamed");
            //employees.Add(103, "Ali");

            //Console.WriteLine("Employee Directory (Sorted by ID):");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
            //}


            //Console.WriteLine("\nRetrieve Employee with ID 102:");
            //if (employees.ContainsKey(102))
            //{
            //    Console.WriteLine($"ID: 102, Name: {employees[102]}");
            //}


            //Console.WriteLine("Removing employee with ID 103...");
            //employees.Remove(103);

            //Console.WriteLine("\nUpdated Employee Directory:");
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
            //}
            #endregion


            #region Q8

            //Given an array of integers from 1 to N with some numbers missing, find the missing numbers.
            //int size = 5;
            //int[] arr = { 1, 3, 4 };
            //HashSet<int> missing = new (arr);
            //List <int> listnumbers = new List <int>();
            //for (int i = 1; i <= size; i++) {
            //    if (!missing.Contains(i))
            //    {

            //        listnumbers.Add(i);
            //    }

            //}

            //foreach (int x in listnumbers) {
            //    Console.WriteLine($"{x}  ");

            //}

            //Console.WriteLine(string.Join(",", listnumbers));

            #endregion

            #region Q9
           // You have a list of integers with possible duplicates, create a HashSet that contains only unique values.

            //List<int> list = [1,2,3,4,5,6,6,7,7,9,30,34,32,12];
            //HashSet<int> ints = new HashSet<int>(list);
            //foreach (var i in ints) {

            //    Console.WriteLine(i + " ");
            //}
            #endregion

        }





    }
    
}
