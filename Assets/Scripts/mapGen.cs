using UnityEngine;
using System.Collections;

public class mapGen : MonoBehaviour {

    public GameObject grass, road, secondRoad, thirdRoad, forthRoad;
    public Camera gameCamera;
    public float genCount;
    bool secondTrig, thirdTrig;
    public bool trigger;

	void Start () {
        Instantiate(road, new Vector3(0, 10.55f, 10), Quaternion.identity);
        Instantiate(grass, new Vector3(0, 10.55f, 12), Quaternion.identity); //9.7
        trigger = false;
        secondTrig = false;
        thirdTrig = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (trigger == true && secondTrig == false &&  thirdTrig == false)
        {
            genCount = Random.Range(1, 35);
            trigger = false;
        }
        if(trigger == true && secondTrig == true)
        {
            genCount = 100;
            trigger = false;
            secondTrig = false;
            
        }
        if(trigger == true && thirdTrig == true)
        {
            genCount = 15;
            trigger = false;
            thirdTrig = false;
            
        }

        if (genCount >= 1 && genCount <= 30)
        {
            Instantiate(road, new Vector3(0, gameCamera.transform.position.y + 10.55f, 10), Quaternion.identity);
            Instantiate(grass, new Vector3(0, gameCamera.transform.position.y + 10.55f, 12), Quaternion.identity); //9.7
        }
        if (genCount >= 31 && genCount <= 35)
        {
            Instantiate(secondRoad, new Vector3(0, gameCamera.transform.position.y + 10.55f, 10), Quaternion.identity);
            Instantiate(grass, new Vector3(0, gameCamera.transform.position.y + 10.55f, 12), Quaternion.identity);
            secondTrig = true;
        }
        if (genCount == 100)
        {
            Instantiate(thirdRoad, new Vector3(0, gameCamera.transform.position.y + 10.55f, 10), Quaternion.identity);
            Instantiate(grass, new Vector3(0, gameCamera.transform.position.y + 10.55f, 12), Quaternion.identity);
            thirdTrig = true;
        }
        genCount = 0;
    }
}
