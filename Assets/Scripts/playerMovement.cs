using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour
{
    public Rigidbody bullet;
    Vector3 carMove = new Vector3(0, 0, 0);
    public bool keyPress, gameStart, sigSpeed, trigger;
    public float y, bulletSpeed, normalMove, speed, acc, camSpeed;
    public float currentPos, lastPos;
    public int i, x, timer, tim1, tim2, timerAccel;
    Rigidbody rigidbody;

    void Start()
    {
        keyPress = false;
        sigSpeed = false;
        gameStart = false;
        acc = 0;
        speed = 2;
        camSpeed = 3f;
        bulletSpeed = 0.9f;
        normalMove = 0f;

        rigidbody = GetComponent<Rigidbody>();

    }
    
    void Update()
    {

        //if(sigSpeed == true)
        //{
        //    speed = 1;
        //}
        //else
        //{
        //    speed = 2;
        //}

        if (gameStart == false)
        {
            if(timer < 200)
            {
                gameObject.transform.Translate(0, -3f * Time.deltaTime, 0);
                timer += 5;
            }
            else if(timer >= 200)
            {
                gameStart = true;
                lastPos = transform.position.y;
                currentPos = transform.position.y;
            }
            
        }

        //Statements checking whether or not the player clicks the movement keys
        if(gameStart == true)
        {

            if (Input.GetKeyDown(KeyCode.Space)) // && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)
            {
                Fire();
            }

            Movement();

            if (trigger == true)
            {
                if (speed > 0.5f && tim2 < 10)
                {
                    if (tim1 < 20)
                    {
                        speed -= 0.5f;
                        tim1 += 1;
                    }
                    else if(tim1 >= 20)
                    {
                        speed += 2f;
                    }

                }
                //else
                //{
                //    if (speed < 2 && tim1 >= 10)
                //    {
                //        if (tim2 < 1)
                //        {
                //            speed += 0.5f;
                //            tim2 += 1;
                //        }
                //    }
                //}
            }
            else
            {
                tim1 = 0;
                tim2 = 0;
            }

        }

    }

    void Fire()
    {
        Rigidbody bulletPrefab = Instantiate(bullet, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.8f, gameObject.transform.position.z), Quaternion.identity) as Rigidbody;
        bulletPrefab.GetComponent<Rigidbody>().AddForce(new Vector3(0, 700, 0));
    }
    
    void Movement()
    {

        Vector3 carMove = new Vector3(0, 0, 0);


        if (Input.GetKey(KeyCode.W))
        {
            carMove = new Vector3(0, 2, 0) * Time.deltaTime;
            currentPos = transform.position.y;

            if(camSpeed < 3)
            {
                camSpeed += 0.5f;
            }
            else if (camSpeed <= 0)
            {
                camSpeed = 0;
            }

            //carMove = new Vector3(0, 2f) * Time.deltaTime;
            keyPress = true;
        }
        else if (currentPos > lastPos && !Input.GetKey(KeyCode.W))
        {
            currentPos -= 0.05f;
            transform.Translate(0, currentPos * Time.deltaTime, 0);
        }
        else if (currentPos <= lastPos && !Input.GetKey(KeyCode.W))
        {
            currentPos = lastPos;
        }

        if (Input.GetKey(KeyCode.S))
        {
            if(speed > 0)
            {
                speed -= 0.5f;
            }
            if(camSpeed > 0)
            {
                camSpeed -= 0.5f;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            speed = 2;
            carMove = new Vector3(-2, 0) * speed * Time.deltaTime;
            keyPress = true;
            if (y < 45)
            {
                y += 5;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            speed = 2;
            carMove = new Vector3(2, 0) * speed * Time.deltaTime;
            keyPress = true;
            if (y > -45)
            {
                y -= 5;
            }
        }

        if (keyPress == true)
        {
            //transform.eulerAngles = new Vector3(0, 0, 0);
            //transform.Translate(carMove);
            //transform.eulerAngles = new Vector3(0, 0, y);
            keyPress = false;
        }
        else if(keyPress == false)
        {

            if (y > 0)
            {
                y -= 5;
            }
            if (y < 0)
            {
                y += 5;
            }
            transform.eulerAngles = new Vector3(0, 0, y);
            //if(camSpeed != 0)
            //carMove = new Vector3(0, 0.025f, 0)* speed * Time.deltaTime;
            
        }
        transform.eulerAngles = new Vector3(0, 0, 0);
        transform.Translate(carMove);
        transform.eulerAngles = new Vector3(0, 0, y);

    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Grass")
        {
            if(speed > 0)
            {
                speed -= 0.5f;
            }
            if(camSpeed > 0)
            {
                camSpeed -= 0.5f;
            }
        }
        if(Col.gameObject.tag == "Puddle")
        {
            trigger = true;
            camSpeed = 1f;
        }
    }

    void OnTriggerExit(Collider Col)
    {
        speed = 2;
        trigger = false;
        if(speed < 2)
        {
            speed += 0.5f;
        }
        if(camSpeed < 3)
        {
            camSpeed += 0.5f;
        }
    }

}
