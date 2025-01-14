using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonRotation : MonoBehaviour
{
    public Vector3 _maxRotation;
    public Vector3 _minRotation;
    private float offset = -51.6f;
    public GameObject ShootPoint;
    public GameObject Bullet;
    public float ProjectileSpeed = 0;
    public float MaxSpeed;
    public float MinSpeed;
    public GameObject PotencyBar;
    private float initialScaleX;
    private GameObject projectile;

    private void Awake()
    {
        initialScaleX = PotencyBar.transform.localScale.x;
    }

    void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var direction = mousePos - ShootPoint.transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * 180f / Mathf.PI + offset;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        if (Input.GetMouseButton(0))
        {
            if (ProjectileSpeed < MaxSpeed)
            {
                ProjectileSpeed += 4 * Time.deltaTime; 
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            projectile = Instantiate(Bullet, ShootPoint.transform.position, Quaternion.Euler(0, 0, angle));
            
            projectile.GetComponent<Rigidbody2D>().velocity = direction * ProjectileSpeed;

            ProjectileSpeed = MinSpeed; 
        }

        CalculateBarScale();
    }

    public void CalculateBarScale()
    {
        PotencyBar.transform.localScale = new Vector3(Mathf.Lerp(0, initialScaleX, ProjectileSpeed / MaxSpeed),
            PotencyBar.transform.localScale.y,
            PotencyBar.transform.localScale.z);
    }
}
