// сумма чисел от 1 до А

/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
        sum += current;

    return sum;

}
Console.Write("Input a positive number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine($"Sum of elements form 1 to {a} is {result}");


*/
//-------------------------------
/*
int a;

do 
{
    Console.Write("Input a positive number: ");
    a = Convert.ToInt32(Console.ReadLine());
}
while(a < 0);
*/


// количество цифр в числе 

/*
int Digitount(int number)
{
    int count = 0;
    while (number != 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digids is: " + Digitount(num));
*/


//-------------------------------
//      2 
/*
int Factorial(int number)
{
    int result = 1;
            //for(int i = 1; i <= number; i++)
            //    result *= i;
            //return result;
    while(number > 1)
    {
        result *= number;
        number--;
    }
    return result;
}

Console.Write("Inter number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(numN));

*/


// 3 metod randomnoi generacii masiva


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of new array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
