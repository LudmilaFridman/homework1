Console.Write("enter а=");
int a = int.Parse(Console.ReadLine());
Console.Write("enter b=");
int b = int.Parse(Console.ReadLine());
Console.Write("enter c=");
int c = int.Parse(Console.ReadLine());

int max =a;
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
Console.Write("max=");
Console.WriteLine(max);