using UnityEngine;

public class ExpSystem : MonoBehaviour
{
    [Header("移動速度"), Range(0, 100)]
    public float speed = 3.5f;

    private Transform player;

    private void Awake()
    {
        player = GameObject.Find("主人公選取").transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}



