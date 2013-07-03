using MusicGenerator.UIAbstraction;
using System;
using System.Windows.Forms;

namespace MusicGenerator
{
    public partial class Form1 : Form
    {
        UIAbstractionFacade uiAbstractionFacade;
        public Form1()
        {
            InitializeComponent();
            uiAbstractionFacade = new UIAbstractionFacadeFactory().getUIAbstractionFacade();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            uiAbstractionFacade.play();
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            uiAbstractionFacade.pause();
        }
    }
}
