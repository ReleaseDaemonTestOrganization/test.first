using Sitecore.Data.Items;
using System;
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
    }
  }
}