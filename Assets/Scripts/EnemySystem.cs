using UnityEngine;

public class EnemySystem : MonoBehaviour
{
	private Transform player;

	private void Awake()
	{

		player = GameObject.Find("主人公選取").transform;
	}

}
