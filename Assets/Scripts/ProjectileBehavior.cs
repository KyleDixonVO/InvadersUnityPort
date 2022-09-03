using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public Sprite[] projectileSprites;
    public float speed;
    public int damage;
    void Start()
    {
        player = GameObject.Find("Player");
        switch (player.GetComponent<PlayerInventory>().currentWeapon) {

            case PlayerInventory.CurrentWeapon.pistol:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = projectileSprites[0];
                break;

            case PlayerInventory.CurrentWeapon.laser:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = projectileSprites[1];
                break;

            case PlayerInventory.CurrentWeapon.railgun:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = projectileSprites[2];
                break;

            case PlayerInventory.CurrentWeapon.rocket:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = projectileSprites[3];
                break;

            case PlayerInventory.CurrentWeapon.tesla:
                this.gameObject.GetComponent<SpriteRenderer>().sprite = projectileSprites[4];
                break;
        }

        speed = player.GetComponent<PlayerInventory>().projectileSpeed;
        damage = player.GetComponent<PlayerInventory>().weaponDamage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
