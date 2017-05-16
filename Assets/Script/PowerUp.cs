using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PowerUp : MonoBehaviour
{
    
    public GameObject FPSpref;
    public GameObject startpoint;
    public Transform prefab;
    public Vector3 pos;
    public int count;
    // Use this for initialization
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {

        
        if (hit.gameObject.tag == "Cube")
        {
            count++;
            GameManager.instance.colis = false;
            Vector3  pos= gameObject.transform.position;
            Debug.Log(count.ToString());
            if (count == 2 )
            {
                gameObject.GetComponentInChildren<Camera>().rect = new Rect(.5f, 0f, .5f, 1f);
                Instantiate(prefab, pos + new Vector3(-3, 0, -3), Quaternion.identity);
                prefab.GetComponentInChildren<Camera>().rect = new Rect(0f, 0f, .5f, 1f);


            }
            if (count == 3)
            {
                gameObject.GetComponentInChildren<Camera>().rect = new Rect(.5f, .5f, .5f, .5f);
                gameObject.GetComponentInChildren<Camera>().rect = new Rect(.5f, 0f, .5f, .5f);
                Instantiate(prefab,pos + new Vector3(3, 0, -3), Quaternion.identity);
                prefab.GetComponentInChildren<Camera>().rect = new Rect(0f, 0f, .5f, .5f);
                Instantiate(prefab, pos + new Vector3(-6, 0, -3), Quaternion.identity);
                prefab.GetComponentInChildren<Camera>().rect = new Rect(0f, .5f, .5f, 5f);
            }
            Destroy(hit.gameObject);
            
        }
        
    }

}
