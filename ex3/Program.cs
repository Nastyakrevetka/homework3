
int FindCube(string str)
{
Console.Write(str);
int N = int.Parse(Console.ReadLine());
int min=1;
while (min<(N+1))
{
    int sqr= min*min*min;
    Console.WriteLine(sqr);
    min++;
}
return N;
}
int N= FindCube("Введите N: ");