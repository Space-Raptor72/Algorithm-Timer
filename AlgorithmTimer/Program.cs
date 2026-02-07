using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace AlgorithmTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            AlgorithmUI AlgorithmUI_Object = new AlgorithmUI();
            int selected = 0; 
            int num_inputs = 10_000;
            while(true)
            {
                AlgorithmUI_Object.Displaymenu(selected);

                ConsoleKeyInfo key = Console.ReadKey();

                if(key.Key == ConsoleKey.DownArrow)
                {
                    selected++; 
                }
                if(key.Key == ConsoleKey.UpArrow)
                {
                    selected--; 
                }
                if(key.Key == ConsoleKey.Enter)
                {
                    long[] test_times = new long[3];
                    Stopwatch timer = new Stopwatch();

                    for(int i = 0; i < 3; i++)
                    {
                        int[] inputs = GenerateInputs(num_inputs);

                        timer.Start();
                        Algorithms.actions[selected](inputs);
                        timer.Stop();

                        test_times[i] = timer.ElapsedMilliseconds;
                        timer.Reset();
                    }
                    AlgorithmUI_Object.Displaytimes(selected, test_times, num_inputs); 
                }

                if(selected > AlgorithmUI_Object.algorithms.Length - 1){selected = 0;}
                if(selected < 0){selected = AlgorithmUI_Object.algorithms.Length - 1;}
                Console.Clear();
            }
            
        }

        public static int[] GenerateInputs(int num_inputs)
        {
            int[] inputs = new int[num_inputs];
            Random random = new Random();
            for(int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = random.Next(0, 100000);
            }
            return inputs;
        }
    }
}
