using UnityEngine;

[CreateAssetMenu(menuName = "RAIJIN/DATA Basic")]
public class DataBasic : ScriptableObject
{   
    [Header("��q"), Range(0,500)]
    public float hp;
    [Header("�����O"), Range(0, 500)]
    public float atk;
    [Header("���ʳt��"), Range(0,100)]
    public float moveSpd;


}
