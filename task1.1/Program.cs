Console.Write("enter а=");
int a = int.Parse(Console.ReadLine());
Console.Write("enter b=");
int b = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;

if(a > b)
{   max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.Write("max=");
Console.WriteLine(max);
Console.Write("min=");
Console.WriteLine(min);