using UnityEngine;

public class Hider : MonoBehaviour
{
    public Vector3 hidePos;

    public void Hide()
    {
        transform.position = hidePos;
    }
}
