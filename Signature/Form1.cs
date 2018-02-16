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
        string fichierUnique;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //

            resetImage();
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
            //
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            // reset
            resetImage();
            // config
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Fichier html (*.html)|*.html|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            // ouverture
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fichierUnique = openFileDialog1.FileName;
            }
            // affichage
            metroTextBox_adresse_unique.Text = fichierUnique;
            // test
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(fichierUnique))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(metroTextBox_nom.Text))
                        {
                            pictureBox1.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_email.Text))
                        {
                            pictureBox3.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_telephone.Text))
                        {
                            pictureBox4.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_portable.Text))
                        {
                            pictureBox5.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_fonction.Text))
                        {
                            pictureBox6.Image = Signature.Properties.Resources.checkbox;
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception p)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(p.Message);
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(fichierUnique))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line.Contains(metroTextBox_nom.Text))
                        {
                            MessageBox.Show("OK");
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception p)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(p.Message);
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        void resetImage()
        {
            pictureBox1.Image = Signature.Properties.Resources.Warning;
            pictureBox2.Image = Signature.Properties.Resources.Warning;
            pictureBox3.Image = Signature.Properties.Resources.Warning;
            pictureBox4.Image = Signature.Properties.Resources.Warning;
            pictureBox5.Image = Signature.Properties.Resources.Warning;
            pictureBox6.Image = Signature.Properties.Resources.Warning;
            pictureBox7.Image = Signature.Properties.Resources.Warning;
            pictureBox8.Image = Signature.Properties.Resources.Warning;
            pictureBox9.Image = Signature.Properties.Resources.Warning;
            pictureBox10.Image = Signature.Properties.Resources.Warning;
            pictureBox11.Image = Signature.Properties.Resources.Warning;
        }
    }
}
