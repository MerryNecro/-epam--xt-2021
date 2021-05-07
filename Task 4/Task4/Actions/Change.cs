using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions
{
    public class Change : FileAction
    {
        private string PreviousCommitPath;

        private string FilePath;

        private string Path;

        public DateTime dateTime { get; }

        public Change(string path, string filePath, string lastCommitPath)
        {
            this.Path = path;

            this.FilePath = filePath;

            this.PreviousCommitPath = lastCommitPath;

            this.dateTime = DateTime.Now;
        }


        public override void Do()
        {
            String text = File.ReadAllText(FilePath);

            Directory.CreateDirectory(Path + "\\" + dateTime.ToString("dd.MM.yyyy.HH.mm.ss"));

            File.WriteAllText(Path + "\\" + dateTime.ToString("dd.MM.yyyy.HH.mm.ss") + "\\" + FilePath.Remove(0, Path.Length), text);

        }


        public override void RollBack() {
            String text = File.ReadAllText(PreviousCommitPath);

            String textTwo = File.ReadAllText(FilePath);

            File.WriteAllText(FilePath, text);

            File.WriteAllText(PreviousCommitPath, textTwo);
        }


        public override void RollUp()
        {
            this.RollBack();
        }
    }

}
