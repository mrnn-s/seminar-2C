// Определить номер четверти плоскости,
// в которой находится точка с координатами Х и У, 
//причем X ≠ 0 и Y ≠ 0

Console.WriteLine("enter x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("enter y:");
int y = int.Parse(Console.ReadLine());
 
if ((x>0) && (y>0))
{
Console.WriteLine("1");
}
if ((x<0) && (y>0))
{
Console.WriteLine("2");
}
if ((x<0) && (y<0))
{
Console.WriteLine("3");
}
if ((x>0) && (y<0))
{
Console.WriteLine("4");
}
if ((x==0) && (y==0))
{
    Console.WriteLine(" wrong x no 0 and y no 0");
}