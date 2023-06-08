using UnityEngine;

public class SpawnWeaponSystem : MonoBehaviour
{
	[Header("�Ǫ��w�s��")]
	public GameObject prefabWeapon;
	[Header("�ͦ����j"),Range(0,10)]
	public float interval = 4.5f;
	public Vector2 power ;
	



    private void Awake()
    {
		InvokeRepeating("SpawnWeapon", 1 , interval);
    }



    private void SpawnWeapon()
	{

		GameObject tempWeapon = Instantiate(prefabWeapon, transform.position, transform.rotation);
		Rigidbody2D rigWeapon = tempWeapon.GetComponent<Rigidbody2D>();
		rigWeapon.AddForce(power);
		

	}


}
