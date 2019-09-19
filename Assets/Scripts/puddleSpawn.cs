using UnityEngine;
using System.Collections;

public class puddleSpawn : MonoBehaviour {

    public GameObject puddle;
    public Camera cameraGet;
    public int timer, randomLocation;

	void Start () {
	
	}
	
	void Update () {
	
        if(timer < 1000)
        {
            timer++;
        }
        else
        {
            randomLocation = Random.Range(1, 6);
            timer = 0;
        }
        if(randomLocation == 1)
        {
            Instantiate(puddle, new Vector3(-5 + cameraGet.transform.position.x, 13 + cameraGet.transform.position.y, 2.1f), Quaternion.identity);
            randomLocation = 0;
        }

        if (randomLocation == 2)
        {
            Instantiate(puddle, new Vector3(-2.5f + cameraGet.transform.position.x, 13 + cameraGet.transform.position.y, 2.1f), Quaternion.identity);
            randomLocation = 0;
        }

        if (randomLocation == 3)
        {
            Instantiate(puddle, new Vector3(0.4f + cameraGet.transform.position.x, 13 + cameraGet.transform.position.y, 2.1f), Quaternion.identity);
            randomLocation = 0;
        }

        if (randomLocation == 4)
        {
            Instantiate(puddle, new Vector3(2.5f + cameraGet.transform.position.x, 13 + cameraGet.transform.position.y, 2.1f), Quaternion.identity);
            randomLocation = 0;
        }

        if (randomLocation == 5)
        {
            Instantiate(puddle, new Vector3(5 + cameraGet.transform.position.x, 13 + cameraGet.transform.position.y, 2.1f), Quaternion.identity);
            randomLocation = 0;
        }

    }
}
