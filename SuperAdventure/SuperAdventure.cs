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
        private Player _player { get; set; }
        private Location _currentLocation { get; set; }

        public SuperAdventure()
        {
            InitializeComponent();

            _currentLocation = new Location(new Guid("fd9d1483-d9b6-4753-8afe-14083d1dde87"),
                "Home", 
                "This is your sweet home :)");

            _player = new Player(100, 100, 50, 0, 1);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblExperience.Text = _player.ExpriencePoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
