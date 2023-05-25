using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    int A = 5;
    int B = 6;
    [Header("移動速度"),Range(0,10)]
    public float moveSpeed = 3.0f;
    [Header("角色剛體")]
    public Rigidbody2D rig;


    private void Awake()
    {
        //print(1 + 1);
        //print($"{2^2 + 3}");
        //print($"A+B={A + B}" );
        //print(A + B);
        //print("A+B=" + (A + B));
        //print("A+B=" + A + B);
    }

    private void Start()
    {
        //print("Im Start");
    }

    private void Update()
    {
        //print("<color=red>喵</color>");
        Move();
    }

	private void Move()
	{
        print("I'm walking");
	}

}
