// See https://aka.ms/new-console-template for more information
int[] arr = new int[] { 10,20,30,22,9,15};
int sum = 0;


for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}
System.Console.WriteLine("sum of number present in array is:"+sum);

