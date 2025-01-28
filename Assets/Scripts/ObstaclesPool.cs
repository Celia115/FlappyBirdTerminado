//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ObstaclesPool : MonoBehaviour
//{
//    [SerializeField] private GameObject obstablePrefab;
//    [SerializeField] private int poolSize = 5;
//    [SerializeField] private float spawnTime = 2.5f;
//    [SerializeField] private float xSpawnPosition = 12f;
//    [SerializeField] private float minYPosition = -2f;
//    [SerializeField] private float maxYPosition = 3f;

//    private float timeElapsed;
//    private int obstacleCount;
//    private GameObject[] obstacles;

//    void Start()
//    {
 //       // Calcula la posici�n inicial de las tuber�as desde el borde derecho de la c�mara
 //       Camera mainCamera = Camera.main;
 //       float cameraWidth = mainCamera.orthographicSize * mainCamera.aspect;
 //       xSpawnPosition = mainCamera.transform.position.x + cameraWidth;

//        obstacles = new GameObject[poolSize];
//        for (int i = 0; i < poolSize; i++)
//        {
//            obstacles[i] = Instantiate(obstablePrefab);
//            obstacles[i].SetActive(false);
 //       }

        // Genera una tuber�a inicial para evitar esperas
//        SpawnObstacle();
//    }

//    void Update()
//    {
//        timeElapsed += Time.deltaTime;
//        if (timeElapsed > spawnTime && !GameManager.Instance.isGameOver)
//        {
//            SpawnObstacle();
//        }
 //   }

 //   private void SpawnObstacle()
  //  {
 //       timeElapsed = 0f;

        // Genera una posici�n aleatoria en el eje Y entre los valores definidos
 //       float ySpawnPosition = Random.Range(minYPosition, maxYPosition);
 //       Vector2 spawnPosition = new Vector2(xSpawnPosition, ySpawnPosition);

        // Establece la posici�n del obst�culo y lo activa si no est� activo
 //       obstacles[obstacleCount].transform.position = spawnPosition;

 //       if (!obstacles[obstacleCount].activeSelf)
 //       {
 //           obstacles[obstacleCount].SetActive(true);
 //       }

   //     obstacleCount++;

        // Si hemos alcanzado el tama�o del pool, reiniciamos el contador
   //     if (obstacleCount == poolSize)
   //     {
   //         obstacleCount = 0;
      //  }
   // }
//}
