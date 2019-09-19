using UnityEngine;
using System.Collections;

public class generateGrid : MonoBehaviour {

    //public GameObject mapGeeeen;
    mapGen gen = new mapGen();

    void Start()
    {
        gen = GameObject.Find("MapGen").GetComponent <mapGen>();
    }

    void OnBecameInvisible()
    {
        gen.trigger = true;
        Destroy(gameObject);
    }

}
