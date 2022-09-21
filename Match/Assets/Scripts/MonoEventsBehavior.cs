using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent,PingEvent;

    public float holdTime;
    // Start is called before the first frame update
    private void Awake()
    {
        awakeEvent.Invoke();
        
        startEvent.Invoke();
        if (PingEvent == null) PingEvent = new UnityEvent ();

        PingEvent.AddListener(DisablePing);
        
    }
    void OnDisable()
    {
        disableEvent.Invoke();
        PingEvent.Invoke();
    }
    void DisablePing()
    {

    }

   
}