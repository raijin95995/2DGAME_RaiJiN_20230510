using UnityEngine;

public class MonsterSystem : MonoBehaviour
{

    private Transform player;

    private void Awake()
    {
        player = GameObject.Find("主人公選取").transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.01f);
    }

}
