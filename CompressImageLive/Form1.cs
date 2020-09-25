using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompressImageLive
{
    public partial class Form1 : Form
    {
        #region Private Fields
        private string compressedFile = "";
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.png;*.jpg;*.jpeg;*.gif;*.tiff;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.tiff;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtOriginalImgPath.Text = openFileDialog.FileName;
        }

        private void txtOriginalImgPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtOriginalImgPath.Text) && IsFileImage(txtOriginalImgPath.Text))
                LoadOriginalImage();
        }

        private void trackBarPercent_Scroll(object sender, EventArgs e)
        {
            txtCompressPercent.Text = trackBarPercent.Value.ToString();
            if (File.Exists(compressedFile))
                SaveJpeg(compressedFile, pictureBoxOriginal.Image, trackBarPercent.Value);
        }

        private void txtCompressPercent_TextChanged(object sender, EventArgs e)
        {
            int val = 0;
            int.TryParse(txtCompressPercent.Text, out val);

            if (val < 0 || val > 100)
                val = 100;
            txtCompressPercent.Text = val.ToString();
            trackBarPercent.Value = val;
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtOriginalImgPath.Text))
            {
                MessageBox.Show("Choose image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            compressedFile = Path.Combine(Path.GetDirectoryName(txtOriginalImgPath.Text), Path.GetFileNameWithoutExtension(txtOriginalImgPath.Text)) + "_Compressed.jpg";
            SaveJpeg(compressedFile, pictureBoxOriginal.Image, trackBarPercent.Value);
        }

        private void btnShowInExplorer_Click(object sender, EventArgs e)
        {
            if (!File.Exists(compressedFile))
            {
                MessageBox.Show("Compressed file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string argument = @"/select, " + compressedFile;
                System.Diagnostics.Process.Start("explorer.exe", argument);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load original image to picture box
        /// </summary>
        private void LoadOriginalImage()
        {
            using (Image original = Image.FromFile(txtOriginalImgPath.Text))
                pictureBoxOriginal.Image = Image.FromFile(txtOriginalImgPath.Text);
            lblOriginalSize.Text = GetFileSize(txtOriginalImgPath.Text);
        }

        /// <summary> 
        /// Saves an image as a jpeg image, with the given quality 
        /// </summary> 
        /// <param name="path"> Path to which the image would be saved. </param> 
        /// <param name="quality"> An integer from 0 to 100, with 100 being the highest quality. </param> 
        public void SaveJpeg(string path, Image img, int quality)
        {
            if (quality < 0 || quality > 100)
                throw new ArgumentOutOfRangeException("Quality must be between 0 and 100.");

            // Encoder parameter for image quality 
            EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            // JPEG image codec 
            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");
            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;
            img.Save(path, jpegCodec, encoderParams);
            using (FileStream stream = new FileStream(compressedFile, FileMode.Open, FileAccess.Read))
            {
                pictureBoxCompressed.Image = Image.FromStream(stream);
            }
            lblCompressedSize.Text = GetFileSize(compressedFile);
        }

        /// <summary> 
        /// Returns the image codec with the given mime type 
        /// </summary> 
        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            // Get image codecs for all image formats 
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec 
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType == mimeType)
                    return codecs[i];

            return null;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Get file size string
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public string GetFileSize(string filepath)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(filepath).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }

        /// <summary>
        ///Check if file is image by it's extension 
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public bool IsFileImage(string filepath)
        {
            string ext = Path.GetExtension(filepath).ToLower();
            if (ext == ".png" || ext == ".jpg" || ext == ".jpeg" || ext == ".gif" || ext == ".tiff"||ext== ".bmp")
                return true;
            else
                return false;
        }
        #endregion
    }
}
