using UnityEngine;

[CreateAssetMenu(menuName = "RAIJIN/DATA Monster")]
public class DataMonster : DataBasic
{
    [Header("掉落經驗機率"), Range(0, 1)]
    public float expFallPercent;
    [Header("經驗值預製物")]
    public GameObject prefabExp;
   


}
