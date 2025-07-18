using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace localrtmp
{
    public static class rtmp
    {
        private static VideoCapture capture;
        public static Mat frame = new Mat();

        public static bool Init(string url)
        {
            capture = new VideoCapture(url, VideoCaptureAPIs.FFMPEG); //Open the stream, you can remove the API argument but specifying it is generally better

            if (capture.IsOpened())
            {
                Console.WriteLine("Successfully opened stream.");
                return true;
            }
            else
            {
                Console.WriteLine("Failed to open stream!");
                return false;
            }
        }
        
        public static bool Capture()
        {
            while (true)
            {
                if (!capture.Read(frame) || frame.Empty()) //Check if capture failed or frame is empty (stream ended, blank stream, etc.)
                {
                    Console.WriteLine("Failed to read frame!");
                }
                else
                {
                    //Convert to bitmap if you want to process it further internally, send to another method etc.
                    //Bitmap bitmap = BitmapConverter.ToBitmap(frame);

                    //Display directly in a new window
                    //Cv2.ImShow("RTMP Stream", frame);
                }
            }
        }
    }
}
