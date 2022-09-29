
void Exponentiate(int A, int B) 
{
    int currentA = A;
    for(int i = 1; i < B; i++) 
    {
        currentA = currentA * A;
    }
    Console.WriteLine(currentA);
}

Exponentiate(3, 5);
Exponentiate(2, 4);