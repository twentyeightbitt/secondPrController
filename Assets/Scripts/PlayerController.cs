using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gameOver == false)
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
