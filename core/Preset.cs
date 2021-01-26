using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace jimp.core
{

    class Preset
    {
        #region Json Structs
        private struct JsonSize { public int Width, Height; }
        private struct JsonRect { public int X, Y, W, H; }
        private struct JsonPreset
        {
            public string name, unit;
            public JsonSize PaperSize;
            public JsonRect InnerRect;
        }
        #endregion

        #region Variables; NaverChange!
        public string name { get; private set; }
        public Size PaperSize { get; private set; }
        public Rectangle InnerArea { get; private set; }
        #endregion

        public Preset Reset()
        {
            this.name = "Default";
            this.PaperSize = new Size(2480, 3508);
            this.InnerArea = new Rectangle();
            return this;
        }

        public static List<Preset> LoadFromJson(string json)
        {
            List<Preset> presets = new List<Preset>();
            presets.Add(new Preset().Reset()); // Add Default Preset;
            try
            {
                foreach( var jsonPreset in JsonConvert.DeserializeObject<JsonPreset[]>(json))
                {
                    var size = new Size(jsonPreset.PaperSize.Width, jsonPreset.PaperSize.Height);
                    var rect = new Rectangle();
                    var preset = new Preset();
                    
                    switch(jsonPreset.unit.ToLower())
                    {
                        case "mm":
                            size.Width = Paper.m2p(jsonPreset.PaperSize.Width);
                            size.Height = Paper.m2p(jsonPreset.PaperSize.Height);
                            rect.X = Paper.m2p(jsonPreset.InnerRect.X);
                            rect.Y = Paper.m2p(jsonPreset.InnerRect.Y);
                            rect.Width = Paper.m2p(jsonPreset.InnerRect.W);
                            rect.Height = Paper.m2p(jsonPreset.InnerRect.H);
                            break;

                        default:
                            rect.X = jsonPreset.InnerRect.X;
                            rect.Y = jsonPreset.InnerRect.Y;
                            rect.Width = jsonPreset.InnerRect.W;
                            rect.Height = jsonPreset.InnerRect.H;
                            break;
                    }

                    preset.name = jsonPreset.name;
                    preset.PaperSize = size;
                    preset.InnerArea = rect;
                    presets.Add(preset);

                }
            }
            catch {}
            return presets;
        }

    }

}
