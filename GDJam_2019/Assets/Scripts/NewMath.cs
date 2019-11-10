using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NewMath
{
    public class HiddenMath
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vec">
        /// The input Vector
        /// </param>
        /// <param name="bound">
        /// The maximum magnitude the vector can reach
        /// </param>
        /// <returns></returns>
        public static Vector2 Clamp(Vector2 vec, float bound)
        {
            float mag = vec.magnitude;

            if (mag > bound)
            {
                vec /= mag;
                vec *= bound;
            }

            return vec;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vec">
        /// The input Vector
        /// </param>
        /// <param name="bound">
        /// the maximum magnitude a vector can reach
        /// </param>
        /// <returns></returns>
        public static Vector3 Clamp(Vector3 vec, float bound)
        {
            float mag = vec.magnitude;

            if (mag > bound)
            {
                vec /= mag;
                vec *= bound;
            }

            return vec;
        }
    }
}