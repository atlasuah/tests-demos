namespace MapperTest
{
    partial class MapperDemo
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.btnScale = new System.Windows.Forms.Button();
            this.tbScale = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbBumpX = new System.Windows.Forms.TextBox();
            this.tbBumpY = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPointCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbMap.Location = new System.Drawing.Point(12, 12);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(503, 507);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseMove);
            this.pbMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseClick);
            this.pbMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseDown);
            this.pbMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseUp);
            this.pbMap.SizeChanged += new System.EventHandler(this.pbMap_SizeChanged);
            // 
            // btnScale
            // 
            this.btnScale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnScale.Location = new System.Drawing.Point(595, 52);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(75, 23);
            this.btnScale.TabIndex = 1;
            this.btnScale.Text = "Set Scale";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // tbScale
            // 
            this.tbScale.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbScale.Location = new System.Drawing.Point(607, 26);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(63, 20);
            this.tbScale.TabIndex = 2;
            this.tbScale.Text = "1";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(595, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Map";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbBumpX
            // 
            this.tbBumpX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbBumpX.Location = new System.Drawing.Point(607, 231);
            this.tbBumpX.Name = "tbBumpX";
            this.tbBumpX.Size = new System.Drawing.Size(63, 20);
            this.tbBumpX.TabIndex = 4;
            // 
            // tbBumpY
            // 
            this.tbBumpY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbBumpY.Location = new System.Drawing.Point(608, 258);
            this.tbBumpY.Name = "tbBumpY";
            this.tbBumpY.Size = new System.Drawing.Size(62, 20);
            this.tbBumpY.TabIndex = 5;
            // 
            // btnZero
            // 
            this.btnZero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnZero.Location = new System.Drawing.Point(595, 313);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 23);
            this.btnZero.TabIndex = 6;
            this.btnZero.Text = "Center Shift";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // tbPosX
            // 
            this.tbPosX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbPosX.Location = new System.Drawing.Point(604, 382);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(66, 20);
            this.tbPosX.TabIndex = 7;
            // 
            // tbPosY
            // 
            this.tbPosY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbPosY.Location = new System.Drawing.Point(604, 408);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(66, 20);
            this.tbPosY.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.Location = new System.Drawing.Point(595, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Map";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSet
            // 
            this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSet.Location = new System.Drawing.Point(595, 284);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "Set Shift";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Scale:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mouse Y:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mouse X:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Shift X:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Shift Y:";
            // 
            // tbPointCount
            // 
            this.tbPointCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbPointCount.Location = new System.Drawing.Point(604, 478);
            this.tbPointCount.Name = "tbPointCount";
            this.tbPointCount.Size = new System.Drawing.Size(66, 20);
            this.tbPointCount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Points:";
            // 
            // MappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 537);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPointCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.tbBumpY);
            this.Controls.Add(this.tbBumpX);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbScale);
            this.Controls.Add(this.btnScale);
            this.Controls.Add(this.pbMap);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(700, 565);
            this.Name = "MappingForm";
            this.Text = "Mapping Demo";
            this.Load += new System.EventHandler(this.MappingForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MappingForm_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MappingForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.TextBox tbScale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbBumpX;
        private System.Windows.Forms.TextBox tbBumpY;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPointCount;
        private System.Windows.Forms.Label label6;
    }
}

