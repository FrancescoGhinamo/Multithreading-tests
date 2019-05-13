using FileSystemEmulator.Common.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailFrontend.Tail.Backend
{
    public class FileReader : Subject
    {
        private string Path;

        public FileReader(string p)
        {
            this.Path = p;
        }

        public void Run()
        {
            FileStream fStr = File.OpenRead(Path);
            StreamReader r = new StreamReader(fStr);
            while(true)
            {
                string line = r.ReadLine();
                if(!line.Equals(""))
                {
                    SetChanged();
                    NotifyObserves(line);
                }
            }
        }

    }
}
