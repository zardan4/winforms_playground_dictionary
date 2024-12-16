using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary
{
    public partial class Form1 : Form
    {
        private Repository repo;

        public Form1()
        {
            InitializeComponent();

            repo = new Repository();

            updateDictionary();
        }

        private void updateDictionary()
        {
            var dict = repo.GetAll();

            Dictionary.Items.Clear();
            foreach (var item in dict)
            {
                Dictionary.Items.Add($"{item.English} / {item.Ukrainian}");
            }
        }

        private void EditTranslation_Click(object sender, EventArgs e)
        {
            string Eng = EnglishTranslation.Text.Trim();
            string Ukr = UkrainianTranslation.Text.Trim();

            if (Eng.Length == 0 || Ukr.Length == 0)
            {
                MessageBox.Show("Enter valid data to add a translation!", "Validation error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            repo.PutTranslation(Eng, Ukr);
            updateDictionary();
        }

        private void Translate_Click(object sender, EventArgs e)
        {
            string input = ToTranslateInput.Text.Trim();

            if (input.Length == 0)
            {
                MessageBox.Show("Enter valid data to translate a word!", "Validation error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var translation = repo.GetTranslation(input);

            if (translation.English == "")
            {
                MessageBox.Show("No translation has been found!", "No matches",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fromLang = "en";

            if (translation.Ukrainian.ToLower() == input.ToLower())
            {
                fromLang = "uk";
            }

            if (fromLang == "en")
            {
                UserWord.Text = translation.English;
                OutputWord.Text = translation.Ukrainian;
            }
            else
            {
                UserWord.Text = translation.Ukrainian;
                OutputWord.Text = translation.English;
            }
        }
    }
}
