namespace laba_6_1_1
{
    partial class creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(creator));
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            label5 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(159, 232, 215);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 414);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label6.Location = new Point(162, 238);
            label6.Name = "label6";
            label6.Size = new Size(286, 26);
            label6.TabIndex = 14;
            label6.Text = "№ Группы: 6101-090301D";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label4.Location = new Point(82, 199);
            label4.Name = "label4";
            label4.Size = new Size(483, 26);
            label4.TabIndex = 13;
            label4.Text = "Самарский университет, направление ИВТ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label3.Location = new Point(162, 160);
            label3.Name = "label3";
            label3.Size = new Size(296, 26);
            label3.TabIndex = 12;
            label3.Text = "Дата рождения: 02.05.2006";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(101, 146, 137);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 147, 95);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(129, 174, 164);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(225, 338);
            button5.Name = "button5";
            button5.Size = new Size(169, 39);
            button5.TabIndex = 11;
            button5.Text = "Меню";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            label5.Location = new Point(115, 116);
            label5.Name = "label5";
            label5.Size = new Size(387, 26);
            label5.TabIndex = 6;
            label5.Text = "Канунников Ярослав Дмитриевич";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(101, 146, 137);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 70);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(101, 146, 137);
            label2.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(586, 0);
            label2.Name = "label2";
            label2.Size = new Size(23, 22);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(101, 146, 137);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(608, 70);
            label1.TabIndex = 1;
            label1.Text = "Информация об авторе";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // creator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 411);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "creator";
            Text = "creator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Label label5;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}