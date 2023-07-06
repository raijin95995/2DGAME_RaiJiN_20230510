using UnityEngine;

public class ExpSystem : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 100)]
    public float speed = 3.5f;

    private Transform player;

    private void Awake()
    {
        player = GameObject.Find("�D�H�����").transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }
}



