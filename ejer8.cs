using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer8 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] esferas;
    GameObject cubo;
    int posMin = -1;
    int posMax  = 0;
    void Start()
    {
        esferas =  GameObject.FindGameObjectsWithTag("grupo1");
        cubo = GameObject.FindWithTag("Cube");
                // Inicializar la posición inicial de la esfera más cercana
        float distanciaMinima = float.MaxValue;
        for (int i = 0; i < esferas.Length; i++)
        {
            float distancia = Vector3.Distance(esferas[i].transform.position, cubo.transform.position);
            if (distancia < distanciaMinima)
            {
                distanciaMinima = distancia;
                posMin = i;
            }
        }
        float distanciaMaxima = float.MinValue;
        for (int i = 0; i < esferas.Length; i++)
        {
            float distancia = Vector3.Distance(esferas[i].transform.position, cubo.transform.position);
            if (distancia > distanciaMaxima)
            {
                distanciaMaxima = distancia;
                posMax = i;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        float distanciaMaxima = float.MinValue;
        for (int i = 0; i < esferas.Length; i++)
        {
            float distancia = Vector3.Distance(esferas[i].transform.position, cubo.transform.position);
            if (distancia > distanciaMaxima)
            {
                distanciaMaxima = distancia;
                posMax = i;
            }
        }
        */
        
        if (esferas[posMin].transform.position.y < 10) {
            Vector3 avanza = new Vector3(esferas[posMin].transform.position.x, esferas[posMin].transform.position.y + 1,esferas[posMin].transform.position.z );
            esferas[posMin].GetComponent<Transform>().position = avanza;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Material m_Material;
            m_Material = esferas[posMax].GetComponent<Renderer>().material;
            Color colorAleatorio = new Color(Random.value, Random.value, Random.value);
            m_Material.color = colorAleatorio;
        }
    }
}
