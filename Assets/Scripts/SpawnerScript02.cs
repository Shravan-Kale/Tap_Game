using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerScript02 : MonoBehaviour
{
	public Transform[] spawnPoints;

	public static int VirusOnScreen = 0;

	public GameObject Virus;

	float timeBetweenSpawns = 0.4f;
	float timeToSpawn = 1f;

	public SceneFader sceneFader;

	void FixedUpdate()
	{
		if (Time.time >= timeToSpawn)
		{
			Spawner();
			timeToSpawn = Time.time + timeBetweenSpawns;
		}
		if (VirusOnScreen >= 10)
		{
			sceneFader.FadeTo("Menu");
			VirusOnScreen = 0;
		}
		if (DestroyScript.VirusDestroid >= 100)
		{
			sceneFader.FadeTo("Level 3");
		}
	}

	void Spawner()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length; i++)
		{
			if (randomIndex == i)
			{
				Instantiate(Virus, spawnPoints[i].position, Quaternion.identity);
				VirusOnScreen++;
			}
		}
	}
}

