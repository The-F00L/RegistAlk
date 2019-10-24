using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _ListBoxFeltolt();
        }

        private ArrayList hobbi_Lista = new ArrayList();

        private void _ListBoxFeltolt() {
            hobbi_Lista.Add("Uszas");
            hobbi_Lista.Add("Futas");
            hobbi_Lista.Add("Horgaszat");
            for (int i = 0; i < hobbi_Lista.Count; i++)
            {
                hobbi_ListBox.Items.AddRange(new object[] { hobbi_Lista[i] });
            }
        }

        private void Hozzad_Button_Click(object sender, EventArgs e)
        {
            hobbi_Lista.Add(ujhobbi_TextBox.Text);
            hobbi_ListBox.Items.Add(ujhobbi_TextBox.Text);
        }

        private void Mentes_Button_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt fajlok (*.txt)|*.txt|Osszes fajl (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "Mentes.txt";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());


                     writer.WriteLine(nev_TextBox.Text+";");
                     writer.WriteLine(szuldatum_TextBox.Text + ";");
                     writer.WriteLine(nem() + ";");
                     
                      for (int i = 0; i < hobbi_ListBox.Items.Count; i++)
                      {
                         writer.WriteLine(hobbi_ListBox.Items[i].ToString() + ";");
                      }
                      //writer.WriteLine("Valasztott");
                //writer.WriteLine(hobbi_ListBox.SelectedItem);

                writer.Dispose();
                writer.Close();

            }
        }
        private string nem() {
            if (fiu_radioButton.Checked == true)
            {
                return "fiu";
            }
            else if (lany_radioButton.Checked == true)
            {
                return "lany";
            }
            else {
                
                MessageBox.Show("donts mar el");
                return null;
            }
           // return null;
        }

        private void Betoltes_Button_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
               
                openFileDialog.Filter = "txt fajlok (*.txt)|*.txt|Osszes fajl (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            feltolt(fileContent);
       

        }
        private void feltolt(string content) {
            String[] _content = content.Split(';');
            nev_TextBox.Text = _content[0];
            szuldatum_TextBox.Text = _content[1];
            if (_content[2].Equals("lany"))
            {
                lany_radioButton.Checked = true;
            }
            else if (_content[2].Equals("fiu"))
            {
                fiu_radioButton.Checked = true;
            }
           
            for (int i = 0; i < hobbi_Lista.Count; i++)
            {
                hobbi_Lista.RemoveAt(i);
                
            }
            hobbi_ListBox.Items.Clear();
            //hiba
            ArrayList _hobbiLista = new ArrayList();
            for (int i = _content.Length; i <= 3; i--)
            {
                _hobbiLista[i]=_content[i];
            }

            for (int y = 0; y < _hobbiLista.Count; y++)
            {
                hobbi_Lista[y] = _hobbiLista[y];
                hobbi_ListBox.Items.Add(_hobbiLista[y]);
            }

        }

      

    }
}
