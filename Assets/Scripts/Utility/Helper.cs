using UnityEngine;

namespace Utility
{
    public static class Helper
    {
        public static Quaternion RandomRotation()
        {
            return new Quaternion(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        }
    }
}