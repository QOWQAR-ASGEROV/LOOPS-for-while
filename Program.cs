// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

Console.WriteLine("Hello, World!");
#region TASK 1 (FOR LOOP)
//  for(int i=0; i<10; i++)
//    Console.WriteLine(i);
//}
#endregion

#region TASK 2(WHILE LOOP)
//int i= 0;
//while( i<10)
//{
//    Console.WriteLine(i);
//    i++;
//}
#endregion

#region task 3 (while loop bool serti)
//bool result = false;
//string choice = "Yes";
//while(choice=="Yes")
//{
//    Console.WriteLine("Dovr davam etsin");
//    choice = Console.ReadLine();
//}
#endregion
#region TASK3(DO WHILE)
//bool result = true;
//do
//{
//    Console.WriteLine("Salam sehvdir");
//} while (result);
#endregion
//EX 4;DO WHILE ,WHILE
int i = 0;
do
{
    int j = 1;

    while (j < 10)
    {
        Console.WriteLine("Elmeddin");
        j++;
    }

    Console.WriteLine("Esgerov");
    i++;
} while (i < 10);