using UnityEngine;
using System.Collections;

public class moveTree : MonoBehaviour {

    playerMovement playMov;

    void Start () {
        playMov = new playerMovement();
    }
	

	void Update () {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            playMov = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        }

        if (playMov.camSpeed > 0)
        {
            transform.Translate(0, -2 * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }

    }
}
