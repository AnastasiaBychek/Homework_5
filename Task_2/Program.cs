int [] FillArray()
{
    int [] array = new int [8];
    for (int i = 0; i< array.Length; i++)
    {
        array [i] =new Random().Next(1, 100);
    }

    return array;
}
int [] arr = FillArray();

void ShowArray(int [] array)
{
   for (int i = 0; i< array.Length; i++)
   {
    Console.Write($" {array[i]} ");
   } 
}
ShowArray(arr);

void SumElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i< array.Length; i++)
    {
      if (i%2 != 0)  
      {
        sum = sum + array[i];
      }
    }
    Console.WriteLine($" sum of elements {sum}");
}
SumElements(arr);