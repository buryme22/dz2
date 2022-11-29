Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string strNum = Convert.ToString(num);
Console.WriteLine("Вторая цифра: "+strNum[1]);



Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(number);

if (text.Length > 2)
{
    Console.WriteLine("Третья цифра: "+text[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckDay (int day)
{   
    if (day == 6 || day == 7) {
    Console.WriteLine("Ура, выходной!");    
    }    

    else Console.WriteLine("Не выходной.");
}

CheckDay(day); 