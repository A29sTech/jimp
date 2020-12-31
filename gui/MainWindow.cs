using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using jimp.core;

namespace jimp.gui
{
    public partial class MainWindow : Form
    {

        private Paper paper;
        private Bitmap rendered;
        private Size layerSize;
        private int layerCopies;

        public MainWindow(string[] args)
        {
            InitializeComponent();
            this.paper = new Paper(new Size(2480, 3508));
            this.paper.SetInnerArea(new Rectangle(Paper.m2p(3), Paper.m2p(1), 0, 0));
            this.rendered = null;
            this.layerSize = new Size();
            this.layerCopies = 1;

            // Add Args Images;
            ShowLayerSetup();
            foreach (var arg in args) AddLayer(arg);
            ShowPaper(true);
        }



        #region Event Handlers;

        // Custom Callback From LayerSetup Form;
        public void OnLayerSetupResult(int numofcopy, Size size)
        {
            this.layerCopies = numofcopy;
            this.layerSize = size;
        }

        private void iLayerAddBtn_Click(object sender, EventArgs e)
        {

            var fileChooser = new OpenFileDialog();
            fileChooser.Title = "Choose A Photo ...";
            fileChooser.Filter = "Image (*.jpg)|*.jpg|Image (*.png)|*.png";
            fileChooser.CheckFileExists = true;
            fileChooser.Multiselect = true;
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                ShowLayerSetup();
                new Thread(()=> {

                    List<string> names = new List<string>();

                    foreach (var file in fileChooser.FileNames)
                    {
                        var name = AddLayer(file, false);
                        if (name != null) names.Add(name);
                    }

                    Invoke((Action)(() =>
                    {
                        iLayerSelectComboBox.Items.AddRange( names.ToArray() );
                        ShowPaper(true);
                    }));
                }).Start();
            }
        }

        private void iLayerRemoveBtn_Click(object sender, EventArgs e)
        {
            if( this.paper.layers.ContainsKey(iLayerSelectComboBox.Text) )
            {
                this.paper.RemoveLayer( iLayerSelectComboBox.Text );
                iLayerSelectComboBox.Items.Remove(iLayerSelectComboBox.Text);
                ShowPaper(true);
            }
        }
        

        private void iLayerCopiesInput_ValueChange(object sender, EventArgs e)
        {
            iLayerUpdateBtn.Enabled = true;
        }


        private void iLayerUpdateBtn_Click(object sender, EventArgs e)
        {
            iLayerUpdateBtn.Enabled = false;
            if (this.paper.layers.ContainsKey(iLayerSelectComboBox.Text))
            {
                this.paper.layers[iLayerSelectComboBox.Text]
                    .SetNumberOfCopy((int)iLayerCopiesInput.Value);
                ShowPaper(true);
            }
        }


        private void iLayerSelectComboBox_IndexChange(object sender, EventArgs e)
        {
            if ( iLayerSelectComboBox.Text == "`Paper" )
            {
                DrawPaper();
                iLayerRemoveBtn.Enabled = false;
                iLayerCopiesInput.Enabled = false;
                iLayerUpdateBtn.Enabled = false;
            } else if (this.paper.layers.ContainsKey(iLayerSelectComboBox.Text))
            {
                imView.Image = this.paper.layers[iLayerSelectComboBox.Text].Img;
                iLayerCopiesInput.Value = this.paper.layers[iLayerSelectComboBox.Text].Cpy;
                iLayerRemoveBtn.Enabled =true;
                iLayerCopiesInput.Enabled = true;
                iLayerUpdateBtn.Enabled = false;
            }
            else
            {
                iLayerRemoveBtn.Enabled = false;
                iLayerCopiesInput.Enabled = false;
                iLayerUpdateBtn.Enabled = false;
            }
        }


        #endregion Event Handlers;


        #region Actions Functions;


        public void Render()
        {
            this.rendered = this.paper.Draw(10);
        }

        public void DrawPaper(bool render=false)
        {
            if (render) Render();
            if (this.rendered != null) imView.Image = this.rendered;
        }


        public void ShowPaper(bool render=false)
        {
            if (iLayerSelectComboBox.SelectedIndex == 0 && render) DrawPaper(render);
            else if (render) Render();
            iLayerSelectComboBox.SelectedIndex = 0; // Reset To Paper;
        }


        public void ShowLayerSetup()
        {
            // TODO: display a dialog!
            var dialog = new LayerSetup(this);
            dialog.ShowDialog();
        }


        #endregion Actions Functions;


        #region Core Functions;
        public string AddLayer(string path, bool uise=true)
        { // uise = use ui -> acsess ui;
            var layerName = Path.GetFileName(path);
            if (this.paper.layers.ContainsKey(layerName))
            {
                MessageBox.Show("Duplicate Layer Name!");
                return "";
            }
            var layer = new Layer(path, this.layerCopies);
            layer.Resize(layerSize, 3);
            this.paper.AddLayer(layerName, layer);
            if (uise) iLayerSelectComboBox.Items.Add(layerName);
            return layerName;
        }


        public void AddLayer(Layer layer, string name)
        {
            this.paper.AddLayer(name, layer);
            iLayerSelectComboBox.Items.Add(name);
        }

        #endregion Core Functions;
    }
}
