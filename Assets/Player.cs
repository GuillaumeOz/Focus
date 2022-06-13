using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static bool elecDone;
    public float ballspeed = 3.0f;
    public Camera cam1;
    public Camera cam2;
    private bool goUp = true;
    private bool ll;
    private bool l;
    private bool r;
    private bool rr;
    private bool wide;
    private bool narrow;
    private bool wn;
    public GameObject tag1;
    public GameObject tag2;
    public GameObject tag3;
    public GameObject tag4;
    public GameObject tag5;
    public GameObject tag6;
    public GameObject tag7;
    public GameObject tag8;
    public GameObject tag9;
    public GameObject tag10;
    public GameObject tag11;
    public GameObject tag12;
    public GameObject tag13;
    public GameObject tag14;
    public GameObject tag15;
    public GameObject tag16;
    public GameObject tag17;
    public GameObject tag18;
    public AudioSource source;
    public AudioSource sourceBack;
    public AudioClip turnNoise;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {      
        startPos = transform.position;
    }

    public void TurnLeft() {
        l = true;
    }

    public void TurnRight() {
        r = true;
    }

    public void TurnLeftLeft() {
        ll = true;
    }

    public void TurnRightRight() {
        rr = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (cam2.enabled == true) {
            if (goUp) {
                gameObject.transform.Translate(0, -ballspeed * Time.deltaTime, 0);
            }
            else {
                if (l) {
                    source.PlayOneShot(turnNoise);
                    transform.Translate(ballspeed / 2 * Time.deltaTime, -ballspeed * Time.deltaTime, 0);
                }
                else if (ll) {
                    source.PlayOneShot(turnNoise);
                    transform.Translate(ballspeed * Time.deltaTime, -ballspeed / 2 * Time.deltaTime, 0);
                }
                else if (r) {
                    source.PlayOneShot(turnNoise);
                    transform.Translate(-ballspeed / 2 * Time.deltaTime, -ballspeed * Time.deltaTime, 0);
                }
                else if (rr) {
                    source.PlayOneShot(turnNoise);
                    transform.Translate(-ballspeed * Time.deltaTime, -ballspeed / 2 * Time.deltaTime, 0);
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Corner1") {
            tag1.SetActive(true);
            tag2.SetActive(true);
            tag3.SetActive(true);
            tag4.SetActive(true);
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            wn = true;
        }
        else if (other.gameObject.tag == "Corner2") {
            tag1.SetActive(false);
            tag2.SetActive(false);
            tag3.SetActive(false);
            tag4.SetActive(false);
            tag5.SetActive(true);
            tag6.SetActive(true);
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            narrow = true;
        }
        else if (other.gameObject.tag == "Corner3") {
            tag1.SetActive(false);
            tag2.SetActive(false);
            tag3.SetActive(false);
            tag4.SetActive(false);
            tag7.SetActive(true);
            tag8.SetActive(true);
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            wide = true;
        }
        else if (other.gameObject.tag == "Corner4") {
            tag5.SetActive(false);
            tag6.SetActive(false);
            tag7.SetActive(false);
            tag8.SetActive(false);
            tag9.SetActive(true);
            tag10.SetActive(true);
            tag11.SetActive(true);
            tag12.SetActive(true);
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            wn = true;
        }
        else if (other.gameObject.tag == "Corner5") {
            tag9.SetActive(false);
            tag10.SetActive(false);
            tag11.SetActive(false);
            tag12.SetActive(false);
            tag13.SetActive(true);
            tag14.SetActive(true);
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            narrow = true;
        }
        else if (other.gameObject.tag == "Corner6") {
            tag9.SetActive(false);
            tag10.SetActive(false);
            tag11.SetActive(false);
            tag12.SetActive(false);
            tag15.SetActive(true);
            tag16.SetActive(true);
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            wide = true;
        }
        else if (other.gameObject.tag == "Corner7") {
            tag9.SetActive(false);
            tag10.SetActive(false);
            tag11.SetActive(false);
            tag12.SetActive(false);
            tag17.SetActive(true);
            tag18.SetActive(true);
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            narrow = true;
        }
        else if (other.gameObject.tag == "Success") {
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            narrow = false;
            elecDone = true;
            cam2.enabled = false;
            cam1.enabled = true;
            MissionCounter.MissionCount++;
            sourceBack.Stop();
        }
        else if (other.gameObject.tag == "Wall") {
            goUp = true;
            ll = false;
            l = false;
            r = false;
            rr = false;
            wide = false;
            narrow = false;
            wn = false;
        }
        else if (other.gameObject.tag == "DeadEnd") {
            transform.position = startPos;
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = true;
            tag1.SetActive(false);
            tag2.SetActive(false);
            tag3.SetActive(false);
            tag4.SetActive(false);
            tag5.SetActive(false);
            tag6.SetActive(false);
            tag7.SetActive(false);
            tag8.SetActive(false);
            tag9.SetActive(false);
            tag10.SetActive(false);
            tag11.SetActive(false);
            tag12.SetActive(false);
            tag13.SetActive(false);
            tag14.SetActive(false);
            tag15.SetActive(false);
            tag16.SetActive(false);              
            tag17.SetActive(false);
            tag18.SetActive(false);
        }
    }
}
