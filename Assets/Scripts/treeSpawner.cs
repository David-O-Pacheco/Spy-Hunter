using UnityEngine;
using System.Collections;

public class treeSpawner : MonoBehaviour {
    int timer2, timer, randLocation, randEnd;
    public GameObject tree;


	void Start () {
	
	}

	void Update () {
        if (timer2 < 50)
        {
            timer2++;
        }
        else if(timer2 >= 50)
        {
            randEnd = Random.Range(-10, 5);
            timer2 = 0;
        }

        if(timer < 60 + randEnd)
        {
            timer++;
        }
        else if (timer >= 50)
        {
            randLocation = Random.Range(0, 6);
            timer = 0;
        }

        if(randLocation == 1 || randLocation == 5)
        {
            Instantiate(tree, new Vector3(Random.Range(-7.22f, -8.5f), 10, 0), Quaternion.identity); //-8.5f
            randLocation = 0;
        }

        if (randLocation == 2 || randLocation == 6)
        {
            Instantiate(tree, new Vector3(Random.Range(-7.22f, -8.5f), 12, 0), Quaternion.identity); //-7.22f
            randLocation = 0;
        }

        if (randLocation == 3 || randLocation == 5)
        {
            Instantiate(tree, new Vector3(Random.Range(7.22f, 8.5f), 10, 0), Quaternion.identity); //8.5f
            randLocation = 0;
        }

        if (randLocation == 4 || randLocation == 6)
        {
            Instantiate(tree, new Vector3(Random.Range(7.22f, 8.5f), 12, 0), Quaternion.identity); //7.22f
            randLocation = 0;
        }
    }
}
