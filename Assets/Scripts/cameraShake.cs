using UnityEngine;
using System.Collections;

public class cameraShake : MonoBehaviour {

    int timer2, timer, y;

	void Start () {
	
	}
	
	void Update () {
        
        if(timer < 300)
        {
            
            transform.Translate(0, 0.25f * Time.deltaTime, 0);
            timer++;
        }
        else if (timer >= 300)
        {
            if (timer2 < 300)
            {
                transform.Translate(0, -0.25f * Time.deltaTime, 0);
                timer2++;
            }
            else if(timer2 >= 300)
            {
                timer = 0;
                timer2 = 0;
            }
        }
	}
}
