using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROISelection
{
    public partial class Form1 : Form
    {
        private string folderPath = string.Empty;
        private List<string> filePaths = new List<string>();

        private Image<Bgr, byte> imageMain, image_Main_Copy;
        private Image<Bgr, byte> imageUL, imageDL, imageUR, imageDR;
        private Image<Bgr, byte> imageCenter;

        //private Rectangle rectUL, rectDL, rectUR, rectDR;
        private Rectangle rectImageUL, rectImageDL, rectImageUR, rectImageDR;
        private Rectangle rectImageCenter;
        private int width;
        private int height;
        
        private int xiUL, yiUL, xiDL, yiDL; //image left ROI position
        private int xiUR, yiUR, xiDR, yiDR; //image right ROI position
        private int xiCenter, yiCenter; //image Center ROI position

        private int step, moveStep;
        private float aspectRatio;
        //private float xpUL, ypUL, xpDL, ypDL; //mouse left ROI position
        //private float xpUR, ypUR, xpDR, ypDR; //mouse left ROI position

        private int ROIsizeX, ROIsizeY;
        private int thinkness = 5;
        private double refX, refY, refZ;

        private DataExcel excel;
        private string[] excelField = { "delta ab", "Y Uniformity", "RG Uniformity",  "BG Uniformity",
            "L", "a", "b", "Y", "R", "G", "B" };

        private string[] itemField = { "UL", "DL", "UR", "DR", "Center"};

        public Form1()
        {
            InitializeComponent();

            btnFolder.Enabled = false;
            btnUpdate.Enabled = false;
            btnIncrease.Enabled = false;
            btnDecrease.Enabled = false;

            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnRight.Enabled = false;
            btnLeft.Enabled = false;

            btnCenterUp.Enabled = false;
            btnCenterDown.Enabled = false;
            btnCenterLeft.Enabled = false;
            btnCenterRight.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Start";
            string imgPath;
            filePaths.Clear();

            openFileDialog1.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Select a picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = "Status: On-Going...";
                folderPath = string.Empty;
                imageMain = new Image<Bgr, byte>(openFileDialog1.FileName);
                imgPath = Path.GetFullPath(openFileDialog1.FileName);
                lblPath.Text = imgPath;

                string[] temp = imgPath.Split('\\');
                for (int i = 0; i < temp.Length - 1; i++)
                {
                    folderPath += temp[i] + "\\";
                }
                Directory.CreateDirectory(folderPath + "Result\\");
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                excel = new DataExcel();

                imgMain.Image = imageMain;
                image_Main_Copy = imageMain.Clone();
                Ini();
                IntROIPosition();
                DrawROI();
                CalUniformity(fileName, 1);
                SaveROI(folderPath + "Result\\" + fileName);

                excel.Save(folderPath + "rawData");
                excel.Close();

                // Enable Button
                btnFolder.Enabled = true;
                btnUpdate.Enabled = true;
                btnIncrease.Enabled = true;
                btnDecrease.Enabled = true;

                btnUp.Enabled = true;
                btnDown.Enabled = true;
                btnRight.Enabled = true;
                btnLeft.Enabled = true;

                btnCenterUp.Enabled = true;
                btnCenterDown.Enabled = true;
                btnCenterLeft.Enabled = true;
                btnCenterRight.Enabled = true;

                lblStatus.Text = "Finish one Picture";
            }
            else
            {
                lblStatus.Text = "No New Picture";
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Start";
            folderBrowserDialog1.SelectedPath = folderPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePaths.Clear();
                CheckFileNumber();

                int fileNumber = filePaths.Count;

                if (fileNumber > 0)
                {
                    lblStatus.Text = "Status: On-Going...";
                    Directory.CreateDirectory(folderPath + "Result\\");
                    excel = new DataExcel();

                    for (int j = 0; j < fileNumber; j++)
                    {
                        
                        string fileName = Path.GetFileNameWithoutExtension(filePaths[j]);
                        //Directory.CreateDirectory(folderPath + "Result\\" + fileName + "\\");

                        imageMain = new Image<Bgr, byte>(filePaths[j]);
                        imgMain.Image = imageMain;
                        image_Main_Copy = imageMain.Clone();
                        Ini();
                        //IntROIPosition();
                        DrawROI();
                        CalUniformity(fileName, j + 1);

                        SaveROI(folderPath + "Result\\" + fileName);
                        lblPath.Text = filePaths[j];
                    }

                    excel.Save(folderPath + "rawData");
                    excel.Close();

                    lblStatus.Text = "Finish All Pictures!!!";
                }
                else
                {
                    lblStatus.Text = "No New Picture";
                }
                
            }
            
        }

        public void CheckFileNumber()
        {
            folderPath = folderBrowserDialog1.SelectedPath + "\\";
            List<string> pathsTemp = Directory.GetFiles(folderPath).ToList();

            for (int i = 0; i < pathsTemp.Count; i++)
            {
                string extension = Path.GetExtension(pathsTemp[i]);
                if (extension.Equals(".jpg") || extension.Equals(".JPG")
                    || extension.Equals(".png") || extension.Equals(".PNG"))
                {
                    filePaths.Add(pathsTemp[i]);
                }
            }
        }

        // calData = { cieL, ciea, cieb, y, r, g, b };
        // result = { delAb, delY, delRg, delBg, cieL, ciea, cieb, y, r, g, b }
        public void CalUniformity(string fileName, int fileNumber)
        {
            double[] dataUL, dataDL, dataUR, dataDR, dataCenter;
            dataUL = CalPic(imageUL);
            dataDL = CalPic(imageDL);
            dataUR = CalPic(imageUR);
            dataDR = CalPic(imageDR);
            dataCenter = CalPic(imageCenter);

            List<double> resultUL = DeltaOutput(txtUL, dataUL, dataCenter);
            List<double> resultDL = DeltaOutput(txtDL, dataDL, dataCenter);
            List<double> resultUR = DeltaOutput(txtUR, dataUR, dataCenter);
            List<double> resultDR = DeltaOutput(txtDR, dataDR, dataCenter);

            int controlRow = 1 + (fileNumber - 1) * 8;

            excel.AddData(controlRow, 1, fileName); // add file name to cell

            // add field to cell
            for (int i = 0; i < excelField.Length; i++)
            {
                excel.AddData(controlRow, i + 2, excelField[i]);
            }

            // add item field to cell
            for (int i = 0; i < itemField.Length; i++)
            {
                excel.AddData(controlRow + i + 1, 1, itemField[i]);
            }
            
            // add delta data to cell
            for (int i = 0; i < resultUL.Count; i++)
            {
                excel.AddData(controlRow + 1, 2 + i, resultUL[i]);
                excel.AddData(controlRow + 2, 2 + i, resultDL[i]);
                excel.AddData(controlRow + 3, 2 + i, resultUR[i]);
                excel.AddData(controlRow + 4, 2 + i, resultDR[i]);
            }

            for (int i = 0; i < dataCenter.Length; i++)
            {
                excel.AddData(controlRow + 5, 6 + i, dataCenter[i]);
            }
            
            txtCenter.Text = "RGB:(" + Math.Round(dataCenter[4], 2) + ", "
                + Math.Round(dataCenter[5], 2) + ", "
                + Math.Round(dataCenter[6], 2) + ")"
                + Environment.NewLine;

            txtCenter.Text += "L*ab:(" + Math.Round(dataCenter[0], 2) + ", "
                + Math.Round(dataCenter[1], 2) + ", "
                + Math.Round(dataCenter[2], 2) + ")"
                + Environment.NewLine;
        }

        // calData = { cieL, ciea, cieb, y, r, g, b };
        public List<double> DeltaOutput(TextBox txtBox, double[] data, double[] dataCenter)
        {
            List<double> result = new List<double>();

            double delAb = Math.Pow(Math.Pow(data[1] - dataCenter[1], 2) + Math.Pow(data[2] - dataCenter[2], 2), 0.5);
            double delY = data[3] / dataCenter[3];
            double delRg = (data[4] / data[5]) / (dataCenter[4] / dataCenter[5]);
            double delBg = (data[6] / data[5]) / (dataCenter[6] / dataCenter[5]);

            result.Add(delAb);
            result.Add(delY);
            result.Add(delRg);
            result.Add(delBg);
            
            for (int i = 0; i < data.Length; i++)
            {
                result.Add(data[i]);
            }

            txtBox.Text = "RGB:(" + Math.Round(data[4], 2) + ", "
                + Math.Round(data[5], 2) + ", "
                + Math.Round(data[6], 2) + ")"
                + Environment.NewLine;

            txtBox.Text += "L*ab:(" + Math.Round(data[0], 2) + ", "
                + Math.Round(data[1], 2) + ", "
                + Math.Round(data[2], 2) + ")"
                + Environment.NewLine;

            txtBox.Text += "delta ab with Center: " + Math.Round(delAb, 2) + Environment.NewLine;
            txtBox.Text += "Ycorner/Ycenter: " + Math.Round(delY*100, 1) + "%" + Environment.NewLine;

            txtBox.Text += "R/G: " + Math.Round(data[4] / data[5], 3) 
                + " (" + Math.Round(delRg*100,1) + "%)" +Environment.NewLine;
            txtBox.Text += "B/G: " + Math.Round(data[6] / data[5], 3)
                + " (" + Math.Round(delBg * 100, 1) + "%)" + Environment.NewLine;

            return result;         
        }

        private void IniTxtBoxValue()
        {
            step = int.Parse(txtStep.Text);
            aspectRatio = float.Parse(txtRatio.Text);
            ROIsizeX = int.Parse(txtROIW.Text);
            ROIsizeY = int.Parse(txtROIH.Text);
            moveStep = int.Parse(txtMove.Text);
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();

            ROIsizeX += (int)Math.Round(step * aspectRatio, 0);
            ROIsizeY += step;

            txtROIW.Text = ROIsizeX.ToString();
            txtROIH.Text = ROIsizeY.ToString();

            SizeROIPosition();
            DrawROI();
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();

            ROIsizeX -= (int)Math.Round(step * aspectRatio, 0);
            ROIsizeY -= step;
            txtROIW.Text = ROIsizeX.ToString();
            txtROIH.Text = ROIsizeY.ToString();

            SizeROIPosition();
            DrawROI();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();

            // Upper-Left
            yiUL -= moveStep;

            // Down-Left
            yiDL += moveStep;

            // Upper-Right
            yiUR -= moveStep;

            // Down-Right
            yiDR += moveStep;

            DrawROI();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();

            // Upper-Left
            yiUL += moveStep;

            // Down-Left
            yiDL -= moveStep;

            // Upper-Right
            yiUR += moveStep;

            // Down-Right
            yiDR -= moveStep;

            DrawROI();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();

            // Upper-Left
            xiUL -= moveStep;

            // Down-Left
            xiDL -= moveStep;

            // Upper-Right
            xiUR += moveStep;

            // Down-Right
            xiDR += moveStep;

            DrawROI();
        }        

        private void btnRight_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();

            // Upper-Left
            xiUL += moveStep;

            // Down-Left
            xiDL += moveStep;

            // Upper-Right
            xiUR -= moveStep;

            // Down-Right
            xiDR -= moveStep;

            DrawROI();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Update ROI";
            string imgPath = lblPath.Text;
            string[] temp = imgPath.Split('\\');
            string path = string.Empty;
            string fileName = string.Empty;
            for (int i = 0; i < temp.Length - 1; i++)
            {
                path += temp[i] + "\\";
            }
            fileName = Path.GetFileNameWithoutExtension(temp[temp.Length - 1]);

            excel = new DataExcel();
            CalUniformity(fileName, 1);
            SaveROI(path + "\\Result\\" + fileName);

            excel.Save(folderPath + "rawData");
            excel.Close();

            lblStatus.Text = "Finish Update";
        }

        public void SaveROI(string path)
        {
            imageUL.Save(path + "_ROI_UL.jpg");
            imageDL.Save(path + "_ROI_DL.jpg");
            imageUR.Save(path + "_ROI_UR.jpg");
            imageDR.Save(path + "_ROI_DR.jpg");
            imageCenter.Save(path + "_ROI_Center.jpg");
        }

        public void ResetAll()
        {
            imageMain = image_Main_Copy = null;
            imageUL = imageDL = imageUR = imageDR = null;
            rectImageUL = rectImageDL = rectImageUR = rectImageDR = Rectangle.Empty;
        }

        public void Ini()
        {
            width = imageMain.Width;
            height = imageMain.Height;
            lblInform.Text = "Width:" + width + ", Height:" + height;
            IniTxtBoxValue();
        }

        public void IntROIPosition()
        {
            // Upper-Left ROI
            xiUL = (int)Math.Round(width * 0.05 / 2.0, 0);
            yiUL = (int)Math.Round(height * 0.05 / 2.0, 0);

            // Down-Left ROI
            xiDL = xiUL;
            yiDL = height - yiUL - ROIsizeY;

            // Upper-Right ROI
            xiUR = width - xiUL - ROIsizeX;
            yiUR = yiUL;

            // Down-Right ROI
            xiDR = width - xiUL - ROIsizeX;
            yiDR = height - yiUL - ROIsizeY;

            // Center
            xiCenter = (int)Math.Round(width / 2.0, 0);
            yiCenter = (int)Math.Round(height / 2.0, 0);
        }

        public void SizeROIPosition()
        {
            // Upper-Left ROI
            //xiUL = (int)Math.Round(width * 0.05 / 2.0, 0);
            //yiUL = (int)Math.Round(height * 0.05 / 2.0, 0);

            // Down-Left ROI
            //xiDL = xiUL;
            yiDL = height - yiUL - ROIsizeY;

            // Upper-Right ROI
            xiUR = width - xiUL - ROIsizeX;
            //yiUR = yiUL;

            // Down-Right ROI
            xiDR = width - xiUL - ROIsizeX;
            yiDR = height - yiUL - ROIsizeY;
        }

        public void DrawROI()
        {
            // Upper-Left ROI
            //Utilities.ImgConvertMouse(imgMain, out xpUL, out ypUL, xiUL, yiUL);
            CalDrawROI(xiUL, yiUL, image_Main_Copy, out imageUL, out rectImageUL);
            picUL.Image = imageUL.ToBitmap();
            imageMain.Draw(rectImageUL, new Bgr(Color.Red), thinkness);

            // Down-Left ROI
            //Utilities.ImgConvertMouse(imgMain, out xpDL, out ypDL, xiDL, yiDL);
            CalDrawROI(xiDL, yiDL, image_Main_Copy, out imageDL, out rectImageDL);
            picDL.Image = imageDL.ToBitmap();
            imageMain.Draw(rectImageDL, new Bgr(Color.Red), thinkness);

            // Upper-Right ROI
            //Utilities.ImgConvertMouse(imgMain, out xpUR, out ypUR, xiUR, yiUR);
            CalDrawROI(xiUR, yiUR, image_Main_Copy, out imageUR, out rectImageUR);
            picUR.Image = imageUR.ToBitmap();
            imageMain.Draw(rectImageUR, new Bgr(Color.Red), thinkness);

            // Down-Right ROI
            //Utilities.ImgConvertMouse(imgMain, out xpDR, out ypDR, xiDR, yiDR);
            CalDrawROI(xiDR, yiDR, image_Main_Copy, out imageDR, out rectImageDR);
            picDR.Image = imageDR.ToBitmap();
            imageMain.Draw(rectImageDR, new Bgr(Color.Red), thinkness);

            // Center
            CalDrawROI(xiCenter, yiCenter, image_Main_Copy, out imageCenter, out rectImageCenter);
            picCenter.Image = imageCenter.ToBitmap();
            imageMain.Draw(rectImageCenter, new Bgr(Color.Red), thinkness);
        }

        public void CalDrawROI(int x, int y, 
            Image<Bgr, byte> imageAll, out Image<Bgr, byte> imageROI,
            out Rectangle rect)
        {
            rect = Rectangle.Empty;

            rect.Location = new Point(x, y);
            rect.Size = new Size(ROIsizeX, ROIsizeY);

            imageROI = imageAll.Clone();
            imageROI.ROI = Rectangle.Empty;
            imageROI.ROI = rect;
        }

        public double[] CalPic(Image<Bgr, byte> img)
        {
            double r = 0, g = 0, b = 0, rg = 0, bg = 0;
            double[] lab;
            double cieL = 0, ciea = 0, cieb = 0;
            double pixelNumber = ROIsizeX * ROIsizeY;
            double y = 0, yAll = 0;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Bgr color = img[j, i];
                    r += color.Red;
                    g += color.Green;
                    b += color.Blue;

                    y = 0.299 * color.Red + 0.587 * color.Green + 0.114 * color.Blue;
                    yAll += y;

                    lab = Rgb2Lab(color.Red, color.Green, color.Blue);
                    cieL += lab[0];
                    ciea += lab[1];
                    cieb += lab[2];
                }
            }
            r /= pixelNumber;
            g /= pixelNumber;
            b /= pixelNumber;
            yAll /= pixelNumber;

            rg = r / g;
            bg = b / g;

            cieL /= pixelNumber;
            ciea /= pixelNumber;
            cieb /= pixelNumber;

            double[] calData = { cieL, ciea, cieb, yAll, r, g, b };

            return calData;

        }

        public double[] Rgb2Lab(double sR, double sG, double sB)
        {
            double[] lab = new double[3];

            // RGB to XYZ
            double var_R = (sR / 255.0);
            double var_G = (sG / 255.0);
            double var_B = (sB / 255.0);

            if (var_R > 0.04045)
            { var_R = Math.Pow(((var_R + 0.055) / 1.055), 2.4); }
            else
            { var_R = var_R / 12.92; }

            if (var_G > 0.04045)
             { var_G = Math.Pow(((var_G + 0.055) / 1.055), 2.4); }
            else
             { var_G = var_G / 12.92; }

            if (var_B > 0.04045)
             { var_B = Math.Pow(((var_B + 0.055) / 1.055), 2.4); }
            else
             { var_B = var_B / 12.92; }

            var_R = var_R * 100;
            var_G = var_G * 100;
            var_B = var_B * 100;

            double X = var_R * 0.4124 + var_G * 0.3576 + var_B * 0.1805;
            double Y = var_R * 0.2126 + var_G * 0.7152 + var_B * 0.0722;
            double Z = var_R * 0.0193 + var_G * 0.1192 + var_B * 0.9505;

            RefWhite(65);
            // XYZ to CIE-L*ab
            double var_X = X / refX;
            double var_Y = Y / refY;
            double var_Z = Z / refZ;

            var judge = Math.Pow((6 / 29.0), 3);
        
            if (var_X > judge)
            { var_X = Math.Pow(var_X, (1 / 3.0)); }
            else
            { var_X = (7.787 * var_X) + (16 / 116.0); }

            if (var_Y > judge)
            { var_Y = Math.Pow(var_Y, (1 / 3.0)); }
            else
            { var_Y = (7.787 * var_Y) + (16 / 116.0); }

            if (var_Z > judge)
            { var_Z = Math.Pow(var_Z, (1 / 3.0)); }
            else
            { var_Z = (7.787 * var_Z) + (16 / 116.0); }

            lab[0]= (116 * var_Y) - 16; // CIE-L*
            lab[1] = 500 * (var_X - var_Y); // CIE-a*
            lab[2] = 200 * (var_Y - var_Z); // CIE-b*

            return lab;
        }

        public void RefWhite(int selection)
        {
            switch (selection)
            {
                case 65:
                    refX = 95.047;
                    refY = 100;
                    refZ = 108.883;
                    break;
                case 50:
                    refX = 96.6797;
                    refY = 100;
                    refZ = 82.5188;
                    break;
            }

        }

        private void imgMain_MouseMove(object sender, MouseEventArgs e)
        {
            int X0, Y0;
            //Utilities.MouseConvertImg(imgMain, out X0, out Y0, e.X, e.Y);
            //lblImagePos.Text = "Image Position: X:" + X0.ToString() + "  Y:" + Y0.ToString();
            lblMousePos.Text = "Mouse Position: X:" + e.X.ToString() + "  Y:" + e.Y.ToString();
        }

        public void DrawCenterROI()
        {
            // Center
            CalDrawROI(xiCenter, yiCenter, image_Main_Copy, out imageCenter, out rectImageCenter);
            picCenter.Image = imageCenter.ToBitmap();
            imageMain.Draw(rectImageCenter, new Bgr(Color.Red), thinkness);

            imageMain.Draw(rectImageUL, new Bgr(Color.Red), thinkness);
            imageMain.Draw(rectImageDL, new Bgr(Color.Red), thinkness);
            imageMain.Draw(rectImageUR, new Bgr(Color.Red), thinkness);
            imageMain.Draw(rectImageDR, new Bgr(Color.Red), thinkness);
        }

        private void btnCenterUp_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();
            yiCenter -= moveStep;
            DrawCenterROI();
        }

        private void btnCenterDown_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();
            yiCenter += moveStep;
            DrawCenterROI();
        }

        private void btnCenterLeft_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();
            xiCenter -= moveStep;
            DrawCenterROI();
        }

        private void btnCenterRight_Click(object sender, EventArgs e)
        {
            imageMain = image_Main_Copy.Clone();
            imgMain.Image = imageMain;
            IniTxtBoxValue();
            xiCenter += moveStep;
            DrawCenterROI();
        }
    }
}
