using System;
using System.Linq;
using SharpKml.Dom;
using SharpKml.Engine;

namespace KMLMap
{
    class Program
    {
        static void Main(string[] args)
        {



            var file = KmzFile.Open(@"C:\Users\haraissia\Documents\Visual Studio 2013\Projects\PrivateChef\KMLMap\Untitled map.kmz");
            var map = file.GetDefaultKmlFile();
            if (map == null) return;
            foreach (var placemark in map.Root.Flatten().OfType<Placemark>())
            {
                     Console.WriteLine(placemark.Name);
                     Console.WriteLine(placemark.Id);
                     Console.WriteLine(placemark.Region);
            }

            Console.ReadLine();
        }
    }
}
