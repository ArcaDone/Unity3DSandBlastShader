using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExplosion : MonoBehaviour
{

    public Material explosionMat;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            MeshRenderer[] renderers = gameObject.GetComponent<Collider>().GetComponentsInChildren<MeshRenderer>();
            this.explosionMat.SetFloat("_StartTime", Time.timeSinceLevelLoad);

            for (int i = 0; i < renderers.Length; i++)
            {
                renderers[i].material = this.explosionMat;
            }
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }

}
