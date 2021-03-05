using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     class BinarySearchTree
    {

        // memeber variables

        public Node RootNode;

        // constructor
        public BinarySearchTree()
        {

        }

        // member methods 

        public void AddNode(Node nodeToAdd)
        {
            if (RootNode == null) //SF: since the rootnode is the first not you start with it, ADD to it first
            {
                RootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = RootNode;
                while (true)
                if (currentNode.Data > nodeToAdd.Data && currentNode.leftNode == null ) //SF: to make this work
                {                                                                         // need to compare better data that they both share (like int =) )
                        currentNode.leftNode = nodeToAdd;
                        break;
                }
                else if (currentNode.Data < nodeToAdd.Data && currentNode.rightNode == null )
                {
                        currentNode.rightNode = nodeToAdd;
                        break;
                }  
            }
        }

        public void SearchNodes(int datatoFind) // this returns a bool (true or false)
        {

        }

    }
}
