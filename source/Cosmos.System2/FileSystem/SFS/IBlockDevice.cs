using System;
using System.Collections.Generic;
using System.Text;

namespace Cosmos.System.FileSystem.SFS
{
    public interface IBlockDevice
    {
        long BlockSize { get; }
        long TotalBlocks { get; }

        byte[] ReadBlock(long offset);
        void WriteBlock(long offset, byte[] block);
    }
}
