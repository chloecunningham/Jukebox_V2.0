using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string[,] songs = new string[,]
         {
            {"Parody", "Ducked_up_Lips - KOA", "Fallen_Kingdom - TryHardNinja", "Kim_Jong_Style - KOA", "On_the_Down_Low - KOA"},
            {"Pop", "If_I_Had_You - Adam Lambert", "Shut_Up - Kelly Clarkson", "Sleep_Walker - Adam Lambert", "Whataya_Want_From_Me - Adam Lambert"},
            {"Punk", "American_Idiot - Green Day", "Burnout - Green Day", "Give_Me_Novacaine - Green Day", "Welcome_To_Paradise - Green Day"},
            {"Rock", "Cut_the_Cord - Shinedown", "Miracle - Shinedown", "Nowhere_Kids - Shinedown", "Second_Chance - Shinedown"},
         };
            Genre_Textbox.Text = (songs[0, 0]);
            Genre_Listbox.Items.Add(songs[0, 1
                ]);
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
