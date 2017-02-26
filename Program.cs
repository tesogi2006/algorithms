using System;
namespace Algorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RunQuicksortDemo();

            //var array = new int[]{10, 6, 15, 3, 8, 12, 18};
            //RunBinarySearchTreeDemo(array);

            //var objects = new object[]{34, 101, "Hello World", true, 'c', "34", 34};
            //RunHashTableDemo(objects);

            //int [] numbers = new int[]{2, 5, 3, 4, 8, 6};
            //RunLinkedListDemo(numbers);
        }


        public static void RunLinkedListDemo(params int[] numbers){
            var node = new ListNode(0);
            var myList = new LinkedList(node);
            for (int i = 0; i < numbers.Length; i++)
            {
                myList.Enqueue(myList.Root, numbers[i]);
            }            
            myList.PrintList(node);
            Console.WriteLine("************");

            var first = myList.Dequeue();
            Console.WriteLine("Dequeue: " + first);
            myList.PrintList(node);
        }

        public static void RunBinarySearchTreeDemo(params int [] numbers){
            var node = new BstNode(4);
            var bst = new BinaryTree(node);
            
            for (int i = 0; i < numbers.Length; i++)
            {
                bst.Add(bst.RootNode, numbers[i]);
            }
            //Console.Write("InOrderTraversal: ");
            //bst.PrintInOrder(bst.RootNode);
            bst.Search(bst.RootNode, 10);
        }

        public static void RunHashTableDemo(params object[] objects){
            var hashTable = new HashTable();
            for (int i = 0; i < objects.Length; i++)
            {
                hashTable.Add(objects[i]);
            }
            hashTable.PrintTable();
        }

        private static void RunQuicksortDemo(){
            int [] array = new int[]{3,1,2,4,3,2,8,1,0,45,2};
            var sort = new Quicksort();
            sort.Sort(array, 0, array.Length-1);
            Console.WriteLine("Sorting Done.");
        }
    }
}
