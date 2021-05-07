using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions
{
    public class Creation : FileAction
    {
        private string Path;

        public Creation(string path)
        {
            this.Path = path;
        }


        public override void Do() { }



        public override void RollBack()
        {
            File.Delete(Path);
        }


        public override void RollUp()
        {
            File.Create(Path);
        }
    }

}
