using System.Collections.Generic;
using Neoxio.HlaSharp.Interop;

namespace Neoxio.HlaSharp
{
    public static class MemoryManagementExtensions
    {
        public static void DisposeNativeContent<T>(this T[] array) where T : UnmanagedHlaObject
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static void DisposeNativeContent<T>(this List<T> list) where T : UnmanagedHlaObject
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static void DisposeNativeContent<T>(this IEnumerable<T> collection) where T : UnmanagedHlaObject
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static void DisposeNativeContent<TKey, TValue>(this IDictionary<TKey, TValue> dict) where TKey : UnmanagedHlaObject where TValue : UnmanagedHlaObject
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static void DisposeNativeKeys<TKey, TValue>(this IDictionary<TKey, TValue> dict) where TKey : UnmanagedHlaObject
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }

        public static void DisposeNativeValues<TKey, TValue>(this IDictionary<TKey, TValue> dict) where TValue : UnmanagedHlaObject
        {
            throw new System.NotImplementedException("This is a reference assembly.");
        }
    }
}