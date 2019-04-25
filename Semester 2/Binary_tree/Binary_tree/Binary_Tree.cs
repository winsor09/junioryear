using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_tree
{
    class Binary_Tree
    {
        public Node Root;
        public int Height;
        public int Count;


        private int CountRucursive(Node val)
        {
            throw new NotImplementedException();
        }

        public void Insert(char val)
        {
            if (Root == null)
            {
                Root = new Node(val);
            }
            else
            {
                Insert(Root, val);
            }
        }

        public void Insert(Node cur, char val)
        {
            if (val >= cur.Value && cur.RightChild == null)
            {
                cur.RightChild = new Node(val);
                return;
            }

            if (val < cur.Value && cur.LeftChild == null)
            {
                cur.LeftChild = new Node(val);
                return;
            }

            if (val >= cur.Value)
            {
                Insert(cur.RightChild, val);
            }

            else if (val < cur.Value)
            {
                Insert(cur.LeftChild, val);
            }
        }

        public void Remove(char val)
        {
            
            if (Root == null)
            {
                return;
            }
            else
            {
                Root = Remove(Root, val);
            }
        }

        private Node Remove(Node cur, char val)
        {
            


            if (cur == null) return cur;

            if (val < cur.Value)
                cur.LeftChild = Remove(cur.LeftChild, val);
            else if (val > cur.Value)
                cur.RightChild = Remove(cur.RightChild, val);
            
            else
            {  
                if (cur.LeftChild == null)
                    return cur.RightChild;
                else if (cur.RightChild == null)
                    return cur.LeftChild;


                cur.Value = MinValue(cur.RightChild);

                cur.RightChild = Remove(cur.RightChild, cur.Value);
            }
            return cur;

        
        }

        private char MinValue(Node cur)
        {
            char minv = cur.Value;
            while (cur.LeftChild != null)
            {
                minv = cur.LeftChild.Value;
                cur = cur.LeftChild;
            }
            return minv;
        }


        public bool Search(char val)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Search(Root, val);
            }
        }


        private bool Search(Node cur, char val)
        {


            if (val == cur.Value)
            {
                return true;
            }
            else
            {
                if (val < cur.Value && cur.LeftChild != null)
                {
                    cur.Value = cur.LeftChild.Value;
                    return Search(cur.LeftChild, val);

                }

                else if (val > cur.Value && cur.RightChild != null)
                {
                    cur.Value = cur.RightChild.Value;
                    return Search(cur.RightChild, val);

                }
                else
                { return false; }
                   
            }

        }

        public void PreOrderPrint()
        {
            PreOrderPrint(Root);
        }


        private void PreOrderPrint(Node cur)
        {
            if (cur == null)
            {
                return;
            }

            Console.Write(cur.Value + ".");
            PreOrderPrint(cur.LeftChild);
            PreOrderPrint(cur.RightChild);
        }

        public void InOrderPrint()
        {
            InOrderPrint(Root);
        }

        private void InOrderPrint(Node cur)
        {
            if (cur == null)
            {
                return;
            }
            InOrderPrint(cur.LeftChild);
            
            Console.Write(cur.Value + ".");
            InOrderPrint(cur.RightChild);


        }

        public void PostOrderPrint()
        {
            PostOrderPrint(Root);
        }

        public void PostOrderPrint(Node cur)
        {
            if (cur == null)
            {
                return;
            }
            PostOrderPrint(cur.LeftChild);


            PostOrderPrint(cur.RightChild);
            Console.Write(cur.Value + ".");
        }

        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }

        ////Extra Credit
        ///

        public void Balance()
        {

        }

    }


}
