using Algorithms;

int[] arr = [5, 45, 3, 9, 25, 8, 45, 1, 0];
int[] arr2 = [0, 1, 3, 5, 8, 9, 25, 45];

var res = Search.BinarySearch(arr2, 45);

Console.WriteLine(res);
System.Threading.Thread.Sleep(1000);