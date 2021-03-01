using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent nm;
    public Transform target;
    public Player player;
    public float distanceThreshold = 10f;
    public float attackDistance = 2f;
    public enum AIState { idle, chasing};
    public AIState aiState = AIState.idle;
    [SerializeField] float damage = 0.1f;
    float lastAttackTime = 0;
    float attackCoolDown = 2;
    public Animator anim;
    public bool isAttacking = true;

    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<UnityEngine.AI.NavMeshAgent>();
        StartCoroutine(Move());
        target = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
    }

    // Update is called once per frame
    IEnumerator Move()
    {

        
        
        while (true)
        {
            switch (aiState)
            {
                case AIState.idle:
                    float dist = Vector3.Distance(target.position, transform.position);
                    if (dist < distanceThreshold)
                    {
                        isAttacking = false;
                        aiState = AIState.chasing;
                    }
                    if (dist < attackDistance)
                    {
                        isAttacking = true;
                        Attack();
                    }
                    nm.SetDestination(transform.position);
                    break;
                case AIState.chasing:
                    dist = Vector3.Distance(target.position, transform.position);
                    if(dist > distanceThreshold)
                    {
                        isAttacking = false;
                        aiState = AIState.idle;
                    }
                    if (dist < attackDistance)
                    {
                        isAttacking = true;
                        Attack();
                    }
                    nm.SetDestination(target.position);
                    break;
                default:
                    break;
            }
            yield return new WaitForSeconds(2);
        }
    }

    void Attack()
    {
        anim.SetBool("isAttacking", isAttacking);
        player.TakeDamage(damage);
        isAttacking = false;
    }
}
