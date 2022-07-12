using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Emil");
            names.Add("Seid");
            names.Add("Cavid");
            names.Add("Sadiq");
            
            CheckNames(StringName,names);
            
            
        }

        public static bool StringName(string name)
        {
            return name != "Cavid";
        }



        public static void CheckNames(Predicate<string> predicate, List<string>words)
        {
            
            foreach (var item in words)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                       
                }
                
            }
            

        }


    }
}
