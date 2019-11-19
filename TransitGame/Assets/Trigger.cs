using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    FollowSpritePath aux = new FollowSpritePath();
    CameraFollow cam = new CameraFollow();

    float startingTime = 50f;
    static float currentTime = 0f;
    bool time = false;
    bool menu = false;

    void Start()
    {
        currentTime = startingTime;
        menu = true;
        cam.setMenuTime(true);
        aux.setSpeed(0.0f);
    }
    
    void Update()
    {
        if (menu)
        {
            currentTime -= 1 * Time.deltaTime;
            //print(currentTime);
            if (currentTime <= 0.0f)
            {
                aux.setSpeed(50f);
                cam.setPregunta(0);
                cam.setTest(false);
                currentTime = startingTime;
                cam.setMenuTime(false);
                menu = false;
            }
        }
        if (time)
        {
            currentTime -= 1 * Time.deltaTime;
            //print(currentTime);
            if (currentTime <= 0.0f)
            {
                aux.setSpeed(50f);
                cam.setPregunta(0);
                cam.setTest(false);
                currentTime = startingTime;
                time = false;
            }
        }
     

        //print(currentTime);
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if(gameObject.name == "ProhibidoPeatones")
            {
                cam.setPregunta(1);
                cam.setTest(true);
                time = true;
                Debug.Log("Cambio Interfaz Succesfull mission accomplished continue to next level !");
                aux.setSpeed(0.0f);
            }

            if (gameObject.name == "CrucePeaton")
            {
                cam.setPregunta(2);
                cam.setTest(true);
                time = true;
                Debug.Log("Cambio Interfaz Succesfull mission accomplished continue to next level !");
                aux.setSpeed(0.0f);
            }

            if (gameObject.name == "MovilidadReducida")
            {
                cam.setPregunta(3);
                cam.setTest(true);
                time = true;
                Debug.Log("Cambio Interfaz Succesfull mission accomplished continue to next level !");
                aux.setSpeed(0.0f);
            }

            if (gameObject.name == "ZonaEscolar")
            {
                cam.setPregunta(4);
                cam.setTest(true);
                time = true;
                Debug.Log("Cambio Interfaz Succesfull mission accomplished continue to next level !");
                aux.setSpeed(0.0f);
            }

            if (gameObject.name == "SeñalPare")
            {
                cam.setPregunta(5);
                cam.setTest(true);
                time = true;
                Debug.Log("Cambio Interfaz Succesfull mission accomplished continue to next level !");
                aux.setSpeed(0.0f);
            }

            if (gameObject.name == "Vel30kmh")
            {
                cam.setPregunta(6);
                cam.setTest(true);
                time = true;
                Debug.Log("Cambio Interfaz Succesfull mission accomplished continue to next level !");
                aux.setSpeed(0.0f);
            }

            if (gameObject.name == "Semaforo")
            {
                cam.setPregunta(7);
                cam.setTest(true);
                time = true;
                Debug.Log("Cambio Interfaz Succesfull mission accomplished continue to next level !");
                aux.setSpeed(0.0f);
            }
        }
       
    }

    
}
