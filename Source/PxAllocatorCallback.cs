using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace NVIDIA.Physix
{
    public unsafe class PxAllocatorCallback
    {
        void* allocate(IntPtr size, char* typeName, char* filename, int line) { return (void*)0x0; }
        void deallocate(void* ptr) { }
    }
}
