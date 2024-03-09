// See https://aka.ms/new-console-template for more information
//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

//using System.Diagnostics.Metrics;

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14
Console.WriteLine("--------->Find sum of all elements in an array<---------");

Console.WriteLine("Enter 6 integers to fill the array!");

int[] numberArry = new int[6];
int i, sum = 0;

for (i = 0; i < 6; i++)
{
    Console.WriteLine("\n Enter integer no.{0}:", i);
    numberArry[i] = int.Parse(Console.ReadLine());
}

for (i = 0; i < 6; i++)
{
    if (numberArry[i] % 2 == 0)
    {
        sum += numberArry[i];
    }
    else
    {
        continue;
    }
}

Console.WriteLine("Sum of all the  even emelents in the array is: {0}", sum);
