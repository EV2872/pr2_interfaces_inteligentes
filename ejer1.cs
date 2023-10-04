using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer1 : MonoBehaviour
{
public int arraySize = 10;  // Tamaño del array
    public float maxValue = 25f;   // Valor máximo para los números aleatorios
    private Vector3[] vectorArray;  // El array que almacenará los valores aleatorios como Vector3

    // Start is called before the first frame update
    void Start() {
        // Inicializa el array con valores aleatorios
        InitializeArray();
    }

    // Update is called once per frame
    void Update() {
        ChangeRandomElement();
        DisplayValuesGreaterThan15();
    }

    void InitializeArray() {
        vectorArray = new Vector3[arraySize];
        for (int i = 0; i < arraySize; i++) {
            float randomX = Random.Range(0f, maxValue);
            float randomY = Random.Range(0f, maxValue);
            float randomZ = Random.Range(0f, maxValue);
            vectorArray[i] = new Vector3(randomX, randomY, randomZ);
        }
    }

    void ChangeRandomElement() {
        int randomIndex = Random.Range(0, arraySize);
        float randomX = Random.Range(0f, maxValue);
        float randomY = Random.Range(0f, maxValue);
        float randomZ = Random.Range(0f, maxValue);
        vectorArray[randomIndex] = new Vector3(randomX, randomY, randomZ);
        transform.position = vectorArray[randomIndex];
    }

    void DisplayValuesGreaterThan15() {
        foreach (Vector3 value in vectorArray) {
            if (value.magnitude > 15f) {
                Debug.Log(value);
            }
        }
    }
}
