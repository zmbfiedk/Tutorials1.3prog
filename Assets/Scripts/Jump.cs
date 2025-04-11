using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 20f;
    [SerializeField] private float gravScaleUp = 1.5f;
    [SerializeField] private float gravScaleDown = 3f;
    private float originalGravity = -9.81f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }

        if (rb.velocity.y > 0)
        {
            Physics.gravity = new Vector3(0, gravScaleUp * originalGravity, 0);
        }
        else if (rb.velocity.y < 0)
        {
            Physics.gravity = new Vector3(0, gravScaleDown * originalGravity, 0);
        }
    }
}
