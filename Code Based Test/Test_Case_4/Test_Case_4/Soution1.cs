/*1. Write a program in C# Sharp to append some text to an existing file.
 * If file is not available, then create one.
   Hint: (Use the appropriate mode of operation. Use stream writer class)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

 

namespace Test_Case_4
{
    class Solution1
    {
        static void Main()
        {
            // file path
            string filePath = @"D:\TRAINING_ASSIGNMENTS\Code Based Test\Test_Case_4\TextFile.txt";
            // message to text file
            string textToAppend = "My name is Shreya Mishra";
            // for appending
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(textToAppend);
                writer.Close();
            }
            Console.WriteLine("Confirmation Message: Text has been appended to the file.");
            Console.ReadLine();
        }
    }



}
