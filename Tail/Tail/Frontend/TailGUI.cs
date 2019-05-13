using FileSystemEmulator.Common.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TailFrontend.Tail.Backend;

namespace Tail.Frontend
{
    public partial class TailGUI : Form, IObserver
    {
        private FileReader Reader;
        public TailGUI()
        {
            InitializeComponent();
        }

        public void Update(Subject s, object obj)
        {
            if(s.Equals(Reader))
            {
                string str = (string)obj;
                TxtLines.AppendText(str + "\n");
            }
        }

        public OpenFileDialog InitOpenFileDialog()
        {
            OpenFileDialog res = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = "txt",
                Filter = "Text files|*." + "txt"

            };
            return res;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = InitOpenFileDialog();
            if(d.ShowDialog().Equals(DialogResult.OK))
            {
                Reader = new FileReader(d.FileName);
                Reader.AddObserver(this);
                new Thread(new ThreadStart(Reader.Run)).Start();
            }
        }
    }
}
