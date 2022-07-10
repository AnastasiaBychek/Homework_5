int [] FillArray()
{
    int [] array = new int [8];
    for (int i = 0; i< array.Length; i++)
    {
        array [i] =new Random().Next(100, 1000);
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

void CountEven(int [] array)
{
    int count = 0;
     for (int i = 0; i< array.Length; i++)
     if (array[i]%2 == 0)
     {
        count = count+1;
     }
Console.WriteLine($" number of even elements {count}");
}
CountEven(arr);