using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public GameObject player;
    public PlayerInventory inventory;
    public PlayerMovement_2D playerMovement;
    public Animator playerAnimator;
    public AnimatorClipInfo[] currentClipInfo;
    public SpriteRenderer handSprite;
    public Sprite[] handSprites;
    public enum HandDirection {
        Forward,
        Back,
        Left,
        Right
    }
    public HandDirection handDirection;

        

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        handSprite = GameObject.Find("Hand").GetComponent<SpriteRenderer>();
        inventory = GameObject.Find("Player").GetComponent<PlayerInventory>();
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement_2D>();
        playerAnimator = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentClipInfo = playerAnimator.GetCurrentAnimatorClipInfo(0);
        Debug.Log(currentClipInfo[0].clip.name);
        switch (currentClipInfo[0].clip.name) {
            case "Anim_PlayerIdleBack" :
                Debug.Log("Idle Back");
                handDirection = HandDirection.Back;
                this.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + player.GetComponent<SpriteRenderer>().bounds.size.y/2);
                break;

            case "Anim_PlayerWalkBack":
                Debug.Log("Walk Back");
                handDirection = HandDirection.Back;
                this.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + player.GetComponent<SpriteRenderer>().bounds.size.y / 2);
                break;

            case "Anim_PlayerIdleForward":
                Debug.Log("Idle Forward");
                handDirection = HandDirection.Forward;
                this.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - player.GetComponent<SpriteRenderer>().bounds.size.y / 4);
                break;

            case "Anim_PlayerWalkForward":
                Debug.Log("Walk Forward");
                handDirection = HandDirection.Forward;
                this.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - player.GetComponent<SpriteRenderer>().bounds.size.y / 4);
                break;

            case "Anim_PlayerIdleLeft":
                Debug.Log("Idle Left");
                handDirection = HandDirection.Left;
                this.transform.position = new Vector2(player.transform.position.x - player.GetComponent<SpriteRenderer>().bounds.size.x/2, player.transform.position.y);
                break;

            case "Anim_PlayerWalkLeft":
                Debug.Log("Walk Left");
                handDirection = HandDirection.Left;
                this.transform.position = new Vector2(player.transform.position.x - player.GetComponent<SpriteRenderer>().bounds.size.x / 2, player.transform.position.y);
                break;

            case "Anim_PlayerIdleRight":
                Debug.Log("Idle Right");
                handDirection = HandDirection.Right;
                this.transform.position = new Vector2(player.transform.position.x + player.GetComponent<SpriteRenderer>().bounds.size.x / 2, player.transform.position.y);
                break;

            case "Anim_PlayerWalkRight":
                Debug.Log("Walk Right");
                handDirection = HandDirection.Right;
                this.transform.position = new Vector2(player.transform.position.x + player.GetComponent<SpriteRenderer>().bounds.size.x / 2, player.transform.position.y);
                break;
        }

        switch (inventory.currentWeapon) {
            
            case PlayerInventory.CurrentWeapon.pistol:
                if (handDirection == HandDirection.Back)
                {
                    handSprite.sprite = handSprites[0];
                }
                else if (handDirection == HandDirection.Forward)
                {
                    handSprite.sprite = handSprites[1];
                }
                else if (handDirection == HandDirection.Left)
                {
                    handSprite.sprite = handSprites[2];
                }
                else if (handDirection == HandDirection.Right)
                {
                    handSprite.sprite = handSprites[3];
                }
                break;

            case PlayerInventory.CurrentWeapon.laser:
                if (handDirection == HandDirection.Back)
                {
                    handSprite.sprite = handSprites[4];
                }
                else if (handDirection == HandDirection.Forward)
                {
                    handSprite.sprite = handSprites[5];
                }
                else if (handDirection == HandDirection.Left)
                {
                    handSprite.sprite = handSprites[6];
                }
                else if (handDirection == HandDirection.Right)
                {
                    handSprite.sprite = handSprites[7];
                }
                break;

            case PlayerInventory.CurrentWeapon.railgun:
                if (handDirection == HandDirection.Back)
                {
                    handSprite.sprite = handSprites[8];
                }
                else if (handDirection == HandDirection.Forward)
                {
                    handSprite.sprite = handSprites[9];
                }
                else if (handDirection == HandDirection.Left)
                {
                    handSprite.sprite = handSprites[10];
                }
                else if (handDirection == HandDirection.Right)
                {
                    handSprite.sprite = handSprites[11];
                }
                break;

            case PlayerInventory.CurrentWeapon.rocket:
                if (handDirection == HandDirection.Back)
                {
                    handSprite.sprite = handSprites[12];
                }
                else if (handDirection == HandDirection.Forward)
                {
                    handSprite.sprite = handSprites[13];
                }
                else if (handDirection == HandDirection.Left)
                {
                    handSprite.sprite = handSprites[14];
                }
                else if (handDirection == HandDirection.Right)
                {
                    handSprite.sprite = handSprites[15];
                }
                break;
            
            case PlayerInventory.CurrentWeapon.tesla:
                if (handDirection == HandDirection.Back)
                {
                    handSprite.sprite = handSprites[16];
                }
                else if (handDirection == HandDirection.Forward)
                {
                    handSprite.sprite = handSprites[17];
                }
                else if (handDirection == HandDirection.Left)
                {
                    handSprite.sprite = handSprites[18];
                }
                else if (handDirection == HandDirection.Right)
                {
                    handSprite.sprite = handSprites[19];
                }
                break;

        }


    }
}
