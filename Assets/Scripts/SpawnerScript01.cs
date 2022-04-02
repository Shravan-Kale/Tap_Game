using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnerScript01 : MonoBehaviour 
{
	//public Transform[][] spawnArray;
	public Transform[] spawnPoints;
	public List<Transform> currentPoints = new List<Transform>();

	public static int VirusOnScreen = 0;

	public GameObject Virus;

	public float timeBetweenSpawns = 1f;
	public float timeToSpawn = 1f;
	public float D;

	public SceneFader sceneFader;

	public Text score;

	void Start()
    {
		Spawner();
    }

	void Update()
    {
		currentPoints.Remove(SpawnInfo.destroyLocation);
		TimeControl();

		score.text = "Score " + DestroyScript.VirusDestroid.ToString();
	}

	void FixedUpdate() 
	{
		D = DestroyScript.VirusDestroid;

		if (Time.time >= timeToSpawn && DestroyScript.VirusDestroid >= 10)
		{
			Spawner();
			timeToSpawn = Time.time + timeBetweenSpawns;
		}
		if (VirusOnScreen >= 10)
		{
			sceneFader.FadeTo("Menu");
			VirusOnScreen = 0;
		}

		/*if (DestroyScript.VirusDestroid >= 50)
		{
			sceneFader.FadeTo("Level 2");
		}*/

		if(VirusOnScreen <= 0 && DestroyScript.VirusDestroid < 10)
        {
			Spawner();
			timeToSpawn = Time.time;
		} 
	}

	public void Spawner()
    {
		int i = Random.Range(0, spawnPoints.Length);

		if (!currentPoints.Contains(spawnPoints[i]))
		{
			Instantiate(Virus, spawnPoints[i].position, Quaternion.identity);
			VirusOnScreen++;
			currentPoints.Add(spawnPoints[i]);
		}

		else
			Spawner();
	}

	public void TimeControl()
    {
		switch (D)
        {
			case 25:
				timeBetweenSpawns = 0.8f;
				break;
			case 30:
				timeBetweenSpawns = 0.5f;
				break;
			case 35:
				timeBetweenSpawns = 0.3f;
				break;
        }
    }

}
