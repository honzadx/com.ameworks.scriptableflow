using System;
using System.Reflection;
using JetBrains.Annotations;

namespace ScriptableFlow.Editor.Helpers
{
    public static class ReflectionStatics
    {
        [CanBeNull]
        public static Type GetNearestTypeOrInterfaceWithAttribute<TAttribute>(this Type type) where TAttribute : Attribute
        {
            var current = type;
            while (current != null && current != typeof(object))
            {
                if (current.GetCustomAttribute<TAttribute>(false) != null)
                    return current;

                current = current.BaseType;
            }
            foreach (var iface in type.GetInterfaces())
            {
                if (iface.GetCustomAttribute<TAttribute>(false) != null)
                    return iface;
            }
            return null;
        }
        
        public static bool HasTypeOrInterfaceWithAttribute<TAttribute>(this Type type) where TAttribute : Attribute
        {
            var current = type;
            while (current != null && current != typeof(object))
            {
                if (current.GetCustomAttribute<TAttribute>(false) != null)
                    return true;

                current = current.BaseType;
            }
            foreach (var iface in type.GetInterfaces())
            {
                if (iface.GetCustomAttribute<TAttribute>(false) != null)
                    return true;
            }
            return false;
        }
    }
}