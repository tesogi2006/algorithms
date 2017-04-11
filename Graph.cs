using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class Graph{
        private int _virtex;
        private List<int>[] _adjacencyList;
        public Graph(int virtex){
            _virtex = virtex;
            _adjacencyList = new List<int>[_virtex];
            for(var i = 0 ; i < _adjacencyList.Length; i++){
                _adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w){
            _adjacencyList[v].Add(w);
        }

        public void BreadthFirstTraversal(int source){
            // mark all virtices as not visited
            bool[] visited = new bool[_virtex];

            // create queue for breadth first search
            var queue = new Queue<int>();
            
            // mark the current node as visited
            visited[source] = true;
            queue.Enqueue(source);
            while(queue.Count != 0){
                // dequeue a virtex from queue and print it
                source = queue.Dequeue();
                Console.Write(source + " ");

                var tmp = _adjacencyList[source];
                // get all adj virtices of the dequeued _virtex
                // s. If adj has not been visited, then mark it 
                // as visited and enqueue it
                int i = 0;
                foreach(var node in tmp){
                    if(!visited[i]){
                        //visited[]
                    }
                }
            }
        }
    }
}