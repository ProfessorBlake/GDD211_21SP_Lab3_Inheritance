/// <summary>
/// Like the Item class, this class does not inherit from Monobehaviour.
/// When an instance of this class is created in another class we can see it in the inspector
/// because of the [System.Serializable] attribute. 
/// </summary>

namespace Basics
{
	[System.Serializable]
	public class PlayerWallet
	{
		public int Gold;
		public int Silver;
	}
}