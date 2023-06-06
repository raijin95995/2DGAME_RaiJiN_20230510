using UnityEngine;

public class SpawnWeaponSystem : MonoBehaviour
{
	[Header("�Ǫ��w�s��")]
	public GameObject prefabWeapon;
	[Header("�ͦ����j"),Range(0,10)]
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