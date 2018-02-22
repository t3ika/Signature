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
        string fichierSortie;
        string nNom, nDivers1, nDivers2, nDivers3, nDivers4, nDivers5, nFonction, nMail;
        List<string> listeElement = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            resetImage();
            changeCouleur();
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
            resetTexte();
            changeCouleur();
            // config
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Fichier html (*.html)|*.html|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            //openFileDialog1.ReadOnlyChecked = true;
            //openFileDialog1.ShowReadOnly = true;
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
                        else if (line.Contains(metroTextBox_divers1.Text))
                        {
                            pictureBox7.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers2.Text))
                        {
                            pictureBox8.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers3.Text))
                        {
                            pictureBox9.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers4.Text))
                        {
                            pictureBox10.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers5.Text))
                        {
                            pictureBox11.Image = Signature.Properties.Resources.checkbox;
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
            // preparation nom fichier
            fichierSortie = metroTextBox_nnom.Text.Replace(" ", ".");
            // copie fichier

            // creation tableau
            string[] valeurEntree = new string[] { metroTextBox_nom.Text, metroTextBox_email.Text, metroTextBox_telephone.Text, metroTextBox_portable.Text, metroTextBox_fonction.Text, metroTextBox_divers1.Text, metroTextBox_divers2.Text, metroTextBox_divers3.Text, metroTextBox_divers4.Text, metroTextBox_divers5.Text };
            string[] valeurSortie = new string[] { metroTextBox_nnom.Text, metroTextBox_nemail.Text, metroTextBox_ntelephone.Text, metroTextBox_nportable.Text, metroTextBox_nfonction.Text, metroTextBox_ndivers1.Text, metroTextBox_ndivers2.Text, metroTextBox_ndivers3.Text, metroTextBox_ndivers4.Text, metroTextBox_ndivers5.Text };
            //
            try
            {
                changeCaractere();
                // 
                //StreamReader reader = File.OpenText(fichierUnique);
                using (StreamReader reader = new StreamReader(fichierUnique))
                {
                    // 
                    while (!reader.EndOfStream)
                    {
                        string ligne = reader.ReadLine();
                        ligne = ligne.Replace(metroTextBox_divers1.Text, nDivers1).Replace(metroTextBox_nom.Text, nNom).Replace(metroTextBox_telephone.Text, metroTextBox_ntelephone.Text).Replace(metroTextBox_portable.Text, metroTextBox_nportable.Text).Replace(metroTextBox_email.Text, nMail).Replace(metroTextBox_fonction.Text, nFonction).Replace(metroTextBox_divers2.Text, nDivers2).Replace(metroTextBox_divers3.Text, nDivers3).Replace(metroTextBox_divers4.Text, nDivers4).Replace(metroTextBox_divers5.Text, nDivers5) ;
                        listeElement.Add(ligne);
                        StreamWriter writer = new StreamWriter(fichierSortie + ".html");
                        foreach (var item in listeElement)
                        {
                            writer.WriteLine(item);
                        }
                        writer.Close();
                    }


                }
                // couleur ok
                metroTile5.BackColor = Color.FromArgb(28,189,8);
                // vide la liste
                listeElement.Clear();
            }
            catch (Exception p)
            {
                // 
                MessageBox.Show("Le fichier ne peut pas être lu : " + p.Message);
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

        void resetTexte()
        {
            metroTextBox_nnom.Text = "";
            metroTextBox_nemail.Text = "";
            metroTextBox_ntelephone.Text = "";
            metroTextBox_nportable.Text = "";
            metroTextBox_nfonction.Text = "";
            metroTextBox_ndivers1.Text = "";
            metroTextBox_ndivers2.Text = "";
            metroTextBox_ndivers3.Text = "";
            metroTextBox_ndivers4.Text = "";
            metroTextBox_ndivers5.Text = "";
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            resetImage();

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
                        else if (line.Contains(metroTextBox_divers1.Text))
                        {
                            pictureBox7.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers2.Text))
                        {
                            pictureBox8.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers3.Text))
                        {
                            pictureBox9.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers4.Text))
                        {
                            pictureBox10.Image = Signature.Properties.Resources.checkbox;
                        }
                        else if (line.Contains(metroTextBox_divers5.Text))
                        {
                            pictureBox11.Image = Signature.Properties.Resources.checkbox;
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

        void changeCouleur()
        {
            metroTile5.BackColor = Color.Red;
        }

        private void metroTextBox_nnom_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_nemail_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_ntelephone_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_nportable_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_nfonction_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_ndivers1_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_ndivers2_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_ndivers3_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_ndivers4_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_ndivers5_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_nom_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_email_TabStopChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox_email_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_telephone_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_portable_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_fonction_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_divers1_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_divers2_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_divers3_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_divers4_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        private void metroTextBox_divers5_TextChanged(object sender, EventArgs e)
        {
            changeCouleur();
        }

        void changeCaractere()
        {
            nNom = metroTextBox_nnom.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");
            nMail = metroTextBox_nemail.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");
            nFonction = metroTextBox_nfonction.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");
            nDivers1 = metroTextBox_ndivers1.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");
            nDivers2 = metroTextBox_ndivers2.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");
            nDivers3 = metroTextBox_ndivers3.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");
            nDivers4 = metroTextBox_ndivers4.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");
            nDivers5 = metroTextBox_ndivers5.Text.Replace("é", "&eacute;").Replace("à", "&agrave;").Replace("è", "&egrave;").Replace("î", "&icirc;").Replace("ï", "&iuml;;").Replace("ô", "&ocirc;").Replace("ë", "&euml;").Replace("ç", "&ccedil;").Replace("ü", "&uuml;").Replace("û", "&ucirc;").Replace("â", "&acirc;").Replace("ê", "&ecirc;");

        }
    }
}
