using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlexiusTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1st task
            int count = vowelsCount("this is the test!");
            Console.WriteLine("The number of vowels is: {0}",count);

            // 2nd task
            // input - array of 3 elements
            int[] array = { 5, 10, 14 };
            count = indexOf(array);
            Console.WriteLine("Index of a element in array: {0}", count);

            // 3rd task
            // input - array of strings
            string[] names = {"Peter", "Alex", "Jacob", "Mark"};
            //string[] names = { "Peter", "Alex", "Jacob"};
            //string[] names = { "Peter", "Alex"};
            //string[] names = { "Peter"};
            //string[] names = {};
            string output = likeFunc(names);
            Console.WriteLine(output);

            Console.ReadKey();
        }

        // function that returns numbers of vowels in string, only lower case letters
        private static int vowelsCount(string text)
        {
            string vowels = "aeiou";
            return text.Count(x => vowels.IndexOf(x) > -1);
        }

        // function that returns index of number that lies between other two elements, numbers are distinct
        private static int indexOf(int[] number)
        {
            if (((number[0] > number[1]) && (number[0] < number[2])) || ((number[0] > number[2]) && (number[0] < number[1])))
                return Array.IndexOf(number, number[0]);
            else if (((number[1] > number[0]) && (number[1] < number[2])) || ((number[1] > number[2]) && (number[1] < number[0])))
                return Array.IndexOf(number, number[1]);
            else return Array.IndexOf(number, number[2]); ;
        }

        // function that returns string of names and number of likes
        private static string likeFunc(string[] array)
        {
            string output = string.Empty;
            
                switch (array.Length)
                {
                    case 0:
                        output = "no one";
                        break;
                    case 1:
                        output = array.First();
                        break;
                    case 2:
                        output = string.Join(" and ", array);
                        break;
                    case 3:
                        
                        output = string.Concat(array.First(),
                                               ", ",
                                               string.Join("", array.Skip(1).Take(1)),
                                               " and ",
                                               array.Last());
                        break;
                    default:
                        
                        output = string.Concat(array.First(),
                                               ", ",
                                               string.Join("", array.Skip(1).Take(1)),
                                               " and ",
                                               (array.Length - 2).ToString(),
                                               " others");
                        break;
                }
            return output += " likes this";
        }
    }
}
