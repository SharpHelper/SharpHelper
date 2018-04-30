using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SharpHelper
{
    public static class EnumHelper
    {
        public static string GetDescription(this Enum myEnum)
        {
            if (myEnum == null)
                return null;

            Type enumType = myEnum.GetType();
            FieldInfo field = enumType.GetField(myEnum.ToString());

            var type = myEnum.GetType();
            var typeInfo = type.GetTypeInfo();
            var memberInfo = typeInfo.GetMember(myEnum.ToString());

            if (memberInfo.Count() == 0)
            {
                return null;
            }

            var attributes = memberInfo[0].GetCustomAttributes<DescriptionAttribute>();
            var attribute = attributes.FirstOrDefault();

            if (attribute == null)
                return myEnum.ToString();

            return attribute.Description;
        }
    }
}
