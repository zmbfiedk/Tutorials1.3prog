using UnityEngine;

public class MoveBasic : MonoBehaviour
{
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 50f;

    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 positionUpdate = transform.position + Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        rb.MovePosition(positionUpdate);

        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));
    }
}
