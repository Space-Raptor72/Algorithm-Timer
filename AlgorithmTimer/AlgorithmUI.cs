using System.Dynamic;
using System.Runtime.InteropServices;
using System.Xml;

namespace AlgorithmTimer
{
    internal class AlgorithmUI
    {
        string title {get; set;}
        public AlgorithmUI()
        {
            using StreamReader reader = new StreamReader(@"C:\Algorithm Timer\AlgorithmTimer\Title.txt");
            this.title = reader.ReadToEnd();
        }

        public void Displaymenu()
        {
            System.Console.WriteLine(title);
            System.Console.WriteLine("1.) Bubble Sort");
        }
    }
}