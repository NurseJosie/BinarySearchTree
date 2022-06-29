
namespace BinarySearchTree
{
    public class BinarySearchTree<T> : BST_G<T> where T : IComparable<T>
    {
        private Node<T>? Root = null; // skapa en Root av ett nod-objekt

        public void Insert(T value)
        {
            if (Root == null) // om det inte finns ngt värde i trädet, gör value till root.
            {
                Root = new Node<T>(value);
                count++; //addera nytt nod-objekt till Count-metoden att returnera
                return;
            }
            var currentNode = Root; //för att kolla de andra noderna
            while (true) //kolla tills tom plats är hittad
            {
                if (currentNode.Data.CompareTo(value) == 0) // om lika som sin parent, lägg till vänster
                {
                    if (currentNode.LeftChild == null)//kolla om man kommit till en tom nod
                    {
                        currentNode.LeftChild = new Node<T>(value); //skapa ny nod
                        count++;
                        return;
                    }
                    currentNode = currentNode.LeftChild; //vandra vidare
                }
                else if (currentNode.Data.CompareTo(value) > 0) // mindre än parent, lägg till vänster
                {
                    
                    if (currentNode.LeftChild == null)
                    {
                        currentNode.LeftChild = new Node<T>(value);
                        count++;
                        return;
                    }
                    currentNode = currentNode.LeftChild; 
                }
                else if (currentNode.Data.CompareTo(value) < 0) // högre än parent, lägg till höger
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = new Node<T>(value);
                        count++;
                        return;
                    }
                    currentNode = currentNode.RightChild;
                }
            }
        }
        //-----------------------------------------------------------
        public bool Exists(T value)
        {
            var currentNode = Root;
            if (Root == null) //om trädet är tomt
            {
                return false;
            }
            while (currentNode != null) //om trädet inte är tomt
            {
                if (currentNode.Data.CompareTo(value) == 0) //om trädet bara innehåller 1 och den är korrekt
                {
                    return true;
                }
                else if (currentNode.Data.CompareTo(value) > 0) //kolla vänster gren
                {
                    currentNode = currentNode.LeftChild; //gå igenom noder i grenen tills den hittas
                }
                else if (currentNode.Data.CompareTo(value) < 0) //eller kolla höger gren
                {
                    currentNode = currentNode.RightChild; 
                }
            }
            return false; // värdet hittades inte
        }
       
        //-----------------------------------------------------------
        private int count = 0;

        public int Count()
        {
            return count; //returnerar count från insert-metoden
        }

        //-----------------------------------------------------------
        //print-metod från läraren...

        public void Print()
        {
            Queue<Node<T>?> nodes = new Queue<Node<T>?>();
            Queue<Node<T>?> newNodes = new Queue<Node<T>?>();
            nodes.Enqueue(Root);
            int depth = 0;

            bool exitCondition = false;
            while (nodes.Count > 0 && !exitCondition)
            {
                depth++;
                newNodes = new Queue<Node<T>?>();

                string xs = "[";
                foreach (var maybeNode in nodes)
                {
                    string data = maybeNode == null ? " " : "" + maybeNode.Data;
                    if (maybeNode == null)
                    {
                        xs += "_, ";
                        newNodes.Enqueue(null);
                        newNodes.Enqueue(null);
                    }
                    else
                    {
                        Node<T> node = maybeNode;
                        string s = node.Data.ToString();
                        xs += s.Substring(0, Math.Min(4, s.Length)) + ", ";
                        if (node.LeftChild != null) newNodes.Enqueue(node.LeftChild);
                        else newNodes.Enqueue(null);
                        if (node.RightChild != null) newNodes.Enqueue(node.RightChild);
                        else newNodes.Enqueue(null);
                    }
                }
                xs = xs.Substring(0, xs.Length - 2) + "]";

                Console.WriteLine(xs);

                nodes = newNodes;
                exitCondition = true;
                foreach (var m in nodes)
                {
                    if (m != null) exitCondition = false;
                }
            }
        }
        //-----------------------------------------------------------
    }
}