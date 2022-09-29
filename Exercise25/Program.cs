// Используя определение степени числа, напишите цикл, 
// который принимает на вход два натуральных числа (A и B)
// и возводит число A в степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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