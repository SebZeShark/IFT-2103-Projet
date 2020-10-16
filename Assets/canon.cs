using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myGravity;

public class canon : MonoBehaviour
{
    gravity grav;
    public GameObject obj;
    int idJoueur;
    int idForme;
    int angle;
    int force;
    bool canThrow;
    int winner;
    
    // Start is called before the first frame update
    void Start()
    {
        grav = obj.GetComponent<gravity>();
        idJoueur = 1;
        idForme = 0;
        angle = 0;
        force = 0;
        canThrow = false;

        winner = boucleDeJeu();
    }

    // Update is called once per frame
    void Update()
    {
        if (idForme == 0)
            idForme = selectForm();
        else
        {
            if (Input.GetButtonDown("Jump") && canThrow)
            {
                if (collision.num < 1)
                {
                    Instantiate(obj, new Vector3(0f, 0f, 0f), Quaternion.identity);

                    obj.GetComponent<gravity>().speed = new Vector3(0, 10, 10);
                }
            }

        }
    }

    int boucleDeJeu()
    {
        idForme = selectForm();
        angle = choisirAngle();
        force = choisirForce();
        canThrow = true;

        return idJoueur;
    }

    int selectForm()
    {
        return 1;
    }

    int choisirAngle()
    {
        return 45;
    }

    int choisirForce()
    {
        return 50;
    }

}
