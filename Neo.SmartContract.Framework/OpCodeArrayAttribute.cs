using Neo.VM;
using System;

namespace Neo.SmartContract.Framework
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Constructor)]
    public class OpCodeArrayAttribute : Attribute
    {
        public byte[] vOpCode { get; }

        public OpCodeArrayAttribute(byte[] vopcode)
        {
            this.vOpCode = vopcode;
        }
    }
}
