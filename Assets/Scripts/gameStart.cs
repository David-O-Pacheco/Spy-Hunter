using UnityEngine;
using System.Collections;

public class gameStart : MonoBehaviour {

    //Assigning clocks for truck animation...
    int firstClock, secondClock, thirdClock, forthClock, rotationTruck;
    int firstEndT, secondEndT, thirdEndT, forthEndT;
    bool nextAnimation, spawnPlayer, finalAnimation;
    float coordX, coordY;
    GameObject TruckSpawning;
    GameObject PlayerSpawning;
    public GameObject Player;

    void Start () {
        TruckSpawning = GameObject.FindGameObjectWithTag("LifeTruck");
        PlayerSpawning = GameObject.FindGameObjectWithTag("Player");
        //---
        rotationTruck = 0;
        firstClock = 0;
        secondClock = 0;
        thirdClock = 0;
        forthClock = 0;
        firstEndT = 700;
        secondEndT = 270;
        thirdEndT = 370;
        forthEndT = 400;
        nextAnimation = false;
        spawnPlayer = false;
	}
	
	void Update () {
        if(TruckSpawning != null)
        {
            if (firstClock < firstEndT)
            {
                TruckSpawning.transform.Translate(0, 2 * Time.deltaTime, 0);
                firstClock += 5;
            }
            else
            {
                nextAnimation = true;
            }

            if (nextAnimation == true)
            {
                if (secondClock < secondEndT)
                {
                    if (rotationTruck > -45)
                    {
                        rotationTruck -= 5;
                    }
                    TruckSpawning.transform.Translate(2 * Time.deltaTime, 2 * Time.deltaTime, 0);
                    TruckSpawning.transform.eulerAngles = new Vector3(0, 0, rotationTruck);
                    secondClock += 5;
                }
                else
                {
                    TruckSpawning.transform.eulerAngles = new Vector3(0, 0, 0);
                    nextAnimation = false;
                    spawnPlayer = true;
                }
            }
            if (spawnPlayer == true)
            {
                coordX = TruckSpawning.transform.position.x;
                coordY = TruckSpawning.transform.position.y;

                spawnPlayer = false;
                PlayerInst();
            }

            if (finalAnimation == true)
            {
                if (thirdClock < thirdEndT)
                {

                    if (rotationTruck < 45)
                    {
                        rotationTruck += 5;
                    }
                    TruckSpawning.transform.Translate(-2 * Time.deltaTime, 2 * Time.deltaTime, 0);
                    TruckSpawning.transform.eulerAngles = new Vector3(0, 0, rotationTruck);
                    thirdClock += 5;
                }
                else
                {
                    TruckSpawning.transform.Translate(0, 3 * Time.deltaTime, 0);
                }
            }
        }
        
	}
    void PlayerInst()
    {
        if (!GameObject.FindGameObjectWithTag("Player"))
        {
            Instantiate(Player, new Vector3(coordX, coordY, 2), Quaternion.identity);
        }

        if (forthClock < forthEndT)
        {
            forthClock += 5;
        }
        else
        {
            finalAnimation = true;
        }
    }
}
