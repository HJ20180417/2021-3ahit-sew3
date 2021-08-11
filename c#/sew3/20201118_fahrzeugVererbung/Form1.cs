using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201118_fahrzeugVererbung
{
    public partial class Form1 : Form
    {
        Yacht yacht = new Yacht("Boot",true,false,0,0,"Yacht","Verbrennungsmotor");
        Ferrari ferrari = new Ferrari("Auto",true,false,0,4,0,"Ferrari","Verbrennungsmotor");
        Privatjet privatjet = new Privatjet("Flugzeug",true,false,12,0,"Privatjet","Düsenmotor");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnMotorAn_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "an";
            if (rbtFerrari.Checked)
            {
                ferrari.EngineRunning = true;
                ferrari.Speed = 0;
                rbtYacht.Enabled = false;
                rbtPrivatjet.Enabled = false;
                btnMotorAn.Enabled = false;

            }
            else if (rbtYacht.Checked)
            {
                yacht.EngineRunning = true;
                yacht.Speed = 0;
                rbtFerrari.Enabled = false;
                rbtPrivatjet.Enabled = false;
                btnMotorAn.Enabled = false;
            }
            else if (rbtPrivatjet.Checked)
            {
                privatjet.EngineRunning = true;
                privatjet.Speed = 0;
                rbtYacht.Enabled = false;
                rbtFerrari.Enabled = false;
                btnMotorAn.Enabled = false;
            }
        }

        private void btnMotorAus_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "aus";
            lblSpeed.Text = "0 km/h";
            if (rbtFerrari.Checked)
            {
                ferrari.EngineRunning = false;
                ferrari.Speed = 0;
                rbtPrivatjet.Enabled = true;
                rbtYacht.Enabled = true;
                btnMotorAn.Enabled = true;

            }
            else if (rbtYacht.Checked)
            {
                yacht.EngineRunning = false;
                yacht.Speed = 0;
                rbtPrivatjet.Enabled = true;
                rbtFerrari.Enabled = true;
                btnMotorAn.Enabled = true;
            }
            else if (rbtPrivatjet.Checked)
            {
                privatjet.EngineRunning = false;
                privatjet.Speed = 0;
                rbtFerrari.Enabled = true;
                rbtYacht.Enabled = true;
                btnMotorAn.Enabled = true;
            }
        }

        private void btnBeschleunigeUm_Click(object sender, EventArgs e)
        {
            int speedUpValue = Convert.ToInt32(txtSpeedUp.Text);
            int currentSpeed = 0;
            txtSpeedUp.Text = "";
            if (rbtFerrari.Checked)
            {
                if(ferrari.HasEngine && ferrari.EngineRunning)
                {
                    currentSpeed = ferrari.speedUp(speedUpValue);
                    lblSpeed.Text = currentSpeed.ToString() + " km/h";
                }
            }
            else if (rbtYacht.Checked)
            {
                if(yacht.HasEngine && yacht.EngineRunning)
                {
                    currentSpeed = yacht.speedUp(speedUpValue);
                    lblSpeed.Text = currentSpeed.ToString() + " km/h";
                }
            }
            else if (rbtPrivatjet.Checked)
            {
                if(privatjet.HasEngine && privatjet.EngineRunning)
                {
                    currentSpeed = privatjet.speedUp(speedUpValue);
                    lblSpeed.Text = currentSpeed.ToString() + " km/h";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (rbtFerrari.Checked)
            {
                MessageBox.Show(ferrari.Info());
            }
            else if (rbtYacht.Checked)
            {
                MessageBox.Show(yacht.Info());
            }
            else if (rbtPrivatjet.Checked)
            {
                MessageBox.Show(privatjet.Info());
            }
            else MessageBox.Show("Nothing checked!");
        }
    }
}
