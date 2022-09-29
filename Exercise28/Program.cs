
void showArray(int[] arr) 
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
};

void getSorted(int[] array) 
{
    int temp;
    for(int i = 1; i < array.Length; i++) 
    {
        for(int j = 0; j < i; j++)
        {
            if(Math.Abs(array[i]) < Math.Abs(array[j]))
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }   
    }
    showArray(array);
};

void sortSomeArray() 
{
    Random rnd = new Random();
    int length = 8;
    int[] randomDigits = new int[length];
    for(int i = 0; i < length; i++) 
    {
        randomDigits[i] = rnd.Next(-100, 100);
    }
    showArray(randomDigits);
    getSorted(randomDigits);
}

sortSomeArray();