using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using jimp.core;
using jimp.gui;

namespace jimp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (test()) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] arg = { "C:\\Users\\Jahid\\Desktop\\y.jpg" };
            Application.Run(new MainWindow( arg ));
        }

        public static bool test()
        {
            List<Preset> presets;
            var file = new StreamReader("C:\\Users\\Jahid\\Desktop\\abc.json");
            presets = Preset.LoadFromJson(file.ReadToEnd());
            Console.WriteLine( presets[0].InnerArea );
            file.Close();

            return true;
        }

    }
}
