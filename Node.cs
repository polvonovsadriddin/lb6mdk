using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab6mdk
{
    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }

        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    }
    public class StringQueue
    {
        private Node head;
        private Node tail;

        public StringQueue()
        {
            head = null;
            tail = null;
        }

       
     
        public int GetTotalLength()
        {
            int totalLength = 0;
            Node current = head;
            while (current != null)
            {
                totalLength += current.Data.Length;
                current = current.Next;
            }
            return totalLength;
        }
        public IEnumerable<string> ToEnumerable()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
    
