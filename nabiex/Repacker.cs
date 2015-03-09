using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

using MabinogiResource;

namespace packer
{
    class Repacker
    {
        public struct FileTag
        {
            public string original;
            public string unpacked;

            public FileTag(string original, string unpacked)
            {
                this.original = original;
                this.unpacked = unpacked;
            }
        };
        private class Unpacked
        {
            public List<FileTag> files = new List<FileTag>();

            public List<string> original = new List<string>();
            public List<string> unpacked = new List<string>();
        };

        /// <summary>
        /// 기존의 pack에 몇가지 파일을 넣고 다시 패킹함
        /// </summary>
        /// <param name="src">원본 팩</param>
        /// <param name="files">추가할 파일 경로들</param>
        public static bool Repack(
            string src,
            List<FileTag> files)
        {
            /*
            string srcTemp = src + ".tmp";
            File.Delete(srcTemp);
            File.Move(src, srcTemp);
            */

            var unpacked = UnpackAll(src);
            var pack = new PackResourceSetCreater(1000, 1);

            foreach (var ft in unpacked.files)
            {
                Console.WriteLine(ft.unpacked);
                if (!pack.AddFile(ft.original, ft.original))
                    return false;
            }
            /*
            foreach (var ft in files)
            {
                if (!pack.AddFile(ft.original, ft.unpacked))
                    return false;
            }*/

            /* TODO : 원래 팩 다 풀고 끼워넣고 다시 팩하지 않고
             *        처음부터 원래 팩에 append만 시키기
             */
            pack.CreatePack(src);

            return true;
        }

        private static Unpacked UnpackAll(string src)
        {
            var result = new Unpacked();
            var pack = PackResourceSet.CreateFromFile(src);
            var items = pack.GetFileCount();

            Console.WriteLine("{0} / {1} items", src, items);

            for (uint i = 0; i < items; i++)
            {
                var p = pack.GetFileByIndex(i);
                var size = p.GetSize();
                byte[] buffer = new byte[size];
                p.GetData(buffer);

                var tempPath = Path.GetTempFileName();
                File.Delete(tempPath);
                var fp = new FileStream(
                    tempPath,
                    FileMode.CreateNew, FileAccess.ReadWrite, FileShare.Read,
                    512, FileOptions.None);
                fp.Write(buffer, 0, (int)size);
                fp.Close();

                result.files.Add(
                    new FileTag(p.GetName(), tempPath));

                Console.WriteLine("{0} -> {1}", p.GetName(), tempPath);
            }

            pack.Close();
            
            return result;
        }
    }
}
