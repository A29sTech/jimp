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
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
