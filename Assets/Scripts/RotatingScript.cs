using UnityEngine;

public class RotatingScript : MonoBehaviour
{
    void FixedUpdate()
    {
       this.transform.Rotate(new Vector3(0f, 0f, 50 * Time.deltaTime));
    }
}
