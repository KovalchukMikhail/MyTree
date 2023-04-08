namespace MyTree
{
    public class RedBlackTree
    {
        public Node Root{get; set;}
        public bool Add(int value)
        {
            if(Root != null){
                bool result = AddNode(Root, value);
                Root = Rebalnce(Root);
                Root.Color = Colors.Black;
                return result;
            }
            else{
                Root = new Node();
                Root.Color = Colors.Black;
                Root.Value = value;
                return true;
            }
        }
        private bool AddNode(Node node, int value)
        {
            if (node.Value == value) return false;
            else
            {
                if (node.Value > value)
                {
                    if (node.LeftNode != null)
                    {
                        bool result = AddNode(node.LeftNode, value);
                        node.LeftNode = Rebalnce(node.LeftNode);
                        return result;
                    }
                    else
                    {
                        node.LeftNode = new Node();
                        node.LeftNode.Color = Colors.Red;
                        node.LeftNode.Value = value;
                        return true;
                    }
                }
                else
                {
                    if (node.RightNode != null)
                    {
                        bool result = AddNode(node.RightNode, value);
                        node.RightNode = Rebalnce(node.RightNode);
                        return result;
                    }
                    else
                    {
                        node.RightNode = new Node();
                        node.RightNode.Color = Colors.Red;
                        node.RightNode.Value = value;
                        return true;
                    }
                }
            }
        }
        private Node Rebalnce(Node node)
        {
            Node result = node;
            bool needRebalance;
            do{
                needRebalance = false;
                if(result.RightNode != null && result.RightNode.Color == Colors.Red &&
                (result.LeftNode == null || result.LeftNode.Color == Colors.Black)){
                    needRebalance = true;
                    result = RightSwap(result);
                }
                if (result.LeftNode != null && result.LeftNode.Color == Colors.Red &&
                result.LeftNode.LeftNode != null && result.LeftNode.LeftNode.Color == Colors.Red){
                    needRebalance = true;
                    result = LeftSwap(result);
                }
                if(result.LeftNode != null && result.LeftNode.Color == Colors.Red &&
                result.RightNode != null && result.RightNode.Color == Colors.Red){
                    needRebalance = true;
                    ColorSwap(result);
                }
            }while(needRebalance);
            return result;

        }
        private Node RightSwap(Node node)
        {
            Node rightNode = node.RightNode;
            Node betweenNode = rightNode.LeftNode;
            rightNode.LeftNode = node;
            node.RightNode = betweenNode;
            rightNode.Color = node.Color;
            node.Color = Colors.Red;
            return rightNode;
        }
        private Node LeftSwap(Node node)
        {
            Node leftNode = node.LeftNode;
            Node betweenNode = leftNode.RightNode;
            leftNode.RightNode = node;
            node.LeftNode = betweenNode;
            leftNode.Color = node.Color;
            node.Color = Colors.Red;
            return leftNode;
        }
        private void ColorSwap(Node node)
        {
            node.RightNode.Color = Colors.Black;
            node.LeftNode.Color = Colors.Black;
            node.Color = Colors.Red;
        }

    }
}