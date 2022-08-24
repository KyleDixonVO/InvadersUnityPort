using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public PlayerInventory inventory;
    public PlayerMovement_2D playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement_2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
