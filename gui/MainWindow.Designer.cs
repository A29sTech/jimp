
namespace jimp.gui
{
    partial class MainWindow
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
            this.controls = new System.Windows.Forms.Panel();
            this.iLayerSelectComboBox = new System.Windows.Forms.ComboBox();
            this.iLayerRemoveBtn = new System.Windows.Forms.Button();
            this.iLayerAddBtn = new System.Windows.Forms.Button();
            this.gfx = new System.Windows.Forms.Panel();
            this.imView = new System.Windows.Forms.PictureBox();
            this.iLayerCopiesInput = new System.Windows.Forms.NumericUpDown();
            this.iLayerUpdateBtn = new System.Windows.Forms.Button();
            this.controls.SuspendLayout();
            this.gfx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLayerCopiesInput)).BeginInit();
            this.SuspendLayout();
            // 
            // controls
            // 
            this.controls.BackColor = System.Drawing.SystemColors.Control;
            this.controls.Controls.Add(this.iLayerUpdateBtn);
            this.controls.Controls.Add(this.iLayerCopiesInput);
            this.controls.Controls.Add(this.iLayerSelectComboBox);
            this.controls.Controls.Add(this.iLayerRemoveBtn);
            this.controls.Controls.Add(this.iLayerAddBtn);
            this.controls.Dock = System.Windows.Forms.DockStyle.Left;
            this.controls.Location = new System.Drawing.Point(0, 0);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(174, 356);
            this.controls.TabIndex = 0;
            // 
            // iLayerSelectComboBox
            // 
            this.iLayerSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iLayerSelectComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iLayerSelectComboBox.FormattingEnabled = true;
            this.iLayerSelectComboBox.Items.AddRange(new object[] {
            "`Paper"});
            this.iLayerSelectComboBox.Location = new System.Drawing.Point(6, 67);
            this.iLayerSelectComboBox.Name = "iLayerSelectComboBox";
            this.iLayerSelectComboBox.Size = new System.Drawing.Size(156, 21);
            this.iLayerSelectComboBox.TabIndex = 2;
            this.iLayerSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.iLayerSelectComboBox_IndexChange);
            // 
            // iLayerRemoveBtn
            // 
            this.iLayerRemoveBtn.Enabled = false;
            this.iLayerRemoveBtn.Location = new System.Drawing.Point(87, 12);
            this.iLayerRemoveBtn.Name = "iLayerRemoveBtn";
            this.iLayerRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.iLayerRemoveBtn.TabIndex = 1;
            this.iLayerRemoveBtn.Text = "Remove";
            this.iLayerRemoveBtn.UseVisualStyleBackColor = true;
            this.iLayerRemoveBtn.Click += new System.EventHandler(this.iLayerRemoveBtn_Click);
            // 
            // iLayerAddBtn
            // 
            this.iLayerAddBtn.Location = new System.Drawing.Point(6, 12);
            this.iLayerAddBtn.Name = "iLayerAddBtn";
            this.iLayerAddBtn.Size = new System.Drawing.Size(75, 23);
            this.iLayerAddBtn.TabIndex = 0;
            this.iLayerAddBtn.Text = "Add";
            this.iLayerAddBtn.UseVisualStyleBackColor = true;
            this.iLayerAddBtn.Click += new System.EventHandler(this.iLayerAddBtn_Click);
            // 
            // gfx
            // 
            this.gfx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gfx.Controls.Add(this.imView);
            this.gfx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gfx.Location = new System.Drawing.Point(174, 0);
            this.gfx.Name = "gfx";
            this.gfx.Size = new System.Drawing.Size(449, 356);
            this.gfx.TabIndex = 1;
            // 
            // imView
            // 
            this.imView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imView.Location = new System.Drawing.Point(0, 0);
            this.imView.Name = "imView";
            this.imView.Size = new System.Drawing.Size(449, 356);
            this.imView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imView.TabIndex = 0;
            this.imView.TabStop = false;
            // 
            // iLayerCopiesInput
            // 
            this.iLayerCopiesInput.Enabled = false;
            this.iLayerCopiesInput.Location = new System.Drawing.Point(6, 41);
            this.iLayerCopiesInput.Name = "iLayerCopiesInput";
            this.iLayerCopiesInput.Size = new System.Drawing.Size(75, 20);
            this.iLayerCopiesInput.TabIndex = 3;
            this.iLayerCopiesInput.ValueChanged += new System.EventHandler(this.iLayerCopiesInput_ValueChange);
            // 
            // iLayerUpdateBtn
            // 
            this.iLayerUpdateBtn.Enabled = false;
            this.iLayerUpdateBtn.Location = new System.Drawing.Point(88, 37);
            this.iLayerUpdateBtn.Name = "iLayerUpdateBtn";
            this.iLayerUpdateBtn.Size = new System.Drawing.Size(74, 23);
            this.iLayerUpdateBtn.TabIndex = 4;
            this.iLayerUpdateBtn.Text = "Update";
            this.iLayerUpdateBtn.UseVisualStyleBackColor = true;
            this.iLayerUpdateBtn.Click += new System.EventHandler(this.iLayerUpdateBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 356);
            this.Controls.Add(this.gfx);
            this.Controls.Add(this.controls);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "MainWindow";
            this.Text = "Jimp";
            this.controls.ResumeLayout(false);
            this.gfx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iLayerCopiesInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controls;
        private System.Windows.Forms.Panel gfx;
        private System.Windows.Forms.Button iLayerRemoveBtn;
        private System.Windows.Forms.Button iLayerAddBtn;
        private System.Windows.Forms.PictureBox imView;
        private System.Windows.Forms.ComboBox iLayerSelectComboBox;
        private System.Windows.Forms.NumericUpDown iLayerCopiesInput;
        private System.Windows.Forms.Button iLayerUpdateBtn;
    }
}