using System.Xml;
using ArvoreBinaria;

BinaryTree<QuizItem> tree = GetTree();
BinaryTreeNode<QuizItem> node = tree.Root;

while (node != null) {
    if (node.Left != null || node.Right != null) {
        Console.WriteLine(node.Data.text);
        switch (Console.ReadKey(true).Key) {
            case ConsoleKey.Y:
                WriteAnswer("Yes");
        }
    }
}