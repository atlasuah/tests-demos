namespace JoystickTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVelocityY = new System.Windows.Forms.TextBox();
            this.tbVelocityX = new System.Windows.Forms.TextBox();
            this.pbDrawing = new System.Windows.Forms.PictureBox();
            this.tbDrawingX = new System.Windows.Forms.TextBox();
            this.tbDrawingY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Accel";
            // 
            // tbVelocityY
            // 
            this.tbVelocityY.Location = new System.Drawing.Point(48, 73);
            this.tbVelocityY.Name = "tbVelocityY";
            this.tbVelocityY.Size = new System.Drawing.Size(100, 20);
            this.tbVelocityY.TabIndex = 10;
            // 
            // tbVelocityX
            // 
            this.tbVelocityX.Location = new System.Drawing.Point(48, 47);
            this.tbVelocityX.Name = "tbVelocityX";
            this.tbVelocityX.Size = new System.Drawing.Size(100, 20);
            this.tbVelocityX.TabIndex = 9;
            // 
            // pbDrawing
            // 
            this.pbDrawing.BackColor = System.Drawing.SystemColors.Window;
            this.pbDrawing.Location = new System.Drawing.Point(362, 12);
            this.pbDrawing.Name = "pbDrawing";
            this.pbDrawing.Size = new System.Drawing.Size(460, 353);
            this.pbDrawing.TabIndex = 11;
            this.pbDrawing.TabStop = false;
            // 
            // tbDrawingX
            // 
            this.tbDrawingX.Location = new System.Drawing.Point(48, 211);
            this.tbDrawingX.Name = "tbDrawingX";
            this.tbDrawingX.Size = new System.Drawing.Size(100, 20);
            this.tbDrawingX.TabIndex = 12;
            // 
            // tbDrawingY
            // 
            this.tbDrawingY.Location = new System.Drawing.Point(48, 237);
            this.tbDrawingY.Name = "tbDrawingY";
            this.tbDrawingY.Size = new System.Drawing.Size(100, 20);
            this.tbDrawingY.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 377);
            this.Controls.Add(this.tbDrawingY);
            this.Controls.Add(this.tbDrawingX);
            this.Controls.Add(this.pbDrawing);
            this.Controls.Add(this.tbVelocityY);
            this.Controls.Add(this.tbVelocityX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVelocityY;
        private System.Windows.Forms.TextBox tbVelocityX;
        private System.Windows.Forms.PictureBox pbDrawing;
        private System.Windows.Forms.TextBox tbDrawingX;
        private System.Windows.Forms.TextBox tbDrawingY;
    }
}

