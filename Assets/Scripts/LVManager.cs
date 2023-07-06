using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LVManager : MonoBehaviour
{
    [Header("經驗值")]
    public Image imgExp;
    [Header("文字等級")]
    public TextMeshProUGUI textLv;
    [Header("文字經驗值")]
    public TextMeshProUGUI textExp;

    private int lv = 1;
    private float exp = 0;



	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.name.Contains("經驗值"))
		{
            collision.GetComponent<ExpSystem>().enabled = true;
		}
	}
}