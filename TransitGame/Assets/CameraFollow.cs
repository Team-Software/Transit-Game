using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform target;
    public Transform pregunta1;
    public Transform pregunta2;
    public Transform pregunta3;
    public Transform pregunta4;
    public Transform pregunta5;
    public Transform pregunta6;
    public Transform pregunta7;
    public Transform menu;
    // Use this for initialization

    public Camera m_OrthographicCamera;
    public Camera m_OrthographicCamera2;
    //These are the positions and dimensions of the Camera view in the Game view
    float m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight;

    void Start () {
        ////This sets the Camera view rectangle to be in the bottom corner of the screen
        //m_ViewPositionX = 0;
        //m_ViewPositionY = 0;

        ////This sets the Camera view rectangle to be smaller so you can compare the orthographic view of this Camera with the perspective view of the Main Camera
        //m_ViewWidth = 0.4f;
        //m_ViewHeight = 0.4f;
        ////This enables the Camera (the one that is orthographic)
        //m_OrthographicCamera.enabled = true;

        ////If the Camera exists in the inspector, enable orthographic mode and change the size
        //if (m_OrthographicCamera)
        //{
        //    print("je");
        //    //This enables the orthographic mode
        //    m_OrthographicCamera.orthographic = true;
        //    //Set the size of the viewing volume you'd like the orthographic Camera to pick up (5)
        //    m_OrthographicCamera.orthographicSize = 5.0f;
        //    //Set the orthographic Camera Viewport size and position
        //    m_OrthographicCamera.rect = new Rect(m_ViewPositionX, m_ViewPositionY, m_ViewWidth, m_ViewHeight);
        //}
    }


    static bool test = false;
    static bool isMenuTime = false;
    static int pregunta = 0;
	// Update is called once per frame
	void Update () {
        if (!test)
        {
            if (isMenuTime)
            {
                m_OrthographicCamera2.enabled = false;
                m_OrthographicCamera.enabled = true;
                transform.position = new Vector3(menu.position.x, menu.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 4f;
                m_OrthographicCamera2.orthographicSize = 4f;
            }
            else
            {
                transform.position = new Vector3(target.position.x, target.position.y, 2f);
                m_OrthographicCamera.enabled = false;
                m_OrthographicCamera2.enabled = true;
                m_OrthographicCamera2.orthographicSize = 30f;
            }
          
        }
        else
        {
            if(pregunta == 1)
            {
                transform.position = new Vector3(pregunta1.position.x, pregunta1.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 7f;
            }
            if (pregunta == 2)
            {
                transform.position = new Vector3(pregunta2.position.x, pregunta2.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 4f;
            }
            if (pregunta == 3)
            {
                transform.position = new Vector3(pregunta3.position.x, pregunta3.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 4f;
            }
            if (pregunta == 4)
            {
                transform.position = new Vector3(pregunta4.position.x, pregunta4.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 4f;
            }

            if (pregunta == 5)
            {
                transform.position = new Vector3(pregunta5.position.x, pregunta5.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 4f;
            }

            if (pregunta == 6)
            {
                transform.position = new Vector3(pregunta6.position.x, pregunta6.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 4f;
            }

            if (pregunta == 7)
            {
                transform.position = new Vector3(pregunta7.position.x, pregunta7.position.y, 2f);
                m_OrthographicCamera.orthographicSize = 4f;
            }
        }
	}

    public void setTest(bool v)
    {
        test = v;
    }
    public void setMenuTime(bool v)
    {
        isMenuTime = v;
    }
    public void setPregunta(int v)
    {
        pregunta = v;
    }
}
