using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< Updated upstream
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed = 5.0f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;
=======
>>>>>>> Stashed changes

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpPower, speed, acceleration, velocity;

    void Start()
    {
<<<<<<< Updated upstream
        rb = GetComponent<Rigidbody2D>();
=======
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {

        velocity = 0;

        if (Input.GetKey(KeyCode.D))
        {
            velocity = Mathf.Lerp(rb.linearVelocityX, -speed, Time.deltaTime * acceleration);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            velocity = Mathf.Lerp(rb.linearVelocityX, speed, Time.deltaTime * acceleration);
        }

        rb.angularVelocity = velocity;

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * jumpPower);
        }
    }
}
