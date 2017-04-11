using System;

namespace Algorithms
{
    public class Quickselect
    {
        public Quickselect(){

        }

        public void Select(int [] arr, int k, int left, int right){
            if(left < right){
                var r = Partition(arr, left, right);
                if(arr[r] == k){
                    Console.WriteLine("Founnd element at " + r);
                    return;
                }

                Select(arr, k, left, r - 1);
                Select(arr, k, r + 1, right);
            }

        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            int i = left, tmp;
            for(int j = left; j < right; j++){
                if(arr[j] <= pivot){
                    i++;
                    tmp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = tmp;
                }
            }

            tmp = arr[left];
            arr[left] = arr[i];
            arr[i] = tmp;

            return i;
        }
    }
}