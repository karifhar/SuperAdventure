using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player { get; set; } = new Player();
        private HealingPotion _healingPotion { get; set; }

        public SuperAdventure()
        {
            InitializeComponent();
            _player.CurrentHP = 100;
            _player.MaxHP = 100;
            _player.ExpriencePoints = 0;
            _player.Gold = 50;
            _player.Level = 1;
            lblHitPoints.Text = _player.CurrentHP.ToString();
            lblExperience.Text = _player.ExpriencePoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }
    }
}
