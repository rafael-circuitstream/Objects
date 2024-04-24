using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    public ScoreManager scoreManager;
    Coroutine c;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Enemy enemyPrefab;
    private float timer;
    // Start is called before the first frame update
    private void Awake()
    {
        singleton = this;
    }

    void Start()
    {
        StartSpawningEnemy();
       
    }

    public void EndGame()
    {
        StopAllCoroutines();
        scoreManager.RegisterHighScore();
    }
    public void StartSpawningEnemy()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy() //
    {
        while (10 == 10)
        {
            yield return new WaitForSeconds(3f);
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform randomSpawnPoint = spawnPoints[randomIndex];

            Enemy enemy = Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            enemy.SetUpEnemy(1);

        }

    }


}
