using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawner : MonoBehaviour
{
    public virtual void Despawn(){
        Destroy(gameObject);
    }
}
