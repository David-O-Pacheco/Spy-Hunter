//using UnityEngine;
//using System.Collections;

//public class puddleCol : MonoBehaviour
//{

//    playerMovement speedChange = new playerMovement();
//    public GameObject player;
//    public bool trigger;
//    int timer, timer2;

//    void Start()
//    {
//        player.GetComponent<playerMovement>();
//    }

//    void Update()
//    {
//        if (GameObject.FindGameObjectWithTag("Player"))
//        {
//            speedChange = GameObject.Find("Player").GetComponent<playerMovement>();
//        }

//        if (trigger == true)
//        {
//            if (speedChange.speed >= 2 && timer2 < 50)
//            {
//                if (timer < 100)
//                {
//                    speedChange.speed -= 0.5f;
//                    timer++;
//                }

//            }
//            else
//            {
//                if (speedChange.speed < 2 && timer >= 50)
//                {
//                    if (timer2 < 100)
//                    {
//                        speedChange.speed += 0.5f;
//                        timer++;
//                    }
//                }
//            }
//        }
//        else
//        {
//            timer = 0;
//            timer2 = 0;
//        }


//    }

//    void OnTriggerEnter(Collider Col)
//    {
//        if (Col.gameObject.tag == "Puddle")
//        {
//            trigger = true;
//        }

//    }

//    void OnTriggerExit(Collider Col)
//    {
//        trigger = false;
//    }
//}
