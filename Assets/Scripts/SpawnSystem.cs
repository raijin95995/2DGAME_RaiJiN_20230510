using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
	[Header("�Ǫ��w�s��")]
	public GameObject prefabMonster;
	[Header("�ͦ����j"),Range(0,10)]
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
