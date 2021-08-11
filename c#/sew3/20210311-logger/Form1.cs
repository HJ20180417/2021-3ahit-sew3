using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210311_logger
{
    public partial class Form1 : Form
    {
        private string logFilePath = @"X:\_repos\2021-3ahit-sew3-HJ20180417\c#\loggerFolder";
        private ClientClass client;
        public Form1()
        {
            InitializeComponent();
            client = new ClientClass();
        }

        private void btnSend_Click(object sender)
        {
            client.ProcessInfo("Text changed: " + txtMailInput.Text);
        }

        private void txtInput_TextChanged(object sender)
        {
            client.ProcessInfo("Text changed: " + txtMailInput.Text);
        }

        private void rbFileLog_Checked(object sender)
        {
            client.Logger = new FileLogger(logFilePath);
        }

        private void rbWindowLog_Checked(object sender)
        {
            client.Logger = new WindowLogger(this.logBox);
        }
    }
}
