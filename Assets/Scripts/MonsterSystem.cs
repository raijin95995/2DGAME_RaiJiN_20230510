using UnityEngine;

public class MonsterSystem : MonoBehaviour
{

    private Transform player;

    private void Awake()
    {
        player = GameObject.Find("�D�H�����").transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, 0.01f);
    }

}
