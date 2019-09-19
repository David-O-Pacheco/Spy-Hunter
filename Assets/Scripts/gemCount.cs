using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gemCount : MonoBehaviour {

    public Text gemText;
    lifeTruck lTruck;
    public int gems, totalGems;

    void Start () {

        gems = 0;
        lTruck = new lifeTruck();
        lTruck = GameObject.Find("GameStart").GetComponent<lifeTruck>();
	}

	void Update () {
        
        gemText.text = "" + gems + " / 5";

        if(gems == 5)
        {
            gemText.color = Color.magenta;
            lTruck.triggerLife = true;
            
        }
	}
}
