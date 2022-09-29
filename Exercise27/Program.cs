
void showArray(int[] arr) 
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int getLength(int num) {
    int count = 0;
    while( num > 0) {
        num = num / 10;
        count+= 1;
    }
    return count;
}

void sumOfDigits(int number) 
{
    int lastDigit = number % 10;              
    
    int length = getLength(number);
    double result = 0;
    for(int i = 0; i <= length ; i++)
    {        
        result = result + (number % 10);
        number = number / 10;
    }
    Console.WriteLine(result);
}
sumOfDigits(452);
sumOfDigits(82);
sumOfDigits(9012);

