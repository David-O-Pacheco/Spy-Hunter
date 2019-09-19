using UnityEngine;
using System.Collections;

public class upVehicles : MonoBehaviour {
    score changeScore;
    health changeHealth;
    public GameObject tracks;
     int timer, timer2, timer3;
    float speed;
     bool signal, signal2, finalSignal;
    public bool colLeftSide;


    void Start () {
        changeScore = new score();
        changeScore = GameObject.FindGameObjectWithTag("GameStart").GetComponent<score>();
        changeHealth = new health();
        changeHealth = GameObject.FindGameObjectWithTag("GameStart").GetComponent<health>();
        timer = 0;
        timer2 = 0;
        timer3 = 0;
        speed = 3.6f;
        signal = false;
        signal2 = false;
	}
	
	
	void Update () {
        if(gameObject != null && finalSignal == false)
        {
            gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (signal && timer < 80 && finalSignal == false)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            gameObject.transform.Translate(4f * Time.deltaTime, 4f * Time.deltaTime, 0);
            gameObject.transform.eulerAngles = new Vector3(0, 0, -45);
            timer += 5;
        }

        else if(timer >= 80)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            signal2 = true;
        }

        if (signal2)
        {
            timer2 += 5;
        }

        if (timer2 >= 1700 && timer3 < 80)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            gameObject.transform.Translate(-4f * Time.deltaTime, 4f * Time.deltaTime, 0);
            gameObject.transform.eulerAngles = new Vector3(0, 0, 45);
            timer3 += 5;
        }

        else if(timer3 >= 80)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            timer = 0;
            timer2 = 0;
            timer3 = 0;
            signal = false;
            signal2 = false;
        }

        if(finalSignal == true && colLeftSide != true)
        {
            if(timer < 100 && speed > 0)
            {
                speed -= 0.05f;
                gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
                gameObject.transform.eulerAngles = new Vector3(0, 0, -10);
                Instantiate(tracks, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.5f, 2.1f), Quaternion.identity);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        if (finalSignal == true && colLeftSide == true)
        {
            if (timer < 100 && speed > 0)
            {
                speed -= 0.05f;
                gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
                gameObject.transform.eulerAngles = new Vector3(0, 0, 10);
                Instantiate(tracks, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.5f, 2.1f), Quaternion.identity);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "SecondRoad")
        {
            signal = true;
        }

        }

    void OnCollisionEnter(Collision Col2)
    {
        if (Col2.gameObject.tag == "Player")
        {
            finalSignal = true;
            changeHealth.healthSet += 0.1f;
        }
        if(Col2.gameObject.tag == "Bullet")
        {
            finalSignal = true;
            changeScore.shootScore += 5;
            changeScore.plus = "+";
            changeScore.scoreText.color = Color.green;
            changeScore.colourTimer = 0;
            Destroy(Col2.gameObject);
        }
    }

    }
