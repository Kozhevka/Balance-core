using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameActive : MonoBehaviour
{
    public static GameActive instance;

    [SerializeField] private Transform floorBlock;
    [SerializeField] private GameObject sphereObj;
    private Rigidbody sphereRb;

    private Vector3 startSpherePos;


    private float minForce = 1f;
    private float maxForce = 2f;

    [SerializeField] private TextMeshProUGUI timerText;
    private float timerCount;
    private bool gameIsActive;

    


    private void Awake()
    {
        if (GameActive.instance == null)
            instance = this;
        else
        {
            Debug.LogError("GameActive.instance already exist");
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        sphereRb = sphereObj.GetComponent<Rigidbody>();
        startSpherePos = sphereObj.transform.position;
    }

    
    

    public void RotateFloor(Vector2 addRot)
    {
        if (gameIsActive)
        {
            floorBlock.rotation = Quaternion.Euler(addRot.y, 0f, -addRot.x);
        }
    }

    

    public void DisableSphere()
    {
        sphereObj.transform.position = startSpherePos;
        sphereRb.constraints = RigidbodyConstraints.FreezePosition;

        sphereObj.SetActive(false);
    }

    public void ActivateSphere()
    {
        gameIsActive = true;

        sphereObj.SetActive(true);

        sphereRb.constraints = RigidbodyConstraints.None;
        sphereRb.AddForce(Random.insideUnitSphere * Random.Range(minForce, maxForce), ForceMode.Impulse);

        floorBlock.rotation = Quaternion.Euler(0f, 0f, 0f);
        StartCoroutine(TimerEnumerator());
    }

    private void OnTriggerEnter(Collider other)
    {
          if (other.CompareTag("Sphere"))
        {
            DisableSphere();
            gameIsActive = false;
            GameManager.instance.GameOver();
        }
    }

    IEnumerator TimerEnumerator()
    {
        timerCount = 0;
        System.TimeSpan ts = System.TimeSpan.FromSeconds(timerCount);

        while (gameIsActive)
        {
            yield return new WaitForEndOfFrame();

            timerCount += Time.deltaTime;


            timerText.text = TimerFormat(timerCount);
        }
    }

    private string TimerFormat(float time)
    {

        System.TimeSpan ts = System.TimeSpan.FromSeconds(time);
        string spanString = System.String.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds % 100);

        return spanString;
        
    }
}
