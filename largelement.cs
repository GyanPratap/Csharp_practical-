int[] sourceArray =new int[] {10,1,48,12};
int maxElement=0;
for (int index = 0; index < sourceArray.Length; index++)
{
    if (sourceArray[index] > maxElement) {
        maxElement = sourceArray[index];
    }
        
}
System.Console.WriteLine(maxElement);