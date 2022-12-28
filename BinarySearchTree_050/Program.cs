using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_050
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    /*Node class consists of three things, the information, 
     * references to the right child, and refereces to the left child*/
    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /*This function search the currentNode of the specified Node as
             well as the current Node of its parents*/
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void insert(string element)/*insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)/*Check if the Node to be inserted already inserted or not*/
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else/*If the specified nod is not present*/
            {
                tmp = new Node(element, null, null);/*Creates a Node*/
                if (parent == null)/*If the tree is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
        
    }
}
