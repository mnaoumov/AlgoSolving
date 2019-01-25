using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task0588_Design_In_Memory_File_System
{
    public class FileSystem
    {
        private readonly FileSystemItem _root = new FileSystemItem("", FileSystemItemType.Directory);

        public string[] ls(string path)
        {
            var pathParts = SplitPathParts(path);

            var pathItem = _root;

            foreach (var part in pathParts)
            {
                pathItem = pathItem.Find(part);
                if (pathItem == null)
                {
                    return new string[] { };
                }
            }

            return pathItem.List();
        }

        private static string[] SplitPathParts(string path)
        {
            return path.Split('/');
        }

        public void mkdir(string path)
        {
            var pathParts = SplitPathParts(path);

            mkdir(pathParts);
        }

        private FileSystemItem mkdir(IEnumerable<string> pathParts)
        {
            var directory = _root;

            foreach (var part in pathParts)
            {
                directory = directory.Find(part) ?? directory.Create(part, FileSystemItemType.Directory);
            }

            return directory;
        }

        public void addContentToFile(string path, string content)
        {
            var pathParts = SplitPathParts(path);

            var directory = mkdir(pathParts.Take(pathParts.Length - 1));

            var fileName = pathParts.Last();
            var file = directory.Find(fileName) ?? directory.Create(fileName, FileSystemItemType.File);

            file.Content += content;
        }

        public string readContentFromFile(string path)
        {
            var pathParts = SplitPathParts(path);

            var pathItem = _root;

            foreach (var part in pathParts)
            {
                pathItem = pathItem.Find(part);
                if (pathItem == null)
                {
                    return null;
                }
            }

            return pathItem.Type == FileSystemItemType.File ? pathItem.Content : null;
        }

        private class FileSystemItem
        {
            private string Name { get; }
            public FileSystemItemType Type { get; }
            private List<FileSystemItem> ChildItems { get; } = new List<FileSystemItem>();
            public string Content { get; set; } = "";

            public FileSystemItem(string name, FileSystemItemType type)
            {
                Name = name;
                Type = type;
            }

            public FileSystemItem Find(string childName)
            {
                switch (Type)
                {
                    case FileSystemItemType.File:
                        return null;
                    case FileSystemItemType.Directory:
                        return ChildItems.FirstOrDefault(x => x.Name == childName);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            public string[] List()
            {
                switch (Type)
                {
                    case FileSystemItemType.File:
                        return new[] { Name };
                    case FileSystemItemType.Directory:
                        return ChildItems.Select(x => x.Name).OrderBy(x => x).ToArray();
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            public FileSystemItem Create(string childName, FileSystemItemType type)
            {
                var childItem = new FileSystemItem(childName, type);
                ChildItems.Add(childItem);
                return childItem;
            }
        }

        private enum FileSystemItemType
        {
            File,
            Directory
        }
    }
}