using System;
using JsonParserCSharp;
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            System.Console.WriteLine(JsonFacade.ProvideJson("input.json"));
        }
    }
}
