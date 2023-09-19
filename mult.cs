int[] arr = new int[] { 10, 20, 30 };
int factor = 2;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i]*factor;
}
System.Console.WriteLine("after multiplication:-");   
for (int i = 0; i < arr.Length; i++)
{
    System.Console.WriteLine(arr[i]);
}
