// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x0C)]
public unsafe partial struct ActionSetting {
    [FieldOffset(0x00)] public int Unknown0;
    [FieldOffset(0x04)] public int Unknown1;
    [FieldOffset(0x08)] public byte Unknown2;
    [FieldOffset(0x09)] public BitField09Flags BitField09;
    public bool Unknown3 => BitField09.HasFlag(BitField09Flags.Unknown3);
    public bool Unknown4 => BitField09.HasFlag(BitField09Flags.Unknown4);
    public bool Unknown5 => BitField09.HasFlag(BitField09Flags.Unknown5);
    public bool Unknown6 => BitField09.HasFlag(BitField09Flags.Unknown6);

    [Flags]
    public enum BitField09Flags : byte {
    	Unknown3 = 1 << 0,
    	Unknown4 = 1 << 1,
    	Unknown5 = 1 << 2,
    	Unknown6 = 1 << 3,
    }
}
