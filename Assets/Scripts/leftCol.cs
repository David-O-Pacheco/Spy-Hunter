using UnityEngine;
using System.Collections;

public class leftCol : MonoBehaviour {


    upVehicles upV;
    downVehicles downV;

	void Start () {

        upV = new upVehicles();
        upV = GameObject.FindGameObjectWithTag("GameStart").GetComponent<upVehicles>();
        downV = new downVehicles();
        downV = GameObject.FindGameObjectWithTag("GameStart").GetComponent<downVehicles>();

    }
	

	void Update () {
	
	}

    void OnCollisionEnter(Collision Col)
    {
        if(Col.gameObject.tag == "LeftCol")
        {
            upV.colLeftSide = true;
            downV.colLeftSide = true;
        }
    }
}
