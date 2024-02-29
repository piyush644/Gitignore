using System;
namespace HelloWorld
{
public class Program
{
public static void Main(string[] args)
{
string input=Console.ReadLine();
long sum=0;
while(input!="ok"){
int t=0;
sum+=Convert.ToInt32(input);
input=Console.ReadLine();
}
Console.WriteLine(sum);
}
}
}