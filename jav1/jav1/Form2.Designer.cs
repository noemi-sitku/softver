﻿namespace jav1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            adatokBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)adatokBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(77, 438);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(252, 438);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", adatokBindingSource, "Szam", true));
            textBox1.Location = new Point(77, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", adatokBindingSource, "Kerdes", true));
            textBox2.Location = new Point(77, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", adatokBindingSource, "V1", true));
            textBox3.Location = new Point(77, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", adatokBindingSource, "V2", true));
            textBox4.Location = new Point(77, 226);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(269, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", adatokBindingSource, "V3", true));
            textBox5.Location = new Point(77, 282);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(269, 27);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", adatokBindingSource, "Kep", true));
            textBox6.Location = new Point(77, 337);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(269, 27);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", adatokBindingSource, "HelyesValasz", true));
            textBox7.Location = new Point(77, 391);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(269, 27);
            textBox7.TabIndex = 8;
            // 
            // adatokBindingSource
            // 
            adatokBindingSource.DataSource = typeof(Adatok);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 499);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)adatokBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private BindingSource adatokBindingSource;
    }
}