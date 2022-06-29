using BinarySearchTree;
//------------------------------------------
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
//-----------------------------------------------

var bts = new BinarySearchTree<int>();

bts.Insert(50);
bts.Insert(41);
bts.Insert(5);
bts.Insert(8);
bts.Insert(97);
bts.Insert(8);
bts.Insert(99);
bts.Insert(10);
bts.Insert(2);
bts.Insert(41);
bts.Insert(5);
bts.Insert(12);
bts.Insert(43);
bts.Insert(29);
bts.Insert(9);
bts.Insert(3);

Console.WriteLine("Number of objects in tree: " + bts.Count()); //8
Console.WriteLine("Does number 99 exist? " + bts.Exists(99)); //true
Console.WriteLine("Does number 3 exist? " + bts.Exists(3)); //false
//Console.WriteLine("Balance of tree: " + bts.GetBalance()); // ligger i node.cs, behövs för G???
//bts.Print();  //stämmer?
//-----------------------------------------------