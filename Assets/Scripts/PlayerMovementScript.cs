using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public Rigidbody rb;

    public GameManager manager;
    public float speed =5;
    public bool snappy = true;

    private Vector3 movementInput;

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
        if(manager == null){
            manager = gameObject.AddComponent<GameManager>();
        }
        speed = manager.PlayerSpeed;
    }

    void Update()
    {
        // 1. Only read X (Horizontal) input
        float x = Input.GetAxisRaw("Horizontal"); // "Raw" makes it stop instantly

        // 2. We set Z to 0 so you never move into the background/foreground
        movementInput = new Vector3(x, 0, 0).normalized;
    }

    private void FixedUpdate()
    {
        if (snappy)
        {
            // 3. Apply speed to X, keep Gravity (Y), and force Z to 0
            // Note: If you are using Unity 6, change 'velocity' to 'linearVelocity'
            rb.linearVelocity = new Vector3(movementInput.x * speed, rb.linearVelocity.y, 0);
        }
        else
        {
            // Adds force only on the X axis
            rb.AddForce(new Vector3(movementInput.x * speed * 10f, 0, 0));
        }
    }
}