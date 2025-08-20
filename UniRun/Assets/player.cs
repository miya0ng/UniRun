using UnityEngine;

public class player : MonoBehaviour
{
    private float jumpforce=10f;

    public int jumpCountMax = 2;
    public int jumpCount = 0;
    public float timer ;
    public int score =1;
    private Animator Animator;
    private Rigidbody2D rb;
    public GameManager gameManger;
    public GameObject gm = null;
    private bool grounded = true;
    private bool isDead = false;
    private void Awake()
    {
        Animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        if (CompareTag("GameController"))
        {
            gameManger = gm.GetComponent<GameManager>();
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButtonDown(0)&& jumpCount < jumpCountMax)
        {
            rb.AddForce(new Vector2(0, jumpforce), ForceMode2D.Impulse);
            jumpCount++;
            if(timer==1)
            {
                timer = 0;
                gameManger.AddScore(score);
            }
        }
        Animator.SetBool("Grounded", grounded);
        //Debug.Log(jumpScore);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            jumpCount = 0;
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            grounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeadZone") && !isDead)
        {
            Die();
        }
    }

    private void Die()
    {
        Animator.SetTrigger("Die");
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.linearVelocity = Vector2.zero;
        isDead = true;
        gameManger.OnPLayerDead();
    }
}
