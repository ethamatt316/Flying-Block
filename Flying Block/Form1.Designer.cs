
namespace Flying_Block
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
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.totalText = new System.Windows.Forms.Label();
            this.flyingBlock = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.bottomCollison = new System.Windows.Forms.PictureBox();
            this.endText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flyingBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCollison)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // totalText
            // 
            this.totalText.AutoSize = true;
            this.totalText.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalText.Location = new System.Drawing.Point(270, 9);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(143, 32);
            this.totalText.TabIndex = 2;
            this.totalText.Text = "TOTAL:0";
            // 
            // flyingBlock
            // 
            this.flyingBlock.Image = global::Flying_Block.Properties.Resources.block;
            this.flyingBlock.Location = new System.Drawing.Point(159, 202);
            this.flyingBlock.Name = "flyingBlock";
            this.flyingBlock.Size = new System.Drawing.Size(62, 61);
            this.flyingBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flyingBlock.TabIndex = 3;
            this.flyingBlock.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flying_Block.Properties.Resources.pipe1;
            this.pipeBottom.Location = new System.Drawing.Point(419, 309);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(110, 195);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flying_Block.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(419, -2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(110, 177);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // bottomCollison
            // 
            this.bottomCollison.BackColor = System.Drawing.Color.Transparent;
            this.bottomCollison.Location = new System.Drawing.Point(-3, 496);
            this.bottomCollison.Name = "bottomCollison";
            this.bottomCollison.Size = new System.Drawing.Size(984, 19);
            this.bottomCollison.TabIndex = 4;
            this.bottomCollison.TabStop = false;
            // 
            // endText
            // 
            this.endText.AutoSize = true;
            this.endText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endText.Location = new System.Drawing.Point(302, 225);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(0, 38);
            this.endText.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(981, 516);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.bottomCollison);
            this.Controls.Add(this.flyingBlock);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "Flying Block";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flyingBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomCollison)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label totalText;
        private System.Windows.Forms.PictureBox flyingBlock;
        private System.Windows.Forms.PictureBox bottomCollison;
        private System.Windows.Forms.Label endText;
    }
}

