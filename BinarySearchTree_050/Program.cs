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
        
    }
}
