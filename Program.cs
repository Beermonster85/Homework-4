// Напишите программу которая принимает на вход число А и выдает сумму чисел от 1 до А
// 7 ----> 28
// 4 ----> 10

Console.WriteLine("Введите любое число А");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = 0;

int GetSumNum()
{
    while (A > count)
    {
        count = count + 1;
        // count++;
        sum = sum + count;
        // sum+ = count;
    }
    return sum;
}

Console.WriteLine(GetSumNum());