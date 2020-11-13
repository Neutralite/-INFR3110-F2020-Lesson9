using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerBehaviour>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
    }
}
