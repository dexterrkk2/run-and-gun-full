using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class ClientState: MonoBehaviour
    {
        private PlayerController _playerController;
        private void Start()
        {
            _playerController = (PlayerController)FindObjectOfType(typeof(PlayerController));
        }
        void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == "Ground")
            {
                _playerController.grounded = true;
            }
            else
            {
                _playerController.Death();
            }
        }
        private void Update()
        {
            if(Input.GetKeyDown("a"))
            {
                _playerController.Turn(Direction.Left);
            }
            else if (Input.GetKeyDown("d"))
            {
                _playerController.Turn(Direction.Right);
            }
            else if (Input.GetButtonUp("Vertical"))
            {
                _playerController.Invoke("Stop", _playerController.standingTimer);
            }
            else if (Input.GetKeyDown("space"))
            {
                if (_playerController.isDiving)
                {
                    _playerController.SuperJump();
                }
                _playerController.Jump();
               
            }
            else if (Input.GetKeyDown("s"))
            {
                if (!_playerController.grounded)
                {
                    _playerController.DiveBomb();
                }
                
                else 
                {
                    _playerController.Duck();
                }
            }
            else if (_playerController.lastState >= _playerController.standingTimer)
            {
                _playerController.Standing();
            }
            if (Input.GetKey("w"))
            {
                _playerController.Run();
            }
           
        }
    }
}