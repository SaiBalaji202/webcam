using Emgu.CV;
using Emgu.CV.Structure;
using System.Windows.Forms;
namespace WebCam1
{
    public partial class Form1 : Form
    {
        bool _streaming;
        Capture _capture;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            _streaming = false;
            _capture = new Capture();
        }

        private void btnStreamOnOff_Click(object sender, System.EventArgs e)
        {
            if (!_streaming)
            {
                Application.Idle += streaming;
                btnStreamOnOff.Text = @"Stop Streaming";
            }
            else
            {
                Application.Idle -= streaming;
                btnStreamOnOff.Text = @"Start Streaming";
            }
            _streaming = !_streaming;
        }

        private void btnCapture_Click(object sender, System.EventArgs e)
        {
            picOutput.Image = picStream.Image;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = @"Save Your Photo";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                picOutput.Image.Save(saveFileDialog.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show(@"Saved!");
            }
        }

        // Streaming Event Handler
        private void streaming(object sender, System.EventArgs e)
        {
            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            picStream.Image = bmp;
        }

    }
}
