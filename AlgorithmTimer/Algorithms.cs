using System.Net;
using System.Runtime.InteropServices;

namespace AlgorithmTimer
{
    internal class Algorithms
    {
       static public Action<int[]>[] actions = [BubbleSort];
        
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
        
    }
}