using UnityEngine;

public class PokeballThrow : MonoBehaviour
{
     public Transform target;
     public float speed = 8f;

     void Update()
     {
          if (target == null) return;

          transform.position = Vector3.MoveTowards(
              transform.position,
              target.position,
              speed * Time.deltaTime
          );
     }
}