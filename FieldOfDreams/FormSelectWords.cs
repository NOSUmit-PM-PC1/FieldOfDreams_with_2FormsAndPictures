using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOfDreams
{
    public partial class FormSelectWords : Form
    {
        public FormSelectWords()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            FormGame windowGame = new FormGame();
            windowGame.Show();
        }
    }
}
