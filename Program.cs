using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Diccionario_Personal
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormMain());
            test();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string url = "C:\archivo.xml";
            OpenFileDialog openFile = initDirectoryFile();
            if (File.Exists(url))
                Console.WriteLine("yes");
            else
                openFile.ShowDialog();

        }
        static private OpenFileDialog initDirectoryFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "XML files (*.xml) | *.xml |All files(*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            return openFileDialog;
        }
        static private void test()
        {
            
        }
    }
}
