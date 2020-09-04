using System;

// Para o Extension Method ficar acessível quando é de classe primitiva 
// cololar no name space system.
namespace System
{
    public static class stringExtensions
    {
        public static string FirsToUpper(this String str )
        {
            string primeira = str.Substring(0,1);
            string segunda = str.Substring(1);
            return primeira.ToUpper() + segunda;
        }
    }
}
