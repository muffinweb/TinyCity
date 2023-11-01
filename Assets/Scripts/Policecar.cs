using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Policecar : MonoBehaviour
{
    Transform _transform;

    Rigidbody _rigidbody;

    [SerializeField] float _speedVelocity;

    [SerializeField] bool _policeCarMoving = false;

    [SerializeField] GameObject _tutorialUi;

    [SerializeField] Animator _animator;



    void Awake()
    {
        _transform = GetComponent<Transform>();

        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_policeCarMoving)
            _transform.position = new Vector3(_transform.position.x, _transform.position.y, (_transform.position.z + (_speedVelocity * -1) * Time.deltaTime) );

        onPressSpace();
    }

    void onPressSpace() {
        if (Input.GetKeyDown(KeyCode.Space)) {

            _policeCarMoving = true;


            _tutorialUi.SetActive(false);

            GameObject.Find("police").GetComponent<AudioSource>().Play();

            _animator.SetBool("isMoving", true);
        }
    }
}
