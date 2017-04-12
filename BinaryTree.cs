using System;
using System.Collections.Generic;

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

        public void Insert(BstNode node, int data){
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
                        Insert(tmp, data);
                    }
                }else{
                    if(tmp.Right == null){
                        tmp.Right = newNode;
                    }else{
                        tmp = tmp.Right;
                        Insert(tmp, data);
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

        // Non-recursive(iterative) tree traversal
        // 1) Create an empty stack S.
        // 2) Initialize current node as root
        // 3) Push the current node to S and set current = current->left until current is NULL
        // 4) If current is NULL and stack is not empty then
        //      a) Pop the top item from stack.
        //      b) Print the popped item, set current = popped_item->right
        //      c) Go to step 3.
        // 5) If current is NULL and stack is empty then we are done.
        public void IterativeInOrder(BstNode node){
            var stack = new Stack<BstNode>();
            var current = node;
            var done = false;
            while(!done){
                if(current != null){
                    stack.Push(current);
                    current = current.Left;
                }
                else{
                    if (stack.Count > 0)
                    {
                        var top = stack.Pop();
                        Console.Write(top.Data + " ");
                        current = top.Right;
                    }else{
                        done = true;
                    }
                } 
            }
            Console.WriteLine();
        }

        // Iterative PostOrder tree traversal
        // 1. Add left child to stack
        // 2. Add right child to stack
        // 3. Print current data
        public void IterativePostOrder(BstNode node){
            var current = node;

            var stack = new Stack<BstNode>();
            stack.Push(current);

            while(stack.Count > 0){
                // todo
            }
        }

        // Iterative PreOrder traversal
        // 1. Print current data
        // 2. Add right child to stack
        // 3. Add left chile to stack
        // Note:    that the right child is pushed first so 
        //          that the left child is processed first
        public void IterativePreOrder(BstNode node){
            var current = node;

            var stack = new Stack<BstNode>();
            stack.Push(current);
            
            while(stack.Count > 0){
                var val = stack.Pop();
                Console.Write(val.Data + " ");
                if(val.Right != null){
                    stack.Push(val.Right);
                }
                if (val.Left != null)
                {
                    stack.Push(val.Left);
                }
            }
        }

        public void BFS(BstNode node){
            var queue = new Queue<BstNode>();
            queue.Enqueue(node);
            while(queue.Count > 0){
                var n = queue.Dequeue();
                Console.Write(n.Data + " ");
                if(n.Left != null){
                    queue.Enqueue(n.Left);
                }
                if(n.Right != null){
                    queue.Enqueue(n.Right);
                }
            }

            Console.WriteLine();
        }

        public void DFS(BstNode node){
            
        }
    }
}