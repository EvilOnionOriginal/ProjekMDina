using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Data.SqlClient;

namespace ProjekMDina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlCommand comm;
        public SqlConnection con;
        DataSet

        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (var open = new FolderBrowserDialog()) 
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    
                    filePath = open.SelectedPath;

                    MettadataGet mettadata = new MettadataGet();

                    foreach (string dirPath in Directory.GetDirectories(filePath))
                    {
                        mettadata.DoStuff(filePath);
                    }

                }
            }

            
        }

        public void ConnectToDB()
        { 
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }
    }
}

