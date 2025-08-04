System.Console.WriteLine("Nullable Types");

Nullable<bool> b = null;
int? i = null;
double? d = null;

System.Console.WriteLine(i);
System.Console.WriteLine(b);
System.Console.WriteLine(d);

int? a = null;
int ba = a ?? 0;

System.Console.WriteLine(ba);

if (a.HasValue)
{
    System.Console.WriteLine($"b = {a.Value}");
}
else
{
    System.Console.WriteLine("a não possui um valor (null)");
}