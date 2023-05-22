int x = 1;
int y = 0;

Console.WriteLine($"{1}");
for (var i = 0; i < 500; i++)
{
    i = x + y;
    y = x;
    x = i;
    Console.WriteLine($"{i}");
}