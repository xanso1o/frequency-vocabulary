using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Task_01
{
    public class Text
    {
        string ext = ".txt";
        string path;
        string[] fileList;
        Dictionary<string, int> registry = new Dictionary<string, int>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public Text(string path)
        {
            this.path = path;
            this.fileList = Directory.GetFiles(this.path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> ReadFile()
        {
            char[] sep = { ' ', '.', ',', ':', ';', '!', '?' };
            foreach (var file in fileList)
            {
                if (file.Contains(ext))
                {
                    string[] text = File.ReadAllLines(file);
                    foreach (var line in text)
                    {
                        string[] words = line.Split(sep);
                        foreach (var word in words)
                        {
                            if (registry.ContainsKey(word))
                            {
                                registry[word]++;
                            }
                            else
                            {
                                registry.Add(word, 1);
                            }
                        }
                    }
                }
            }
            return this.registry;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pairs"></param>
        /// <returns></returns>
        public IOrderedEnumerable<KeyValuePair<string, int>> SortDescending(Dictionary<string, int> pairs)
        {
            return pairs.OrderByDescending(i =>i.Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="registry"></param>
        /// <param name="fileResult"></param>
        public void FileSave(IOrderedEnumerable<KeyValuePair<string, int>> registry, string fileResult)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(fileResult + "\\result.txt");
                foreach (var word in registry)
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(word.Key + " " + word.Value);
                    streamWriter.WriteLine(word.ToString());
                }
                streamWriter.Close();
                Console.WriteLine("Done!");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception source: {0}", exception.Source);
            }
        }
    }
        
}
