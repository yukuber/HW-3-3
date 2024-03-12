using System;
using HW_3_3.interfaces;

namespace HW_3_3.classes;

class Weeks: IPrinter
{
  void IPrinter.Print()        
  {
    foreach (weeks i in Enum.GetValues(typeof(weeks)))
    {
      Console.WriteLine(i);
    }      
    Console.WriteLine();
  }

  enum weeks {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}
}