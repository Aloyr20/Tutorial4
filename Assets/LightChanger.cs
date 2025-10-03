using UnityEngine;

public class LightChanger : MonoBehaviour
{
    float rotate_y = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,rotate_y += 10, 0);
    }
}
