namespace KursPt2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Test_Create = new System.Windows.Forms.Button();
            this.button_Test_Create_Manual = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_True_Answers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вопросDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тестDataSet = new KursPt2.ТестDataSet();
            this.questionsTableAdapter = new KursPt2.ТестDataSetTableAdapters.QuestionsTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.questionsAnswersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.answersTableAdapter = new KursPt2.ТестDataSetTableAdapters.AnswersTableAdapter();
            this.textBox_Questions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Answers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тестDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsAnswersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Test_Create
            // 
            this.button_Test_Create.Location = new System.Drawing.Point(858, 54);
            this.button_Test_Create.Name = "button_Test_Create";
            this.button_Test_Create.Size = new System.Drawing.Size(314, 53);
            this.button_Test_Create.TabIndex = 0;
            this.button_Test_Create.Text = "Создать тест\r\n(автоматически)";
            this.button_Test_Create.UseVisualStyleBackColor = true;
            this.button_Test_Create.Click += new System.EventHandler(this.button_Test_Create_Click);
            // 
            // button_Test_Create_Manual
            // 
            this.button_Test_Create_Manual.Location = new System.Drawing.Point(858, 369);
            this.button_Test_Create_Manual.Name = "button_Test_Create_Manual";
            this.button_Test_Create_Manual.Size = new System.Drawing.Size(314, 69);
            this.button_Test_Create_Manual.TabIndex = 1;
            this.button_Test_Create_Manual.Text = "Создать тест\r\n(вручную)";
            this.button_Test_Create_Manual.UseVisualStyleBackColor = true;
            this.button_Test_Create_Manual.Click += new System.EventHandler(this.button_Test_Create_Manual_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(858, 113);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(154, 53);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Очистить поле";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_True_Answers
            // 
            this.button_True_Answers.Location = new System.Drawing.Point(1018, 113);
            this.button_True_Answers.Name = "button_True_Answers";
            this.button_True_Answers.Size = new System.Drawing.Size(154, 53);
            this.button_True_Answers.TabIndex = 3;
            this.button_True_Answers.Text = "Правильные ответы";
            this.button_True_Answers.UseVisualStyleBackColor = true;
            this.button_True_Answers.Click += new System.EventHandler(this.button_True_Answers_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.вопросDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 426);
            this.dataGridView1.TabIndex = 4;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 50;
            // 
            // вопросDataGridViewTextBoxColumn
            // 
            this.вопросDataGridViewTextBoxColumn.DataPropertyName = "Вопрос";
            this.вопросDataGridViewTextBoxColumn.HeaderText = "Вопрос";
            this.вопросDataGridViewTextBoxColumn.Name = "вопросDataGridViewTextBoxColumn";
            this.вопросDataGridViewTextBoxColumn.Width = 750;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.тестDataSet;
            // 
            // тестDataSet
            // 
            this.тестDataSet.DataSetName = "ТестDataSet";
            this.тестDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 444);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(1160, 405);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // questionsAnswersBindingSource
            // 
            this.questionsAnswersBindingSource.DataMember = "QuestionsAnswers";
            this.questionsAnswersBindingSource.DataSource = this.questionsBindingSource;
            // 
            // answersTableAdapter
            // 
            this.answersTableAdapter.ClearBeforeFill = true;
            // 
            // textBox_Questions
            // 
            this.textBox_Questions.Location = new System.Drawing.Point(858, 28);
            this.textBox_Questions.Name = "textBox_Questions";
            this.textBox_Questions.Size = new System.Drawing.Size(154, 20);
            this.textBox_Questions.TabIndex = 6;
            this.textBox_Questions.TextChanged += new System.EventHandler(this.textBox_Questions_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество вопросов";
            // 
            // textBox_Answers
            // 
            this.textBox_Answers.Location = new System.Drawing.Point(1018, 28);
            this.textBox_Answers.Name = "textBox_Answers";
            this.textBox_Answers.Size = new System.Drawing.Size(154, 20);
            this.textBox_Answers.TabIndex = 8;
            this.textBox_Answers.TextChanged += new System.EventHandler(this.textBox_Answers_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1015, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество ответов";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(859, 200);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Вопрос 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(859, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Вопрос 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(859, 246);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Вопрос 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(859, 269);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Вопрос 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(859, 292);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "Вопрос 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(859, 315);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(72, 17);
            this.checkBox6.TabIndex = 15;
            this.checkBox6.Text = "Вопрос 6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(859, 338);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 17);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.Text = "Вопрос 7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(974, 200);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(72, 17);
            this.checkBox8.TabIndex = 17;
            this.checkBox8.Text = "Вопрос 8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(974, 223);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(72, 17);
            this.checkBox9.TabIndex = 18;
            this.checkBox9.Text = "Вопрос 9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(974, 246);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(78, 17);
            this.checkBox10.TabIndex = 19;
            this.checkBox10.Text = "Вопрос 10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(974, 269);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(78, 17);
            this.checkBox11.TabIndex = 20;
            this.checkBox11.Text = "Вопрос 11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(974, 292);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(78, 17);
            this.checkBox12.TabIndex = 21;
            this.checkBox12.Text = "Вопрос 12";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(974, 315);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(78, 17);
            this.checkBox13.TabIndex = 22;
            this.checkBox13.Text = "Вопрос 13";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(1087, 200);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(78, 17);
            this.checkBox14.TabIndex = 23;
            this.checkBox14.Text = "Вопрос 14";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(1087, 223);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(78, 17);
            this.checkBox15.TabIndex = 24;
            this.checkBox15.Text = "Вопрос 15";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(1087, 246);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(78, 17);
            this.checkBox16.TabIndex = 25;
            this.checkBox16.Text = "Вопрос 16";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(1087, 269);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(78, 17);
            this.checkBox17.TabIndex = 26;
            this.checkBox17.Text = "Вопрос 17";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(1087, 292);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(78, 17);
            this.checkBox18.TabIndex = 27;
            this.checkBox18.Text = "Вопрос 18";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(1087, 315);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(78, 17);
            this.checkBox19.TabIndex = 28;
            this.checkBox19.Text = "Вопрос 19";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(1087, 338);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(78, 17);
            this.checkBox20.TabIndex = 29;
            this.checkBox20.Text = "Вопрос 20";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(886, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Выберите вопросы для ручного составления теста";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox20);
            this.Controls.Add(this.checkBox19);
            this.Controls.Add(this.checkBox18);
            this.Controls.Add(this.checkBox17);
            this.Controls.Add(this.checkBox16);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox14);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.checkBox12);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Answers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Questions);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_True_Answers);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Test_Create_Manual);
            this.Controls.Add(this.button_Test_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тестDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsAnswersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Test_Create;
        private System.Windows.Forms.Button button_Test_Create_Manual;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_True_Answers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ТестDataSet тестDataSet;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private ТестDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource questionsAnswersBindingSource;
        private ТестDataSetTableAdapters.AnswersTableAdapter answersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вопросDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_Questions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Answers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.Label label3;
    }
}

