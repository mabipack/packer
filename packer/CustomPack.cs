using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packer
{
    class CustomPack
    {
        private List<string> files;

        public static CustomPack Create()
        {
            var cp = new CustomPack();

            return cp;
        }
        public static CustomPack FromFile(string path)
        {
            var cp = new CustomPack();

            return cp;
        }

        CustomPack()
        {
            files = new List<string>();
        }

        private bool Open(string path)
        {


            return true;
        }
        public bool Pack(string path)
        {

            return true;
        }


    }
}
