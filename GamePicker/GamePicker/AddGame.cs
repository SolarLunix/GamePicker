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
            List<Boolean> platforms = thePlatforms();
            String gameName = this.gameNameInput.Text;
            Console.WriteLine(gameName);
            this.Close();
            
        }

        private List<Boolean> thePlatforms()
        {
            List<Boolean> platforms = new List<Boolean>();
            // Add all of the platforms' check boxes:
            platforms.Add(this.atari2600GameCheck.Checked);
            platforms.Add(this.atari5200GameCheck.Checked);
            platforms.Add(this.atariLynxGameCheck.Checked);
            platforms.Add(this.colecoVisionGameCheck.Checked);
            platforms.Add(this.colorTVGameGameCheck.Checked);
            platforms.Add(this.dreamcastGameCheck.Checked);
            platforms.Add(this.gameBoyAdvanceGameCheck.Checked);
            platforms.Add(this.gameBoyGameCheck.Checked);
            platforms.Add(this.gameCubeGameCheck.Checked);
            platforms.Add(this.intellivisionGameCheck.Checked);
            platforms.Add(this.magnavoxOdysseyGameCheck.Checked);
            platforms.Add(this.masterSystemGameCheck.Checked);
            platforms.Add(this.ngageGameCheck.Checked);
            platforms.Add(this.nintendo3DSGameCheck.Checked);
            platforms.Add(this.nintendo64GameCheck.Checked);
            platforms.Add(this.nintendoDSGameCheck.Checked);
            platforms.Add(this.nesGameCheck.Checked);
            platforms.Add(this.pcGameCheck.Checked);
            platforms.Add(this.philipsCDiGameCheck.Checked);
            platforms.Add(this.psGameCheck.Checked);
            platforms.Add(this.ps2GameCheck.Checked);
            platforms.Add(this.ps3GameCheck.Checked);
            platforms.Add(this.ps4GameCheck.Checked);
            platforms.Add(this.pspGameCheck.Checked);
            platforms.Add(this.psVitaGameCheck.Checked);
            platforms.Add(this.segaGameGearGameCheck.Checked);
            platforms.Add(this.segaGenesisGameCheck.Checked);
            platforms.Add(this.segaPicoGameCheck.Checked);
            platforms.Add(this.segaSaturnGameCheck.Checked);
            platforms.Add(this.snesGameCheck.Checked);
            platforms.Add(this.telstarGameCheck.Checked);
            platforms.Add(this.turbografx16GameCheck.Checked);
            platforms.Add(this.wiiGameCheck.Checked);
            platforms.Add(this.wiiUGameCheck.Checked);
            platforms.Add(this.xboxGameCheck.Checked);
            platforms.Add(this.xBox360GameCheck.Checked);
            platforms.Add(this.xboxOneGameCheck.Checked);

            return platforms;
        }
    }
}
