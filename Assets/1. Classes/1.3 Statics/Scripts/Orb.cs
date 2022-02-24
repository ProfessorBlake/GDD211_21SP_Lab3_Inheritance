using UnityEngine;

namespace Basics
{
    public class Orb : MonoBehaviour
    {
        public static int TotalOrbs;

        private string message;

        public static void SayRandomNumber()
		{
            Debug.Log($"Orb: {Random.Range(0, 1000)}");
		}

        public static void SayMessage()
		{
            // This will not work because this function is static, but "message" is not, so the class cannot know which 
            // message to print, as each instance of this class can have it's own message. The error says "An object reference is required."
            // So an instance of the class becomes and "object".

            //Debug.Log($"Orb: {message}");
		}
    }
}