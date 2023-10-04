using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer5 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject cilindro;
    GameObject cubo;
    void Start()
    {
        cilindro = GameObject.FindWithTag("Cylinder");
        cubo = GameObject.FindWithTag("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Distancia al cilindro: " + Vector3.Distance(transform.position, cilindro.transform.position));
        Debug.Log("Distancia al cubo: " + Vector3.Distance(transform.position, cubo.transform.position));
    }
}
