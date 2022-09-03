using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool spacePressed = false;
    public bool shiftPressed = false;
    private PlayerMovement_2D player;
    public int weaponDamage;
    public float weaponFireDelay;
    public int projectileSpeed;
    public bool canBounce = false;
    public bool canPierce = false;
    public bool canFire = true;
    public float fireDelayTime;
    public enum CurrentWeapon 
    { 
        pistol,
        laser,
        railgun,
        rocket,
        tesla
    }
    public CurrentWeapon currentWeapon;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement_2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && spacePressed == false)
        {
            spacePressed = true;
            Debug.Log("Space Pressed");
        }
        else
        {
            spacePressed = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && shiftPressed == false)
        {
            shiftPressed = true;
            Debug.Log("Shift Pressed");
            currentWeapon++;
            if (currentWeapon > CurrentWeapon.railgun)
            {
                currentWeapon = CurrentWeapon.pistol;
            }
            Debug.Log(currentWeapon);
            
        }
        else
        {
            shiftPressed = false;
        }

        if (spacePressed && canFire)
        {
            StartCoroutine(StartFireDelay());
        }

        switch (currentWeapon) {

            case CurrentWeapon.pistol:
                weaponDamage = 1;
                weaponFireDelay = 0.33f;
                projectileSpeed = 10;
                canBounce = false;
                canPierce = false;
                break;

            case CurrentWeapon.laser:
                weaponDamage = 2;
                weaponFireDelay = 0.50f;
                projectileSpeed = 10;
                canBounce = true;
                canPierce = false;
                break;

            case CurrentWeapon.railgun:
                weaponDamage = 10;
                weaponFireDelay = 1.33f;
                projectileSpeed = 20;
                canBounce = false;
                canPierce = true;
                break;
        }

    }

    public IEnumerator StartFireDelay()
    {
        canFire = false;
        fireDelayTime = weaponFireDelay;
        while (fireDelayTime > 0)
        {
            Debug.Log("Fire Delay: " + fireDelayTime);
            yield return new WaitForSeconds(0.01f);
            fireDelayTime -= 0.01f;
        }
        canFire = true;
    }

    public void FireWeapon()
    {

    }
}

