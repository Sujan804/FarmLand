namespace newSimulation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.chickenTimer = new System.Windows.Forms.Timer(this.components);
            this.duckTimer = new System.Windows.Forms.Timer(this.components);
            this.foodTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chickenTimer
            // 
            this.chickenTimer.Enabled = true;
            this.chickenTimer.Interval = 50;
            this.chickenTimer.Tick += new System.EventHandler(this.chickenTimer_Tick);
            // 
            // duckTimer
            // 
            this.duckTimer.Enabled = true;
            this.duckTimer.Tick += new System.EventHandler(this.duckTimer_Tick);
            // 
            // foodTimer
            // 
            this.foodTimer.Enabled = true;
            this.foodTimer.Interval = 300;
            this.foodTimer.Tick += new System.EventHandler(this.foodTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::newSimulation.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "newSimulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer chickenTimer;
        private System.Windows.Forms.Timer duckTimer;
        private System.Windows.Forms.Timer foodTimer;
    }
}

