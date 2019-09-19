using UnityEngine;
using System.Collections;

public class enemieSpawner2 : MonoBehaviour {
    int randVehicle, randLocation, rangeSpawn;
    float coordX, coordY;
    float timer, timer2;
    public GameObject RightTruck, RightTaxi, RightPolice;


    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        if (timer2 < 50)
        {
            timer2 += 1;
        }
        else if (timer2 > 50)
        {
            rangeSpawn = Random.Range(10, 30);
            timer2 = 0;
        }

        if (timer < 180 + rangeSpawn)
        {
            timer += 1;
        }
        else if (timer == 180 + rangeSpawn)
        {
            timer = 0;
            randLocation = Random.Range(1, 4);
            randVehicle = Random.Range(1, 4);
        }

        if (randLocation == 1)
        {
            coordX = -1.34f;
            coordY = -25f;
        }
        if (randLocation == 2)
        {
            coordX = -3.07f;
            coordY = -25;
        }
        if (randLocation == 3)
        {
            coordX = -4.83f;
            coordY = -25;
        }

        if (randVehicle == 1 && coordX != 0) //Right Truck
        {
            Instantiate(RightTruck, new Vector3(coordX, coordY, 2), Quaternion.identity);
            randVehicle = 0;
            randLocation = 0;
            coordX = 0;
            coordY = 0;
        }

        else if (randVehicle == 2 && coordX != 0) //Right Taxi
        {
            Instantiate(RightTaxi, new Vector3(coordX, coordY, 2), Quaternion.identity);
            randVehicle = 0;
            randLocation = 0;
            coordX = 0;
            coordY = 0;
        }

        else if (randVehicle == 3 && coordX != 0) //Right Police
        {
            Instantiate(RightPolice, new Vector3(coordX, coordY, 2), Quaternion.identity);
            randVehicle = 0;
            randLocation = 0;
            coordX = 0;
            coordY = 0;
        }

    }
}
