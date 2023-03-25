namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            Button red = new Button();
            Button green = new Button();

            red.Size = new Size(100, 50);
            red.Location = new Point(20, 20);
            red.Text = "Red";

            green.Size = new Size(100, 50);
            green.Location = new Point(20, 70);
            green.Text = "Green";

            red.Click += (e, s) =>
            {
                this.BackColor = Color.Red;
            };

            green.Click += (e, s) =>
            {
                this.BackColor = Color.Green;
            };

            this.Controls.Add(red);
            this.Controls.Add(green);
        }

        #endregion
    }
}