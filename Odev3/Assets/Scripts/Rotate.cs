using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public GameObject[] gezegen;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        KendiEkseni();
        GunesEtrafi();

    }

    void KendiEkseni()
    {
        gezegen[0].transform.Rotate(0, 0.3f, 0);
        gezegen[1].transform.Rotate(0, 0.4f, 0);
        gezegen[2].transform.Rotate(0, 0.3f, 0);
        gezegen[3].transform.Rotate(0, 2f, 0);
        gezegen[4].transform.Rotate(0, 0.5f, 0);
        gezegen[5].transform.Rotate(0, 7f, 0);
        gezegen[6].transform.Rotate(0, 5f, 0);
        gezegen[7].transform.Rotate(0, 3f, 0);
        gezegen[8].transform.Rotate(0, 4f, 0);
    }

    void GunesEtrafi()
    {
        gezegen[1].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 20 * Time.deltaTime);
        gezegen[2].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 18 * Time.deltaTime);
        gezegen[3].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 16 * Time.deltaTime);
        gezegen[4].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 14 * Time.deltaTime);
        gezegen[5].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 12 * Time.deltaTime);
        gezegen[6].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 4 * Time.deltaTime);
        gezegen[7].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 3 * Time.deltaTime);
        gezegen[8].transform.RotateAround(gezegen[0].transform.position, Vector3.up, 2 * Time.deltaTime);
    }
}
