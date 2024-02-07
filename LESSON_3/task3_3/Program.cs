int n = 10;
int[] array = { 1, -4, 2, 5, -6, 2, 1, 5, -6, 8 };
int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
        i = i + 1;
    
}
