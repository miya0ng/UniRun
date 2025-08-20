using Unity.VisualScripting;
using UnityEngine;
public class Scroll : MonoBehaviour
{
    public float speed = 10f;

    private void Start()
    {

    }
    private void Update()
    {
        GameManager gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        if(gameManager.IsGameOver)
        {
            return; // Do not scroll if the game is over
        }
        if (CompareTag("Background")|| CompareTag("Platform"))
        {
            if(transform.position.x < -20)
            {
                transform.position = new Vector2(20,0);
            }
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
