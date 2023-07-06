using UnityEngine;

public class MonsterSystem : MonoBehaviour
{

    private Transform player;
    public DataMonster data;

    private void Awake()
    {
        player = GameObject.Find("主人公選取").transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, 
                                                 player.position, data.moveSpd * Time.deltaTime);
    }

}
