using System;

namespace Sjerrul.CharacterForge.Utilities.Assertion
{
    public class CodeAttribute : Attribute
    {
        public string Code { get; set; }
        public CodeAttribute(string code)
        {
            this.Code = code;
        }
    }
}