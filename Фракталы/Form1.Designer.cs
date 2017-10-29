namespace fracts
{
	partial class Form1
	{
		/// <summary>
		/// Требуется переменная конструктора.
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
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.butt_dis = new System.Windows.Forms.Button();
            this.butt_clear = new System.Windows.Forms.Button();
            this.butt_sc = new System.Windows.Forms.Button();
            this.set_sc_y = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.set_sc_x = new System.Windows.Forms.NumericUpDown();
            this.butt_open_fract = new System.Windows.Forms.Button();
            this.set_dis_y = new System.Windows.Forms.NumericUpDown();
            this.butt_draw_fract = new System.Windows.Forms.Button();
            this.set_dis_x = new System.Windows.Forms.NumericUpDown();
            this.num_iter_fract = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.shoroh = new System.Windows.Forms.NumericUpDown();
            this.diamond = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_iter_fract)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoroh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox.Location = new System.Drawing.Point(142, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1134, 661);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // butt_dis
            // 
            this.butt_dis.Location = new System.Drawing.Point(9, 52);
            this.butt_dis.Name = "butt_dis";
            this.butt_dis.Size = new System.Drawing.Size(117, 23);
            this.butt_dis.TabIndex = 12;
            this.butt_dis.Text = "Переместить";
            this.butt_dis.UseVisualStyleBackColor = true;
            this.butt_dis.Click += new System.EventHandler(this.butt_dis_Click);
            // 
            // butt_clear
            // 
            this.butt_clear.Location = new System.Drawing.Point(9, 342);
            this.butt_clear.Name = "butt_clear";
            this.butt_clear.Size = new System.Drawing.Size(117, 23);
            this.butt_clear.TabIndex = 10;
            this.butt_clear.Text = "Очистить";
            this.butt_clear.UseVisualStyleBackColor = true;
            this.butt_clear.Click += new System.EventHandler(this.butt_clear_Click);
            // 
            // butt_sc
            // 
            this.butt_sc.Location = new System.Drawing.Point(9, 128);
            this.butt_sc.Name = "butt_sc";
            this.butt_sc.Size = new System.Drawing.Size(117, 23);
            this.butt_sc.TabIndex = 14;
            this.butt_sc.Text = "Изменить масштаб";
            this.butt_sc.UseVisualStyleBackColor = true;
            this.butt_sc.Click += new System.EventHandler(this.butt_sc_Click);
            // 
            // set_sc_y
            // 
            this.set_sc_y.DecimalPlaces = 2;
            this.set_sc_y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_y.Location = new System.Drawing.Point(68, 102);
            this.set_sc_y.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.set_sc_y.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_y.Name = "set_sc_y";
            this.set_sc_y.Size = new System.Drawing.Size(50, 20);
            this.set_sc_y.TabIndex = 9;
            this.set_sc_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Фракталы:";
            // 
            // set_sc_x
            // 
            this.set_sc_x.DecimalPlaces = 2;
            this.set_sc_x.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_x.Location = new System.Drawing.Point(9, 102);
            this.set_sc_x.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.set_sc_x.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.set_sc_x.Name = "set_sc_x";
            this.set_sc_x.Size = new System.Drawing.Size(50, 20);
            this.set_sc_x.TabIndex = 8;
            this.set_sc_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // butt_open_fract
            // 
            this.butt_open_fract.Location = new System.Drawing.Point(9, 178);
            this.butt_open_fract.Name = "butt_open_fract";
            this.butt_open_fract.Size = new System.Drawing.Size(117, 21);
            this.butt_open_fract.TabIndex = 31;
            this.butt_open_fract.Text = "Открыть";
            this.butt_open_fract.UseVisualStyleBackColor = true;
            this.butt_open_fract.Click += new System.EventHandler(this.butt_open_fract_Click);
            // 
            // set_dis_y
            // 
            this.set_dis_y.Location = new System.Drawing.Point(76, 25);
            this.set_dis_y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.set_dis_y.Name = "set_dis_y";
            this.set_dis_y.Size = new System.Drawing.Size(50, 20);
            this.set_dis_y.TabIndex = 6;
            // 
            // butt_draw_fract
            // 
            this.butt_draw_fract.Location = new System.Drawing.Point(9, 315);
            this.butt_draw_fract.Name = "butt_draw_fract";
            this.butt_draw_fract.Size = new System.Drawing.Size(117, 21);
            this.butt_draw_fract.TabIndex = 32;
            this.butt_draw_fract.Text = "Нарисовать";
            this.butt_draw_fract.UseVisualStyleBackColor = true;
            this.butt_draw_fract.Click += new System.EventHandler(this.butt_draw_fract_Click);
            // 
            // set_dis_x
            // 
            this.set_dis_x.Location = new System.Drawing.Point(9, 25);
            this.set_dis_x.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.set_dis_x.Name = "set_dis_x";
            this.set_dis_x.Size = new System.Drawing.Size(50, 20);
            this.set_dis_x.TabIndex = 5;
            // 
            // num_iter_fract
            // 
            this.num_iter_fract.Location = new System.Drawing.Point(9, 218);
            this.num_iter_fract.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_iter_fract.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_iter_fract.Name = "num_iter_fract";
            this.num_iter_fract.Size = new System.Drawing.Size(117, 20);
            this.num_iter_fract.TabIndex = 33;
            this.num_iter_fract.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Масштаб (по Х и У):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Кол-во итераций:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Перенос (по Х и У):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.diamond);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.shoroh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num_iter_fract);
            this.panel1.Controls.Add(this.set_dis_x);
            this.panel1.Controls.Add(this.butt_draw_fract);
            this.panel1.Controls.Add(this.set_dis_y);
            this.panel1.Controls.Add(this.butt_open_fract);
            this.panel1.Controls.Add(this.set_sc_x);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.set_sc_y);
            this.panel1.Controls.Add(this.butt_sc);
            this.panel1.Controls.Add(this.butt_clear);
            this.panel1.Controls.Add(this.butt_dis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 661);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Коэф-нт шероховатости";
            // 
            // shoroh
            // 
            this.shoroh.Location = new System.Drawing.Point(9, 257);
            this.shoroh.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.shoroh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shoroh.Name = "shoroh";
            this.shoroh.Size = new System.Drawing.Size(117, 20);
            this.shoroh.TabIndex = 35;
            this.shoroh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // diamond
            // 
            this.diamond.Location = new System.Drawing.Point(9, 283);
            this.diamond.Name = "diamond";
            this.diamond.Size = new System.Drawing.Size(117, 21);
            this.diamond.TabIndex = 37;
            this.diamond.Text = "Горный массив";
            this.diamond.UseVisualStyleBackColor = true;
            this.diamond.Click += new System.EventHandler(this.diamond_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D векторная графика";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_sc_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_dis_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_iter_fract)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoroh)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button butt_dis;
        private System.Windows.Forms.Button butt_clear;
        private System.Windows.Forms.Button butt_sc;
        private System.Windows.Forms.NumericUpDown set_sc_y;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown set_sc_x;
        private System.Windows.Forms.Button butt_open_fract;
        private System.Windows.Forms.NumericUpDown set_dis_y;
        private System.Windows.Forms.Button butt_draw_fract;
        private System.Windows.Forms.NumericUpDown set_dis_x;
        private System.Windows.Forms.NumericUpDown num_iter_fract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown shoroh;
        private System.Windows.Forms.Button diamond;
    }
}

