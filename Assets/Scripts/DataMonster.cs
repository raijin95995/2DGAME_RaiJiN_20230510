using UnityEngine;

[CreateAssetMenu(menuName = "RAIJIN/DATA Monster")]
public class DataMonster : DataBasic
{
    [Header("�����g����v"), Range(0, 1)]
    public float expFallPercent;
    [Header("�g��ȹw�s��")]
    public GameObject prefabExp;
   


}
