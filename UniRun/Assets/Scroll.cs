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
        if (CompareTag("Background")|| CompareTag("Platform"))
        {
            if(transform.position.x < -20)
            {
                transform.position = new Vector3(20,0,0);
            }
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
