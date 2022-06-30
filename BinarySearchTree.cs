
namespace BinarySearchTree
{
    public class BinarySearchTree<T> : BST_G<T> where T : IComparable<T>
    {
        private Node<T>? Root = null; // skapa en Root av ett nod-objekt

        //-----------------------------------------------------------
        public void Insert(T value)
        {
            if (Exists(value)) return; //för att undvika dubletter

            if (Root == null) // om det inte finns ngt värde i trädet, gör value till root.
            {
                Root = new Node<T>(value);
                count++; //addera nytt nod-objekt till Count-metoden att returnera
                return;
            }
            var currentNode = Root; //för att kolla de andra noderna
            while (true) //kolla tills tom plats är hittad
            {
                if (currentNode.Data.CompareTo(value) > 0) // mindre än parent, lägg till vänster
                {
                    
                    if (currentNode.LeftChild == null) //kolla om man kommit till en tom nod
                    {
                        currentNode.LeftChild = new Node<T>(value); //skapa ny nod
                        count++;
                        Console.WriteLine(value + " added!");
                        Console.WriteLine("Current balance: " + Root.GetBalance()); // visa trädets balans
                        return;
                    }
                    currentNode = currentNode.LeftChild; //vandra vidare
                }
                else if (currentNode.Data.CompareTo(value) < 0) // högre än parent, lägg till höger
                {
                    if (currentNode.RightChild == null)
                    {
                        currentNode.RightChild = new Node<T>(value);
                        count++;
                        Console.WriteLine(value + " added!");
                        Console.WriteLine("Current balance: " + Root.GetBalance()); // visa trädets balans
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
    }
}