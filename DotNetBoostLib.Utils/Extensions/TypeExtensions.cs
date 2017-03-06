namespace DotNetBoostLib.Utils.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public static class TypeExtensions
    {
        public static IEnumerable<FieldInfo> GetConstants(this Type type)
        {
            return type.GetFields(BindingFlags.Public).Where(x => x.IsLiteral && x.IsInitOnly);
        }

        public static FieldInfo GetConstantByName(this Type type, string name)
        {
            return GetConstants(type).FirstOrDefault(x => x.Name == name);
        }
    }
}
