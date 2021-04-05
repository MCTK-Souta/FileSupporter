using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSupporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1.搬移檔案(MoveFile)\n 2.複製檔案(CopyFile)\n 3.讀取檔案(ReadFile)\n " +
                "4.刪除檔案(DeleteFile)\n 5.建立資料夾(CreatFolder)\n 6.刪除資料夾(DeleteFolder)");
            Console.WriteLine("請選擇輸入1~6進行:");
            
            int num = int.Parse(Console.ReadLine());
            string path ;
            string content ;
            string read;
            string alert;
            switch (num)
            {
                case 1:
                    Console.WriteLine("是否執行?(Y/N)");
                    alert = Console.ReadLine().ToLower();
                    if (alert=="y")
                    {
                        Console.WriteLine("輸入來源檔案路徑:");
                        path = Console.ReadLine();
                        Console.WriteLine("輸入目標資料夾路徑(含檔案名稱):");
                        content = Console.ReadLine();
                        FileConsole.Movefile(path, content);
                    }

                    break;

                case 2:
                    Console.WriteLine("是否執行?(Y/N)");
                    alert = Console.ReadLine().ToLower();
                    if (alert == "y")
                    {
                        Console.WriteLine("輸入來源檔案路徑:");
                        path = Console.ReadLine();
                        Console.WriteLine("輸入目標資料夾路徑(含檔案名稱):");
                        content = Console.ReadLine();
                        FileConsole.Copyfile(path, content);
                    }

                    break;

                case 3:
                    Console.WriteLine("是否執行?(Y/N)");
                    alert = Console.ReadLine().ToLower();
                    if (alert == "y")
                    {
                        Console.WriteLine("輸入目標檔案路徑:");
                        path = Console.ReadLine();
                        read = FileConsole.Readfile(path);
                        Console.WriteLine(read);
                        Console.Read();
                    }
                    break;

                case 4:
                    Console.WriteLine("是否執行?(Y/N)");
                    alert = Console.ReadLine().ToLower();
                    if (alert == "y")
                    {
                        Console.WriteLine("輸入目標檔案路徑:");
                        path = Console.ReadLine();
                        FileConsole.DeleteFile(path);
                        Console.Read();
                    }

                    break;

                case 5:
                    Console.WriteLine("是否執行?(Y/N)");
                    alert = Console.ReadLine().ToLower();
                    if (alert == "y")
                    {
                        Console.WriteLine("輸入目標資料夾路徑:");
                        path = Console.ReadLine();
                        FolderConsole.CreatFolder(path);
                        Console.ReadLine();
                    }

                    break;

                case 6:
                    Console.WriteLine("是否執行?(Y/N)");
                    alert = Console.ReadLine().ToLower();
                    if (alert == "y")
                    {
                        Console.WriteLine("輸入目標資料夾路徑:");
                        path = Console.ReadLine();
                        FolderConsole.DeleteFolder(path);
                        Console.ReadLine();  
                    }

                    break;
            }






        }
    }
}
