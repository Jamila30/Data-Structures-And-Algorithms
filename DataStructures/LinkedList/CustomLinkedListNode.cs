using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class CustomLinkedListNode<T>
    {
        internal T? Element;
        internal  CustomLinkedListNode<T>? Next { get; set; }

        public CustomLinkedListNode()
        {
            
        }
        public CustomLinkedListNode(T element)
        {
            Element = element;
        }

       
    }
}
