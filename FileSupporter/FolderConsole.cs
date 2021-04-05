using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSupporter
{
    class FolderConsole
    {

        public static void CreatFolder(string path)
        {
            if(Directory.Exists(path))
            {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Directory.CreateDirectory(path);
            sw.Stop();
            Console.WriteLine($"{path}創建成功");
            Console.WriteLine("花費處理時間" + sw.ElapsedMilliseconds + "毫秒");
             Console.WriteLine("按一下結束");
            }
        }

        /*刪除資料夾(含其內檔案)*/
        public static void DeleteFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Console.WriteLine("找無該資料夾");
                return;
            }
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();//計算系統花費時間
            sw.Start();
            foreach (string d in Directory.GetFileSystemEntries(path))//刪除資料夾內的所有東西迴圈
            {
                if(File.Exists(d))
                {
                    File.Delete(d);//刪除資料夾內檔案
                }
                else
                {
                    Directory.Delete(d); //刪除子資料夾
                }
            }
            Directory.Delete(path);//刪除資料夾
            sw.Stop();
            Console.WriteLine("花費處理時間" + sw.ElapsedMilliseconds + "毫秒");
            Console.WriteLine($"成功刪除{path}");
            Console.WriteLine("按一下結束");
        }

    }
}
