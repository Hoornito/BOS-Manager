﻿using System;
using System.Linq;

namespace SL.Services.Extensions
{
    public static class TypeExtensions
    {
        public static bool ImplementsGenericInterface(this Type type, Type genericType)
        {
            if (type == null)
            {
                return false;
            }
            return type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == genericType);
        }
    }
}
