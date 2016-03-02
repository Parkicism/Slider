namespace Twack_0._999
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblMC = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblGS = new System.Windows.Forms.Label();
            this.cbRow = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnScramble = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblR = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMC.Location = new System.Drawing.Point(507, 227);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(81, 18);
            this.lblMC.TabIndex = 19;
            this.lblMC.Text = "Move Count:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(622, 227);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 18);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Time:";
            // 
            // lblGS
            // 
            this.lblGS.AutoSize = true;
            this.lblGS.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGS.Location = new System.Drawing.Point(491, 110);
            this.lblGS.Name = "lblGS";
            this.lblGS.Size = new System.Drawing.Size(124, 35);
            this.lblGS.TabIndex = 17;
            this.lblGS.Text = "Grid Size";
            // 
            // cbRow
            // 
            this.cbRow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRow.FormattingEnabled = true;
            this.cbRow.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbRow.Location = new System.Drawing.Point(562, 180);
            this.cbRow.Name = "cbRow";
            this.cbRow.Size = new System.Drawing.Size(53, 21);
            this.cbRow.TabIndex = 16;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(512, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 49);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Twack 0.1";
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(485, 258);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(261, 199);
            this.pbImage.TabIndex = 14;
            this.pbImage.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(545, 468);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 23);
            this.btnUpload.TabIndex = 13;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnScramble
            // 
            this.btnScramble.Location = new System.Drawing.Point(625, 130);
            this.btnScramble.Name = "btnScramble";
            this.btnScramble.Size = new System.Drawing.Size(100, 36);
            this.btnScramble.TabIndex = 12;
            this.btnScramble.Text = "Scramble";
            this.btnScramble.UseVisualStyleBackColor = true;
            this.btnScramble.Click += new System.EventHandler(this.btnScramble_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(625, 172);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(100, 36);
            this.btnGen.TabIndex = 11;
            this.btnGen.Text = "Generate / Reset";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // cbColumn
            // 
            this.cbColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumn.FormattingEnabled = true;
            this.cbColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbColumn.Location = new System.Drawing.Point(562, 151);
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Size = new System.Drawing.Size(53, 21);
            this.cbColumn.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(507, 149);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(54, 23);
            this.lblR.TabIndex = 22;
            this.lblR.Text = "Rows:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(486, 178);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(75, 23);
            this.lblC.TabIndex = 23;
            this.lblC.Text = "Columns:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 503);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.cbColumn);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblGS);
            this.Controls.Add(this.cbRow);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnScramble);
            this.Controls.Add(this.btnGen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblGS;
        private System.Windows.Forms.ComboBox cbRow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnScramble;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblC;
    }
}

