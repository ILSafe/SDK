using System;
using System.Collections.Generic;
using System.Linq;

namespace ILSafe.SDK
{
    public enum SecurityType : byte
    {
        NONE,
        SECURITY,
        VIRTUALIZATION,
        ALL
    }

    public enum SecurityOptions : byte
    {
        NONE,
        ENCODESTRINGS,
        FAKEILCODE,
        CODEJUNK,
        SUPRESSILDASM,
        ANTIDEBUG,
        ANTIVM,
        INTCONFUSER,
        LAZYIMPORT
    }

    public class SecurityTypeAttribute : Attribute
    {
        public SecurityType _type { get; set; }

        public SecurityTypeAttribute(SecurityType type)
        {
            _type = type;
        }
    }

    public class SecurityOptionsAttribute : Attribute
    {
        public List<SecurityOptions> _type { get; set; }

        public SecurityOptionsAttribute(params SecurityOptions[] type)
        {
            _type = type.ToList();
        }
    }
}