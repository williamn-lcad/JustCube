using UnityEngine;

public class Spinning : MonoBehaviour
{
    Vector3 rotation = new Vector3(0, 45, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }
}
