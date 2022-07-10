double [] FillArray()
{
    double [] array = new double [5];
    for (int i = 0; i< array.Length; i++)
    {
        array [i] =new Random().Next(1, 100);
    }

    return array;
}
double [] arr = FillArray();

void ShowArray(double [] array)
{
   for (int i = 0; i< array.Length; i++)
   {
    Console.Write($" {array[i]} ");
   } 
}
ShowArray(arr);

void Difference(double [] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    for (int i = 1; i< array.Length; i++)
    {
        if(array[i]> maxNum)
        {
        maxNum = array[i];
        }
    if(array[i]< minNum)
        {
        minNum = array[i];
        }
    }
    double diff = maxNum - minNum;
    Console.WriteLine($" difference between Max and Min {diff}");
}
Difference(arr);
