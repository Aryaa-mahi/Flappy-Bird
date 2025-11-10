using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public LogicScript logicScript;
    public bool birdisAlive = true; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapstrength;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        birdisAlive = false;
    }
}
