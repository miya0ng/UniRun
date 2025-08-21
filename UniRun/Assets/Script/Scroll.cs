using Unity.VisualScripting;
using UnityEngine;
public class Scroll : MonoBehaviour
{
    public float speed = 10f;
    GameObject p;

    private void Start()
    {
        p = GameObject.FindWithTag("Platform");
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
                p.SetActive(false);
                //transform.position = new Vector2(20,0);
            }
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
