Console.WriteLine("Enter the first string: ");
string str1 = Console.ReadLine();

Console.WriteLine("Enter the second string: ");
string str2 = Console.ReadLine();

if (str1.Length > str2.Length)
{
    Console.Write(str1 + str2);
}
else if (str1.Length < str2.Length)
{
    Console.Write(str2 + str1[0]);
}
else
{
    Console.WriteLine("");
}