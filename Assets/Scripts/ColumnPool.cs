using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize = 5;
    public GameObject columnPrefab;

    public float columnMin = -1f;
    public float columnMax = 3f;
    private float spawnXPosition = 10f;

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-14, 0);

    private float timeSinceLastSpawned;
    public float spawnRate;

    private int currentColumn;

    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            // Instancia los obstáculos fuera de la pantalla inicial
            columns[i] = Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
            columns[i].SetActive(false); // Los desactiva inicialmente
        }
    }



    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (!GameManager.Instance.isGameOver && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;

            // Genera una posición aleatoria en el eje Y
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            // Activa la columna si está desactivada
            if (!columns[currentColumn].activeSelf)
            {
                columns[currentColumn].SetActive(true);
            }

            currentColumn++;
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
        }
    }

}
