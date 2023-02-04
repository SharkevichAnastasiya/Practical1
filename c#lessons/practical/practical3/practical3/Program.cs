// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндропом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*

Console.Write("Input a number: ");
string number = Console.ReadLine();

void PalindromNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Your number: {number} - palindrom.");
  }
  else Console.WriteLine($"Your number: {number} - is not palindrom.");
}

if (number.Length == 5)
{
  PalindromNumber(number);
}
else Console.WriteLine($"Your number is wrong: ");

*/


// Задача 2. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*

Console.WriteLine("Input your number: ");
int x1 = Coordinate("A", "x");
int y1 = Coordinate("A", "y");
int z1 = Coordinate("A", "z");
int x2 = Coordinate("B", "x");
int y2 = Coordinate("B", "y");
int z2 = Coordinate("B", "z");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"enter coordinates {coorName} . {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"segmentLength {segmentLength} ");

*/


// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*
void ShowCube(int num)
{
    int current = 1;
    if(num <= 0) Console.WriteLine("Error num: ");
    else 
    {
        while (current <= num )
        {
        Console.Write(Math.Pow(current,3) + " ");
        current++;
        }
    }
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowCube(num);
*/
