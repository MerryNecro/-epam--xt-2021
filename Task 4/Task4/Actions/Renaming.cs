using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions
{
    public class Renaming : FileAction
    {
        private string OldPath;
        private string NewPath;


        public Renaming(string oldPath, string newPath)
        {
            this.OldPath = oldPath;
            this.NewPath = newPath;

        }


        public override void Do() { }


        public override void RollBack() 
        {
            FileSystem.RenameFile(NewPath, OldPath);

            string str = OldPath;

            OldPath = NewPath;

            NewPath = str;
        }

        public override void RollUp()
        {
            RollUp();
        }
    }

}
