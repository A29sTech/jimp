using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jimp.core;

namespace jimp.gui
{

    public partial class LayerSetup : Form
    {

        private MainWindow parent;

        public LayerSetup(MainWindow parent)
        {
            InitializeComponent();
            this.parent = parent;
            presetsBox.SelectedIndex = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void presetsBox_IndexChange(object sender, EventArgs e)
        {
            switch (presetsBox.Text)
            {
                case "Std. Photo Defined By Jahid":
                    this.layerWidth.Text = "27";
                    this.nOfCopyInput.Text = "3";
                    break;
                case "W30M : C3":
                    this.layerWidth.Text = "30";
                    this.nOfCopyInput.Text = "3";
                    break;
                default:
                    this.layerWidth.Text = "27";
                    this.nOfCopyInput.Text = "3";
                    break;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            int _numofcopy = (int)this.nOfCopyInput.Value;
            int _width = -1;
            int _height = -1;
            int.TryParse( this.layerWidth.Text, out _width );
            int.TryParse(this.layerHeight.Text, out _height);
            if (_width < 1 || _height < 1) this.Close();
            parent.OnLayerSetupResult( _numofcopy, new Size(Paper.m2p(_width), Paper.m2p(_height)));
            this.Close();
        }
    }
}
