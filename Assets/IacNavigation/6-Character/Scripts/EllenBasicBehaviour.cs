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
		}

		#endregion
	}
}