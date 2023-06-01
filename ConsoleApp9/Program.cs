int[] mas = new int[10];
Random rnd = new Random();
int temp = 0;
for (int i = 0; i <10; i++)
{
    mas[i] = rnd.Next(1, 100); 
    Console.Write(mas[i] + " ");
    if (mas[i] % 2 == 0)
        temp++;
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве: "+ temp);
