using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSupporter
{
    class FileConsole
    {
        public static void Movefile(string path, string content)
        {
            if (!File.Exists(path))
            { 
                Console.WriteLine($"{path} 來源檔案不存在");
                Console.ReadLine();
                return;
            }


            if (File.Exists(content))
            {
                Console.WriteLine($"{content} 目標路徑檔案已存在");
                Console.ReadLine();
                return;
            }
            else
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                File.Move(path, content);
                sw.Stop();
                Console.WriteLine($"成功搬運至{content}");
                Console.WriteLine("花費處理時間" + sw.ElapsedMilliseconds+"毫秒");
                Console.WriteLine("按一下結束");
            }

        }

        public static void Copyfile(string path,string content)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} 來源檔案不存在");
                Console.ReadLine();
                return;
            }

            if (File.Exists(content))
            {
                Console.WriteLine($"{content} 目標路徑檔案已存在");
                Console.ReadLine();
                return;
            }
            else
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                File.Copy(path, content); ;
                sw.Stop();
                Console.WriteLine($"成功自{path}複製至{content}");
                Console.WriteLine("花費處理時間" + sw.ElapsedMilliseconds + "毫秒");
                Console.WriteLine("按一下結束");
            }
            
        }

        public static string Readfile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} 檔案不存在");
                Console.ReadLine();
                return string.Empty;
            }
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            string content = File.ReadAllText(path);
            sw.Stop();
            Console.WriteLine("花費處理時間" + sw.ElapsedMilliseconds + "毫秒");
            Console.WriteLine($"成功讀取 {path} \n\n內容:");
            return content+"\n\n按一下結束";

        }

        public static void DeleteFile(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine($"{path} 檔案不存在");
                Console.ReadLine();
                return;
            }
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            File.Delete(path);
            sw.Stop();
            Console.WriteLine("花費處理時間" + sw.ElapsedMilliseconds + "毫秒");
            Console.WriteLine($"{path}刪除成功");
            Console.WriteLine("按一下結束");
        }

    }
}
