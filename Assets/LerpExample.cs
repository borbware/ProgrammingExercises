using System.Collections;
using UnityEngine;

public class LerpExample : MonoBehaviour
{

    float a = -5f;
    float b = 2f;
    float t = 0f;

    [SerializeField] Transform pointA, pointB;
    [SerializeField] Transform rotationA, rotationB;
    [SerializeField] Transform scaleA, scaleB;
    [SerializeField] Transform kaveri;

    [SerializeField] AnimationCurve curve; 

    Renderer _renderer;
    bool lerping = false;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        transform.position = pointA.position;
        kaveri.position = pointA.position;
    }


    void LerpExample1()
    {
        if (!lerping && Input.GetButtonDown("Jump"))
        {
            lerping = true;
            t = 0;
            a = transform.position.x;
            b = transform.position.x + 5;
        }

        if (lerping)
        {

            // transform.position = new Vector3(
            //     Mathf.Lerp(a, b, t),
            //     transform.position.y,
            //     transform.position.z);

            // transform.position = new Vector3(
            //     Mathf.SmoothStep(a, b, t),
            //     transform.position.y,
            //     transform.position.z);

            float curveInterpolate(float a, float b, float t)
            {
                return a + (b - a) * curve.Evaluate(t);       
            }

            transform.position = new Vector3(
                curveInterpolate(a, b, t),
                transform.position.y,
                transform.position.z);

            // _renderer.material.SetColor("_Color", 
            //     new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, t))
            // );
            
            t += Time.deltaTime / 1; // takes 2 seconds to reach end

            if (transform.position.x == b)
                lerping = false;
        }        
    }

    void LerpScaleFactor()
    {
        if (!lerping && Input.GetButtonDown("Jump"))
        {
            lerping = true;
            t = 0;
            a = 1.0f;
            b = 5.0f;
        }

        if (lerping)
        {
            transform.localScale = Vector3.one * Mathf.Lerp(a, b, t);

           t += Time.deltaTime / 2; // takes 2 seconds to reach end

            if (t >= 1.0f)
                lerping = false;
        }        
    }


    void LerpPosition()
    {
        if (!lerping && Input.GetButtonDown("Jump"))
        {
            lerping = true;
            t = 0;
        }

        if (lerping)
        {
            transform.position = Vector3.Lerp(
                pointA.position,
                pointB.position,
                t);
            
            t += Time.deltaTime / 2; // takes 2 seconds to reach end

            if (t >= 1.0f)
                lerping = false;
        }             
    }

    void LerpRotation()
    {
        if (!lerping && Input.GetButtonDown("Jump"))
        {
            lerping = true;
            t = 0;
        }

        if (lerping)
        {
            transform.rotation = Quaternion.Slerp(
                rotationA.rotation,
                rotationB.rotation,
                t);
            
            t += Time.deltaTime / 2; // takes 2 seconds to reach end

            if (t >= 1.0f)
                lerping = false;
        }
    }


    void LerpScale()
    {
        if (!lerping && Input.GetButtonDown("Jump"))
        {
            lerping = true;
            t = 0;
        }

        if (lerping)
        {
            transform.localScale = Vector3.Lerp(
                scaleA.localScale,
                scaleB.localScale,
                t);
            
            t += Time.deltaTime / 2; // takes 2 seconds to reach end

            if (t >= 1.0f)
                lerping = false;
        }
    }



void BetterLerp()
    {

        IEnumerator LerpCoroutine()
        {
            float t = 0f;
            while ( t < 1.0f )
            {
                transform.position = new Vector3(
                    Mathf.Lerp(a, b, t),
                    transform.position.y,
                    transform.position.z);
                
                t += Time.deltaTime / 2; // takes 2 seconds to reach end
                yield return null;
            }
            transform.position = new Vector3(
                b, transform.position.y, transform.position.z
            );
        }

        if (Input.GetButtonDown("Jump"))
        {
            a = transform.position.x;
            b = transform.position.x + 5;
            StartCoroutine(LerpCoroutine());
        }
    }

void BetterPositionLerp()
    {
        IEnumerator LerpTransform(
            Transform transformToLerp,
            Transform pointA,
            Transform pointB,
            float time
        )
        {
            float t = 0f;
            while ( t < 1.0f )
            {
                transformToLerp.position = Vector3.Lerp(
                    pointA.position,
                    pointB.position,
                    t);

                t += Time.deltaTime / time; // takes "time" seconds to reach end
                yield return null;
            }
            transformToLerp.position = pointB.position;
        }

        // lerp own position
        if (transform.position == pointA.position
         && Input.GetButtonDown("Jump"))
        {
            StartCoroutine(LerpTransform(transform, pointA, pointB, 2));
        }
        if (transform.position == pointB.position
         && Input.GetButtonDown("Jump"))
        {
            StartCoroutine(LerpTransform(transform, pointB, pointA, 1));
        }

        // lerp kaveri position
        if (kaveri.position == pointA.position
         && Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(LerpTransform(kaveri, pointA, pointB, 0.2f));
        }
        if (kaveri.position == pointB.position
         && Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(LerpTransform(kaveri, pointB, pointA, 0.5f));
        }
    }


    void Update()
    {
        LerpExample1();
        // LerpScaleFactor();

        // LerpVector3();
        // LerpQuaterion();
        // LerpScale();

        // BetterPositionLerp();

    }
}
