using System.Collections;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var collection = new ArrayList { 1, true, DateTime.Now };

//var evenNumbers = numbers.Where(x => x % 2 == 0);
//var blabla = numbers.Where(x => x % 2 == 0);
IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);   
numbers.Add(10);
numbers.Add(12);
numbers.Remove(4);

foreach (var n in evenNumbers)
{
    Console.Write($" {n}");
}