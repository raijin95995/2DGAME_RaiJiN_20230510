using UnityEngine;

public class DamageMonster : DamageBasic
{

	


	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name.Contains("²y´Î"))
		{
			Damage(50);
			
		}
	}


	protected override void Dead()
	{
		base.Dead();
		Destroy(gameObject);
	}
}
