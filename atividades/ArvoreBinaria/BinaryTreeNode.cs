using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode() {
            base.Children = new List<TreeNode<T>>();
        }

        public BinaryTreeNode<T> Left {
            get {return (BinaryTreeNode<T>)Children[0]; } //Isto é um Cast / converção
            set {Children[0] = value;}
        }
        
        public BinaryTreeNode<T> Right {
            get {return (BinaryTreeNode<T>)Children[1]; } //Isto é um Cast / converção
            set {Children[1] = value;}
        }
    }
}