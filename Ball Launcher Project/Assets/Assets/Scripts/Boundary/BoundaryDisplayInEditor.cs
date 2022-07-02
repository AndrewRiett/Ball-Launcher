using UnityEngine;

public class BoundaryDisplayInEditor : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(GetComponent<Collider>().bounds.center, 
            GetComponent<Collider>().bounds.size);
    }
}
