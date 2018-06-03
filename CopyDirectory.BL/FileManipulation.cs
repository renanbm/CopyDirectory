using System;
using System.Collections.Generic;

namespace CopyDirectory.BL
{
    public static class FileManipulation
    {
        public static void CopyDirectory(string sourceDirectory, string targetDirectory, Action<string> onProgressListener)
        {
            var subDirectoryNewPath = CreateDirectory(sourceDirectory, targetDirectory, onProgressListener);

            var files = System.IO.Directory.GetFiles(sourceDirectory);

            CopyFiles(files, subDirectoryNewPath, onProgressListener);

            var subDirectories = System.IO.Directory.GetDirectories(sourceDirectory);

            if (subDirectories.Length == 0)
                return;

            foreach (var subDirectory in subDirectories)
            {
                CopyDirectory(subDirectory, subDirectoryNewPath, onProgressListener);
            }
        }

        private static string CreateDirectory(string sourceDirectory, string targetDirectory, Action<string> onProgressListener)
        {
            var subDirectoryName = GetName(sourceDirectory);

            var subDirectoryNewPath = $"{targetDirectory}\\{subDirectoryName}";

            onProgressListener($"{DateTime.Now.TimeOfDay} - Creating directory: {subDirectoryNewPath}");

            if(!System.IO.Directory.Exists(subDirectoryNewPath))
                System.IO.Directory.CreateDirectory(subDirectoryNewPath);

            return subDirectoryNewPath;
        }

        private static void CopyFiles(IEnumerable<string> files, string targetDirectory, Action<string> onProgressListener)
        {
            foreach (var file in files)
            {
                var fileName = GetName(file);

                onProgressListener($"{DateTime.Now.TimeOfDay} - Creating file: {fileName}");

                System.IO.File.Copy(file, $"{targetDirectory}\\{fileName}", true);
            }
        }

        private static string GetName(string path)
        {
            var split = path.Split('\\');

            var subDirectoryName = split[split.Length - 1];
            return subDirectoryName;
        }
    }
}
