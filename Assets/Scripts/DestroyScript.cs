//using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyScript : MonoBehaviour
{
    public static int VirusDestroid;

    public SpawnerScript01 spawner;

    public BoxCollider2D c;

    public static int i;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            this.transform.position = new Vector3(100f, -100f, 100f);
            Destroy(gameObject);
            SpawnerScript01.VirusOnScreen--;
            SpawnerScript02.VirusOnScreen--;
            SpawnerScript03.VirusOnScreen--;
            VirusDestroid++;                  
        }
    }
}

