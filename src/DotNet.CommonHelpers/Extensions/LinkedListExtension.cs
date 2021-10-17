using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.CommonHelpers.Extensions
{
    /// <summary>
    /// Linked list extensions
    /// </summary>
    public static class LinkedListExtension
    {
        /// <summary>
        /// Enumerates the nodes so you can walk them with linq
        /// </summary>        
        public static IEnumerable<LinkedListNode<T>> EnumerateNodes<T>(this LinkedList<T> list)
        {
            var node = list.First;
            while (node != null)
            {
                yield return node;
                node = node.Next;
            }
        }

        /// <summary>
        /// Returns node at postion pos from start
        /// </summary>        
        public static LinkedListNode<T> NodeAt<T>(this LinkedList<T> myLinkedList, int pos)
        {
            var node = myLinkedList.First;
            int cnt = 0;
            while (node != null && cnt < pos)
            {
                node = node.Next;
                cnt++;
            }
            return node;
        }

        /// <summary>
        /// Returns node with distance pos from tail
        /// </summary>        
        public static LinkedListNode<T> TailNodeAt<T>(this LinkedList<T> myLinkedList, int pos)
        {
            var node = myLinkedList.Last;
            int cnt = 0;
            while (node != null && cnt < pos)
            {
                node = node.Previous;
                cnt++;
            }
            return node;
        }


        /// <summary>
        /// Returns last "length" number of items in the list. If the list is shorter, the result will be shorter than length.
        /// </summary>                
        public static List<T> Tail<T>(this LinkedList<T> myLinkedList, int length)
        {
            var node = myLinkedList.Last;
            var tail = new List<T>();
            int cnt = 0;
            while (node != null && cnt < length)
            {
                tail.Insert(0, node.Value);
                node = node.Previous;
                cnt++;
            }
            return tail;
        }

        /// <summary>
        /// Returns the list of length items after (including) the current node (if end comes first, the list is shorter)
        /// </summary>
        public static List<T> NextList<T>(this LinkedListNode<T> node, int length)
        {
            var ret = new List<T>();

            int cnt = 0;
            while (node != null && cnt < length)
            {
                ret.Add(node.Value);
                node = node.Next;
                cnt++;
            }
            return ret;
        }
        /// <summary>
        /// Returns the list of length items before (including) the current node (if end comes first, the list is shorter)
        /// </summary>        
        public static List<T> PreviousList<T>(this LinkedListNode<T> node, int length)
        {
            var ret = new List<T>();

            int cnt = 0;
            while (node != null && cnt < length)
            {
                ret.Insert(0, node.Value);
                node = node.Previous;
                cnt++;
            }
            return ret;
        }
    }
}
