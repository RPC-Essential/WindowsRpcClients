//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\Sens.dll
// Interface ID: 63fbe424-2029-11d1-8db8-00aa004abd5e
// Interface Version: 1.0



namespace rpc_63fbe424_2029_11d1_8db8_00aa004abd5e_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, int Member8, int MemberC)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("63fbe424-2029-11d1-8db8-00aa004abd5e", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint RPC_IsNetworkAlive(out int p0, out int p1, out int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadInt32();
            p1 = u.ReadInt32();
            p2 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint RPC_IsDestinationReachableA(string p0, ref System.Nullable<Struct_0> p1, out int p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<Struct_0>(m.Write_0));
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            p2 = u.ReadInt32();
            p3 = u.ReadInt32();
            return u.ReadUInt32();
        }
        public uint RPC_IsDestinationReachableA_2(string p0, ref System.Nullable<Struct_0> p1, out int p2, out int p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedAnsiString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.WriteReferent(p1, new System.Action<Struct_0>(m.Write_0));
            _Unmarshal_Helper u = SendReceive(2, m);
            p1 = u.ReadReferentValue<Struct_0>(new System.Func<Struct_0>(u.Read_0), false);
            p2 = u.ReadInt32();
            p3 = u.ReadInt32();
            return u.ReadUInt32();
        }
    }
    #endregion
}
