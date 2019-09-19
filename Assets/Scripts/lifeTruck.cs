using UnityEngine;
using System.Collections;

public class lifeTruck : MonoBehaviour {

    public GameObject lTruck;
    GameObject truckM;
    public bool triggerLife;
    bool tOnce;

	void Start () {
	
	}
	

	void Update () {
	
        if(triggerLife == true && tOnce == false)
        {
            Instantiate(lTruck, new Vector3(4.83f, 10, 0), Quaternion.identity);
            truckM = GameObject.FindGameObjectWithTag("LifeTruck");
            tOnce = true;
        }

        if (truckM.transform.position.y > -0.94f)
        {
            truckM.transform.Translate(0, -2 * Time.deltaTime, 0);
        }

        if(truckM.transform.position.y <= -0.94f)
        {
            //Open back of truck
        }

	}
}
