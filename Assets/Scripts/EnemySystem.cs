using UnityEngine;

public class EnemySystem : MonoBehaviour
{
	private Transform player;

	private void Awake()
	{

		player = GameObject.Find("�D�H�����").transform;
	}

}
