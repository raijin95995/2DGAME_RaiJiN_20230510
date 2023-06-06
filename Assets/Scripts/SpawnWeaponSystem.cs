using UnityEngine;

public class SpawnWeaponSystem : MonoBehaviour
{
	[Header("怪物預製物")]
	public GameObject prefabWeapon;
	[Header("生成間隔"),Range(0,10)]
	public float interval = 4.5f;



    private void Awake()
    {
		InvokeRepeating("SpawnWeapon", 1 , interval);
    }



    private void SpawnWeapon()
	{

		Instantiate(prefabWeapon, transform.position, transform.rotation);
	
	}


}
