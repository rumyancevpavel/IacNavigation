using System;
using UnityEngine;
using UnityEngine.AI;

namespace IacNavigation.Character.Scripts
{
	public class EllenBasicBehaviour : MonoBehaviour
	{
		#region Consts
		
		private const string RUNNING_PARAM_NAME = "Running";
		
		#endregion
		
		#region Editor

		[SerializeField] private NavMeshAgent _agent;

		[SerializeField] private Animator _animator;

		#endregion

		#region Methods

		public void GoTo(Vector3 destination)
		{
			_agent.SetDestination(destination);
		}

		private void Update()
		{
			_animator.SetBool(RUNNING_PARAM_NAME, IsMoving());
		}

		private bool IsMoving()
		{
			return _agent.velocity.magnitude > 0.1f;
		}

		private void OnAnimatorMove()
		{
			if (_animator.GetBool(RUNNING_PARAM_NAME))
			{
				_agent.speed = (_animator.deltaPosition / Time.deltaTime).magnitude;
			}
		}

		#endregion
	}
}