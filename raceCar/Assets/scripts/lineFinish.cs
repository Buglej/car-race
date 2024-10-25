using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineFinish : MonoBehaviour
{
    private BoxCollider2D myBoxCollider;
    public bool coll = false;
    // Start is called before the first frame update
    void Start()
    {
        myBoxCollider = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CekaniCoroutine());
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Car")
            coll = true;
    }
    IEnumerator CekaniCoroutine()
    {
        if (coll == true)
        {
            myBoxCollider.enabled = false;
            yield return new WaitForSeconds(0.1f);
            coll = false;
            myBoxCollider.enabled = true;
        }
    }
}