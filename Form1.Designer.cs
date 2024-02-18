namespace TextEditor1502
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SaveButton = new Button();
            CopyButton = new Button();
            RedoButton = new Button();
            UndoButton = new Button();
            button7 = new Button();
            button8 = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            создатьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            правкаToolStripMenuItem = new ToolStripMenuItem();
            отменитьToolStripMenuItem = new ToolStripMenuItem();
            повторитьToolStripMenuItem = new ToolStripMenuItem();
            вырезатьToolStripMenuItem = new ToolStripMenuItem();
            копироватьToolStripMenuItem = new ToolStripMenuItem();
            вставитьToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            выделитьВсеToolStripMenuItem = new ToolStripMenuItem();
            текстToolStripMenuItem = new ToolStripMenuItem();
            постановкаЗадачиToolStripMenuItem = new ToolStripMenuItem();
            грамматикаToolStripMenuItem = new ToolStripMenuItem();
            классификацияГрамматикиToolStripMenuItem = new ToolStripMenuItem();
            методАнализаToolStripMenuItem = new ToolStripMenuItem();
            диагностикаИНейтрализацияToolStripMenuItem = new ToolStripMenuItem();
            тестовыйПримерToolStripMenuItem = new ToolStripMenuItem();
            списокЛитературыToolStripMenuItem = new ToolStripMenuItem();
            исходныйКодПрограммыToolStripMenuItem = new ToolStripMenuItem();
            пускToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            вызовСправкиToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            CreateButton = new Button();
            OpenButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Image = (Image)resources.GetObject("SaveButton.Image");
            SaveButton.Location = new Point(175, 38);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(74, 57);
            SaveButton.TabIndex = 2;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.Image = (Image)resources.GetObject("CopyButton.Image");
            CopyButton.Location = new Point(529, 38);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(83, 57);
            CopyButton.TabIndex = 5;
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.Click += CopyButton_Click;
            // 
            // RedoButton
            // 
            RedoButton.Image = (Image)resources.GetObject("RedoButton.Image");
            RedoButton.Location = new Point(458, 38);
            RedoButton.Name = "RedoButton";
            RedoButton.Size = new Size(65, 57);
            RedoButton.TabIndex = 4;
            RedoButton.UseVisualStyleBackColor = true;
            RedoButton.Click += RedoButton_Click;
            // 
            // UndoButton
            // 
            UndoButton.Image = (Image)resources.GetObject("UndoButton.Image");
            UndoButton.Location = new Point(374, 38);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(78, 57);
            UndoButton.TabIndex = 3;
            UndoButton.UseVisualStyleBackColor = true;
            UndoButton.Click += UndoButton_Click;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(695, 38);
            button7.Name = "button7";
            button7.Size = new Size(68, 57);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(618, 38);
            button8.Name = "button8";
            button8.Size = new Size(71, 57);
            button8.TabIndex = 6;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, правкаToolStripMenuItem, текстToolStripMenuItem, пускToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(973, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьToolStripMenuItem, открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            создатьToolStripMenuItem.Size = new Size(157, 22);
            создатьToolStripMenuItem.Text = "Создать";
            создатьToolStripMenuItem.Click += создатьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(157, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(157, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(157, 22);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как ";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(157, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // правкаToolStripMenuItem
            // 
            правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отменитьToolStripMenuItem, повторитьToolStripMenuItem, вырезатьToolStripMenuItem, копироватьToolStripMenuItem, вставитьToolStripMenuItem, удалитьToolStripMenuItem, выделитьВсеToolStripMenuItem });
            правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            правкаToolStripMenuItem.Size = new Size(59, 20);
            правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            отменитьToolStripMenuItem.Size = new Size(148, 22);
            отменитьToolStripMenuItem.Text = "Отменить";
            отменитьToolStripMenuItem.Click += отменитьToolStripMenuItem_Click;
            // 
            // повторитьToolStripMenuItem
            // 
            повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            повторитьToolStripMenuItem.Size = new Size(148, 22);
            повторитьToolStripMenuItem.Text = "Повторить";
            повторитьToolStripMenuItem.Click += повторитьToolStripMenuItem_Click;
            // 
            // вырезатьToolStripMenuItem
            // 
            вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            вырезатьToolStripMenuItem.Size = new Size(148, 22);
            вырезатьToolStripMenuItem.Text = "Вырезать";
            вырезатьToolStripMenuItem.Click += вырезатьToolStripMenuItem_Click;
            // 
            // копироватьToolStripMenuItem
            // 
            копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            копироватьToolStripMenuItem.Size = new Size(148, 22);
            копироватьToolStripMenuItem.Text = "Копировать";
            копироватьToolStripMenuItem.Click += копироватьToolStripMenuItem_Click;
            // 
            // вставитьToolStripMenuItem
            // 
            вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            вставитьToolStripMenuItem.Size = new Size(148, 22);
            вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(148, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // выделитьВсеToolStripMenuItem
            // 
            выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            выделитьВсеToolStripMenuItem.Size = new Size(148, 22);
            выделитьВсеToolStripMenuItem.Text = "Выделить все";
            выделитьВсеToolStripMenuItem.Click += выделитьВсеToolStripMenuItem_Click;
            // 
            // текстToolStripMenuItem
            // 
            текстToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { постановкаЗадачиToolStripMenuItem, грамматикаToolStripMenuItem, классификацияГрамматикиToolStripMenuItem, методАнализаToolStripMenuItem, диагностикаИНейтрализацияToolStripMenuItem, тестовыйПримерToolStripMenuItem, списокЛитературыToolStripMenuItem, исходныйКодПрограммыToolStripMenuItem });
            текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            текстToolStripMenuItem.Size = new Size(48, 20);
            текстToolStripMenuItem.Text = "Текст";
            // 
            // постановкаЗадачиToolStripMenuItem
            // 
            постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
            постановкаЗадачиToolStripMenuItem.Size = new Size(288, 22);
            постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
            постановкаЗадачиToolStripMenuItem.Click += постановкаЗадачиToolStripMenuItem_Click;
            // 
            // грамматикаToolStripMenuItem
            // 
            грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            грамматикаToolStripMenuItem.Size = new Size(288, 22);
            грамматикаToolStripMenuItem.Text = "Грамматика";
            грамматикаToolStripMenuItem.Click += грамматикаToolStripMenuItem_Click;
            // 
            // классификацияГрамматикиToolStripMenuItem
            // 
            классификацияГрамматикиToolStripMenuItem.Name = "классификацияГрамматикиToolStripMenuItem";
            классификацияГрамматикиToolStripMenuItem.Size = new Size(288, 22);
            классификацияГрамматикиToolStripMenuItem.Text = "Классификация грамматики";
            классификацияГрамматикиToolStripMenuItem.Click += классификацияГрамматикиToolStripMenuItem_Click;
            // 
            // методАнализаToolStripMenuItem
            // 
            методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            методАнализаToolStripMenuItem.Size = new Size(288, 22);
            методАнализаToolStripMenuItem.Text = "Метод анализа";
            методАнализаToolStripMenuItem.Click += методАнализаToolStripMenuItem_Click;
            // 
            // диагностикаИНейтрализацияToolStripMenuItem
            // 
            диагностикаИНейтрализацияToolStripMenuItem.Name = "диагностикаИНейтрализацияToolStripMenuItem";
            диагностикаИНейтрализацияToolStripMenuItem.Size = new Size(288, 22);
            диагностикаИНейтрализацияToolStripMenuItem.Text = "Диагностика и нейтрализация ошибок";
            диагностикаИНейтрализацияToolStripMenuItem.Click += диагностикаИНейтрализацияToolStripMenuItem_Click;
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            тестовыйПримерToolStripMenuItem.Size = new Size(288, 22);
            тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            тестовыйПримерToolStripMenuItem.Click += тестовыйПримерToolStripMenuItem_Click;
            // 
            // списокЛитературыToolStripMenuItem
            // 
            списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            списокЛитературыToolStripMenuItem.Size = new Size(288, 22);
            списокЛитературыToolStripMenuItem.Text = "Список литературы";
            списокЛитературыToolStripMenuItem.Click += списокЛитературыToolStripMenuItem_Click;
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            исходныйКодПрограммыToolStripMenuItem.Size = new Size(288, 22);
            исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            исходныйКодПрограммыToolStripMenuItem.Click += исходныйКодПрограммыToolStripMenuItem_Click;
            // 
            // пускToolStripMenuItem
            // 
            пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            пускToolStripMenuItem.Size = new Size(46, 20);
            пускToolStripMenuItem.Text = "Пуск";
            пускToolStripMenuItem.Click += пускToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вызовСправкиToolStripMenuItem, оПрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // вызовСправкиToolStripMenuItem
            // 
            вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
            вызовСправкиToolStripMenuItem.Size = new Size(156, 22);
            вызовСправкиToolStripMenuItem.Text = "Вызов справки";
            вызовСправкиToolStripMenuItem.Click += вызовСправкиToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(156, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 113);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(926, 243);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(23, 385);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(926, 169);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // CreateButton
            // 
            CreateButton.Image = (Image)resources.GetObject("CreateButton.Image");
            CreateButton.Location = new Point(23, 38);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(68, 57);
            CreateButton.TabIndex = 12;
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // OpenButton
            // 
            OpenButton.Image = (Image)resources.GetObject("OpenButton.Image");
            OpenButton.Location = new Point(97, 38);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(72, 57);
            OpenButton.TabIndex = 13;
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 610);
            Controls.Add(OpenButton);
            Controls.Add(CreateButton);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(CopyButton);
            Controls.Add(RedoButton);
            Controls.Add(UndoButton);
            Controls.Add(SaveButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            //Load += Form1_Load;
            //TextChanged += Form1_TextChanged;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            //Validated += Form1_Validated;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaveButton;
        private Button CopyButton;
        private Button RedoButton;
        private Button UndoButton;
        private Button button7;
        private Button button8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem текстToolStripMenuItem;
        private ToolStripMenuItem пускToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem повторитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
        private ToolStripMenuItem грамматикаToolStripMenuItem;
        private ToolStripMenuItem классификацияГрамматикиToolStripMenuItem;
        private ToolStripMenuItem методАнализаToolStripMenuItem;
        private ToolStripMenuItem диагностикаИНейтрализацияToolStripMenuItem;
        private ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private ToolStripMenuItem вызовСправкиToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button CreateButton;
        private Button OpenButton;
    }
}
