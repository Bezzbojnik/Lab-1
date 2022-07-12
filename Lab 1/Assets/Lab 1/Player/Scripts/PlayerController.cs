using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject TestCube;
    public GameObject RotateObject;
    public GameObject Bullet;
    public Transform BulletPosition;

    private Camera _cam;

    void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        var groundPlane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);

        if (groundPlane.Raycast(ray, out float position))
        {
            Vector3 worldPosition = ray.GetPoint(position);
            TestCube.transform.position = new Vector3(worldPosition.x, worldPosition.y, worldPosition.z);
            RotateObject.transform.LookAt(TestCube.transform);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var bullet = Instantiate(Bullet, BulletPosition);

            bullet.transform.Rotate(Vector3.up, RotateObject.transform.rotation.eulerAngles.y);

            //Vector3 rotateShoot = TestCube.transform.position - RotateObject.transform.position;
            //bullet.GetComponent<Rigidbody>().AddForce(rotateShoot.normalized * 50, ForceMode.Impulse);
        }
    }
}
