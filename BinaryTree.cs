using System;

namespace Algorithms
{
    public class BstNode
    {
        public int Data;
        public BstNode Left, Right;

        public BstNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
    public class BinaryTree{
        public BstNode RootNode;
        private static int _count = 0;
        public BinaryTree(BstNode initNode){
            RootNode = initNode;
        }

        public bool IsEmpty(){
            return RootNode == null;
        }

        public void Add(BstNode node, int data){
            var newNode = new BstNode(data);
            var tmp = node;
            
            if(IsEmpty()){
                RootNode = newNode;
            }else{
                if(tmp.Data > data){
                    if(tmp.Left == null){
                        tmp.Left = newNode;
                    }else{
                        tmp = tmp.Left;
                        Add(tmp, data);
                    }
                }else{
                    if(tmp.Right == null){
                        tmp.Right = newNode;
                    }else{
                        tmp = tmp.Right;
                        Add(tmp, data);
                    }
                }

            }
            _count++;
        }

        public int TreeSize(){
            return _count;
        }

        public void Search(BstNode node, int value){
            var tmp = node;
            if(node == null) return;

            if(node.Data == value){
                Console.WriteLine($"{value} found!");
                return;
            }else{
                if(node.Data > value){
                    tmp = node.Left;
                    Search(tmp, value);
                }else{
                    tmp = node.Right;
                    Search(tmp, value);
                }
            }
        }

        public void PrintInOrder(BstNode node){
            var tmp = node;
            if(node == null) return;

            PrintInOrder(tmp.Left);
            Console.Write(tmp.Data + " ");
            PrintInOrder(tmp.Right);
        }

        public void PrintPreOrder(BstNode node)
        {
            var tmp = node;
            if (node == null) return;

            Console.Write(tmp.Data + " ");
            PrintPreOrder(tmp.Left);
            PrintPreOrder(tmp.Right);
        }

        public void PrintPostOrder(BstNode node)
        {
            var tmp = node;
            if (node == null) return;

            PrintPostOrder(tmp.Left);
            PrintPostOrder(tmp.Right);
            Console.Write(tmp.Data + " ");
        }
    }
}