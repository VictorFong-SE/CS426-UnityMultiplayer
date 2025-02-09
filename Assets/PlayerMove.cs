using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

        var x = Input.GetAxis("Horizontal") * .1f;
        var z = Input.GetAxis("Vertical") * .1f;
        transform.Translate(x,0,z);
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
