using System.Dynamic;
using System.Runtime.InteropServices;
using System.Xml;

namespace AlgorithmTimer
{
    internal class AlgorithmUI
    {
        string title {get; set;}
        public string[] algorithms = ["Bubble Sort", "Selection Sort", "Insertion Sort", "Merge Sort", "Quick Sort", "Heap Sort", "Radix Sort", "Bucket Sort", "Shell Sort", "Counting Sort", "All"]; 
        public AlgorithmUI()
        {
            using StreamReader reader = new StreamReader(@"C:\Algorithm Timer\AlgorithmTimer\Title.txt");
            this.title = reader.ReadToEnd();
        }

        public void Displaymenu(int selected)
        {
            System.Console.WriteLine(title);
            for(int i = 0; i < algorithms.Length; i++)
            {
                if(i == selected)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    System.Console.Write($"> {algorithms[i]}");
                    Console.ResetColor();
                    System.Console.WriteLine();
                }
                else{System.Console.WriteLine(algorithms[i]);}
                
            }
        }
    }
}