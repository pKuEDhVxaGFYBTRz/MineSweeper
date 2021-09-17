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
        BackendGrid BGrid { get; set; }
        DisplayGrid DGrid { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void start_Click_1(object sender, EventArgs e)
        {
            
            // create the grids
            BGrid = new BackendGrid();
            DGrid = new DisplayGrid(gamePanel, BGrid, mainMenuPanel, gamePanel);
            
            // make the game visible
            mainMenuPanel.Visible = false;
            gamePanel.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("clicked grid");
        }

        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void makeMenuVisible()
        {
            gamePanel.Visible = false;
            mainMenuPanel.Visible = true;
        }
    }
}
