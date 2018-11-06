using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class BSTree
    {
        private Node _root;

        public void Insert(int value)
        {
            if (_root == null)
            {
                _root = new Node(value);
            }
    
            else
            {
                Node current_node = _root;
                while (true)
                {
                    if (value < current_node.value)
                    {
                        if (current_node.Lchild == null)
                        {
                            current_node.Lchild = new Node(value);
                            break;
                        }
                        else
                        {
                            current_node = current_node.Lchild;
                        }
                    }

                    else
                    {
                        if (current_node.Rchild == null)
                        {
                            current_node.Rchild = new Node(value);
                            break;
                        }
                        else
                        {
                            current_node = current_node.Rchild;
                        }
                    }
                }
            }
        
        }

        public void Delete(int value)
        {
            Node current_node = _root;
            while (true)
            {
                if (current_node.value == value)
                {
                    if (current_node.Lchild == null & current_node.Rchild == null)
                    {
                        current_node = null;
                    }

                    else if (current_node.Lchild != null & current_node.Rchild == null)
                    {
                        current_node = current_node.Lchild;
                    }

                    else if (current_node.Lchild == null & current_node.Rchild != null)
                    {
                        current_node = current_node.Rchild;
                    }

                    else
                    {
                        int val_2 = current_node.Lchild.value;
                        int val_1 = current_node.Rchild.value;
                        Node child1 = current_node.Lchild.Lchild;
                        Node child2 = current_node.Lchild.Rchild;
                        Node child3 = current_node.Rchild.Lchild;
                        Node child4 = current_node.Rchild.Rchild;
                        current_node = null;
                        current_node = _root;
                        while (true)
                        {
                            if (val_1 < current_node.value)
                            {
                                if (current_node.Lchild == null)
                                {
                                    current_node.Lchild = new Node(val_1);
                                    break;
                                }
                                else
                                {
                                    current_node = current_node.Lchild;
                                }
                            }

                            else
                            {
                                if (current_node.Rchild == null)
                                {
                                    current_node.Rchild = new Node(val_1);
                                    break;
                                }
                                else
                                {
                                    current_node = current_node.Rchild;
                                }
                            }
                        }
                        current_node.Lchild = child3;
                        current_node.Rchild = child4;
                        current_node = _root;
                        while (true)
                        {
                            if (val_2 < current_node.value)
                            {
                                if (current_node.Lchild == null)
                                {
                                    current_node.Lchild = new Node(val_2);
                                    break;
                                }
                                else
                                {
                                    current_node = current_node.Lchild;
                                }
                            }

                            else
                            {
                                if (current_node.Rchild == null)
                                {
                                    current_node.Rchild = new Node(val_2);
                                    break;
                                }
                                else
                                {
                                    current_node = current_node.Rchild;
                                }
                            }
                        }
                        current_node.Lchild = child1;
                        current_node.Rchild = child2;
                    }
                }
            }
        }

        bool Search (int val)
        {
            if (_root == null)
            {
                return false;
            }

            while (true)
            {
                Node current_node = _root;
                while (true)
                {
                    if (current_node.value == val)
                    {
                        return true;
                    }
                    else if (current_node.value < val)
                    {
                        if (current_node.Rchild != null)
                        {
                            current_node = current_node.Rchild;
                        }
                        else { return false; }
                    }
                    else
                    {
                        if (current_node.Lchild != null)
                        {
                           current_node = current_node.Lchild;
                        }
                        else { return false; }
                    }
                }
            }
        }

        
        public int Find_minimum (Node root)
        {
            Node current_node = root;
            while (current_node.Lchild != null)
            {
                current_node = current_node.Lchild;
            }
            return current_node.value;
        }
        
    }
}
