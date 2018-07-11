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

namespace Jukebox_v2._0
{
    public partial class Jukebox : Form
    {
        public Jukebox()
        {
            InitializeComponent();
        }

        private void Jukebox_Load(object sender, EventArgs e)

        {
            string path = @"C:\Users\Chloe\Desktop\Jukebox ReSub\Jukebox_V2.0\songs.txt"; //path to read the songs from
            

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e) //opens the set up box
        {
            Set_up f1 = new Set_up();
            f1.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) //opens the about page
        {
            About f2 = new About();
            f2.ShowDialog();
        }

        private void Genre_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
