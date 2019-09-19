using UnityEngine;
using System.Collections;

public class gemGeneration : MonoBehaviour {

    int randomGem, timer;
    public GameObject Gem1, Gem2, Gem3, Gem4;

	void Start () {
	
	}
	
	void Update () {
	
        if(timer < 500)
        {
            timer++;
        }
        else if(timer >= 500)
        {
            randomGem = Random.Range(0, 4);
            timer = 0;
        }

        if(randomGem == 1)
        {
            Instantiate(Gem1, new Vector3(Random.Range(-5.05f, 5.05f), 10, 2.1f), Quaternion.identity);
            randomGem = 0;
        }

        if (randomGem == 2)
        {
            Instantiate(Gem2, new Vector3(Random.Range(-5.05f, 5.05f), 10, 2.1f), Quaternion.identity);
            randomGem = 0;
        }

        if (randomGem == 3)
        {
            Instantiate(Gem3, new Vector3(Random.Range(-5.05f, 5.05f), 10, 2.1f), Quaternion.identity);
            randomGem = 0;
        }

        if (randomGem == 4)
        {
            Instantiate(Gem4, new Vector3(Random.Range(-5.05f, 5.05f), 10, 2.1f), Quaternion.identity);
            randomGem = 0;
        }
    }
}
