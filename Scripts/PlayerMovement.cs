using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    Vector3 forwardForce;

    public float directForce = 2000f;
    public float sideForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello world");
        forwardForce = new Vector3(0, 0, directForce * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        
        rigidbody.AddForce(forwardForce);

        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rigidbody.AddForce(0, 0, -directForce * Time.deltaTime * 0.5f);
        }

        if (rigidbody.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame("you fell down");
        }
    }
}
