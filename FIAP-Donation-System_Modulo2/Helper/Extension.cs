﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAP_Donation_System_Modulo2.Helper
{
    public static class Extension
    {
        public static T GetCustomAttribute<T>(this System.Enum enumVal) where T : Attribute

        {

            var type = enumVal.GetType();

            var memInfo = type.GetMember(enumVal.ToString());

            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);

            return attributes.Length > 0 ? (T)attributes[0] : null;

        }



        public static string GetDescription(this System.Enum enumVal)

        {

            var attr = enumVal.GetCustomAttribute<DescriptionAttribute>();

            if (attr == null)

                return null;



            return attr.Description;

        }
    }
}
