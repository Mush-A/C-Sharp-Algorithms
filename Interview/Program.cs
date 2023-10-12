// See https://aka.ms/new-console-template for more information
using Interview.Sorting;

List<int> intList = new List<int> { 10, 2, 3, 4 };

var intSort = new Sort<int>(intList);

var sorted = intSort.BubbleSort().Print();

Console.WriteLine(sorted);