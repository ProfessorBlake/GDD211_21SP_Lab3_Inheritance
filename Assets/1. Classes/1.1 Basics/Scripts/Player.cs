using UnityEngine;

/// This represents a typical Player script in Unity.
/// This class inherits from the Monobehaviour class, which allows it to be attached to Game Objects.
/// 
/// Using a Namespace prevents this name of this class from interfering with another class of the same name
/// elsewhere in the project.
/// 
/// When we add this script to a GameObject we are creating an INSTANCE of this class. Each instance can
/// have it's own variables, so one Player can have 10 Health while another can have 5.

namespace Basics
{
	public class Player : MonoBehaviour
	{
		public PlayerItem item;
		public PlayerWallet wallet;
		public int Health;
	}
}