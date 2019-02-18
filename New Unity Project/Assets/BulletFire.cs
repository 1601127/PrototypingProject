using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {
    public GameObject Bullet;
    public GameObject B_Origin;
    private GameObject SpawnedBullet;
    private BulletAttributes BulletAt;
    private MeshRenderer BulletMat;

    
    public Material[] Xmat;
    public Material[] Ymat;
    public Material[] Zmat;
    private Material ChosenMat;

    public string Axis;
    public int Strength;
    public string Mod;



    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        // Spawns the bullet as long as there aren't any other bullets in the level
        if (Input.GetAxis("FireBullet") > 0 && GameObject.FindGameObjectsWithTag("Bullet").Length < 1 && Strength != 0 )
        {
            SpawnedBullet = Instantiate(Bullet, B_Origin.transform);
            print(SpawnedBullet.name);
            SpawnedBullet.transform.SetParent(null);
            BulletMat= SpawnedBullet.GetComponent<MeshRenderer>();
            BulletMat.material = ChosenMat;
            BulletAt=SpawnedBullet.GetComponent<BulletAttributes>();
            BulletAt.Strength = Strength;
            BulletAt.Axis = Axis;
            BulletAt.Mod = Mod;

        }

        // Sets the bullet to X-modification
        if (Input.GetAxis("Num1") > 0 || Input.GetAxis("Num4") > 0 || Input.GetAxis("Num7") > 0)
        {
            Axis = "X";
        }

        // Sets the bullet to Y-modification
        if (Input.GetAxis("Num2") > 0 || Input.GetAxis("Num5") > 0 || Input.GetAxis("Num8") > 0){
            Axis = "Y";
        }

        // Sets the bullet to Z-modification
        if (Input.GetAxis("Num3") > 0 || Input.GetAxis("Num6") > 0 || Input.GetAxis("Num9") > 0)
        {
            Mod = "Z";
        }

        // Sets the bullet to X-modification
        if (Input.GetAxis("Num1") > 0 || Input.GetAxis("Num2") > 0 || Input.GetAxis("Num3") > 0)
        {
            Mod = "M";
        }

        // Sets the bullet to Y-modification
        if (Input.GetAxis("Num4") > 0 || Input.GetAxis("Num5") > 0 || Input.GetAxis("Num6") > 0)
        {
            Mod = "R";
        }

        // Sets the bullet to Z-modification
        if (Input.GetAxis("Num7") > 0 || Input.GetAxis("Num8") > 0 || Input.GetAxis("Num9") > 0)
        {
            Axis = "S";
        }


        if (Axis == "X")
        {
            if (Strength > 0)
            {
                ChosenMat = Xmat[0];
            }
            else
            {
                ChosenMat = Xmat[1];
            }
        }

        if (Axis == "Y")
        {
            if (Strength > 0)
            {
                ChosenMat = Ymat[0];
            }
            else
            {
                ChosenMat = Ymat[1];
            }
        }

        if (Axis == "Z")
        {
            if (Strength > 0)
            {
                ChosenMat = Zmat[0];
            }
            else
            {
                ChosenMat = Zmat[1];
            }
        }

    
        



        if (Input.GetAxis("Str") > 0)
        {
            Strength = Strength + 1;
        }
        else if((Input.GetAxis("Str") < 0))
        {
            Strength = Strength - 1;
        }
    }
}
