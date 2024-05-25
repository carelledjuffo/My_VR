using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMole : MonoBehaviour
{

   Collider moleCollider;
    void Start()
    { 
        Debug.Log("In Start");
        moleCollider = GetComponent<Collider>();
        moleCollider.enabled = false;
    }

    public void SwitchCollider(int state)
    {
        if (moleCollider == null)
    {
        moleCollider = GetComponent<Collider>();
        moleCollider.enabled = false;
    } else
     {
      if (state == 0)
        {
            moleCollider.enabled = false;
        }
        else
        {
            moleCollider.enabled = true;
        }
    }
        
    }

   
   public void DestroyThisMole()
    {
        Destroy(gameObject);
    }
}
