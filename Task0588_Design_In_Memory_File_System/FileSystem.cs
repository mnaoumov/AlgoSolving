using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoSolving.Task0588_Design_In_Memory_File_System
{
    public class FileSystem
    {
        // ReSharper disable once MemberCanBeMadeStatic.Global
        // ReSharper disable once InconsistentNaming
        public string[] ls(string path)
        {
            FileSystemItem item = FileSystemItem.Get(path);
            return item.List();
        }

        // ReSharper disable once MemberCanBeMadeStatic.Global
        // ReSharper disable once InconsistentNaming
        public void mkdir(string path)
        {
            Directory directory = Directory.Get(path);
            directory.Create();
        }

        // ReSharper disable once MemberCanBeMadeStatic.Global
        // ReSharper disable once InconsistentNaming
        public void addContentToFile(string path, string content)
        {
            File file = File.Get(path);
            file.Create();
            file.Content += content;
        }

        // ReSharper disable once MemberCanBeMadeStatic.Global
        // ReSharper disable once InconsistentNaming
        public string readContentFromFile(string path)
        {
            File file = File.Get(path);
            return file.Content;
        }

        private abstract class FileSystemItem
        {
            private static readonly Directory Root;
            private const char PathSeparator = '/';
            public string Name { get; }
            private Directory ParentDirectory { get; }
            protected bool Exists { private get; set; }

            static FileSystemItem()
            {
                Root = new Directory(null, null)
                {
                    Exists = true
                };
            }

            protected FileSystemItem(string name, Directory parentDirectory)
            {
                Name = name;
                ParentDirectory = parentDirectory;
            }

            public static FileSystemItem Get(string path)
            {
                return Get<FileSystemItem>(path, (name, parentDirectory) => new Directory(name, parentDirectory));
            }

            protected static TFileSystemItem Get<TFileSystemItem>(string path, Func<string, Directory, TFileSystemItem> factory) where TFileSystemItem : FileSystemItem
            {
                if (path == null)
                {
                    throw new ArgumentNullException(nameof(path));
                }

                var wrongTypeException = new ArgumentException("Wrong type", nameof(path));

                if (path == PathSeparator.ToString())
                {
                    if (Root is TFileSystemItem)
                    {
                        return Root as TFileSystemItem;
                    }

                    throw wrongTypeException;
                }

                var invalidPathException = new ArgumentException("Invalid path", nameof(path));

                if (path == "" || path[0] != PathSeparator)
                {
                    throw invalidPathException;
                }

                string[] pathParts = path.Substring(1).Split(PathSeparator);

                Directory directory = Root;

                FileSystemItem child;
                foreach (string directoryName in pathParts.Take(pathParts.Length - 1))
                {
                    child = directory.GetChildItem(directoryName);
                    if (child == null)
                    {
                        directory = new Directory(directoryName, directory);
                    }
                    else if (child is Directory childDirectory)
                    {
                        directory = childDirectory;
                    }
                    else
                    {
                        throw wrongTypeException;
                    }
                }

                string leafName = pathParts.Last();

                child = directory.GetChildItem(leafName);
                TFileSystemItem leaf = factory(leafName, directory);

                if (child == null)
                {
                    return leaf;
                }
                else if (child is TFileSystemItem fileSystemItem)
                {
                    return fileSystemItem;
                }
                else
                {
                    throw wrongTypeException;
                }
            }

            public string[] List()
            {
                if (!Exists)
                {
                    return new string[] { };
                }

                return ListIfExists();
            }

            protected abstract string[] ListIfExists();

            public void Create()
            {
                if (Exists)
                {
                    return;
                }

                ParentDirectory.Create();
                ParentDirectory.ChildItems.Add(this);
                Exists = true;
            }
        }

        private class File : FileSystemItem
        {
            private File(string name, Directory parentDirectory) : base(name, parentDirectory)
            {
            }

            public new static File Get(string path)
            {
                return Get(path, (name, parentDirectory) => new File(name, parentDirectory));
            }

            protected override string[] ListIfExists()
            {
                return new[] { Name };
            }

            public string Content { get; set; } = "";
        }

        private class Directory : FileSystemItem
        {
            public Directory(string name, Directory parentDirectory) : base(name, parentDirectory)
            {
            }

            public List<FileSystemItem> ChildItems { get; } = new List<FileSystemItem>();

            public new static Directory Get(string path)
            {
                return Get(path, (name, parentDirectory) => new Directory(name, parentDirectory));
            }

            protected override string[] ListIfExists()
            {
                return ChildItems.Select(x => x.Name).OrderBy(x => x).ToArray();
            }

            public FileSystemItem GetChildItem(string childName)
            {
                if (string.IsNullOrEmpty(childName))
                {
                    throw new ArgumentException("Invalid name", nameof(childName));
                }

                return ChildItems.FirstOrDefault(x => x.Name == childName);
            }
        }
    }
}