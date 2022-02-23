// Decompiled with JetBrains decompiler
// Type: lesson7.Program
// Assembly: lesson7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7F7D3994-9C28-4582-BA6C-9AA61B3AD164
// Assembly location: C:\Users\Core_i5\source\repos\lesson7\lesson7\bin\Debug\lesson7.exe

using System;

namespace lesson7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Hello, buddy, enter your password to login!");
      if (Console.ReadLine() == "peaceful")
        Console.WriteLine("Come in! I'm glad to see you!");
      else
        Console.WriteLine("Step back, you look like mafia!");
      Console.ReadLine();
        }
      
  }
}
