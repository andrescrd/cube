using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private float speed = 150;
    
    private Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();

        if (m_Rigidbody)
        {
            m_Rigidbody.AddForce(Vector3.up * speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
