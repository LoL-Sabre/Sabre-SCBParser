using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabre_SCBParser
{
    class Program
    {
        static void Main(string[] args)
        {
            SCBFile s = new SCBFile("GhostBowl.SCB");
            Console.WriteLine("> Magic = " + s.header.Magic);
            Console.WriteLine("> Version = " + s.header.Major + "." + s.header.Minor);
            Console.WriteLine("> Name = " + s.header.Name);
            Console.WriteLine("> Number of Vertices = " + s.header.NumberOfVertices);
            Console.WriteLine("> Number of Faces = " + s.header.NumberOfFaces);
            Console.WriteLine("> Two = " + s.header.Two);
            Console.WriteLine("> Min = " + s.header.Min[0] + ", " + s.header.Min[1] + ", " + s.header.Min[2]);
            Console.WriteLine("> Max = " + s.header.Max[0] + ", " + s.header.Max[1] + ", " + s.header.Max[2]);
            Console.WriteLine("> Is Unknown Section Present = " + s.header.IsUnknownPresent);
            Console.WriteLine();
            foreach(var v in s.Vertices)
            {
                Console.WriteLine("> Vert = " + v.Position[0] + ", " + v.Position[1] + ", " + v.Position[2]);
            }
            foreach(var f in s.Faces)
            {
                Console.WriteLine();
                Console.WriteLine("> Indice = " + f.Indices[0] + ", " + f.Indices[1] + ", " + f.Indices[2]);
                Console.WriteLine("> MatName = " + f.Name);
                Console.WriteLine("> U = " + f.U[0] + ", " + f.U[1] + ", " + f.U[2]);
                Console.WriteLine("> V = " + f.V[0] + ", " + f.V[1] + ", " + f.V[2]);
            }
            Console.ReadLine();
        }
    }
}
