using UnityEngine;
using System.Collections;

public class moveGem : MonoBehaviour {

    playerMovement pMove;
    gemCount gem;

	void Start () {

        pMove = new playerMovement();
        gem = new gemCount();
        gem = GameObject.FindGameObjectWithTag("GameStart").GetComponent<gemCount>();

	}
	
	void Update () {

        if (GameObject.FindGameObjectWithTag("Player"))
        {
            pMove = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        }
        if (pMove.camSpeed > 0)
        {
            transform.Translate(0, -2 * Time.deltaTime, 0);
        }
        else
        {
            transform.Translate(0, 0, 0);
        }
    }

    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Player")
        {
            gem.gems += 1;
            Destroy(gameObject);
        }
    }

}
