using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions
{
    public class Deletion : FileAction
    {
        private string PreviousPath;
        private string Path;


        public Deletion(string path, string previousPath)
        {
            this.Path = path;

            this.PreviousPath = previousPath;
        }


        public override void Do()
        {

        }


        public override void RollBack() 
        {
            File.WriteAllText(Path, File.ReadAllText(PreviousPath));
            
        }


        public override void RollUp()
        {
            File.Delete(Path);
        }

    }
}
