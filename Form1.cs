using Microsoft.VisualBasic.Devices;
using System;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextEditor1502
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var button = new System.Windows.Forms.Button { Location = new Point(10, 90), Text = "�������� ������ ������" };
            button.Click += button1_Click;
            Controls.Add(button);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 20);
            richTextBox2.Font = new Font(richTextBox2.Font.FontFamily, 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //������� ����� ���� ���������
            Form1 textEditorForm = new Form1();
            textEditorForm.Show();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            //�������� ������� OpenTextFile
            OpenTextFile();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //�������� ������� SaveTextToFile
            SaveTextToFile(richTextBox1.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            string[] keywords = { "if", "else", "while", "for", "switch", "case", "break", "default", "return" }; int start = richTextBox1.SelectionStart;
            foreach (string keyword in keywords)
            {
                int index = 0; while (index < richTextBox1.Text.Length)
                {
                    int startIndex = richTextBox1.Find(keyword, index, RichTextBoxFinds.WholeWord);
                    if (startIndex == -1)
                    {
                        break;
                    }
                    richTextBox1.SelectionStart = startIndex; richTextBox1.SelectionLength = keyword.Length;
                    richTextBox1.SelectionColor = Color.Blue; richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                    index = startIndex + keyword.Length;
                }
            }
            richTextBox1.SelectionStart = start;
            richTextBox1.SelectionColor = Color.Black;
        

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
                    //�������� ���� � �������
                    MessageBox.Show("���� ������� ��������!");
                }
                catch (Exception ex)
                {
                    //�������� ���� � �������
                    MessageBox.Show("������ ��� ���������� �����" + ex.Message);
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
                    //�������� ���� � �������
                    MessageBox.Show("���� ������� ������!");
                }
                catch (Exception ex)
                {
                    //�������� ���� � �������
                    MessageBox.Show("������ ��� �������� �����" + ex.Message);
                }
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //��������� ����������
            //Application.Exit();
            this.Close();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� ���� � �������
            MessageBox.Show("��������� ����������� ���������� 3 ����� ������ ���-114 ������������ ������");
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" �������-������ ����\r\n�������-��������� ����\r\n���������-��������� ����\r\n�����-����� �� ���������\r\n��������-������\r\n���������-������\r\n��������-��������\r\n����������-��������\r\n��������-���������\r\n�������-�������\r\n�������� ���-�������� ��");
        }
        // ������ "����������"
        private void CopyButton_Click(object sender, EventArgs e)
        {
            //�������� ������� CopyAllText
            CopyAllText(richTextBox1);
        }

        private string previousText;
        //������� ����������� ������
        private void CopyAllText(RichTextBox textBox)
        {
            //������ ��������� �����
            previousText = textBox.Text;

            // Perform the copy operation
            //textBox.Copy();

            // �������� ���� ����� � ��������� ����
            textBox.SelectAll();

            // �������� ���� ����� � �����
            Clipboard.SetText(textBox.SelectedText);

            // ������� ��������� ����� ������
            textBox.DeselectAll();
        }

        //������ "��������"
        private void button8_Click(object sender, EventArgs e)
        {
            //�������� ������� CutAllText
            CutAllText(richTextBox1);
        }
        //������� ��������� ������
        private void CutAllText(RichTextBox textBox)
        {
            // �������� ���� ����� � ��������� ����
            textBox.SelectAll();

            // �������� ���� ����� � �����
            textBox.Cut();

            // ������� ��������� ����� ������
            textBox.DeselectAll();
        }
        //������ "��������"
        private void button7_Click(object sender, EventArgs e)
        {
            //�������� ������� PasteText
            PasteText(richTextBox1);
        }

        //������� �������
        private void PasteText(RichTextBox textBox)
        {
            // �������� �� ������� ������
            if (Clipboard.ContainsText())
            {
                //������� ������
                textBox.Paste();



            }
        }



        private void UndoButton_Click(object sender, EventArgs e)
        {
            //������ ���������� �������� 
            richTextBox1.Undo();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            //�������������� ���������� ��������
            richTextBox1.Redo();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //������� ��������� ����
            richTextBox1.Clear();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //������� ����� ���� ���������
            Form1 textEditorForm = new Form1();
            textEditorForm.Show();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� ������� OpenTextFile
            OpenTextFile();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� ������� SaveTextToFile
            SaveTextToFile(richTextBox1.Text);
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //������ ���������� �������� 
            richTextBox1.Undo();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������������� ���������� ��������
            richTextBox1.Redo();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� ������� CutAllText
            CutAllText(richTextBox1);
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� ������� CopyAllText
            CopyAllText(richTextBox1);
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 textEditorForm3 = new Form3();
            textEditorForm3.Show();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("� ����������");
        }

        private void �����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("� ����������");
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("� ����������");
        }

        private void �������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("� ����������");
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("� ����������");
        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("� ����������");
        }

        private void ��������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            MessageBox.Show("� ����������");
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox1.Text;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // ��������� ������ ������, ��������������� �� ������� ���������� 
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            // ��������� ������� �����             
            {
                foreach (string file in files)
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line;
                        richTextBox1.Clear(); while ((line = sr.ReadLine()) != null)
                        {    // ������ � ����������� �������
                            richTextBox1.AppendText(line);
                        }
                    }
            }

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            // ��������, ��� ��������������� ����            
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            }

        }

        private void  richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}