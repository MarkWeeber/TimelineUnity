using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectModifier : MonoBehaviour
{
    private Rigidbody rb;
    private bool expand = false;
    private float expandPortion = 0f;
    private float expandTimer = 0;
    private float time = 1.5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(expand)
        {
            this.transform.localScale = new Vector3(this.transform.localScale.x + expandPortion, 
                                                    this.transform.localScale.y + expandPortion,
                                                    this.transform.localScale.z + expandPortion);
            expandTimer -= Time.deltaTime;
            if(expandTimer < 0)
            {
                expand = false;
            }
        }
    }

    public void Jump(float value)
    {
        rb.AddForce(Vector3.up * value, ForceMode.Impulse);
    }

    public void Expand(float size)
    {
        expand = true;
        expandTimer = time;
        expandPortion = size / time;
    }

    public void DestroyThis()
    {
        Destroy(gameObject);
    }
}
