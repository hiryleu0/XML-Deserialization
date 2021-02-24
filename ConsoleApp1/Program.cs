using System;
using Library;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pas = LibraryProject.LibraryReader.ReadLibrary(@"..\..\..\File.xml",@"..\..\..\ClassLibrary\Schema.xsd",@"http://example.org/jk/ryllm");
            Console.WriteLine(pas);
        }
    }
}
