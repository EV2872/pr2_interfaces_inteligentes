using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer6 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject cilindro;
    GameObject cubo;
    GameObject esfera;
    void Start()
    {
        cilindro = GameObject.FindWithTag("Cylinder");
        cubo = GameObject.FindWithTag("Cube");
        esfera = GameObject.FindWithTag("Sphere");
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 posEsfera = esfera.transform.position;
        Vector3 newposCilindro = cilindro.transform.position;
        Vector3 newposCubo = cubo.transform.position;
        newposCilindro[0] = posEsfera.x + 5;
        newposCilindro[1] = posEsfera.y;
        newposCilindro[2] = posEsfera.z;
        newposCubo[0] = posEsfera.x - 5;
        newposCubo[1] = posEsfera.y;
        newposCubo[2] = posEsfera.z;
        cilindro.transform.position = newposCilindro;
        cubo.transform.position = newposCubo;
    }
}
