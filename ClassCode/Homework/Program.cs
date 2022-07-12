using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework
{
    class Program
    {
        #region Delegate
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str);

        //public delegate string StringLength(string str,int m);
        #endregion

        static void Main(string[] args)
        {
            #region Predicate,Action
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Console.WriteLine(Sum(CheckOdd, arr));
            //Console.WriteLine(Sum(CheckEven, arr));
            //Console.WriteLine(Sum(CheckSumMoreThanFive, arr));

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.FindAll(m => m > 6 && m < 9);


            //var result2 = numbers.FindAll(CheckSumMoreThanFive);




            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Test(StringToUpper, "Cavid");
            //Test(StringToLower, "Cavid");

            //string name = "Emil";

            //string str = "Emil";

            //Console.WriteLine(str);

            //ChangeString change = StringToUpper;

            //change += StringToLower;

            //change += delegate (string s)
            //{
            //    Console.WriteLine(s.ToLower());
            //};
            //change += s => Console.WriteLine(s.ToLower());

            //change("Orxan");

            //Action<string,int,string> action = StringToUpper;
            //action += StringToLower;
            //action("Seid",55,"P-130");
            #endregion

            #region Function
            //Console.WriteLine(Test(StrLength, "Seid",23));

            //Func<string, int, string> func = StrLength;

            //Func<string, int, int> func2 = StrLength2;

            //Console.WriteLine(func2("Seid",17));
            #endregion

        }


        #region Function
        //public static string StrLength(string str, int m)
        //{
        //    return str.Length.ToString() + "-" + "Age" + "-" + m;
        //}
        //public static int StrLength2(string str, int m)
        //{
        //    return str.Length + m;
        //}
        #endregion

        #region Predicate,Action
        //public static Test() => Console.WriteLine("Tested");

        //public static string Test(StringLength func, string str, int m)
        //{
        //    return func(str, m);
        //}

        //public static void StringToUpper(string str,int n,string t)
        //{
        //    Console.WriteLine(str.ToUpper() + "-" + n + t);
        //}
        //public static void StringToLower(string str,int n,string t)
        //{
        //    Console.WriteLine(str.ToLower() + "-" + n + t);
        //}

        //public static void Test(ChangeString func,string str)
        //{
        //    func(str);
        //}





        //public static bool CheckOdd(int number)
        //{
        //    return number % 2 == 1;
        //}

        //public static bool CheckEven(int numeric)
        //{
        //    return numeric % 2 == 0;
        //}

        //public static bool CheckSumMoreThanFive(int digit)
        //{
        //    return digit > 6;
        //}




        //public static int Sum(Predicate<int>predicate, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        //public static int SumEven(CheckNums func,int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        //public static int SumMoreThanFive(CheckNums func,int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        #endregion



    }
}
