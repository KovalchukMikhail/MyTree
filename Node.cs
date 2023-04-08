namespace MyTree{
    public class Node{
        public int Value {get; set;}
        public Colors Color {get; set;}
        public Node LeftNode {get; set;}
        public Node RightNode {get; set;}

        public override string ToString()
        {
            return $"Node[ value = {Value}, color = {Color}]";
        }
    }
}