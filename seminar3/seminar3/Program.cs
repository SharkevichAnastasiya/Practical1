// напишете программу которая выдает четверти этой плоскости 
// 
/*
int GetQuadrat(int x, int y)
{
    int quadNum = 0;
    if(x > 0 && y > 0) quadNum = 1;
    else if(x < 0 && y > 0) quadNum = 2;
    else if(x < 0 && y < 0) quadNum = 3;
    else if(x > 0 && y < 0) quadNum = 4;

    return quadNum; 
}
*/
/*
int GetQuadrat(int x, int y)
{
    if(х > 0 && y > 0) return  1;
    if(х < 0 && y > 0) return  2;
    if(х < 0 && y < 0) return  3;
    if(х > 0 && y < 0) return  4;

    return quadNum; 
}
*/

/*Console.Write("Input a first coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());

int result = GetQuadrat(xA, yA);

if(result == 0) Console.WriteLine("Your point is on axes: ");
else Console.WriteLine($"Your point is on {result} quadrant");

*/


// Напишите программу ,которая по заданому номеру четверти показывает диапазон возможных координат 
// точек в этой четверти (х и у)     void


/*
void ShowCoordinate(int quadNum)
{
    if (quadNum <= 0 || quadNum > 4) Console.WriteLine("we are on the axes: ");
    else if (quadNum == 1) Console.WriteLine("x > 0, y > 0 ");
    else if (quadNum == 2) Console.WriteLine("x < 0, y > 0 ");
    else if (quadNum == 3) Console.WriteLine("x < 0, y < 0 ");
    else if (quadNum == 4) Console.WriteLine("x > 0, y < 0 "); 
}


Console.Write("Input a quad number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowCoordinate(num);
*/
//-----------------------------------------------------

// Напишите программу ,которая принимает на вход число (N) и выдает квадраты чисел от 1 до N  void

/*
void ShowN(int num)
{
    int current = 1;
    if(num <= 0) Console.WriteLine("Error num: ");
    else 
    {
        while (current <= num )
        {
        Console.Write(Math.Pow(current,2) + " ");
        current++;
        }
    }
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowN(num);
*/


// Напишите программу , которая принимает на вход координаты двух точек и находит растояние между ними в 2D
//

/*
double LenthPoint(double хA, double yA, double хB, double yB)
{
    double kat1 = хB - хA;
    double kat2 = yB - yA;
    double gip = Math.Sqrt(Math.Pow(kat1 ,2) + Math.Pow(kat2,2));
    return gip;
}
Console.Write("input хA:");
double хA = Convert.ToDouble(Console.ReadLine());
Console.Write("input хB:");
double хB = Convert.ToDouble(Console.ReadLine());
Console.Write("input yA:");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input yB:");
double yB = Convert.ToDouble(Console.ReadLine());

double result = LenthPoint(хA, yA, хB, yB);
Console.WriteLine(Math.Round(result, 2));

*/


