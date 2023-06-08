using UnityEngine;

[CreateAssetMenu(menuName = "RAIJIN/DATA Basic")]
public class DataBasic : ScriptableObject
{   
    [Header("血量"), Range(0,500)]
    public float hp;
    [Header("攻擊力"), Range(0, 500)]
    public float atk;
    [Header("移動速度"), Range(0,100)]
    public float moveSpd;


}
