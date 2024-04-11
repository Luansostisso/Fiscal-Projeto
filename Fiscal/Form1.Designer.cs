namespace Fiscal {
    partial class Fiscal {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscal));
            groupBox1 = new GroupBox();
            LCDPR = new Button();
            Contribuicoes = new Button();
            btnSped = new Button();
            btnsintegra = new Button();
            groupBox2 = new GroupBox();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(LCDPR);
            groupBox1.Controls.Add(Contribuicoes);
            groupBox1.Controls.Add(btnSped);
            groupBox1.Controls.Add(btnsintegra);
            groupBox1.Controls.Add(groupBox2);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // LCDPR
            // 
            resources.ApplyResources(LCDPR, "LCDPR");
            LCDPR.FlatAppearance.BorderSize = 0;
            LCDPR.Name = "LCDPR";
            LCDPR.UseVisualStyleBackColor = true;
            // 
            // Contribuicoes
            // 
            resources.ApplyResources(Contribuicoes, "Contribuicoes");
            Contribuicoes.FlatAppearance.BorderSize = 0;
            Contribuicoes.Name = "Contribuicoes";
            Contribuicoes.UseVisualStyleBackColor = true;
            // 
            // btnSped
            // 
            resources.ApplyResources(btnSped, "btnSped");
            btnSped.FlatAppearance.BorderSize = 0;
            btnSped.Name = "btnSped";
            btnSped.TabStop = false;
            btnSped.UseVisualStyleBackColor = true;
            btnSped.Click += btnSped_Click;
            // 
            // btnsintegra
            // 
            btnsintegra.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnsintegra, "btnsintegra");
            btnsintegra.Name = "btnsintegra";
            btnsintegra.TabStop = false;
            btnsintegra.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar2);
            groupBox2.Controls.Add(progressBar1);
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // progressBar2
            // 
            resources.ApplyResources(progressBar2, "progressBar2");
            progressBar2.Name = "progressBar2";
            // 
            // progressBar1
            // 
            resources.ApplyResources(progressBar1, "progressBar1");
            progressBar1.Name = "progressBar1";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button1, "button1");
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button2, "button2");
            button2.ForeColor = Color.White;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderColor = Color.Aquamarine;
            button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(button3, "button3");
            button3.ForeColor = Color.White;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // Fiscal
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Fiscal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
        private Button LCDPR;
        private Button Contribuicoes;
        private Button btnsintegra;
        private Button button1;
        private Button button2;
        private Button button3;
        public Button btnSped;
    }
}
