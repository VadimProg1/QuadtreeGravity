
namespace QuadtreeGravity
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numeric_deceleration = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_speed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_massOfCursor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeric_amountOfPoints = new System.Windows.Forms.NumericUpDown();
            this.button_restart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_deceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_massOfCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_amountOfPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numeric_deceleration);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.numeric_speed);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numeric_massOfCursor);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numeric_amountOfPoints);
            this.splitContainer1.Panel1.Controls.Add(this.button_restart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1283, 988);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // numeric_deceleration
            // 
            this.numeric_deceleration.Location = new System.Drawing.Point(59, 349);
            this.numeric_deceleration.Name = "numeric_deceleration";
            this.numeric_deceleration.Size = new System.Drawing.Size(93, 22);
            this.numeric_deceleration.TabIndex = 9;
            this.numeric_deceleration.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_deceleration.ValueChanged += new System.EventHandler(this.numeric_deceleration_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deceleration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Speed ";
            // 
            // numeric_speed
            // 
            this.numeric_speed.Location = new System.Drawing.Point(59, 273);
            this.numeric_speed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_speed.Name = "numeric_speed";
            this.numeric_speed.Size = new System.Drawing.Size(93, 22);
            this.numeric_speed.TabIndex = 6;
            this.numeric_speed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_speed.ValueChanged += new System.EventHandler(this.numeric_speed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mass of cursor";
            // 
            // numeric_massOfCursor
            // 
            this.numeric_massOfCursor.Location = new System.Drawing.Point(59, 202);
            this.numeric_massOfCursor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric_massOfCursor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_massOfCursor.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numeric_massOfCursor.Name = "numeric_massOfCursor";
            this.numeric_massOfCursor.Size = new System.Drawing.Size(93, 22);
            this.numeric_massOfCursor.TabIndex = 4;
            this.numeric_massOfCursor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_massOfCursor.ValueChanged += new System.EventHandler(this.numeric_massOfCursor_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount of particles";
            // 
            // numeric_amountOfPoints
            // 
            this.numeric_amountOfPoints.Location = new System.Drawing.Point(59, 116);
            this.numeric_amountOfPoints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric_amountOfPoints.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_amountOfPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_amountOfPoints.Name = "numeric_amountOfPoints";
            this.numeric_amountOfPoints.Size = new System.Drawing.Size(93, 22);
            this.numeric_amountOfPoints.TabIndex = 2;
            this.numeric_amountOfPoints.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numeric_amountOfPoints.ValueChanged += new System.EventHandler(this.numeric_amountOfPoints_ValueChanged);
            // 
            // button_restart
            // 
            this.button_restart.Location = new System.Drawing.Point(59, 398);
            this.button_restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_restart.Name = "button_restart";
            this.button_restart.Size = new System.Drawing.Size(93, 33);
            this.button_restart.TabIndex = 0;
            this.button_restart.Text = "Restart";
            this.button_restart.UseVisualStyleBackColor = true;
            this.button_restart.Click += new System.EventHandler(this.button_restart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 984);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 988);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "QuadtreeGrav";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_deceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_massOfCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_amountOfPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_amountOfPoints;
        private System.Windows.Forms.Button button_restart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_massOfCursor;
        private System.Windows.Forms.NumericUpDown numeric_deceleration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_speed;
    }
}

