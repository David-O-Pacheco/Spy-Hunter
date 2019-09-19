using UnityEngine;
using System.Collections;

public class trackDisappear : MonoBehaviour {

    playerMovement pMove;
    int time;

	void Start () {
        pMove = new playerMovement();
	}

	void Update () {
        //if(time < 100)
        //{
        //    time++;
        //}
        //else if(time >= 100)
        //{
        //    Destroy(gameObject);
        //}

        if (GameObject.FindGameObjectWithTag("Player"))
        {
            pMove = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        }

        if (pMove.camSpeed > 0)
        {
            transform.Translate(0, -2 * Time.deltaTime, 0);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
