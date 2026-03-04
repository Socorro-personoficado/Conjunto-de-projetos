namespace SocorroLista
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
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            trackBar4 = new TrackBar();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Location = new Point(0, 405);
            trackBar1.Maximum = 600;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(800, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll_1;
            // 
            // trackBar2
            // 
            trackBar2.Dock = DockStyle.Bottom;
            trackBar2.Location = new Point(0, 360);
            trackBar2.Maximum = 600;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(800, 45);
            trackBar2.TabIndex = 1;
            trackBar2.Scroll += trackBar2_Scroll_1;
            // 
            // trackBar3
            // 
            trackBar3.Dock = DockStyle.Bottom;
            trackBar3.Location = new Point(0, 315);
            trackBar3.Maximum = 360;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(800, 45);
            trackBar3.SmallChange = 90;
            trackBar3.TabIndex = 2;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // trackBar4
            // 
            trackBar4.Dock = DockStyle.Bottom;
            trackBar4.Location = new Point(0, 270);
            trackBar4.Minimum = 1;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(800, 45);
            trackBar4.TabIndex = 3;
            trackBar4.Value = 1;
            trackBar4.Scroll += trackBar4_Scroll;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 270);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 346);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 391);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 391);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(36, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 391);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(36, 23);
            textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(trackBar4);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
