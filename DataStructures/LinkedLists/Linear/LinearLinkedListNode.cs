﻿using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedLists.Linear
{
    public class LinearLinkedListNode<T>
    {
        internal T? Element;
        internal  LinearLinkedListNode<T>? Next { get; set; }
        internal  LinearLinkedListNode<T>? Prev { get; set; }

        public LinearLinkedListNode()
        {
            
        }
        public LinearLinkedListNode(T element)
        {
            Element = element;
        }

       
    }
}
