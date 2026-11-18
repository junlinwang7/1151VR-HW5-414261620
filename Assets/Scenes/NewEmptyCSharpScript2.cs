using UnityEngine;

public class CaptureEffect : MonoBehaviour
{
     public GameObject effect;

     private void OnTriggerEnter(Collider other)
     {
          if (other.CompareTag("Pokemon"))
          {
               Instantiate(
                   effect,
                   other.transform.position,
                   Quaternion.identity
               );

               Destroy(other.gameObject);
          }
     }
}