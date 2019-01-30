using Shipwreck.Phash;
using Shipwreck.Phash.Bitmaps;
using System;
using System.Drawing;
using System.Linq;

namespace PerceptiveHash
{
    class Program
    {
        static void Main(string[] args)
        {
            var src = (Bitmap) Image.FromFile(PATH_TO_FIRST_IMAGE);
            var src2 = (Bitmap) Image.FromFile(PATH_TO_SECOND_IMAGE);
            
            int hammingDistance = CompareImages(src, src2);
            
            // small is better
            // 0 - equal
            // 40 - not equal
            Console.WriteLine(result);
        }

        public static int CompareImages(Bitmap src, Bitmap src2)
        
            return CalcHammingDistance(
                ImagePhash.ComputeDigest(src.ToLuminanceImage()).Coefficents,
                ImagePhash.ComputeDigest(src2.ToLuminanceImage()).Coefficents
        }

        private static int CalcHammingDistance(byte[] a, byte[] b)
        {
            return (a.Zip(b, (x, y) => x != y).Count(i => i));
        }
    }
}
