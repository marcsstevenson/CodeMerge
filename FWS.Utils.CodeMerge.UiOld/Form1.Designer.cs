namespace CodeMerge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtInputCode = new System.Windows.Forms.TextBox();
			this.txtOutputCode = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnMerge = new System.Windows.Forms.Button();
			this.btnFlip = new System.Windows.Forms.Button();
			this.txtSubstitutions = new System.Windows.Forms.TextBox();
			this.btnQuote = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSwapValue = new System.Windows.Forms.TextBox();
			this.cbCamel = new System.Windows.Forms.CheckBox();
			this.lblSwapCode = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbAddSpaces = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtInputCode
			// 
			this.txtInputCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.txtInputCode.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInputCode.Location = new System.Drawing.Point(12, 29);
			this.txtInputCode.Multiline = true;
			this.txtInputCode.Name = "txtInputCode";
			this.txtInputCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtInputCode.Size = new System.Drawing.Size(337, 608);
			this.txtInputCode.TabIndex = 0;
			// 
			// txtOutputCode
			// 
			this.txtOutputCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutputCode.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutputCode.Location = new System.Drawing.Point(545, 29);
			this.txtOutputCode.Multiline = true;
			this.txtOutputCode.Name = "txtOutputCode";
			this.txtOutputCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutputCode.Size = new System.Drawing.Size(564, 608);
			this.txtOutputCode.TabIndex = 1;
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClear.Location = new System.Drawing.Point(355, 461);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(184, 23);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnMerge
			// 
			this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnMerge.Location = new System.Drawing.Point(355, 490);
			this.btnMerge.Name = "btnMerge";
			this.btnMerge.Size = new System.Drawing.Size(184, 23);
			this.btnMerge.TabIndex = 4;
			this.btnMerge.Text = "Merge";
			this.btnMerge.UseVisualStyleBackColor = true;
			this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
			// 
			// btnFlip
			// 
			this.btnFlip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFlip.Location = new System.Drawing.Point(356, 432);
			this.btnFlip.Name = "btnFlip";
			this.btnFlip.Size = new System.Drawing.Size(183, 23);
			this.btnFlip.TabIndex = 5;
			this.btnFlip.Text = "Flip";
			this.btnFlip.UseVisualStyleBackColor = true;
			this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
			// 
			// txtSubstitutions
			// 
			this.txtSubstitutions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.txtSubstitutions.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubstitutions.Location = new System.Drawing.Point(356, 29);
			this.txtSubstitutions.Multiline = true;
			this.txtSubstitutions.Name = "txtSubstitutions";
			this.txtSubstitutions.Size = new System.Drawing.Size(183, 370);
			this.txtSubstitutions.TabIndex = 6;
			// 
			// btnQuote
			// 
			this.btnQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnQuote.Location = new System.Drawing.Point(355, 403);
			this.btnQuote.Name = "btnQuote";
			this.btnQuote.Size = new System.Drawing.Size(183, 23);
			this.btnQuote.TabIndex = 7;
			this.btnQuote.Text = "C# Quote";
			this.btnQuote.UseVisualStyleBackColor = true;
			this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(355, 600);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Swap Value";
			// 
			// txtSwapValue
			// 
			this.txtSwapValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSwapValue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSwapValue.Location = new System.Drawing.Point(358, 618);
			this.txtSwapValue.Name = "txtSwapValue";
			this.txtSwapValue.Size = new System.Drawing.Size(181, 23);
			this.txtSwapValue.TabIndex = 9;
			// 
			// cbCamel
			// 
			this.cbCamel.AutoSize = true;
			this.cbCamel.Location = new System.Drawing.Point(11, 20);
			this.cbCamel.Name = "cbCamel";
			this.cbCamel.Size = new System.Drawing.Size(55, 17);
			this.cbCamel.TabIndex = 10;
			this.cbCamel.Text = "Camel";
			this.cbCamel.UseVisualStyleBackColor = true;
			// 
			// lblSwapCode
			// 
			this.lblSwapCode.AutoSize = true;
			this.lblSwapCode.Location = new System.Drawing.Point(13, 13);
			this.lblSwapCode.Name = "lblSwapCode";
			this.lblSwapCode.Size = new System.Drawing.Size(59, 13);
			this.lblSwapCode.TabIndex = 11;
			this.lblSwapCode.Text = "Input Code";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(358, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Substitutions";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(545, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Output Code";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.cbAddSpaces);
			this.groupBox1.Controls.Add(this.cbCamel);
			this.groupBox1.Location = new System.Drawing.Point(359, 519);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(180, 68);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Merge Options";
			// 
			// cbAddSpaces
			// 
			this.cbAddSpaces.AutoSize = true;
			this.cbAddSpaces.Location = new System.Drawing.Point(11, 43);
			this.cbAddSpaces.Name = "cbAddSpaces";
			this.cbAddSpaces.Size = new System.Drawing.Size(84, 17);
			this.cbAddSpaces.TabIndex = 11;
			this.cbAddSpaces.Text = "Add Spaces";
			this.cbAddSpaces.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1121, 649);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSwapCode);
			this.Controls.Add(this.txtSwapValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnQuote);
			this.Controls.Add(this.txtSubstitutions);
			this.Controls.Add(this.btnFlip);
			this.Controls.Add(this.btnMerge);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtOutputCode);
			this.Controls.Add(this.txtInputCode);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(764, 323);
			this.Name = "Form1";
			this.Text = "Code Merge";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputCode;
        private System.Windows.Forms.TextBox txtOutputCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.TextBox txtSubstitutions;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSwapValue;
		private System.Windows.Forms.CheckBox cbCamel;
		private System.Windows.Forms.Label lblSwapCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbAddSpaces;
    }
}

