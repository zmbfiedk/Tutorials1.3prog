using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb; 
    public float force = 20f; //jump force keep public
    void Start()
    {
        rb = GetComponent<Rigidbody>();// dont delete
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
