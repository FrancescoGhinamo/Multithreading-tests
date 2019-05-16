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

        public async Task Run()
        {
            FileStream fStr = null;
            try
            {
                fStr = File.OpenRead(Path);
                StreamReader r = new StreamReader(fStr);
                await Task.Run(() =>
                {
                    while (true)
                    {
                        string line = r.ReadLine();
                        if (line != null)
                        {
                            SetChanged();
                            NotifyObserves(line);
                        }
                    }
                }); 
            }
            catch(Exception ) {}
            finally
            {
                if(fStr != null)
                {
                    fStr.Close();
                }
                
            }
            
        }

    }
}
