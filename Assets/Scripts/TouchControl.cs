using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    public static Vector3 touchposition;
    BoxCollider2D c;

    void Start()
    {
        c = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Touch touch = Input.GetTouch(0);
                touchposition = Camera.main.ScreenToWorldPoint(touch.position);
                touchposition.z = 0f;
                transform.position = touchposition;
            }           
        }

        if (Input.GetMouseButtonDown(0))
        {
            touchposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            touchposition.z = 0f;
            transform.position = touchposition;
        }
    }

    void OnCollisionEnter2D()
    {
        this.transform.position = new Vector3(0f, -5.8f, -4.2f);
    }
}
