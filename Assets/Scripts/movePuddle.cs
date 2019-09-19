using UnityEngine;
using System.Collections;

public class movePuddle : MonoBehaviour {

    playerMovement newMovP;

	void Start () {

        newMovP = new playerMovement();

	}
	
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            newMovP = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        }
        if(newMovP.camSpeed > 0)
        {
            transform.Translate(0, -3.5f * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
	}
}
