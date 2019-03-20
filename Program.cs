using Spine;
using System;

namespace BinaryToJson
{
    class Program
    {
        static void Main(string[] args) {
            if (args.Length < 1) {
                Console.WriteLine("Usage: Drag a binary Spine skeleton file onto this executable and this outputs a json-ified version");
                Console.ReadLine();
                return;
            }
            string fileName = args[0];
            Atlas atlas = new Atlas();

            var sb = new SkeletonBinary(atlas);
            sb.ReadSkeletonData(fileName);


            Console.ReadLine();
        }
    }
}
