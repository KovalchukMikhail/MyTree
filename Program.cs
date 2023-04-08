namespace MyTree
{
    public class Program
    {
        public static void Main()
        {
            RedBlackTree tree = new RedBlackTree();
            tree.Add(10);
            // ShowTree(tree.Root);
            tree.Add(6);
            tree.Add(5);
            tree.Add(29);
            tree.Add(0);
            tree.Add(13);
            tree.Add(14);
            tree.Add(15);
            tree.Add(16);
            tree.Add(17);
            // ShowTree(tree.Root);
            tree.Add(11);
            ShowTree(tree.Root);
            Console.WriteLine("______________________");
            tree.Add(2);
            tree.Add(4);
            tree.Add(25);
            tree.Add(7);
            tree.Add(8);
            tree.Add(12);
            tree.Add(29);
            tree.Add(30);
            tree.Add(31);
            tree.Add(55);
            tree.Add(66);
            tree.Add(77);
            ShowTree(tree.Root);
        }

        public static void ShowTree(Node node, string str = "")
        {
            if (node != null)
            {
                Console.WriteLine(str + node.ToString());
            }
            if (node.LeftNode != null)
            {
                ShowTree(node.LeftNode, str + "  L");
            }
            if (node.RightNode != null)
            {
                ShowTree(node.RightNode, str + "  R");
            }
        }
    }
}
