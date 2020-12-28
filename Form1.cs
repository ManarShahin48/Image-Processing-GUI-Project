using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Cuda;

namespace IP_GUI_Project
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> imgGray;
        Image<Gray, byte> imgBinarize;
        public Form1()
        {
            InitializeComponent();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"F:\data\lena.jpg";
                Image<Bgr, byte> img = new Image<Bgr, byte>(path);
                pictureBox1.Image = img.ToBitmap();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }*/

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                this.pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //pictureBox1.Image = imgInput.Bitmap;
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bGRToGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Gray, byte> imgOutPut = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            //imgOutPut = imgInput.Convert<Gray, byte>();
            CvInvoke.CvtColor(imgInput, imgOutPut, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            pictureBox2.Image = imgOutPut.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bGR2YCrCbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Ycc, byte> imgOutPut = new Image<Ycc, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutPut = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            //imgOutPut = imgInput.Convert<Gray, byte>();
            CvInvoke.CvtColor(imgInput, imgOutPut, Emgu.CV.CvEnum.ColorConversion.Bgr2YCrCb);

            imgFinalOutPut.Data = imgOutPut.Data;
            pictureBox2.Image = imgFinalOutPut.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bGRHSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Hsv, byte> imgOutPut = new Image<Hsv, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutPut = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            //imgOutPut = imgInput.Convert<Gray, byte>();
            CvInvoke.CvtColor(imgInput, imgOutPut, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

            imgFinalOutPut.Data = imgOutPut.Data;
            pictureBox2.Image = imgFinalOutPut.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bGRLuvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Luv, byte> imgOutPut = new Image<Luv, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutPut = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            //imgOutPut = imgInput.Convert<Gray, byte>();
            CvInvoke.CvtColor(imgInput, imgOutPut, Emgu.CV.CvEnum.ColorConversion.Bgr2Luv);

            imgFinalOutPut.Data = imgOutPut.Data;
            pictureBox2.Image = imgFinalOutPut.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bGRLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Lab, byte> imgOutPut = new Image<Lab, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutPut = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            //imgOutPut = imgInput.Convert<Gray, byte>();
            CvInvoke.CvtColor(imgInput, imgOutPut, Emgu.CV.CvEnum.ColorConversion.Bgr2Lab);

            imgFinalOutPut.Data = imgOutPut.Data;
            pictureBox2.Image = imgFinalOutPut.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bGRHLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Hls, byte> imgOutPut = new Image<Hls, byte>(imgInput.Width, imgInput.Height);
            Image<Bgr, byte> imgFinalOutPut = new Image<Bgr, byte>(imgInput.Width, imgInput.Height);
            //imgOutPut = imgInput.Convert<Gray, byte>();
            CvInvoke.CvtColor(imgInput, imgOutPut, Emgu.CV.CvEnum.ColorConversion.Bgr2Hls);

            imgFinalOutPut.Data = imgOutPut.Data;
            pictureBox2.Image = imgFinalOutPut.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));
            _imgCanny = imgInput.Canny(20, 50);
          // pictureBox2.Image = _imgCanny.Bitmap;
            pictureBox2.Image = _imgCanny.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void sobalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }
            Image<Gray, byte> _imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgSobel = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

            _imgSobel = _imgGray.Sobel(1, 1, 3);
           // pictureBox2.Image = _imgSobel.Bitmap;
            pictureBox2.Image = _imgSobel.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }

            Image<Gray, byte> _imgGray = imgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgLaplacian = new Image<Gray, float>(imgInput.Width, imgInput.Height, new Gray(0));

            _imgLaplacian = _imgGray.Laplace(7);
            //pictureBox2.Image = _imgLaplacian.Bitmap;
            pictureBox2.Image = _imgLaplacian.ToBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void watershedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    MessageBox.Show("please select an image.");
                    return;
                }
                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                var mask = img.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
                Mat distanceTransform = new Mat();
                CvInvoke.DistanceTransform(mask, distanceTransform, null, Emgu.CV.CvEnum.DistType.L2, 3);
                CvInvoke.Normalize(distanceTransform, distanceTransform, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
                var markers = distanceTransform.ToImage<Gray, byte>().ThresholdBinary(new Gray(50), new Gray(255));
                CvInvoke.ConnectedComponents(markers, markers);
                var finalmarkers = markers.Convert<Gray, Int32>();
                CvInvoke.Watershed(img, finalmarkers);
                Image<Gray, byte> boundaaries = finalmarkers.Convert<byte>(delegate (Int32 x)
                  {
                      return (byte)(x == -1 ? 255 : 0);
                  });
                boundaaries._Dilate(1);
                img.SetValue(new Bgr(0, 255, 0), boundaaries);
                // AddImage(img, "");
                pictureBox2.Image = img.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grabCutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip5_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }
            var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

            img = img.Rotate(90, new Bgr(0, 0, 0), false);

            pictureBox2.Image = img.AsBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           /*try
            {
                if (pictureBox1.Image == null)
                {
                    return;
                }
                Image<Bgra, byte> imginput = new Image<Bgra, byte>("F:\\data\fruits.jpg");
                Image<Bgra, byte> imgoutput = new Image<Bgra, byte>(imginput.Size);
                
                CudaImage<Bgra, byte> cudaImage = new CudaImage<Bgra, byte>(imgInput);
                CudaInvoke.MeanShiftSegmentation(cudaImage, imgoutput, 15, 30, 50, new MCvTermCriteria(10));
                
                pictureBox1.Image = imginput.ToBitmap();
                pictureBox2.Image = imgoutput.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }
            var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

            img = img.Rotate(180, new Bgr(0, 0, 0), false);

            pictureBox2.Image = img.AsBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rotate270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("please select an image.");
                return;
            }
            var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

            img = img.Rotate(270, new Bgr(0, 0, 0), false);

            pictureBox2.Image = img.AsBitmap();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    MessageBox.Show("please select an image.");
                    return;
                }
                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();
                var mask = img.Convert<Gray, byte>().ThresholdBinaryInv(new Gray(150), new Gray(255));
                Mat distanceTransform = new Mat();
                CvInvoke.DistanceTransform(mask, distanceTransform, null, Emgu.CV.CvEnum.DistType.L2, 3);
                CvInvoke.Normalize(distanceTransform, distanceTransform, 0, 255, Emgu.CV.CvEnum.NormType.MinMax);
                var markers = distanceTransform.ToImage<Gray, byte>().ThresholdBinary(new Gray(50), new Gray(255));
                CvInvoke.ConnectedComponents(markers, markers);
                var finalmarkers = markers.Convert<Gray, Int32>();
                CvInvoke.Watershed(img, finalmarkers);
                Image<Gray, byte> boundaaries = finalmarkers.Convert<byte>(delegate (Int32 x)
                {
                    return (byte)(x == -1 ? 255 : 0);
                });
                boundaaries._Dilate(1);
                img.SetValue(new Bgr(0, 255, 0), boundaaries);
                // AddImage(img, "");
                pictureBox2.Image = img.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aaaaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adaptiveThresholdingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    MessageBox.Show("please select an image.");
                    return;
                }
                imgGray = imgInput.Convert<Gray, byte>();
                pictureBox1.Image = imgGray.ToBitmap();
                //pictureBox2.Image = img.ToBitmap();
                imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));
                CvInvoke.Threshold(imgGray, imgBinarize, 500, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
                pictureBox2.Image = imgBinarize.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adaptiveThresholdingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    MessageBox.Show("please select an image.");
                    return;
                }
                imgGray = imgInput.Convert<Gray, byte>();
                pictureBox1.Image = imgGray.ToBitmap();
                
                imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));
               
                CvInvoke.AdaptiveThreshold(imgGray, imgBinarize,255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary,5,0.0);
                pictureBox2.Image = imgBinarize.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adaptiveThresholdingMeanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    MessageBox.Show("please select an image.");
                    return;
                }
                imgGray = imgInput.Convert<Gray, byte>();
                pictureBox1.Image = imgGray.ToBitmap();

                imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));

                CvInvoke.AdaptiveThreshold(imgGray, imgBinarize, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 5, 0.0);
                pictureBox2.Image = imgBinarize.ToBitmap();
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    