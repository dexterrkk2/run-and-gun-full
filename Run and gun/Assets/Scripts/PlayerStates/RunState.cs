using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class RunState: MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController) 
        {
            _playerController = playerController;
            _playerController.CurrentSpeed = _playerController.maxSpeed;
        }
        void Update()
        {
            if (_playerController)
            {
                if (_playerController.CurrentSpeed > 0)
                {
                    _playerController.transform.Translate(Vector3.forward * _playerController.CurrentSpeed * Time.deltaTime); 
                }
            }
        }
    }
}
