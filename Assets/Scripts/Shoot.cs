using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;  

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject ob = Instantiate(prefab);

            ob.transform.rotation = transform.rotation;

            ob.transform.position = transform.position + transform.forward;

            Destroy(ob, 3f);
        }
    }
}
