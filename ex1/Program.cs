int Palindrom (string str)
{
Console.Write(str);
int numb = int.Parse(Console.ReadLine());
int revers =0;
while (numb>0)
{
    revers= revers*10+ numb%10;
    numb= numb/10;
}
return revers;
}
Console.WriteLine("Введите число: ");
int Numb = int.Parse(Console.ReadLine());
int ReversNumb= Palindrom("введите число повторно, пожалуйста: ");
Console.WriteLine(ReversNumb);
if (Numb == ReversNumb)
{Console.Write("число палиндром");}
else 
{Console.Write("число не полиндром");}