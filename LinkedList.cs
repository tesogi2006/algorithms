using System;
namespace Algorithms
{
    public class ListNode
    {
        public int Data { get; set; }
        public ListNode Next { get; set; }
        public ListNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class LinkedList{
        public ListNode Root{get;set;}

        public LinkedList(ListNode node){
            Root = node;
        }

        public void Enqueue(ListNode node, int data){
            var newNode = new ListNode(data);
            var tmp = node;

            if(tmp == null){
                Root = newNode;
            }else{
                if(tmp.Next == null){
                    tmp.Next = newNode;
                }else{
                    tmp = tmp.Next;
                    Enqueue(tmp, data);
                }
            }
        }

        public int Dequeue(){
            var data = Root.Data;
            Root = Root.Next;
            return data;
        }

        public void PrintList(ListNode node){
            if(node == null)
            {
                return;
            }
            Console.Write(node.Data + " ");
            var tmp = node.Next;
            PrintList(tmp);
        }
    }
}