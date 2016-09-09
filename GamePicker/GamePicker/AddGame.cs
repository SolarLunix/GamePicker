using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePicker
{
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addGameBtn_Click(object sender, EventArgs e)
        {
            List<String> platforms = thePlatforms();
            this.Close();
            
        }

        private List<String> thePlatforms()
        {
            List<String> platforms = new List<String>();
            if (this.pcGameCheck.Checked)
            {
                platforms.Add("PC");
            }

            if (this.xBox360GameCheck.Checked)
            {
                platforms.Add("Xbox360");
            }

            Console.WriteLine("\n\nPlatforms:");
            foreach(String plat in platforms)
            {
                Console.WriteLine("\t" + plat);
            }
            return platforms;
        }
    }
}
