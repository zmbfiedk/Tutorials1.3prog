using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public float force = 1000f;
    public GameObject ps;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            Transform t = other.transform;

            rb.AddExplosionForce(force, new Vector3(t.position.x, t.position.y, t.position.z + 1f), 0f);

            MoveBasic mbScript = other.GetComponentInChildren<MoveBasic>();
            mbScript.enabled = false;

            rb.constraints = RigidbodyConstraints.None;

            GameObject p = Instantiate(ps, transform);
            p.transform.position = t.position;

            Destroy(p, 1f);
        }
    }
}
