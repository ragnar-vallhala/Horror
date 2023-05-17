using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = new Vector2(0,0);
        if(Input.GetKey(KeyCode.LeftArrow))
        position.x--;
        if(Input.GetKey(KeyCode.RightArrow))
        position.x++;
        if(Input.GetKey(KeyCode.UpArrow))
        position.y++;
        if(Input.GetKey(KeyCode.DownArrow))
        position.y--;
        position = position.normalized;
        transform.position += new Vector3(position.x,0, position.y);
    }
}
