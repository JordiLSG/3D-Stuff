using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    public Canvas popUpCanvas;

    public float radius;


    private void Start()
    {
        popUpCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] players = Physics.OverlapSphere(transform.position, radius);

        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].gameObject.tag == "Jammo")
            {
                popUpCanvas.gameObject.SetActive(true);
                print(players[i].gameObject.name);
            }
        }
    }


}
