using System.Net;
using System.Runtime.InteropServices;

namespace AlgorithmTimer
{
    internal class Algorithms
    {
       static public Action<int[]>[] actions = [BubbleSort, SelectionSort, InsertionSort, MergeSort, QuickSort, HeapSort, RadixSort, BucketSort, ShellSort, CountingSort];
        
        static public void BubbleSort(int[] inputs)
        {
            bool swaped = false;
            for(int i = 0; i < inputs.Length - 1; i++)
            {
                swaped = false; 
                for(int j = 0; j < (inputs.Length - i) - 1; j++)
                {
                   if(inputs[j] > inputs[j + 1])
                    {
                        int temp = inputs[j + 1];
                        inputs[j + 1] = inputs[j];
                        inputs[j] = temp; 
                        swaped = true;
                    } 
                }
                if(!swaped){break;}
            }
        }
        static public void SelectionSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine(); 
        }

        static public void InsertionSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine(); 
        }

        static public void MergeSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine();
        }

        static public void QuickSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine();
        }

        static public void HeapSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine();
        }

        static public void RadixSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine();
        }

        static public void BucketSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine();
        }

        static public void ShellSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine();
        }

        static public void CountingSort(int[] inputs)
        {
            System.Console.WriteLine("To be implemented");
            Console.ReadLine();
        }

        
    }
}