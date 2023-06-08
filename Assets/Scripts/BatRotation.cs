using UnityEngine;

public class BatRotation : MonoBehaviour
{


  
    void Update()
    {
      this.transform.eulerAngles += new Vector3(0, 0, 5);
    }
}
