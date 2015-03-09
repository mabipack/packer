using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

using Microsoft.Win32;

namespace packer
{
    class MabiData
    {
        const string SubKeyPath = "Software\\Nexon\\Mabinogi";
        const string ExecutableName = "Mabinogi.exe";

        public static string GetMabiPath()
        {
            var reg = Registry.CurrentUser.OpenSubKey(SubKeyPath);
            var path = reg.GetValue("").ToString();

            if (!File.Exists(path + "\\" + ExecutableName))
            {
                if (!File.Exists(".\\" + ExecutableName))
                    return null;

                // return ".";
                return Directory.GetCurrentDirectory();
            }

            return path;
        }

        public static string GetCharName()
        {
            var reg = Registry.CurrentUser.OpenSubKey(SubKeyPath);
            
            return reg.GetValue("LastLoginChar").ToString();
        }
        public static string GetLastestPackagePath()
        {
            var files = Directory.EnumerateFiles(GetMabiPath() + "\\package");

            /* (\d+)_to_(\d+)\\.pack 
             * (\d+)_full.pack
             */
            string path = "";
            DateTime maxt = DateTime.FromFileTime(0);

            foreach (var f in files)
            {
                var ctime = File.GetCreationTime(f);

                if (maxt < ctime)
                {
                    maxt = ctime;
                    path = f;
                }
            }

            return path;
        }
    }
}
