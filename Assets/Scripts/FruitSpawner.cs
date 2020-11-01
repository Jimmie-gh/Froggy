using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private List<Fruit> fruitsToSpawn = new List<Fruit>();
    [SerializeField] private float spawnPeriod=1f;
    [SerializeField] private ScoreController scoreController;
    [SerializeField] private float edge = 8.9f;

    private void Start()
    {
        StartCoroutine(Spawning());
    }

    private void Spawn()
    {
        int fruitNumber = Random.Range(0, fruitsToSpawn.Count);
        Fruit currentFruit = fruitsToSpawn[fruitNumber];
        Fruit spawnedFruit = Instantiate(currentFruit, new Vector2(Random.Range(-edge,edge), transform.position.y), Quaternion.identity);
        spawnedFruit.Initialize(scoreController);

    }  



    private IEnumerator Spawning()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnPeriod);
        }
    }



}
