using System;
using UnityEngine;

//namespace UnityStandardAssets.Characters.ThirdPerson
namespace Swordsmanship
{
    //[RequireComponent(typeof (NavMeshAgent))]
    [RequireComponent(typeof (SwordsmanCharacter))]
    public class AISwordsmanControl : MonoBehaviour
    {
        //public NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public SwordsmanCharacter character { get; private set; } // the character we are controlling
        public Transform target;                                    // target to aim for


        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            //agent = GetComponentInChildren<NavMeshAgent>();
            character = GetComponent<SwordsmanCharacter>();

	        //agent.updateRotation = false;
	        //agent.updatePosition = true;
        }


        private void Update()
        {
            //if (target != null)
            //    agent.SetDestination(target.position);

            //if (agent.remainingDistance > agent.stoppingDistance)
            //    character.Move(agent.desiredVelocity, false, false);
            //else
            //    character.Move(Vector3.zero, false, false);


            //tmp for test

            //float r = UnityEngine.Random.value;

            //if(r < 0.15f)
            //{
            //    character.BlockLeft();
            //}
            //else if (r < 0.3f)
            //{
            //    character.BlockFront();
            //}
            //else if (r < 0.45f)
            //{
            //    character.BlockRight();
            //}
            //else
            //{
            //    character.AttackStabIdle();
            //    character.AttackStabAttack();
            //}

            character.BlockRight();

        }


        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
