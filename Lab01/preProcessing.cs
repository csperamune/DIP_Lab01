using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace Lab01
{
    class preProcessing
    {
        IplImage src;
        private CvArr dst;


        public void loadOriginalImage()
        {
            src = Cv.LoadImage("eye.jpg", LoadMode.Color);
            Cv.SaveImage("1.jpg", src);
        }
        public void grayScaleImage()
        {
            dst = Cv.LoadImage("1.jpg", LoadMode.GrayScale);
            Cv.CvtColor(src, dst, ColorConversion.RgbToGray);
            Cv.SaveImage("2.jpg", dst);
        }
        public int extractImageWight(int size)
        {
            return src.Width;
        }

        public int extractImageHeight(int Height)
        {
            return src.Height;
        }

        public int extractImageChannels(int ElemChannels)
        {
            return src.ElemChannels;
        }
    }
}
