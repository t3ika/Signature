using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;

namespace Signature
{
    public partial class Form1 : MetroForm
    {
        string fichierNom;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        void keepsafe()
        {
            //string fileName = @"C:\mydir\myfile.ext";
            //StreamReader reader = new StreamReader(fileName);

            //List<string> listeElement = new List<string>();
            //while (!reader.EndOfStream)
            //{
            //    ligne = reader.ReadLine();
            //    listeElement.Add(ligne);
            //    if (ligne == "Autre")
            //    {
            //        reader.Close();
            //        MessageBox.Show(ligne);
            //        listeElement.Insert(listeElement.Count - 1, textBox3.Text);
            //        MessageBox.Show(ligne);
            //        StreamWriter writer = new StreamWriter(fileName);
            //        foreach (var item in listeElement)
            //        {
            //            writer.WriteLine(item);
            //        }
            //        writer.Close();
            //    }
            //}







            //Stream myStream = null;
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "Fichier html (*.html)|*.html|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;

            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        if ((myStream = openFileDialog1.OpenFile()) != null)
            //        {
            //            using (myStream)
            //            {
            //                // Insert code to read the stream here.
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            //    }
            //}
        }

        private void metroTile_openfolder_Click(object sender, EventArgs e)
        {
            //
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Fichier html (*.html)|*.html|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            //
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fichierNom = openFileDialog1.FileName;
            }
            //
            metroTextBox2.Text = fichierNom;

        }

        private void metroTile_valider_Click(object sender, EventArgs e)
        {

        }
    }
}
