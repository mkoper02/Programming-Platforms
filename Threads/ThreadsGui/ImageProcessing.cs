namespace ThreadsGui {
    public class ImageProcessing {
        public static Bitmap InvertColors(Bitmap Image) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }

            return Image;
        }

        public static Bitmap Grayscale(Bitmap Image) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var avg = (pixel.R + pixel.G + pixel.B) / 3;
                    Image.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }

            return Image;
        }

        public static Bitmap Thresholding(Bitmap Image, int value) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var avg = (pixel.R + pixel.G + pixel.B) / 3;
                    Image.SetPixel(i, j, avg > value ? Color.Black : Color.White);
                }

            return Image;
        }

        public static Bitmap Sepia(Bitmap Image) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var r = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    var g = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    var b = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);
                    Image.SetPixel(i, j, Color.FromArgb(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b));
                }

            return Image;
        }

        public static Bitmap Brightness(Bitmap Image, int value) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    var r = pixel.R + value;
                    var g = pixel.G + value;
                    var b = pixel.B + value;
                    Image.SetPixel(i, j, Color.FromArgb(r > 255 ? 255 : r, g > 255 ? 255 : g, b > 255 ? 255 : b));
                }

            return Image;
        }

        public static Bitmap RedChannelColor(Bitmap Image) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(pixel.R, 0, 0));
                }

            return Image;
        }

        public static Bitmap GreenChannelColor(Bitmap Image) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(0, pixel.G, 0));
                }

            return Image;
        }

        public static Bitmap BlueChannelColor(Bitmap Image) {
            for (var i = 0; i < Image.Width; i++)
                for (var j = 0; j < Image.Height; j++) {
                    var pixel = Image.GetPixel(i, j);
                    Image.SetPixel(i, j, Color.FromArgb(0, 0, pixel.B));
                }

            return Image;
        }
    }
}
