using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed, jumpForce;

    Rigidbody2D rb2D;
    ModeManager modeManager;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        modeManager = FindAnyObjectByType<ModeManager>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.left);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        modeManager.Toggle();
    }
}
