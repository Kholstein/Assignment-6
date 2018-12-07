using UnityEngine;
public class crusherTrap : MonoBehaviour
{
    public Transform StopPoint;
    private Vector3 StartPoint;
    private Vector3 StopPosition;
    public float UpDownLoopTime = 5f;

    public Transform respawnPoint;


    void Start()
    {
        StartPoint = transform.position;
        StopPosition = StopPoint.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(StartPoint, StopPosition, Mathf.SmoothStep(0f, 1f, Mathf.PingPong(Time.time / UpDownLoopTime, 1f)));
    }

//    private void OnTriggerEnter(Collider player)
//    {
//        player.transform.position = respawnPoint.transform.position;
//    }
}