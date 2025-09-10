namespace WForms
{
    partial class MainForm
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
            this.Addbutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.Findbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.GetPricebutton = new System.Windows.Forms.Button();
            this.AllCategoributton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.Addbutton.FlatAppearance.BorderSize = 0;
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(69, 211);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(293, 119);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "Добавить товар";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Delbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.Delbutton.FlatAppearance.BorderSize = 0;
            this.Delbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.Delbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delbutton.Location = new System.Drawing.Point(69, 379);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(293, 119);
            this.Delbutton.TabIndex = 1;
            this.Delbutton.Text = "Удалить товар";
            this.Delbutton.UseVisualStyleBackColor = false;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // Findbutton
            // 
            this.Findbutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Findbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.Findbutton.FlatAppearance.BorderSize = 0;
            this.Findbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.Findbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Findbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Findbutton.Location = new System.Drawing.Point(69, 554);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(293, 119);
            this.Findbutton.TabIndex = 2;
            this.Findbutton.Text = "Найти товар";
            this.Findbutton.UseVisualStyleBackColor = false;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.Updatebutton.FlatAppearance.BorderSize = 0;
            this.Updatebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Updatebutton.Location = new System.Drawing.Point(470, 211);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(293, 119);
            this.Updatebutton.TabIndex = 3;
            this.Updatebutton.Text = "Обновить товар";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // GetPricebutton
            // 
            this.GetPricebutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GetPricebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.GetPricebutton.FlatAppearance.BorderSize = 0;
            this.GetPricebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.GetPricebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetPricebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetPricebutton.Location = new System.Drawing.Point(470, 379);
            this.GetPricebutton.Name = "GetPricebutton";
            this.GetPricebutton.Size = new System.Drawing.Size(293, 119);
            this.GetPricebutton.TabIndex = 4;
            this.GetPricebutton.Text = "Посчитать общую сумму\r\n";
            this.GetPricebutton.UseVisualStyleBackColor = false;
            this.GetPricebutton.Click += new System.EventHandler(this.GetPricebutton_Click);
            // 
            // AllCategoributton
            // 
            this.AllCategoributton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AllCategoributton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(157)))), ((int)(((byte)(119)))));
            this.AllCategoributton.FlatAppearance.BorderSize = 0;
            this.AllCategoributton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(69)))));
            this.AllCategoributton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCategoributton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCategoributton.Location = new System.Drawing.Point(470, 554);
            this.AllCategoributton.Name = "AllCategoributton";
            this.AllCategoributton.Size = new System.Drawing.Size(293, 119);
            this.AllCategoributton.TabIndex = 5;
            this.AllCategoributton.Text = "Вывести все товары в категории";
            this.AllCategoributton.UseVisualStyleBackColor = false;
            this.AllCategoributton.Click += new System.EventHandler(this.AllCategoributton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберете действие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(881, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Добро пожаловать в магазин Дикие ягоды\r\n";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(931, 214);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(714, 454);
            this.listBox1.TabIndex = 9;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(24)))), ((int)(((byte)(3)))));
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(1428, 692);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(217, 69);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(924, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Корзина";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1657, 872);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllCategoributton);
            this.Controls.Add(this.GetPricebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Findbutton);
            this.Controls.Add(this.Delbutton);
            this.Controls.Add(this.Addbutton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimumSize = new System.Drawing.Size(1673, 911);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button GetPricebutton;
        private System.Windows.Forms.Button AllCategoributton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label3;
    }
}

