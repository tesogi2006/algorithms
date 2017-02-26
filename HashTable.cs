using System;

namespace Algorithms
{
    public class HashTable
    {
        private const int TABLE_SIZE = 100;
        private HashNode[] _table;
        public HashTable(){
            _table = new HashNode[TABLE_SIZE];
        }

        public void Add(object data){
            var index = GetHash(data);
            var newNode = new HashNode();
            newNode.Data = data;
            if(_table[index] != null){
                _table[index].Next = newNode;
            }else{
                _table[index] = newNode;
            }
        }

        public int GetHash(object data){
            var h = data.ToString().ToCharArray();
            int sum = 0;
            for (int i = 0; i < h.Length; i++)
            {
                sum += (int)h[i];
            }
            var index = sum * 541 % TABLE_SIZE;

            return index;
        }

        public void PrintTable(){
            for (int i = 0; i < _table.Length; i++)
            {
                if(_table[i] != null){
                    Console.Write($"Index {i}: " + _table[i].Data);
                    var current = _table[i];
                    while(current.Next != null){
                        Console.Write(" " + _table[i].Data);
                        current = current.Next;
                    }
                    Console.WriteLine();
                }
            }
        }
    }

    public class HashNode{
        public object Data;
        public HashNode Next;
    }
}