using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210506_delegates
{
    public partial class Form1 : Form
    {
        public delegate string PersonHandler(string name);
        Person p1 = new Person("Hans");
        PersonHandler personHandler;
        bool connected = false;
        bool connected2 = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void callMethod_Click(object sender, EventArgs e)
        {
            if (personHandler == null)
            {
                lblGeburtstag.Text = "Niemand wollte zum Geburtstag gratulieren";
                lblMuttertag.Text = "Niemand wollte zum Muttertag gratulieren";
            }
            else
            {
                if (connected == true && connected2 == true)
                {
                    MessageBox.Show("Alles gute zum Geburtstag, wünscht dir " + p1.Name);
                    MessageBox.Show("Alles gute zum Muttertag, wünscht dir " + p1.Name);
                }
                if(connected == true && connected2 == false)
                {
                    lblGeburtstag.Text = personHandler(p1.Name);
                    lblMuttertag.Text = "Niemand wollte zum Muttertag gratulieren";
                }
                if(connected == false && connected2 == true)
                {
                    lblMuttertag.Text = personHandler(p1.Name);
                    lblGeburtstag.Text = "Niemand wollte zum Geburtstag gratulieren";
                }
            }
        }

        private void ckbConnect_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbConnect.Checked)
            {
                personHandler += p1.ZumGeburtstag;
                connected = true;
            }
            if (!ckbConnect.Checked)
            {
                personHandler -= p1.ZumGeburtstag;
                connected = false;
            }
        }

        private void ckbMuttertag_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMuttertag.Checked)
            {
                personHandler += p1.ZumMuttertag;
                connected2 = true;
            }
            if (!ckbMuttertag.Checked)
            {
                personHandler -= p1.ZumMuttertag;
                connected2 = false;
            }
        }
    }
}
