using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PickUp : MonoBehaviour
    {
    [SerializeField] private bool isHeal;
    private void OnTriggerEnter(Collider other)
    {
        Player playerprops = other.GetComponent<Player>();

        if (playerprops != null)
        { if (isHeal)
            {
                playerprops.Heal();
            }
            else
            {
                playerprops.Harm();
            }
             
          Destroy(gameObject);
        }
    }
}

