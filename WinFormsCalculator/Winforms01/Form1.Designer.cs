namespace Winforms01
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
            this.txtUserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualBotton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.CeroButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourBotton = new System.Windows.Forms.Button();
            this.MultButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserInputText
            // 
            this.txtUserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserInputText.Location = new System.Drawing.Point(12, 29);
            this.txtUserInputText.Name = "txtUserInputText";
            this.txtUserInputText.Size = new System.Drawing.Size(460, 20);
            this.txtUserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Location = new System.Drawing.Point(12, 55);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(375, 51);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter an equation and press enter or =";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.ColumnCount = 4;
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonPanel.Controls.Add(this.EqualBotton, 3, 4);
            this.ButtonPanel.Controls.Add(this.PointButton, 2, 4);
            this.ButtonPanel.Controls.Add(this.CeroButton, 1, 4);
            this.ButtonPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonPanel.Controls.Add(this.FourBotton, 0, 2);
            this.ButtonPanel.Controls.Add(this.MultButton, 3, 1);
            this.ButtonPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonPanel.Controls.Add(this.DivisionButton, 3, 0);
            this.ButtonPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonPanel.Location = new System.Drawing.Point(15, 109);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.RowCount = 5;
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonPanel.Size = new System.Drawing.Size(457, 326);
            this.ButtonPanel.TabIndex = 2;
            // 
            // EqualBotton
            // 
            this.EqualBotton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualBotton.Location = new System.Drawing.Point(345, 263);
            this.EqualBotton.Name = "EqualBotton";
            this.EqualBotton.Size = new System.Drawing.Size(109, 60);
            this.EqualBotton.TabIndex = 19;
            this.EqualBotton.Text = "=";
            this.EqualBotton.UseVisualStyleBackColor = true;
            this.EqualBotton.Click += new System.EventHandler(this.EqualBotton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointButton.Location = new System.Drawing.Point(231, 263);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(108, 60);
            this.PointButton.TabIndex = 18;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // CeroButton
            // 
            this.CeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CeroButton.Location = new System.Drawing.Point(117, 263);
            this.CeroButton.Name = "CeroButton";
            this.CeroButton.Size = new System.Drawing.Size(108, 60);
            this.CeroButton.TabIndex = 17;
            this.CeroButton.Text = "0";
            this.CeroButton.UseVisualStyleBackColor = true;
            this.CeroButton.Click += new System.EventHandler(this.CeroButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(345, 198);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(109, 59);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(231, 198);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(108, 59);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(117, 198);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(108, 59);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 198);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(108, 59);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Location = new System.Drawing.Point(345, 133);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(109, 59);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(231, 133);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(108, 59);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(117, 133);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(108, 59);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourBotton
            // 
            this.FourBotton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourBotton.Location = new System.Drawing.Point(3, 133);
            this.FourBotton.Name = "FourBotton";
            this.FourBotton.Size = new System.Drawing.Size(108, 59);
            this.FourBotton.TabIndex = 8;
            this.FourBotton.Text = "4";
            this.FourBotton.UseVisualStyleBackColor = true;
            this.FourBotton.Click += new System.EventHandler(this.FourBotton_Click);
            // 
            // MultButton
            // 
            this.MultButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultButton.Location = new System.Drawing.Point(345, 68);
            this.MultButton.Name = "MultButton";
            this.MultButton.Size = new System.Drawing.Size(109, 59);
            this.MultButton.TabIndex = 7;
            this.MultButton.Text = "X";
            this.MultButton.UseVisualStyleBackColor = true;
            this.MultButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(231, 68);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(108, 59);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(117, 68);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(108, 59);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 68);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(108, 59);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivisionButton.Location = new System.Drawing.Point(345, 3);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(109, 59);
            this.DivisionButton.TabIndex = 3;
            this.DivisionButton.Text = "%";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.PorcentButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Location = new System.Drawing.Point(231, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(108, 59);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(108, 59);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualBotton;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.txtUserInputText);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button EqualBotton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button CeroButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourBotton;
        private System.Windows.Forms.Button MultButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button DelButton;
    }
}

