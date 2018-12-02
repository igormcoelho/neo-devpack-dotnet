using Neo.VM;
using System;

namespace Neo.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class InlineAttribute : Attribute
    {
        public OpExt[] Operations { get; }

        public InlineAttribute(params OpExt[] ops)
        {
            this.Operations = ops;
        }
    }

    // OpCode with Extension parameters
    public class OpExt
    {
        public OpCode Code; // unused
        public byte[] Parameters; // unused
        public string SParameters; // unused

        public OpExt(OpCode Code, byte[] Parameters = null)
        {
            this.Code = Code;
            this.Parameters = Parameters;
            this.SParameters = null;
        }

        public OpExt(string call)
        {
            this.Code = OpCode.SYSCALL;
            this.Parameters = null;
            this.SParameters = call;
        }

        public static implicit operator OpExt(OpCode code)
        {
            return new OpExt(code);
        }

        public static implicit operator OpExt(string call)
        {
            return new OpExt(call);
        }
    }
}
