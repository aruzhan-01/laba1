using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextEditor1502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //Создаем новое окно программы
            Form1 textEditorForm = new Form1();
            textEditorForm.Show();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //Вызываем функцию OpenTextFile
            OpenTextFile();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Вызываем функцию SaveTextToFile
            SaveTextToFile(richTextBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveTextToFile(string textToSave)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        writer.Write(textToSave);
                    }
                    //Вызываем окно с текстом
                    MessageBox.Show("Файл успешно сохранен!");
                }
                catch (Exception ex)
                {
                    //Вызываем окно с текстом
                    MessageBox.Show("Ошибка при сохранении файла" + ex.Message);
                }
            }
        }
        private void OpenTextFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text File|*.txt";
            openFileDialog1.Title = "Open Text File";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        richTextBox1.Text = reader.ReadToEnd();
                    }
                    //Вызываем окно с текстом
                    MessageBox.Show("Файл успешно открыт!");
                }
                catch (Exception ex)
                {
                    //Вызываем окно с текстом
                    MessageBox.Show("Ошибка при открытии файла" + ex.Message);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Закрываем приложение
            //Application.Exit();
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызываем окно с текстом
            MessageBox.Show("Программа разработана студенткой 3 курса группы АВТ-114 Кожахметовой Аружан");
        }

        private void вызовСправкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Создать-создаём файл\r\nОткрыть-открываем файл\r\nСохранить-сохраняем файл\r\nВыход-выход из программы\r\nОтменить-отмена\r\nПовторить-повтор\r\nВырезать-вырезаем\r\nКопировать-копируем\r\nВставить-вставляем\r\nУдалить-удаляем\r\nВыделить все-выделяем всё");
        }
        // Кнопка "Копировать"
        private void CopyButton_Click(object sender, EventArgs e)
        {
            //Вызываем функцию CopyAllText
            CopyAllText(richTextBox1);
        }

        private string previousText;
        //Функция коипрования текста
        private void CopyAllText(RichTextBox textBox)
        {
            //Храним последний текст
            previousText = textBox.Text;

            // Perform the copy operation
            //textBox.Copy();

            // Выбираем весь текст в текстовом поле
            textBox.SelectAll();

            // Копируем весь текст в буфер
            Clipboard.SetText(textBox.SelectedText);

            // Убираем выделение всего текста
            textBox.DeselectAll();
        }

        //Кнопка "Вырезать"
        private void button8_Click(object sender, EventArgs e)
        {
            //Вызываем функцию CutAllText
            CutAllText(richTextBox1);
        }
        //Функция вырезания текста
        private void CutAllText(RichTextBox textBox)
        {
            // Выбираем весь текст в текстовом поле
            textBox.SelectAll();

            // Вырезаем весь текст в буфер
            textBox.Cut();

            // Убираем выделение всего текста
            textBox.DeselectAll();
        }
        //Кнопка "Вставить"
        private void button7_Click(object sender, EventArgs e)
        {
            //Вызываем функцию PasteText
            PasteText(richTextBox1);
        }

        //Функция Вставки
        private void PasteText(RichTextBox textBox)
        {
            // Проверка на наличие текста
            if (Clipboard.ContainsText())
            {
                //Вставка текста
                textBox.Paste();



            }
        }


        private void UndoButton_Click(object sender, EventArgs e)
        {
            //отмена последнего действия 
            richTextBox1.Undo();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            //восстановление отменённого действия
            richTextBox1.Redo();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Очищает текстовое поле
            richTextBox1.Clear();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаем новое окно программы
            Form1 textEditorForm = new Form1();
            textEditorForm.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызываем функцию OpenTextFile
            OpenTextFile();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызываем функцию SaveTextToFile
            SaveTextToFile(richTextBox1.Text);
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //отмена последнего действия 
            richTextBox1.Undo();
        }

        private void повторитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //восстановление отменённого действия
            richTextBox1.Redo();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызываем функцию CutAllText
            CutAllText(richTextBox1);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызываем функцию CopyAllText
            CopyAllText(richTextBox1);
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void постановкаЗадачиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 textEditorForm3 = new Form3();
            textEditorForm3.Show();
        }

        private void грамматикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("В разработке");
        }

        private void классификацияГрамматикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("В разработке");
        }

        private void методАнализаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("В разработке");
        }

        private void диагностикаИНейтрализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("В разработке");
        }

        private void тестовыйПримерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("В разработке");
        }

        private void списокЛитературыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("В разработке");
        }

        private void исходныйКодПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("В разработке");
        }

        private void пускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox1.Text;
        }
    }
}
