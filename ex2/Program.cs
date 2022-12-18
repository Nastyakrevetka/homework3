Console.Clear();
  int DataEntryXY(string str)
  {
  Console.WriteLine(str);
  int number = int.Parse(Console.ReadLine());
  return number;
   }
    void FindLong (int x1,int y1, int z1, int x2, int y2, int z2)
    {   double longline = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
      Console.WriteLine($"Расстояние между точками= {longline}");}

  int x1= DataEntryXY("Введите координаты x1");
    int y1= DataEntryXY("Введите координаты y1");
    int z1= DataEntryXY("Введите координаты z1");
    int x2= DataEntryXY("Введите координаты x2");
    int y2= DataEntryXY("Введите координаты y2");
    int z2= DataEntryXY("Введите координаты z2");
FindLong(x1,y1,z1,x2,y2,z2);
