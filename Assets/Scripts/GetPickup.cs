using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private Renderer r;            
    private AudioSource source;     
    private ParticleSystem ps;      

    void Start()
    {
        r = GetComponent<Renderer>();
        source = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("LALAL");
            r.enabled = false;
            source.Play();
            ps.Play();
            GameObject.Destroy(gameObject, 2f);
        }
    }
}
