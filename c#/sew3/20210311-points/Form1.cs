﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

// Übung var4: Class Point, Textfile RW, Binaryfile RW, ArrayList,  
// IComparable, IComparer - Sortierung nach Abstand zum Referenzpunkt
// und nach PointID
// last update: 10.3.2021

namespace _20210311_points
{
    public partial class Form1 : Form
    {
        PointReader myPointReader;
        ReferencePointComparer myComparePoint;

        public Form1()
        {
            InitializeComponent();
            myPointReader = new PointReader();
            myComparePoint = new ReferencePointComparer(0, 0);
        }

        private void cmdSaveCoords_Click(object sender, EventArgs e)
        {
            myPointReader.AddPoint(System.Convert.ToDouble(txtXcoords.Text), System.Convert.ToDouble(txtYcoords.Text));
            txtXcoords.Text = ""; txtYcoords.Text = ""; txtXcoords.Focus();
        }

        private void cmdAusgabe_Click(object sender, EventArgs e)
        {
            foreach (Point p in myPointReader.PointList)
            {
                lboxcoords.Items.Add(System.Convert.ToDouble(p.Xcoord) + ";" + System.Convert.ToDouble(p.Ycoord));
            }
        }

        private void cmdClearLbox_Click(object sender, EventArgs e)
        {
            lboxcoords.Items.Clear();
        }

        private void cmdWriteCoords_Click(object sender, EventArgs e)
        {   //ggf. try-catch ergänzen
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (radioButtonText.Checked)
                    myPointReader.WriteToFile(saveFileDialog1.FileName);
                if (radioButtonBin.Checked)
                    myPointReader.WriteToFileBin(saveFileDialog1.FileName);
            }
        }

        private void cmdReadCoords_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            lboxcoords.Items.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   //ggf. try-catch ergänzen
                if (radioButtonText.Checked)
                    myPointReader.GetFromFile(openFileDialog1.FileName);
                if (radioButtonBin.Checked)
                    myPointReader.GetFromFileBin(openFileDialog1.FileName);
            }

            foreach (Point p in myPointReader.PointList)
            {
                lboxcoords.Items.Add(System.Convert.ToString(p.Xcoord) + ";" + System.Convert.ToString(p.Ycoord));
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Point key = new Point();
            try
            {
                if (radioButtonText.Checked)
                    key = myPointReader.GetPoint(System.Convert.ToInt32(txt_Index.Text));
                if (radioButtonBin.Checked)
                    key = myPointReader.GetPointBin(System.Convert.ToInt32(txt_Index.Text));
                MessageBox.Show(Convert.ToString(key.Xcoord) + " ; " + Convert.ToString(key.Ycoord));
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtXref.Text != "" && txtYref.Text != "")
                {
                    myComparePoint.X = Convert.ToDouble(txtXref.Text);
                    myComparePoint.Y = Convert.ToDouble(txtYref.Text);
                }

                // Nutzt IComparable und CompareTo()
                // Variante 1: ergänzen


                // Vergleich mit Referenzpunkt myComparePoint
                // Nutzt IComparer und Compare()

                // Variante 2: ergänzen

            }
            catch (ApplicationException ex)
            { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        } // Sort
    }
}