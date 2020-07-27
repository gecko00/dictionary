using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Словарик
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dictionaryDataSet.WordsTable' table. You can move, or remove it, as needed.
            this.wordsTableTableAdapter.Fill(this.dictionaryDataSet.WordsTable);
            // TODO: This line of code loads data into the 'wordsdataDataSet.WordsTable' table. You can move, or remove it, as needed.
            this.wordsTableTableAdapter.Fill(this.dictionaryDataSet.WordsTable);

            
            // Подсчитывам количество слов в словаре. Каждое слово требует новую строку => считаем строки
            int numberOfWords = wordsdataGridView.RowCount - 1;
            // Кладем количество слов в лейбл внизу формы
            label_numberOfWords.Text += numberOfWords.ToString();

          
            //Добавляем в комбобоксы столько item'ов, сколько есть слов.
            for (int i = 0; i < numberOfWords; i++)
            {
                comboBoxEng.Items.Add(wordsdataGridView.Rows[i].Cells[1].Value);
                comboBoxRus.Items.Add(wordsdataGridView.Rows[i].Cells[2].Value);
            }
            comboBoxEng.SelectedIndex = 0;
        }

        public void btn_test_Click(object sender, EventArgs e)
        {
            // Прячем эту форму и открываем форму с тестом
                this.Hide();
                FormTest newForm = new FormTest(this);
                newForm.ShowDialog();
        }

        // Если в комбобоксе меняется элемент, кидаем новый текст в текстовые поля и меняем индекс выбранного элемента в другом комбобоксе, а также картинку в пикчербоксе
        private void comboBoxEng_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxEng.Text = wordsdataGridView.Rows[comboBoxEng.SelectedIndex].Cells[3].Value.ToString();
            textBoxRus.Text = wordsdataGridView.Rows[comboBoxEng.SelectedIndex].Cells[4].Value.ToString();
            comboBoxRus.SelectedIndex = comboBoxEng.SelectedIndex;
            
            pictureBox1.ImageLocation = "Images\\" + wordsdataGridView.Rows[comboBoxEng.SelectedIndex].Cells[5].Value + ".jpg";
        }

        private void comboBoxRus_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEng.SelectedIndex = comboBoxRus.SelectedIndex;
        }



        
    }
}
    