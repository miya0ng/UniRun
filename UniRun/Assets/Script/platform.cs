using UnityEngine;

public class platform : MonoBehaviour
{
    //public GameObject[] obstacles;
    public GameObject[] obstacles;

    private bool stepped;

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        foreach (var obstacle in obstacles)
        {
            obstacle.SetActive(Random.value < 0.3);
        }
        transform.position = new Vector3(0, Random.Range(-30, 30), 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!stepped && collision.collider.CompareTag("Player"))
        {
            stepped = true;
            gameManager.AddScore(1);
        }
    }
}
