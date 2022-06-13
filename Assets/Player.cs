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
    private bool wide = false;
    private bool narrow = false;
    private bool wn = false;
    public AudioSource source;
    public AudioSource sourceBack;
    public AudioClip turnNoise;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
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

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "WN") {
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            wn = true;
        }
        else if (other.gameObject.tag == "Wide") {
            ll = false;
            l = false;
            r = false;
            rr = false;
            goUp = false;
            wide = true;
        }
        else if (other.gameObject.tag == "Narrow") {
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
        }
    }
}
