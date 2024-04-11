namespace Fiscal {
    partial class Filtro_Sintegra {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            checkBox14 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox3 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 407);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dateTimePicker3);
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Controls.Add(label4);
            groupBox5.Controls.Add(label3);
            groupBox5.Location = new Point(6, 332);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(560, 69);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Inventário";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox14);
            groupBox4.Controls.Add(checkBox13);
            groupBox4.Controls.Add(checkBox12);
            groupBox4.Controls.Add(checkBox11);
            groupBox4.Controls.Add(checkBox10);
            groupBox4.Controls.Add(checkBox9);
            groupBox4.Controls.Add(checkBox8);
            groupBox4.Controls.Add(checkBox7);
            groupBox4.Controls.Add(checkBox6);
            groupBox4.Controls.Add(checkBox5);
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Location = new Point(6, 119);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(560, 207);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Registro a serem gerados";
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(202, 174);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(164, 19);
            checkBox14.TabIndex = 13;
            checkBox14.Text = "74 - Registro de Inventário";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(202, 149);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(235, 19);
            checkBox13.TabIndex = 12;
            checkBox13.Text = "88EAN - Código de barras dos produtos";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(202, 124);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(228, 19);
            checkBox12.TabIndex = 11;
            checkBox12.Text = "75 - Lista de produtos comercializados";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(202, 99);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(234, 19);
            checkBox11.TabIndex = 10;
            checkBox11.Text = "70 - Nota fiscal de serviço de transporte";
            checkBox11.UseVisualStyleBackColor = true;
            checkBox11.CheckedChanged += checkBox11_CheckedChanged;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(202, 74);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(273, 19);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "61R - Resumo por item (NFC-e e Nota Manual)";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(202, 47);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(166, 19);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "61 - Vendas (Nota Manual)";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(202, 22);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(131, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "61 - Vendas (NFC-e)";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 174);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(140, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "60R - Resumo Mensal";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 149);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(122, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "60I - Item vendido";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 124);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(134, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "60D - Resumo Diário";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 99);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(104, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "60A - Analítico";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 74);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(142, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "60M - Registro mestre";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(161, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "50 - Vendas (NF-e, 1 e 1A)";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "50 - Compras";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton3);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Location = new Point(6, 66);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(560, 47);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Finalidade do arquivo";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(443, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(97, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Desfazimento";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(256, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(181, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Retificação aditiva do arquivo";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(77, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(170, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Retificação total do arquivo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Normal";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTimePicker2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(6, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(560, 43);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 19);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 4;
            label2.Text = "até";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "De";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(326, 14);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(42, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 4;
            label3.Text = "Obter preço de custo por:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 19);
            label4.Name = "label4";
            label4.Size = new Size(201, 15);
            label4.TabIndex = 5;
            label4.Text = "Data final para geração do inventário";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Preço de custo unitário";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(288, 37);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(228, 23);
            dateTimePicker3.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(444, 425);
            button1.Name = "button1";
            button1.Size = new Size(140, 28);
            button1.TabIndex = 1;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Filtro_Sintegra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 457);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Filtro_Sintegra";
            Text = "Filtro por período de datas";
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
        private Button button1;
    }
}