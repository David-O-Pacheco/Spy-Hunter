using UnityEngine;
using System.Collections;

public class MenuCarsLeft : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
        transform.Translate(0, 5f * Time.deltaTime, 0);
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
