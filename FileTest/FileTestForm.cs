using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTest
{
    public partial class FileTestForm : Form
    {
        public FileTestForm()
        {
            InitializeComponent();
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                outputTextBox.Text = string.Empty;
                string fileName = inputTextBox.Text;

                IFileSystemRepository repository 
                    = new FileSystemRepository(fileName);
                string info = repository.GetInformation();

                if (info != null)
                {
                    outputTextBox.AppendText(info);

                    if(repository.FileExists())
                    {
                        string content = repository.ReadFile();
                        if (content != null)
                        {
                            outputTextBox.AppendText(content);
                        }
                        else
                        {
                            MessageBox.Show("Error al leer del archivo",
                                "Error de archivo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string[] directoryList 
                            = repository.GetDirectories();

                        outputTextBox.AppendText("Contenido del directorio:\n"
                            + Environment.NewLine);
                        foreach (string directory in directoryList)
                        {
                            outputTextBox.AppendText($"{directory}\n"
                                + Environment.NewLine);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"{inputTextBox.Text} no existe",
                                "Error de archivo", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
        }
    }
}
