using UnityEngine;

public class MonsterSystem : MonoBehaviour
{

    private Transform player;
    public DataMonster data;

    private void Awake()
    {
        player = GameObject.Find("�D�H�����").transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, 
                                                 player.position, data.moveSpd * Time.deltaTime);
    }

}
