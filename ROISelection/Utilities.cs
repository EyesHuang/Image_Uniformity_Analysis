using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROISelection
{
    class Utilities
    {
        /* Picture to image coordinates transformation
          * 輸入 picture coordinates (xp, yp)
          * 輸出 image coordinates (xi, yi)
          */
        public static void MouseConvertImg(PictureBox pic,
            out int xi, out int yi, float xp, float yp)
        {
            int pic_hgt = pic.ClientSize.Height;
            int pic_wid = pic.ClientSize.Width;
            int img_hgt = pic.Image.Height;
            int img_wid = pic.Image.Width;

            xi = 0;
            yi = 0;
            switch (pic.SizeMode)
            {
                case PictureBoxSizeMode.AutoSize:
                    break;
                case PictureBoxSizeMode.Normal:
                    break;
                case PictureBoxSizeMode.CenterImage:
                    xi = (int)Math.Round((xp - (float)(pic_wid - img_wid) / 2),0);
                    yi = (int)Math.Round((yp - (float)(pic_hgt - img_hgt) / 2),0);
                    break;
                case PictureBoxSizeMode.StretchImage:      // 目前使用中
                                                           // image coordinates(xi, yi),  picture coordinates(xp, yp)
                    xi = (int)Math.Round(((float)img_wid * xp / (float)pic_wid),0);
                    yi = (int)Math.Round(((float)img_hgt * yp / (float)pic_hgt),0);
                    break;
                case PictureBoxSizeMode.Zoom:
                    float pic_aspect = (float)pic_wid / (float)pic_hgt;
                    float img_aspect = (float)img_wid / (float)img_hgt;
                    if (pic_aspect > img_aspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        yi = (int)Math.Round((float)(img_hgt * yp / (float)pic_hgt),0);

                        // The image fills the height of the PictureBox.
                        // Get its width.
                        float scaled_width = img_wid * pic_hgt / img_hgt;
                        float dx = ((float)pic_wid - scaled_width) / 2;
                        xi = (int)Math.Round(((xp - dx) * (float)img_hgt / (float)pic_hgt),0);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        xi = (int)Math.Round(((float)img_wid * xp / (float)pic_wid),0);

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        float scaled_height = img_hgt * pic_wid / img_wid;
                        float dy = ((float)pic_hgt - scaled_height) / 2;
                        yi = (int)Math.Round(((yp - dy) * (float)img_wid / (float)pic_wid),0);
                    }
                    break;
            }
        }

        public static void ImgConvertMouse(PictureBox pic,
            out float xp, out float yp, int xi, int yi)
        {
            int pic_hgt = pic.ClientSize.Height;
            int pic_wid = pic.ClientSize.Width;
            int img_hgt = pic.Image.Height;
            int img_wid = pic.Image.Width;

            xp = 0;
            yp = 0;

            switch (pic.SizeMode)
            {
                case PictureBoxSizeMode.Zoom:
                    float pic_aspect = (float)pic_wid / (float)pic_hgt;
                    float img_aspect = (float)img_wid / (float)img_hgt;
                    if (pic_aspect > img_aspect)
                    {
                        // The PictureBox is wider/shorter than the image.
                        yp = yi * pic_hgt / (float)img_hgt;

                        // The image fills the height of the PictureBox.
                        // Get its width.
                        double scaled_width = img_wid * pic_hgt / (double)img_hgt;
                        double dx = (pic_wid - scaled_width) / 2.0;
                        xi = (int)Math.Round(((xp - dx) * (float)img_hgt / (float)pic_hgt), 0);

                        xp = (float)Math.Round((xi * pic_hgt / (double)img_hgt + dx),1);
                    }
                    else
                    {
                        // The PictureBox is taller/thinner than the image.
                        xp = xi * pic_wid / (float)img_wid;

                        // The image fills the height of the PictureBox.
                        // Get its height.
                        double scaled_height = img_hgt * pic_wid / img_wid;
                        double dy = ((double)pic_hgt - scaled_height) / 2;
                        yp = (float)Math.Round((dy + yi * pic_wid / (double)img_wid),1);
                    }
                    break;
            }


        }

    }
}
