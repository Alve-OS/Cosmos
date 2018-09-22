using System;

using Cosmos.HAL.BlockDevice;
using Cosmos.System.FileSystem.SFS;

namespace Cosmos.System.FileSystem
{
    public class SFSFileSystemFactory : FileSystemFactory
    {
        public override string Name => "SFS";

        public override bool IsType(Partition aDevice)
        {
            return true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SFSFileSystem"/> class.
        /// </summary>
        /// <param name="aDevice">The partition.</param>
        /// <param name="aRootPath">The root path.</param>
        /// <exception cref="Exception">SFS signature not found.</exception>
        public override FileSystem Create(Partition aDevice, string aRootPath, long aSize)
        {
            var sfs = new SimpleFS(aDevice, aRootPath, aSize);
            sfs.Load();
            return sfs;
        } 
    }
}
