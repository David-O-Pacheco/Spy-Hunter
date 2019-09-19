using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

    playerMovement pM;
    public Text scoreText;
    public float mainScore;
    public int distance, scorePublic, shootScore, colourTimer;
    public string plus;
    int dist;
    Vector3 lastPos;

	void Start ()
    {
        colourTimer = 20;
        plus = "";
        pM = new playerMovement();
	}
	
	void Update () {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            pM = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
        }
        if(pM.camSpeed > 0.5f)
        {
            dist = distance / 44;
        }
        mainScore = dist + scorePublic + shootScore;
        scoreText.text =  plus + mainScore;
        if(colourTimer < 30)
        {
            colourTimer++;
        }
        else if(colourTimer >= 20)
        {
            scoreText.color = Color.white;
            plus = "";
        }
    }
}
