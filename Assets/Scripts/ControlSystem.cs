using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class ControlSystem : MonoBehaviour
{
    //int A = 5;
    //int B = 6;
    [Header("���ʳt��"),Range(0,30)]
    public float moveSpeed = 3.0f;
    [Header("�������")]
    public Rigidbody2D rig;
    [Header("�ʵe���")]
    public Animator ani;
    [Header("�]�B�}��")]
    public string perRun = "�}������";




    private void Awake()
    {
        //print(1 + 1);
        //print($"{2^2 + 3}");
        //print($"A+B={A + B}" );
        //print(A + B);
        //print("A+B=" + (A + B));
        //print("A+B=" + A + B);
        rig = this.gameObject.GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        //print("Im Start");
    }

    private void Update()
    {
        //print("<color=red>�p</color>");
        Move();
    }

	private void Move()
	{
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //print("I'm walking");
        rig.velocity = new Vector2(h,v) * moveSpeed ;

        ani.SetBool(perRun, h != 0 || v!=0);

        print(Input.GetKeyDown(KeyCode.D));

	}

}
