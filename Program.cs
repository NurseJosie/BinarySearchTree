using static BinarySearchTree.BST;

//BinarySearchTree bts = new BinarySearchTree();

//bool run = true;

//while (run)
//  {

//    Console.WriteLine("BINARY SEARCH TREE");
//    Console.WriteLine("1. Add a number");
//    Console.WriteLine("2. Search for a number");
//    Console.WriteLine("3. Count all objects in the tree");
//    Console.WriteLine("4. Exit");

//    Console.WriteLine("Enter your menu choice:");
//    int menuInput = Convert.ToInt32(Console.ReadLine());
//    switch (menuInput)
//    {
//        case 1:
//            Console.WriteLine("Enter a number to add i the Binary Tree:");
//            int inputNum = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Thanks");
//            BinarySearchTree.Insert(inputNum);
//            break;
//        case 2:
//            break;
//        case 3:
//            break;
//        case 4:
//            Console.WriteLine("Bye!");
//            run = false;
//            break;
//        default:
//            Console.WriteLine("Enter a number between 1-4.");
//            break;
//    }
//}

namespace BinarySearchTree
{
	public static class BST
	{
		public interface BST_G<T> where T : IComparable<T>
		{
			// Remember: the most efficient tree is a balanced tree. A balanced tree has the same (or as close as possible to) amount of nodes on the left as on the right.

			// Inserts a new value to the tree
			public void Insert(T value);
		
		// Returns true if an object that is equal to value exists in the tree
		// Uses the IComparable<T> interface. x.CompareTo(y) == 0
		public bool Exists(T value);
    

		// Returns the number of objects currently in the tree
		public int Count();
      
	}
	//public interface BST_VG<T> where T : IComparable<T>
	//{
	//	// Remove a value from the tree
	//	public void Remove(T value);

	//	// You need a method to balance the tree, whenever it is unbalanced. All methods that change the tree can cause it to become unbalanced.
	//	public void Balance();

	//	// Methods that you may find useful:
	//	// private int GetMaxDepth()
	//	// private int GetMinDepth()
	//}

	// add BST_VG if you are aiming for VG
	public class BinarySearchTree<T> : BST_G<T> where T : IComparable<T>
	{
		private Node<T>? Root = null;

            public int Count()
            {
                throw new NotImplementedException();
            }

            public bool Exists(T value)
            {
                throw new NotImplementedException();
            }

            // lägg till ett valfritt värde. om högre än parent- höger, om lägre- vänster. om lika värde som parent- vänster.
            public void Insert(T value)
		{
                Node<T> node = new Node<T>(value); //?

                if (Root == null) // om det inte finns ngt värde i trädet, gör value till root.
                {
                    Root = new Node<T>(value);
                }
                else if (Root.Data.CompareTo(value) > 0) //IComparable, om root > value. 
                {
                    node.LeftChild = new Node<T>(value);
                }
                else if (Root.Data.CompareTo(value) < 0)
                {
                    node.RightChild = new Node<T>(value);
                }

                //rekursivt?! :o

            }
	}

	// Returns true if an object that is equal to value exists in the tree
	// Uses the IComparable<T> interface. x.CompareTo(y) == 0
	public bool Exists(T value)
	{
            if (Root.Data == null)
            {
				return false;
            }
			else if(Root.Data == value)
            {
				return true;
            }
			else if(value.CompareTo(Root.data) < 0)
            {
				contains(value, ............................)
            }
	}

	// Returns the number of objects currently in the tree
	public int Count()
	{
		throw new NotImplementedException();
	}
}

	public class Node<T>
	{
		public T Data { get; set; }
		public Node<T>? LeftChild { get; set; }
		public Node<T>? RightChild { get; set; }

		public Node(T value)
		{
			LeftChild = null;
			RightChild = null;
			Data = value;
		}

		// A balanced tree should be as close as possible to equal amount of nodes on both sides
		// 0 is best, but +1 and -1 is ok.
		public int GetBalance()
		{
			int left = (LeftChild == null) ? 0 : LeftChild.GetBalance() + 1;
			int right = (RightChild == null) ? 0 : RightChild.GetBalance() + 1;
			return right - left;
		}
	}
}
}
