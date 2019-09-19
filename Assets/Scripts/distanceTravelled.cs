using UnityEngine;
using System.Collections;

public class distanceTravelled : MonoBehaviour {

    public float distanceTrav;
    Vector3 lastDistance;
    score scoreScript = new score();

	void Start () {
        lastDistance = transform.position;
        scoreScript = GameObject.Find("GameStart").GetComponent<score>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        distanceTrav += Vector3.Distance(transform.position, lastDistance);
        lastDistance = transform.position;
        scoreScript.distance += (int)distanceTrav;
	}
}
