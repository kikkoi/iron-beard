using System.IO;

namespace IronBeard.Core.Features.FileSystem
{
    public class InputFile
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string BaseDirectory { get; set; }
        public string FullDirectory => Path.GetFullPath(BaseDirectory + RelativeDirectory);
        public string FullPath => Path.Combine(FullDirectory, Name + Extension);
        public string RelativePath => Path.Combine(RelativeDirectory, Name + Extension);
        public string RelativeDirectory { get; set; }
    }
}