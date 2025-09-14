using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DataStructures.Linear.LinkedLists.Linear
{
    public class LinearLinkedListNode<T>
    {
        internal T? Element;
        internal  LinearLinkedListNode<T>? Next { get; set; }
        public LinearLinkedListNode()
        {
            
        }
        public LinearLinkedListNode(T element)
        {
            Element = element;
        }

       
    }
}
