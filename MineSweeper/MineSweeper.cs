using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void start_Click_1(object sender, EventArgs e)
        {
        
            BackendGrid BGrid = new BackendGrid();
            DisplayGrid DGrid = new DisplayGrid();
            
            mainMenuPannel.Visible = false;
            gamePanel.Visible = false;

            MessageBox.Show("run game");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("clicked grid");
        }
    }
}
