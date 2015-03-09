using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

using MabinogiResource;

namespace packer
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();

            AllocConsole();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            var resources = PackResourceSet.CreateFromFile(
                "E:\\Nexon\\Mabinogi\\package\\808_to_811.pack");
            var items = resources.GetFileCount();

            var reg = Registry.CurrentUser.OpenSubKey("Software\\Nexon\\Mabinogi");

            listBox1.Items.Add(reg.GetValue("LastLoginChar"));
            

            
            listBox1.Items.Add( items.ToString() + " item(s) found" );
            for (uint i = 0; i < items; i++)
            {
                listBox1.Items.Add(resources.GetFileByIndex(i).GetName());
            }

            lbNickname.Text = MabiData.GetCharName();
            lbMabiPath.Text = MabiData.GetMabiPath();

            listBox1.Items.Add(MabiData.GetLastestPackagePath());

            var pack = PackResourceSet.CreateFromFile("서샷.pack");
            items = pack.GetFileCount();

            var newpack = new PackResourceSetCreater(1000, 1);


            for (uint i = 0; i < items; i++)
            {
                var p = pack.GetFileByIndex(i);
                listBox1.Items.Add(p.GetName());

                var size = p.GetSize();
                byte[] buffer = new byte[size];
                p.GetData(buffer);

                listBox1.Items.Add(p.GetVersion().ToString());

                var tempPath = Path.GetTempFileName();
                File.Delete(tempPath);
                var fp = new FileStream(
                    tempPath,
                    FileMode.CreateNew, FileAccess.ReadWrite, FileShare.Read,
                    512, FileOptions.None);
                fp.Write(buffer, 0, (int)size);
                fp.Close();

                newpack.AddFile("asdf.xml", tempPath);
                newpack.CreatePack("a.pack");

                
            }
             * */
            

            var ft = new List<Repacker.FileTag>();
            ft.Add(
                new Repacker.FileTag(
                    "data\\asdf.txt", "BroadCtrl.dll"));
            bool result = Repacker.Repack(
                "E:\\Nexon\\Mabinogi\\package\\816_to_817_3.pack",
                ft);
        }
    }
}
