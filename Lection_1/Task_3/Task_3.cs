using System.Linq;

int varr = 2;

int[] myArray = new int[10];

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Enter element value {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < myArray.Length; i++)
{
    myArray[i] = myArray[i] * varr; 
}

Console.WriteLine("");
Console.WriteLine(" Resolt: ");

for (int i = 0;i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}


