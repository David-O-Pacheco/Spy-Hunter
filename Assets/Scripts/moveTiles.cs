using UnityEngine;
using System.Collections;

public class moveTiles : MonoBehaviour {
    int timer;
    playerMovement newMov;

    void Start () {
        newMov = new playerMovement();
    }
	
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            newMov = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        }
        transform.Translate(0, -1.9f * newMov.camSpeed * Time.deltaTime, 0);
    }
}
