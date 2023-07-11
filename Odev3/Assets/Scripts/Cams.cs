using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour
{
    public GameObject cam;


    public Camera MainCam;
    public Camera cam2;
    

    public GameObject[] text;
    public GameObject[] text1;
    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(false);
        textClose();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha2))
        {
            cam.SetActive(true);
            gameObject.GetComponent<Canvas>().worldCamera = cam2 as Camera;
            textOpen();
            text1Close();
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cam.SetActive(false);
            gameObject.GetComponent<Canvas>().worldCamera = MainCam as Camera;
            textClose();
            text1Open();
        }
    }

    void textOpen()
    {
        text[0].SetActive(true);
        text[1].SetActive(true);
        text[2].SetActive(true);
        text[3].SetActive(true);
        text[4].SetActive(true);
        text[5].SetActive(true);
        text[6].SetActive(true);
        text[7].SetActive(true);
        text[8].SetActive(true);
    }
    void textClose()
    {
        text[0].SetActive(false);
        text[1].SetActive(false);
        text[2].SetActive(false);
        text[3].SetActive(false);
        text[4].SetActive(false);
        text[5].SetActive(false);
        text[6].SetActive(false);
        text[7].SetActive(false);
        text[8].SetActive(false);
    }

    void text1Open()
    {
        text1[0].SetActive(true);
        text1[1].SetActive(true);
        text1[2].SetActive(true);
        text1[3].SetActive(true);
        text1[4].SetActive(true);
        text1[5].SetActive(true);
        text1[6].SetActive(true);
        text1[7].SetActive(true);
        text1[8].SetActive(true);
    }
    void text1Close()
    {
        text1[0].SetActive(false);
        text1[1].SetActive(false);
        text1[2].SetActive(false);
        text1[3].SetActive(false);
        text1[4].SetActive(false);
        text1[5].SetActive(false);
        text1[6].SetActive(false);
        text1[7].SetActive(false);
        text1[8].SetActive(false);
    }
}
