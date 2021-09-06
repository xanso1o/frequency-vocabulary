using System;
using System.Collections.Generic;
using System.Linq;

/*Develop a program that takes a path to a folder and creates a frequency dictionary of words found in all
text files of the specified folder. The result of the program is a text file containing
all words and their number of detections in files, sorted by number

Example:
mom - 23
walked - 12
on - 3
market -2*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter directory path: ");
            string path = Console.ReadLine();
            Text txt = new Text(path);
            Dictionary<string, int> dict = txt.ReadFile();
            IOrderedEnumerable<KeyValuePair<string, int>> registry = txt.SortDescending(dict);
            Console.WriteLine("Enter path for file result: ");
            string fileResult = Console.ReadLine();
            txt.FileSave(registry, fileResult);
        }
    }
}
