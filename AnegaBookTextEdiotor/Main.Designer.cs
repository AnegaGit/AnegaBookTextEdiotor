namespace WindowsFormsApp2
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ioBookText = new System.Windows.Forms.TextBox();
            this.buttonApplyText = new System.Windows.Forms.Button();
            this.labelBookLength = new System.Windows.Forms.Label();
            this.Page0 = new System.Windows.Forms.RichTextBox();
            this.Page1 = new System.Windows.Forms.RichTextBox();
            this.Page2 = new System.Windows.Forms.RichTextBox();
            this.Page3 = new System.Windows.Forms.RichTextBox();
            this.Page4 = new System.Windows.Forms.RichTextBox();
            this.Page5 = new System.Windows.Forms.RichTextBox();
            this.Page6 = new System.Windows.Forms.RichTextBox();
            this.Page7 = new System.Windows.Forms.RichTextBox();
            this.Page8 = new System.Windows.Forms.RichTextBox();
            this.Page9 = new System.Windows.Forms.RichTextBox();
            this.buttonTexxtToClipboard = new System.Windows.Forms.Button();
            this.ioFirstPage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ioFirstPage)).BeginInit();
            this.SuspendLayout();
            // 
            // ioBookText
            // 
            this.ioBookText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ioBookText.Location = new System.Drawing.Point(13, 45);
            this.ioBookText.Multiline = true;
            this.ioBookText.Name = "ioBookText";
            this.ioBookText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ioBookText.Size = new System.Drawing.Size(260, 515);
            this.ioBookText.TabIndex = 0;
            // 
            // buttonApplyText
            // 
            this.buttonApplyText.Location = new System.Drawing.Point(13, 13);
            this.buttonApplyText.Name = "buttonApplyText";
            this.buttonApplyText.Size = new System.Drawing.Size(260, 23);
            this.buttonApplyText.TabIndex = 1;
            this.buttonApplyText.Text = "Test Text";
            this.buttonApplyText.UseVisualStyleBackColor = true;
            this.buttonApplyText.Click += new System.EventHandler(this.ButtonApplyText_Click);
            // 
            // labelBookLength
            // 
            this.labelBookLength.AutoSize = true;
            this.labelBookLength.Location = new System.Drawing.Point(302, 18);
            this.labelBookLength.Name = "labelBookLength";
            this.labelBookLength.Size = new System.Drawing.Size(105, 13);
            this.labelBookLength.TabIndex = 2;
            this.labelBookLength.Text = "Book has xxx pages.";
            // 
            // Page0
            // 
            this.Page0.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page0.Location = new System.Drawing.Point(305, 48);
            this.Page0.Name = "Page0";
            this.Page0.ReadOnly = true;
            this.Page0.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page0.Size = new System.Drawing.Size(179, 270);
            this.Page0.TabIndex = 3;
            this.Page0.Text = "";
            // 
            // Page1
            // 
            this.Page1.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page1.Location = new System.Drawing.Point(488, 48);
            this.Page1.Name = "Page1";
            this.Page1.ReadOnly = true;
            this.Page1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page1.Size = new System.Drawing.Size(179, 270);
            this.Page1.TabIndex = 3;
            this.Page1.Text = "";
            // 
            // Page2
            // 
            this.Page2.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page2.Location = new System.Drawing.Point(671, 48);
            this.Page2.Name = "Page2";
            this.Page2.ReadOnly = true;
            this.Page2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page2.Size = new System.Drawing.Size(179, 270);
            this.Page2.TabIndex = 3;
            this.Page2.Text = "";
            // 
            // Page3
            // 
            this.Page3.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page3.Location = new System.Drawing.Point(854, 48);
            this.Page3.Name = "Page3";
            this.Page3.ReadOnly = true;
            this.Page3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page3.Size = new System.Drawing.Size(179, 270);
            this.Page3.TabIndex = 3;
            this.Page3.Text = "";
            // 
            // Page4
            // 
            this.Page4.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page4.Location = new System.Drawing.Point(1037, 48);
            this.Page4.Name = "Page4";
            this.Page4.ReadOnly = true;
            this.Page4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page4.Size = new System.Drawing.Size(179, 270);
            this.Page4.TabIndex = 3;
            this.Page4.Text = "";
            // 
            // Page5
            // 
            this.Page5.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page5.Location = new System.Drawing.Point(305, 324);
            this.Page5.Name = "Page5";
            this.Page5.ReadOnly = true;
            this.Page5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page5.Size = new System.Drawing.Size(179, 270);
            this.Page5.TabIndex = 3;
            this.Page5.Text = "";
            // 
            // Page6
            // 
            this.Page6.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page6.Location = new System.Drawing.Point(488, 324);
            this.Page6.Name = "Page6";
            this.Page6.ReadOnly = true;
            this.Page6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page6.Size = new System.Drawing.Size(179, 270);
            this.Page6.TabIndex = 3;
            this.Page6.Text = "";
            // 
            // Page7
            // 
            this.Page7.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page7.Location = new System.Drawing.Point(671, 324);
            this.Page7.Name = "Page7";
            this.Page7.ReadOnly = true;
            this.Page7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page7.Size = new System.Drawing.Size(179, 270);
            this.Page7.TabIndex = 3;
            this.Page7.Text = "";
            // 
            // Page8
            // 
            this.Page8.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page8.Location = new System.Drawing.Point(854, 324);
            this.Page8.Name = "Page8";
            this.Page8.ReadOnly = true;
            this.Page8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page8.Size = new System.Drawing.Size(179, 270);
            this.Page8.TabIndex = 3;
            this.Page8.Text = "";
            // 
            // Page9
            // 
            this.Page9.Font = new System.Drawing.Font("BlackChancery", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page9.Location = new System.Drawing.Point(1037, 324);
            this.Page9.Name = "Page9";
            this.Page9.ReadOnly = true;
            this.Page9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Page9.Size = new System.Drawing.Size(179, 270);
            this.Page9.TabIndex = 3;
            this.Page9.Text = "";
            // 
            // buttonTexxtToClipboard
            // 
            this.buttonTexxtToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTexxtToClipboard.Location = new System.Drawing.Point(13, 566);
            this.buttonTexxtToClipboard.Name = "buttonTexxtToClipboard";
            this.buttonTexxtToClipboard.Size = new System.Drawing.Size(260, 25);
            this.buttonTexxtToClipboard.TabIndex = 5;
            this.buttonTexxtToClipboard.Text = "Copy to Clipboard";
            this.buttonTexxtToClipboard.UseVisualStyleBackColor = true;
            this.buttonTexxtToClipboard.Click += new System.EventHandler(this.buttonTexxtToClipboard_Click);
            // 
            // ioFirstPage
            // 
            this.ioFirstPage.Location = new System.Drawing.Point(610, 16);
            this.ioFirstPage.Name = "ioFirstPage";
            this.ioFirstPage.Size = new System.Drawing.Size(45, 20);
            this.ioFirstPage.TabIndex = 6;
            this.ioFirstPage.ValueChanged += new System.EventHandler(this.ioFirstPage_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Page:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ioFirstPage);
            this.Controls.Add(this.buttonTexxtToClipboard);
            this.Controls.Add(this.Page9);
            this.Controls.Add(this.Page4);
            this.Controls.Add(this.Page8);
            this.Controls.Add(this.Page3);
            this.Controls.Add(this.Page7);
            this.Controls.Add(this.Page6);
            this.Controls.Add(this.Page2);
            this.Controls.Add(this.Page5);
            this.Controls.Add(this.Page1);
            this.Controls.Add(this.Page0);
            this.Controls.Add(this.labelBookLength);
            this.Controls.Add(this.buttonApplyText);
            this.Controls.Add(this.ioBookText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Anega Book Text Editor";
            ((System.ComponentModel.ISupportInitialize)(this.ioFirstPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ioBookText;
        private System.Windows.Forms.Button buttonApplyText;
        private System.Windows.Forms.Label labelBookLength;
        private System.Windows.Forms.RichTextBox Page0;
        private System.Windows.Forms.RichTextBox Page1;
        private System.Windows.Forms.RichTextBox Page2;
        private System.Windows.Forms.RichTextBox Page3;
        private System.Windows.Forms.RichTextBox Page4;
        private System.Windows.Forms.RichTextBox Page5;
        private System.Windows.Forms.RichTextBox Page6;
        private System.Windows.Forms.RichTextBox Page7;
        private System.Windows.Forms.RichTextBox Page8;
        private System.Windows.Forms.RichTextBox Page9;
        private System.Windows.Forms.Button buttonTexxtToClipboard;
        private System.Windows.Forms.NumericUpDown ioFirstPage;
        private System.Windows.Forms.Label label1;
    }
}

