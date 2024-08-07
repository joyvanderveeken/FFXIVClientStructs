// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe partial struct MotionTimeline {
    [FieldOffset(0x00)] public int Filename_Offset;
    [FieldOffset(0x04)] public byte BlendGroup;
    [FieldOffset(0x05)] public byte Unknown_70_1;
    [FieldOffset(0x06)] public byte Unknown_70_2;
    [FieldOffset(0x07)] public BitField07Flags BitField07;
    public bool IsLoop => BitField07.HasFlag(BitField07Flags.IsLoop);
    public bool IsBlinkEnable => BitField07.HasFlag(BitField07Flags.IsBlinkEnable);
    public bool IsLipEnable => BitField07.HasFlag(BitField07Flags.IsLipEnable);

    [Flags]
    public enum BitField07Flags : byte {
    	IsLoop = 1 << 0,
    	IsBlinkEnable = 1 << 1,
    	IsLipEnable = 1 << 2,
    }
}
