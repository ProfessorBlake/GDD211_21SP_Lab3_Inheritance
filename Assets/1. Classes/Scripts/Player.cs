using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] private string playerName;

	private Inventory playerInventory;
	private float delay = 4f;

	static int totalPlayers = 0;

	private void Awake()
	{
		totalPlayers++;
		Debug.Log("Total Players: " + totalPlayers);
	}

	private void Start()
	{
		playerInventory = new Inventory();
		LogInventory();
	}

	private void Update()
	{
		delay -= Time.deltaTime;
		if(delay <= 0f)
		{
			delay = 4f;
			int r = Random.Range(0, 4);

			if (r == 0)
			{
				playerInventory.Gold += 1;
				Debug.Log(playerName + " found 1 gold!");
			}
			else if (r == 1)
			{
				playerInventory.Gold -= 1;
				Debug.Log(playerName + " lost 1 gold!");
			}
			else if (r == 2)
			{
				playerInventory.Silver += 5;
				Debug.Log(playerName + " found 5 silver!");
			}
			else if (r == 3)
			{
				playerInventory.Silver -= 5;
				Debug.Log(playerName + " lost 5 silver!");
			}

			LogInventory();
		}
	}
	
	private void LogInventory()
	{
		Debug.Log("Inventory for " + playerName + " (Gold: " + playerInventory.Gold + ") - (Silver: " + playerInventory.Silver + ")");
	}
}