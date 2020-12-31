
namespace jimp.gui
{
    partial class LayerSetup
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.layerWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.layerHeight = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.presetsBox = new System.Windows.Forms.ComboBox();
            this.nOfCopyInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nOfCopyInput)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(89, 117);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // layerWidth
            // 
            this.layerWidth.Location = new System.Drawing.Point(62, 39);
            this.layerWidth.Name = "layerWidth";
            this.layerWidth.Size = new System.Drawing.Size(102, 20);
            this.layerWidth.TabIndex = 1;
            this.layerWidth.Text = "27";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height :";
            // 
            // layerHeight
            // 
            this.layerHeight.Location = new System.Drawing.Point(62, 65);
            this.layerHeight.Name = "layerHeight";
            this.layerHeight.Size = new System.Drawing.Size(102, 20);
            this.layerHeight.TabIndex = 5;
            this.layerHeight.Text = "0";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(12, 117);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // presetsBox
            // 
            this.presetsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetsBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.presetsBox.FormattingEnabled = true;
            this.presetsBox.Items.AddRange(new object[] {
            "Std. Photo Defined By Jahid"});
            this.presetsBox.Location = new System.Drawing.Point(12, 12);
            this.presetsBox.Name = "presetsBox";
            this.presetsBox.Size = new System.Drawing.Size(152, 21);
            this.presetsBox.TabIndex = 7;
            // 
            // nOfCopyInput
            // 
            this.nOfCopyInput.Location = new System.Drawing.Point(12, 91);
            this.nOfCopyInput.Maximum = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.nOfCopyInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nOfCopyInput.Name = "nOfCopyInput";
            this.nOfCopyInput.Size = new System.Drawing.Size(152, 20);
            this.nOfCopyInput.TabIndex = 8;
            this.nOfCopyInput.Tag = "Num Of Copy";
            this.nOfCopyInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LayerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(176, 154);
            this.Controls.Add(this.nOfCopyInput);
            this.Controls.Add(this.presetsBox);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.layerHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.layerWidth);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "LayerSetup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LayerSetup";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nOfCopyInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox layerWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox layerHeight;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ComboBox presetsBox;
        private System.Windows.Forms.NumericUpDown nOfCopyInput;
    }
}