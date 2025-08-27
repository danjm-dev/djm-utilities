namespace DJM.Utilities
{
    public enum ImageFormat : byte
    {
        PNG = 0,
        JPEG = 1,
        TGA = 2,
        EXR = 3,
    }

    public static class ImageFormatExtensions
    {
        private const string PngExtension = "png";
        private const string JpegExtension = "jpg";
        private const string TgaExtension = "tga";
        private const string EXRExtension = "exr";
        
        public static string GetFileExtension(this ImageFormat format)
        {
            return format switch
            {
                ImageFormat.PNG => PngExtension,
                ImageFormat.JPEG => JpegExtension,
                ImageFormat.TGA => TgaExtension,
                ImageFormat.EXR => EXRExtension,
                _ => string.Empty
            };
        }
    }
}