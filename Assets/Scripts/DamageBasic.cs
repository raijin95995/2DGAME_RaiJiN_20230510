using TMPro;
using UnityEngine;

public class DamageBasic : MonoBehaviour
{

	public GameObject prefabDamage;
	public DataBasic data ;
	private float hp;


	private void Awake()
	{
		hp = data.hp;

	}

	public void Damage(float damage)
	{
		hp -= damage;
		GameObject tempDamage= Instantiate(prefabDamage, transform.position, transform.rotation);
		tempDamage.transform.Find("¶Ë®`­È¤å¦r").GetComponent<TextMeshProUGUI>().text = damage.ToString();

		Destroy(tempDamage, 1.0f);

		if (hp <= 0) Dead();

		

	}

	protected virtual void Dead()
	{

	}

}
