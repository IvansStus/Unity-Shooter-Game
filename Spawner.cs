using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]

public class Wave{
    public string waveName;
    public int numberOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;

}

public class Spawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    public Animator animator;
    //public Text waveName;
    //public Button nextLevel;
    //public Button nextButton;
    //zpublic int numScene;

    private Wave currentWave;
    private int currentWaveIndex;
    private bool canSpawn = true;
    private float nextSpawnTime;
    private bool canAnimate = false;
   
    // Update is called once per frame
    void Update()
    {
        currentWave = waves[currentWaveIndex];
        SpawnWave();
        
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        if(totalEnemies.Length == 0 && Time.time != 0){
            animator.SetTrigger("LevelComplete");
            Debug.Log("Level Finished");
            StartCoroutine(LoadNextScene());
        }

    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(5);
        if (SceneManager.GetActiveScene().name == "Game Scene 1")
        {
            SceneManager.LoadScene("Game Scene 2");
        }

        if (SceneManager.GetActiveScene().name == "Game Scene 2")
        {
            SceneManager.LoadScene("Game Scene 3");
        }

        if (SceneManager.GetActiveScene().name == "Game Scene 3")
        {
            SceneManager.LoadScene("Credits");
        }
    }

    void SpawnNextWave(){
        currentWaveIndex++;
        canSpawn = true; 
    }

    void SpawnWave(){
        if(canSpawn && nextSpawnTime < Time.time){
            GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0,currentWave.typeOfEnemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0,spawnPoints.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.numberOfEnemies--;
            nextSpawnTime = Time.time + currentWave.spawnInterval;
            if(currentWave.numberOfEnemies == 0){
                canSpawn = false;
                canAnimate = true;
            }
        }
        
    }

    /*
    public void NextLevel()
    {
        Debug.Log("Clicked Next Level Button!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + numScene);
    }

    public void LostGame(){
        animator.SetTrigger("isDead");
        nextButton.gameObject.SetActive(true);

    }

    public void LoadCredits() {
        SceneManager.LoadScene(2);
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    */

}