using UnityEngine;

namespace DJM.Utilities
{
    public static class UnityObjectExtensions
    {
        /// <summary>
        ///     Returns the object itself if it exists, null otherwise.
        /// </summary>
        /// <remarks>
        ///     This method helps differentiate between a null reference and a destroyed Unity object. Unity's "== null" check
        ///     can incorrectly return true for destroyed objects, leading to misleading behaviour. The OrNull method use
        ///     Unity's "null check", and if the object has been marked for destruction, it ensures an actual null reference is
        ///     returned,
        ///     aiding in correctly chaining operations and preventing NullReferenceExceptions.
        /// </remarks>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object being checked.</param>
        /// <returns>The object itself if it exists and not destroyed, null otherwise.</returns>
        public static T OrNull<T>(this T obj) where T : Object
        {
            return obj ? obj : null;
        }
        
        public static void Destroy<T>(this T obj) where T : Object
        {
            Object.Destroy(obj);
        }
        
        public static void DestroyImmediate<T>(this T obj) where T : Object
        {
            Object.DestroyImmediate(obj);
        }

        public static void ContextualDestroy<T>(this T obj) where T : Object
        {
#if UNITY_EDITOR
            if(Application.isPlaying) Object.Destroy(obj);
            else Object.DestroyImmediate(obj);
#else
            Object.Destroy(obj);
#endif
        }
    }
}