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
           // richTextBox2.Text = richTextBox1.Text;
            string input = richTextBox1.Text;

            Dictionary<LexemeType, int> lexemeCodes = new Dictionary<LexemeType, int>()
{

{ LexemeType.Keyword2, 1 },
{ LexemeType.Delimiter, 13 },
{ LexemeType.Identifier, 3 },
{ LexemeType.DataType, 2 },
{ LexemeType.Equally, 6 },
{ LexemeType.Plus, 11 },
{ LexemeType.Minus, 12 },
{ LexemeType.Semicolon, 9 },
{ LexemeType.True, 4 }, 
{ LexemeType.False, 5 },
{ LexemeType.Number, 7 },
{ LexemeType.Invalid, 10 }
};


            string[] keyword2 = { "final" };
            string[] delimiters = { " " };
            string[] dataTypes = { "int" };
            string[] equallies = { "=" };
            string[] pluses = { "+" };
            string[] minuses = { "-" };
            string[] semicolones = { ";" };
            string[] trues = { "true" };
            string[] falses = { "false" };


            List<Lexeme> lexemes = new List<Lexeme>();

            int position = 0;
            while (position < input.Length)
            {
                bool found = false;

                //const
                foreach (string keyword in keyword2)
                {
                    if (input.Substring(position).StartsWith(keyword))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Keyword2], LexemeType.Keyword2, input, position, position + keyword.Length - 1));
                        position += keyword.Length;
                        found = true;
                        break;
                    }
                }

                if (found) continue;


                //data type
                foreach (string dataType in dataTypes)
                {
                    if (input.Substring(position).StartsWith(dataType))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.DataType], LexemeType.DataType, input, position, position + dataType.Length - 1));
                        position += dataType.Length;
                        found = true;
                        break;
                    }
                }

                if (found) continue;

                //=
                foreach (string op in equallies)
                {
                    if (input.Substring(position).StartsWith(op))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Equally], LexemeType.Equally, input, position, position + op.Length - 1));
                        position += op.Length;
                        found = true;
                        break;
                    }
                }

                if (found) continue;

                //+
               foreach (string op in pluses)
                {
                    if (input.Substring(position).StartsWith(op))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Equally], LexemeType.Plus, input, position, position + op.Length - 1));
                        position += op.Length;
                        found = true;
                        break;
                    }
                }

                if (found) continue;
                // true
                foreach (string op in trues)
                {
                    if (input.Substring(position).StartsWith(op))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.True], LexemeType.True, input, position, position + op.Length - 1));
                        position += op.Length;
                        found = true;
                        break;
                    }
                }
                // false
                foreach (string op in falses)
                {
                    if (input.Substring(position).StartsWith(op))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.False], LexemeType.False, input, position, position + op.Length - 1));
                        position += op.Length;
                        found = true;
                        break;
                    }
                }

                //-
                foreach (string op in minuses)
                {
                    if (input.Substring(position).StartsWith(op))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Equally], LexemeType.Minus, input, position, position + op.Length - 1));
                        position += op.Length;
                        found = true;
                        break;
                    }
                }
               
                if (found) continue;

                //;
                foreach (string op in semicolones)
                {
                    if (input.Substring(position).StartsWith(op))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Semicolon], LexemeType.Semicolon, input, position, position + op.Length - 1));
                        position += op.Length;
                        found = true;
                        break;
                    }
                }



                if (found) continue;

                //_
                foreach (string delimiter in delimiters)
                {
                    if (input.Substring(position).StartsWith(delimiter))
                    {
                        lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Delimiter], LexemeType.Delimiter, input, position, position + delimiter.Length - 1));
                        position += delimiter.Length;
                        found = true;
                        break;
                    }
                }
                if (found) continue;

                //name
                if (char.IsLetter(input[position]))
                {
                    int start = position;
                    while (position < input.Length && char.IsLetterOrDigit(input[position]))
                    {
                        position++;
                    }
                    string identifier = input.Substring(start, position - start);
                    lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Identifier], LexemeType.Identifier, input, start, position - 1));
                }
                //value
                else if (char.IsDigit(input[position]))
                {
                    int start = position;
                    while (position < input.Length && char.IsDigit(input[position]))
                    {
                        position++;
                    }
                    string number = input.Substring(start, position - start);
                    lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Number], LexemeType.Number, input, start, position - 1));
                }
                //error
                else
                {
                    string invalid = input[position].ToString();
                    lexemes.Add(new Lexeme(lexemeCodes[LexemeType.Invalid], LexemeType.Invalid, input, position, position));
                    position++;
                }
            }

            dataGridView1.Rows.Clear();
            foreach (Lexeme lexeme in lexemes)
            {
                dataGridView1.Rows.Add(lexeme.Code, lexeme.Type, lexeme.Token, lexeme.StartPosition, lexeme.EndPosition);
            }
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

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // ����� ����� �������� ��� ��� ����������� ������� ��� ����������� ������������
            MessageBox.Show(" �������-������ ����\r\n�������-��������� ����\r\n���������-��������� ����\r\n�����-����� �� ���������\r\n��������-������\r\n���������-������\r\n��������-��������\r\n����������-��������\r\n��������-���������\r\n�������-�������\r\n�������� ���-�������� ��");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // ����� ����� �������� ��� ��� ����������� ���������� � ���������
            MessageBox.Show("��������� ����������� ���������� 3 ����� ������ ���-114 ������������ ������");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}