using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
	[Header("怪物預製物")]
	public GameObject prefabMonster;
	[Header("生成間隔"),Range(0,10)]
	public float interval = 4.5f;



    private void Awake()
    {
		InvokeRepeating("SpawnMonster", 1, interval);
    }



    private void SpawnMonster()
	{

		Instantiate(prefabMonster, transform.position, transform.rotation);
	
	}


}
