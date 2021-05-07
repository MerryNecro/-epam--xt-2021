using Actions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    class CastomGit
    {
        private string path;

        private List<(DateTime, FileAction)> Log = new List <(DateTime, FileAction)>();

        public Dictionary<String, String> FilePastPath = new Dictionary<string, string>();

        private UserCommunication communicator = new UserCommunication();

        private DateTime LogTime;

        public CastomGit(string path)
        {
            this.path = path;
        }

        
        public void StartProgram()
        {
            string[] files = Directory.GetFiles(path, "*.txt");

            DateTime currentTime = DateTime.Now;

            string initialCommitPath = path + "\\" + currentTime.ToString("dd.MM.yyyy.HH.mm.ss");

            Directory.CreateDirectory(initialCommitPath);

            for (int i = 0; i< files.Length; i++)
            {
                String text = File.ReadAllText(files[i]);

                File.WriteAllText(initialCommitPath + files[i].Remove(0, path.Length), text);

                FilePastPath.Add(files[i], initialCommitPath + files[i].Remove(0, path.Length));
            }

            Tracking();

        }


        public void Tracking()
        {
            Console.WriteLine("Tracking...");

            using FileSystemWatcher fileWatcher = new FileSystemWatcher(path);

            fileWatcher.NotifyFilter = NotifyFilters.Attributes
                     | NotifyFilters.CreationTime
                     | NotifyFilters.DirectoryName
                     | NotifyFilters.FileName
                     | NotifyFilters.LastAccess
                     | NotifyFilters.LastWrite
                     | NotifyFilters.Size;

            fileWatcher.Changed += OnChanged;
            fileWatcher.Created += OnCreated;
            fileWatcher.Deleted += OnDeleted;
            fileWatcher.Renamed += OnRenamed;

            fileWatcher.Filter = "*.txt";
            fileWatcher.EnableRaisingEvents = true;

            communicator.PrintMenu();
            communicator.OpenMenu(this, Console.ReadLine());
        }


        #region TRACKMETHODS
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }

            FileAction change = new Change(path,e.FullPath, FilePastPath[e.FullPath]);

            change.Do();

            Log.Add((DateTime.Now, change));
        }


        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            FileAction create = new Creation(e.FullPath);

            FilePastPath.Add(e.FullPath, e.FullPath);

            Log.Add((DateTime.Now, create));
        }


        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            FileAction delet = new Deletion(e.FullPath, FilePastPath[e.FullPath]);

            Log.Add((DateTime.Now, delet));
        }


        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            FileAction rename = new Renaming(e.OldFullPath, e.FullPath);

            Log.Add((DateTime.Now, rename));
        }
        #endregion



        public void RollDown(DateTime time)
        {
            int i = Log.Count;
            while(time <= Log[i].Item1)
            {
                Log[i].Item2.RollBack();
                LogTime = Log[i].Item1;
                i--;
            }
        }


        public void RollUp(DateTime time)
        {
            int i = 0;

            while (LogTime != Log[i].Item1) i++;

            while (time >= Log[i].Item1)
            {
                Log[i].Item2.RollUp();
                i++;
            }
        }
    }
}
