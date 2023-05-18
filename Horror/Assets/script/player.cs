using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private Transform m_transform;
    private float y;
    private void Start()
    {
       y = transform.position.y;
    }

    void Update()
    {
        
        Vector3 forward = transform.forward;
        Vector3 right = Vector3.Cross(forward, new Vector3(0,1,0));
        if (Input.GetKey(KeyCode.LeftArrow))
            m_transform.position -=right;
        if(Input.GetKey(KeyCode.RightArrow))
            m_transform.position+=right;
        if (Input.GetKey(KeyCode.UpArrow))
            m_transform.position -= forward;
        if(Input.GetKey(KeyCode.DownArrow))
            m_transform.position+=forward;
        m_transform.position.Set(m_transform.position.x,y, m_transform.position.z);

        
        
    }
}
