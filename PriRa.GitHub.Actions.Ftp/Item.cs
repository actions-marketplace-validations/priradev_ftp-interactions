﻿namespace PriRa.GitHub.Actions.Ftp
{
    internal class Item
    {

        public string FullPath { get; set; }
        public string LocalPath { get; set; }
        public string Directory { get; set; }
        public string Name { get; set; }

        public Item(string filename, string originalPath)
        {
            FullPath = Standardize(filename);
            LocalPath = FullPath.Substring(originalPath.Length).TrimStart('/');

            var split = LocalPath.LastIndexOf('/');
            if (split > 0)
            {
                Directory = LocalPath.Substring(0, split);
                Name = LocalPath.Substring(split + 1).TrimStart('/');
            }
            else
            {
                Directory = "/";
                Name = LocalPath.TrimStart('/');
            }
        }

        private string Standardize(string filename)
        {
            // All slashes, all the time.
            filename = filename.Replace('\\', '/');

            // Result.
            return filename;
        }

    }
}