using UnityEngine;

public class PipeMovemenrScript : MonoBehaviour
{
    public float movespeed = 5;
    public float deadZone = -30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position= transform.position +(Vector3.left*movespeed)* Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Pipe deleted");
        Destroy(gameObject);
        }
        
    }
}
