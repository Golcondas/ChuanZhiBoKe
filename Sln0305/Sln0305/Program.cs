using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sln0305
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path1 = @"G:\ChuanZhiBoKe\Sln0305\Test\字符串1.exe";
                Console.WriteLine(path1);
                System.IO.File.Delete(path1);
                Console.WriteLine("删除成功!");

                string path = @"G:\ChuanZhiBoKe\Sln0305\Test\字符串2.exe";
                Console.WriteLine(path);
                System.IO.File.Delete(path);
                Console.WriteLine("删除成功!");
                
                string path2 = @"G:\ChuanZhiBoKe\Sln0305\Test\字符串3.exe";
                Console.WriteLine(path2);
                System.IO.File.Delete(path2);
                Console.WriteLine("删除成功!");
            }catch(Exception e)
            {
                Console.WriteLine("错误{0}堆栈{1}",e.ToString(),e.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
