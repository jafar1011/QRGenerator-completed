using QRCoder;
using QRGenerator.Properties;
using System.Diagnostics;

namespace QRGenerator
{
    public partial class Form1 : Form
    {
        string url = "https://github.com/jafar1011";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (string.IsNullOrWhiteSpace(input)) return;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            pictureBox1.Image = qrCodeImage;
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save QR Code";
                saveFileDialog.FileName = "QRCode.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image original = Resources.generate;
            Image resized = new Bitmap(original, new Size(32, 32));

            button1.Image = resized;
            button1.ImageAlign = ContentAlignment.MiddleLeft;

            button1.Padding = new Padding(30, 0, 0, 0);

            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.TextImageRelation = TextImageRelation.Overlay;


            Image original2 = Resources.download;
            Image resized2 = new Bitmap(original2, new Size(28, 28));

            button3.Image = resized2;
            button3.ImageAlign = ContentAlignment.MiddleLeft;

            button3.Padding = new Padding(30, 0, 0, 0);

            button3.TextAlign = ContentAlignment.MiddleCenter;
            button3.TextImageRelation = TextImageRelation.Overlay;





        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.HotTrack;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open link: " + ex.Message);
            }
        }
    }
}
