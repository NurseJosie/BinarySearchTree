using BinarySearchTree;

var bts = new BinarySearchTree<int>();
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("---------------------------BINARY SEARCH TREE--------------------------");
Console.WriteLine("-----------------------------------------------------------------------");
bts.Insert(50);
bts.Insert(61);
bts.Insert(5);
bts.Insert(8);
bts.Insert(97);
bts.Insert(31);
bts.Insert(99);
bts.Insert(10);
bts.Insert(2);
bts.Insert(41);
bts.Insert(7);
bts.Insert(12);
bts.Insert(43);
bts.Insert(29);
bts.Insert(9);
bts.Insert(1);
bts.Insert(6);
bts.Insert(23);
bts.Insert(12); //dubblett
bts.Insert(13);
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("Number of objects in tree: " + bts.Count()); //19
Console.WriteLine("-----------------------------------------------------------------------");
Console.WriteLine("Does number 99 exist? " + bts.Exists(99)); //true
Console.WriteLine("Does number 3 exist? " + bts.Exists(3)); //false
Console.WriteLine("-----------------------------------------------------------------------");

//•	Berätta om hur effektiv din lösning är
//Jag valde att lösa denna uppgift med iterationer då det var enklare för mig i nuläget. En större trygghet i att använda rekursion hade gett mig en kod som både varit enklare att läsa och snabbare att skriva. Rekursion hade inte nödvändigtvis påverkat tidskomplexiteten positivt. 

//•	Diskutera möjliga förbättringar, som hade kunnat påverka prestanda
//Rekursion för mindre och snyggare kod. Ett balanserat träd hade gett en bättre tidskomplexitet då sökvägarna blir kortare.  

//•	Analysera den med avseende på tids- och rymdskomplexitet. Använd "big O notation" och analysera utifrån worst case.
//o	Insert:
//  O(n) , linjär.
//o Exists:
//  O(n), linjär.
//o Count:
//  O(1), konstant.
//Eftersom mitt träd är obalanserat har den samma tidskomplexitet som en Linked list, O(n). Ett balanserat träd har i bästa fall O(log(n), vilket är något snabbare.
