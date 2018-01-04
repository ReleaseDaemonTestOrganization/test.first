using Sitecore.Data.Items;
using System;
using System.Collections;
using System.Threading;

namespace test.first
{
  public class Class1
  {
    public void ShowMessage()
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Hello World!");
      Console.WriteLine("Hello World!");
      Console.WriteLine("Hello World!");
      Console.WriteLine("Hello World!");

      Thread.Sleep(1000);
      ICollection collection = new ArrayList();

      for (int i=0; i <= collection.Count; i++)
        Console.WriteLine("Hello World!"+ i.ToString());
    }
  }
}