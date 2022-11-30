// Task19
// 
// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
int number = 12321; // Возникла проблема с математическими операциями, результат получается правильным только в случае чисел, содержащих цифры до 4,
                    // если ввести число 45654, выдаст "Данное число не является полиндромом" (при делении происходит округление по законам математики),
                    // думаю проблема с конвертацией типов данных, использующихся в мат. операциях. Помогите, пожалуйста!

int First = Convert.ToInt32(number/Math.Pow(10, 4));
int Second = Convert.ToInt32(number%10);
int Third1 = Convert.ToInt32(number/Math.Pow(10, 3)); 
int Third2 = Convert.ToInt32(number/Math.Pow(10, 4));
int Third3 = Third2*10;
int Third = Third1 - Third3;
int Fourth = Convert.ToInt32(number%100/10);
Console.WriteLine(First);
Console.WriteLine(Second);
Console.WriteLine(Third);
Console.WriteLine(Fourth);


if (First == Second & Third == Fourth)
{
    Console.WriteLine("Данное число является полиндромом");
}
else
{
    Console.WriteLine("Данное число не является полиндромом");
}

//второй способ

Console.WriteLine("Введите пятизначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];
int i = 0;
while (i<=4)
{
    array[i] = number1%10;
    Console.WriteLine($"элемент {i} = {array[i]}");
    number1 = number1/10;
    i++;
}
if (array[0] == array[4])
{
    if (array[1] == array[3])
    {
        Console.WriteLine("Данное число является полиндромом");
    }
    else
    {
        Console.WriteLine("Данное число не является полиндромом");
    }
}
else
{
    Console.WriteLine("Данное число не является полиндромом");
}

//Task21


int[] A = new int[3];

int[] B = new int[3];

Console.WriteLine("Введите координату x первой точки");
A[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
B[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
A[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
B[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
A[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
B[2] = Convert.ToInt32(Console.ReadLine());

int d = Convert.ToInt32(Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2)));
Console.WriteLine("Расстояние между двумя точками = " + d);

// Task 23

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int j = 1;
while (j<N)
{
    Console.WriteLine(Math.Pow(j, 3));
    j++;
}