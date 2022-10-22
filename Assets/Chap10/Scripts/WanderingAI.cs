using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 살아 있으면 이동할 것.
/// 
/// 앞으로 이동할 것.
/// 
/// 넓은 범위를 체크할 예정
/// SphereCast를 이용해서 벽 체크할 것.
/// 
/// 만약 적이라면 공격 진행
/// TransformPoint -> 위치 벡터를 월드 위치로 변환
/// Vec3.forward는 로컬 좌표이기 때문.
/// 
/// 벽과 일정한 거리에 오게되면 랜덤하게 방향 전환
/// </summary>


public class WanderingAI : MonoBehaviour {
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    private bool _alive;

    // Fireball Projectile
    [SerializeField] private GameObject fireballPrefab;
    private GameObject _fireball;

    private void Start()
    {
        _alive = true;
    }

    void Update () {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.SphereCast(ray, 0.75f, out hit)) {

                GameObject hitObject = hit.transform.gameObject;

                if (hitObject.GetComponent<PlayerCharacter>()) {
                    if (_fireball == null) {
                        _fireball = Instantiate(fireballPrefab) as GameObject;
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                } else if (hit.distance < obstacleRange) {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
	}

    public void SetAlive(bool alive)
    {
        _alive = alive;
    }
}
