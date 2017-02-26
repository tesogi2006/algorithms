using System;

namespace Algorithms
{
    public class Quicksort
    {
        private static int _iterationCounter = 0;
        public Quicksort(){}

        public void Sort(int [] array, int left, int right){
            if(left < right){
                var r = Parition(array, left, right);
                Sort(array, left, r - 1);
                Sort(array, r + 1, right);
            }
        }

        public int Parition(int[] array, int left, int right){
            int tmp, pivot = array[left];
            var i = left-1;
            Console.WriteLine("Pivot=" + pivot);
            for(int j = left; j <= right; j++){
                if(array[j] <= pivot){
                    i++;
                    // swap arrays at i and j
                    tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
            }

            // swap array[left] with pivot
            tmp = array[i];
            array[i] = array[left];
            array[left] = tmp;

            _iterationCounter++;            
            PrintArray(array);
            return i;
        }

        public void PrintArray(int [] array){
            Console.Write($"Iter {_iterationCounter}: ");
            foreach(var a in array){
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}