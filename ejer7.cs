using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer7 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A)) {
            Material m_Material;
            m_Material = GetComponent<Renderer>().material;
            Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
            Renderer cilindroRenderer = cilindro.GetComponent<Renderer>();
            cilindroRenderer.material.color = colorAleatorio;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Material m_Material;
            m_Material = GetComponent<Renderer>().material;
            Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
            Renderer cuboRenderer = cubo.GetComponent<Renderer>();
            cuboRenderer.material.color = colorAleatorio;
        }
    }
}
