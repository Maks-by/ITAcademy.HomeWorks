
using System;
using System.IO;
namespace Blanc_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"C:\Users\Максим\Desktop\DZ\DZ2\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
            imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"C:\Users\Максим\Desktop\DZ\DZ2\imaje.png", imageBytes);
            textReader.Dispose();
        }
    }
}
