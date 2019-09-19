using UnityEngine;
using System.Collections;

public class offScreen : MonoBehaviour {

	void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
