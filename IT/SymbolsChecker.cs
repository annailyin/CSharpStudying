using System;
using System.Collections.Generic;
using System.Text;

namespace IT
{
    public class SymbolsChecker
    {
        public static bool IsEnglishSymbol(char smb)
        {
            return (smb >= 'a' && smb <= 'z') ||
                (smb >= 'A' && smb <= 'Z');
        }
    }
}
