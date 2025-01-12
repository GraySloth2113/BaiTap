namespace Lab03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tx1 = new System.Windows.Forms.TextBox();
            this.Tx2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb1 = new System.Windows.Forms.CheckBox();
            this.Cb2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tx3 = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(115, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(148, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(149, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "B:";
            // 
            // Tx1
            // 
            this.Tx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tx1.Location = new System.Drawing.Point(206, 117);
            this.Tx1.Name = "Tx1";
            this.Tx1.Size = new System.Drawing.Size(208, 26);
            this.Tx1.TabIndex = 3;
            this.Tx1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tx2
            // 
            this.Tx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tx2.Location = new System.Drawing.Point(206, 164);
            this.Tx2.Name = "Tx2";
            this.Tx2.Size = new System.Drawing.Size(208, 26);
            this.Tx2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(470, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tìm";
            // 
            // Cb1
            // 
            this.Cb1.AutoSize = true;
            this.Cb1.Location = new System.Drawing.Point(535, 117);
            this.Cb1.Name = "Cb1";
            this.Cb1.Size = new System.Drawing.Size(62, 17);
            this.Cb1.TabIndex = 6;
            this.Cb1.Text = "UCSLN";
            this.Cb1.UseVisualStyleBackColor = true;
            this.Cb1.CheckedChanged += new System.EventHandler(this.Cb1_CheckedChanged);
            // 
            // Cb2
            // 
            this.Cb2.AutoSize = true;
            this.Cb2.Location = new System.Drawing.Point(535, 166);
            this.Cb2.Name = "Cb2";
            this.Cb2.Size = new System.Drawing.Size(63, 17);
            this.Cb2.TabIndex = 7;
            this.Cb2.Text = "BCSNN";
            this.Cb2.UseVisualStyleBackColor = true;
            this.Cb2.CheckedChanged += new System.EventHandler(this.Cb2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(263, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kết Quả:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Tx3
            // 
            this.Tx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Tx3.Location = new System.Drawing.Point(206, 293);
            this.Tx3.Name = "Tx3";
            this.Tx3.Size = new System.Drawing.Size(208, 29);
            this.Tx3.TabIndex = 9;
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Find.Location = new System.Drawing.Point(186, 358);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(76, 31);
            this.btn_Find.TabIndex = 10;
            this.btn_Find.Text = "Tìm";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_DeleteAll.Location = new System.Drawing.Point(306, 358);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(83, 31);
            this.btn_DeleteAll.TabIndex = 11;
            this.btn_DeleteAll.Text = "Bỏ Qua";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(437, 359);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 30);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DeleteAll);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.Tx3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cb2);
            this.Controls.Add(this.Cb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tx2);
            this.Controls.Add(this.Tx1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "tìm UCSLN và BCSNN của a và b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tx1;
        private System.Windows.Forms.TextBox Tx2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Cb1;
        private System.Windows.Forms.CheckBox Cb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tx3;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_DeleteAll;
        private System.Windows.Forms.Button btn_Exit;
    }
}