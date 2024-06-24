using System;
using System.Windows.Forms;
using ImageMagick;
using System.IO;
using System.Threading.Tasks;

namespace conversor_intento2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.Click += new EventHandler(this.btnConvertir_Click);

            // Permite que la ventana del formulario se maximice y cambie de tamaño.
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Ajusta la imagen de fondo al tamaño del formulario.
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private async void btnConvertir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HEIC files (*.heic)|*.heic";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("¿Dónde quieres guardar tus imágenes?", "Guardar imágenes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaCarpetaSalida = folderBrowserDialog.SelectedPath;

                    // Crea una nueva ventana de formulario para la barra de progreso.
                    Form progressForm = new Form();
                    ProgressBar progressBar = new ProgressBar();
                    progressForm.Controls.Add(progressBar);
                    progressForm.Show();

                    // Configura la barra de progreso.
                    progressBar.Maximum = openFileDialog.FileNames.Length;
                    progressBar.Value = 0;

                    // Establece un tamaño específico para la barra de progreso y la ventana del formulario.
                    progressBar.Width = 300;
                    progressBar.Height = 30;
                    progressForm.Width = 350;
                    progressForm.Height = 100;

                    // Centra la ventana de la barra de progreso en la pantalla.
                    progressForm.StartPosition = FormStartPosition.CenterScreen;

                    await Task.Run(() =>
                    {
                        foreach (string rutaArchivoEntrada in openFileDialog.FileNames)
                        {
                            string nombreArchivo = Path.GetFileNameWithoutExtension(rutaArchivoEntrada);
                            string rutaArchivoSalida = Path.Combine(rutaCarpetaSalida, nombreArchivo + ".jpg");

                            using (MagickImage image = new MagickImage(rutaArchivoEntrada))
                            {
                                image.Write(rutaArchivoSalida);
                            }

                            // Actualiza la barra de progreso.
                            progressForm.Invoke((MethodInvoker)delegate
                            {
                                progressBar.Value++;
                            });
                        }
                    });

                    // Cierra la ventana de la barra de progreso cuando la conversión haya terminado.
                    progressForm.Close();

                    MessageBox.Show("Las imágenes han sido convertidas exitosamente y guardadas en la ubicación seleccionada.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
