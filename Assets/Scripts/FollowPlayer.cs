using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + new Vector3(0.5f, 7.6f, 17f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0.5f, 7.6f, 17f);
    }
}
