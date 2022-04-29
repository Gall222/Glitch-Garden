using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    [SerializeField] float currentSpeed = 0f;

    GameObject currentTarget;
    Animator animator;

    private void Awake()
    {
        FindObjectOfType<LevelController>().addEnemy();
    }

    private void OnDestroy()
    {
        var levelController = FindObjectOfType<LevelController>();
        if (levelController != null)
        {
            levelController.killEnemy();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);

    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }



    public void Attack(GameObject target)
    {
        animator.SetBool("IsAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
            {
                health.GetDamage(damage);
            }
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }

    }
}
