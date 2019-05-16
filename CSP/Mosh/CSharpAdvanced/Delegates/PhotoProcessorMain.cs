using System;

namespace CSP.Mosh.CSharpAdvanced.Delegates
{
    public class PhotoProcessorMain
    {
        public static void Run()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        public static void RemoveRedEyeFilter(Photo photo) => Console.WriteLine("Apply RemoveRedEye");
    }
}