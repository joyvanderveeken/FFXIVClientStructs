// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0xD0)]
public unsafe partial struct GFATE {
    [FieldOffset(0x00), FixedSizeArray] internal FixedSizeArray15<GFATEParamsStruct> _gFATEParams;
    [FieldOffset(0xB4)] public uint Unknown0;
    [FieldOffset(0xB8)] public uint Unknown1;
    [FieldOffset(0xBC)] public BitFieldBCFlags BitFieldBC;
    public bool Unknown2 => BitFieldBC.HasFlag(BitFieldBCFlags.Unknown2);
    public bool Unknown3 => BitFieldBC.HasFlag(BitFieldBCFlags.Unknown3);
    public bool Unknown4 => BitFieldBC.HasFlag(BitFieldBCFlags.Unknown4);
    [FieldOffset(0xC0)] public uint Unknown5;
    [FieldOffset(0xC4)] public uint Unknown6;
    [FieldOffset(0xC8)] public ushort Unknown7;
    [FieldOffset(0xCA)] public ushort Unknown8;
    [FieldOffset(0xCC)] public ushort Unknown9;
    [FieldOffset(0xCE)] public byte Unknown10;
    [FieldOffset(0xCF)] public byte Unknown11;

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public partial struct GFATEParamsStruct {
        /// <remarks>Level</remarks>
        [FieldOffset(0x00)] public uint LGBPopRange;
        [FieldOffset(0x04)] public uint Icon;
        [FieldOffset(0x08)] public BitField08Flags BitField08;
        public bool Unknown0 => BitField08.HasFlag(BitField08Flags.Unknown0);
        public bool Unknown1 => BitField08.HasFlag(BitField08Flags.Unknown1);
        public bool Unknown2 => BitField08.HasFlag(BitField08Flags.Unknown2);
    
        [Flags]
        public enum BitField08Flags : byte {
        	Unknown0 = 1 << 0,
        	Unknown1 = 1 << 1,
        	Unknown2 = 1 << 2,
        }
    }
    [Flags]
    public enum BitFieldBCFlags : byte {
    	Unknown2 = 1 << 0,
    	Unknown3 = 1 << 1,
    	Unknown4 = 1 << 2,
    }
}
