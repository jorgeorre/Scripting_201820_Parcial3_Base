using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private ActorController[] players;
    public GameObject[] ai = new GameObject[4];
    private float gameTime = 25F;
    private Vector3 spawnVal;
    public float CurrentGameTime { get; set; }
    int randai;
    // Use this for initialization
    private IEnumerator Start()
    {

        CurrentGameTime = gameTime;

        // Sets the first random tagged player
        players = FindObjectsOfType<ActorController>();

        yield return new WaitForSeconds(0.5F);

        players[Random.Range(0, players.Length)].onActorTagged(true);

        randai = Random.Range(0, 5);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnVal.x, spawnVal.x), 1, Random.Range(-spawnVal.z, spawnVal.z));
        Instantiate(ai[randai], spawnPos + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation); 
    }

    private void Update()
    {
        CurrentGameTime -= Time.deltaTime;

        if (CurrentGameTime <= 0F)
        {
            //TODO: Send GameOver event.
            
            Debug.Log("Game Over");

        }
    }
}