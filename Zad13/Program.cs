//Задача 13: Напишите программу, которая выводит третью цифру слева заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//3267912 -> 6

Console.Write("Введите числа : ");
int num = Convert.ToInt32(Console.ReadLine());

int index = 1;
int i = 0;               
int result = 0;

while (num > index)
{
    index = index * 10; 
    i++;                
}

if (i > 3)              
{
    while (i > 3)
    {
        num = num / 10;
        result = num % 10;
        i--;
    }
}
else if (i < 3)          
{
    Console.WriteLine("Нет третий цифры"); 
}
else                      
{
    result = num % 10;

}

Console.WriteLine($"Результат {result}");





