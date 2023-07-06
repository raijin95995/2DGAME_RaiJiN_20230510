using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LVManager : MonoBehaviour
{
    [Header("�g���")]
    public Image imgExp;
    [Header("��r����")]
    public TextMeshProUGUI textLv;
    [Header("��r�g���")]
    public TextMeshProUGUI textExp;

    private int lv = 1;
    private float exp = 0;



	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.name.Contains("�g���"))
		{
            collision.GetComponent<ExpSystem>().enabled = true;
		}
	}
}