using System;

namespace CSP.Mosh.CSharpAdvanced.Delegates
{
    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler?.Invoke(photo);

            photo.Save();
        }
    }
}