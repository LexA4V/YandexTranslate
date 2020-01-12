namespace YandexTranslate
{
    partial class MainForm
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
            this.btnTranslate = new System.Windows.Forms.Button();
            this.tBOutput = new System.Windows.Forms.TextBox();
            this.tBSource = new System.Windows.Forms.TextBox();
            this.cBLangSorce = new System.Windows.Forms.ComboBox();
            this.cBLangOutput = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.btnSwap = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(301, 40);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(106, 53);
            this.btnTranslate.TabIndex = 0;
            this.btnTranslate.Text = "Перевести";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // tBOutput
            // 
            this.tBOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBOutput.Enabled = false;
            this.tBOutput.Location = new System.Drawing.Point(415, 40);
            this.tBOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tBOutput.Multiline = true;
            this.tBOutput.Name = "tBOutput";
            this.tBOutput.Size = new System.Drawing.Size(290, 320);
            this.tBOutput.TabIndex = 1;
            // 
            // tBSource
            // 
            this.tBSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBSource.Location = new System.Drawing.Point(4, 40);
            this.tBSource.Margin = new System.Windows.Forms.Padding(4);
            this.tBSource.Multiline = true;
            this.tBSource.Name = "tBSource";
            this.tBSource.Size = new System.Drawing.Size(289, 320);
            this.tBSource.TabIndex = 1;
            // 
            // cBLangSorce
            // 
            this.cBLangSorce.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBLangSorce.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBLangSorce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBLangSorce.FormattingEnabled = true;
            this.cBLangSorce.Location = new System.Drawing.Point(3, 3);
            this.cBLangSorce.Name = "cBLangSorce";
            this.cBLangSorce.Size = new System.Drawing.Size(291, 26);
            this.cBLangSorce.TabIndex = 3;
            // 
            // cBLangOutput
            // 
            this.cBLangOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBLangOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBLangOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBLangOutput.FormattingEnabled = true;
            this.cBLangOutput.Location = new System.Drawing.Point(414, 3);
            this.cBLangOutput.Name = "cBLangOutput";
            this.cBLangOutput.Size = new System.Drawing.Size(292, 26);
            this.cBLangOutput.TabIndex = 3;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.ColumnCount = 3;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel.Controls.Add(this.cBLangSorce, 0, 0);
            this.panel.Controls.Add(this.cBLangOutput, 2, 0);
            this.panel.Controls.Add(this.btnTranslate, 1, 1);
            this.panel.Controls.Add(this.tBSource, 0, 1);
            this.panel.Controls.Add(this.tBOutput, 2, 1);
            this.panel.Controls.Add(this.btnSwap, 1, 0);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.RowCount = 2;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel.Size = new System.Drawing.Size(709, 364);
            this.panel.TabIndex = 4;
            // 
            // btnSwap
            // 
            this.btnSwap.AutoSize = true;
            this.btnSwap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSwap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSwap.Location = new System.Drawing.Point(301, 4);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(106, 28);
            this.btnSwap.TabIndex = 0;
            this.btnSwap.Text = "<->";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 388);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "TranslateForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox tBOutput;
        private System.Windows.Forms.TextBox tBSource;
        private System.Windows.Forms.ComboBox cBLangSorce;
        private System.Windows.Forms.ComboBox cBLangOutput;
        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.Button btnSwap;
    }
}

