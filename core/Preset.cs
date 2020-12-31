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
        public string unit { get; private set; }
        public Size PaperSize { get; private set; }
        public Rectangle InnerArea { get; private set; }
        #endregion

        public static List<Preset> LoadFromJson(string json)
        {
            List<Preset> presets = new List<Preset>();
            try
            {
                foreach( var jsonPreset in JsonConvert.DeserializeObject<JsonPreset[]>(json))
                {
                    var size = new Size(jsonPreset.PaperSize.Width, jsonPreset.PaperSize.Width);
                    var rect = new Rectangle();
                    var preset = new Preset();
                    rect.X = jsonPreset.InnerRect.X;
                    rect.Y = jsonPreset.InnerRect.Y;
                    rect.Width = jsonPreset.InnerRect.W;
                    rect.Height = jsonPreset.InnerRect.H;
                    preset.name = jsonPreset.name;
                    preset.unit = jsonPreset.unit;
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
