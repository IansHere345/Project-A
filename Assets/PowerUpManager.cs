using System.Collections;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public float boostedJump = 2f;
    public float boostedJumpDuration = 5f;

    private StarterAssets.FirstPersonController firstPersonController;
    private StarterAssets.ThirdPersonController thirdPersonController;
    private float normalJumpHeight;
    private Coroutine boostRoutine;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GreenOrb"))
        {
            firstPersonController = GetComponent<StarterAssets.FirstPersonController>();
            thirdPersonController = GetComponent<StarterAssets.ThirdPersonController>();

            if (firstPersonController == null && thirdPersonController == null)
            {
                return;
            }

            if (boostRoutine == null)
            {
                normalJumpHeight = firstPersonController != null
                    ? firstPersonController.JumpHeight
                    : thirdPersonController.JumpHeight;
            }

            SetJumpHeight(normalJumpHeight * boostedJump);

            if (boostRoutine != null)
            {
                StopCoroutine(boostRoutine);
            }

            boostRoutine = StartCoroutine(ResetJumpHeight());
        }
    }

    private IEnumerator ResetJumpHeight()
    {
        yield return new WaitForSeconds(boostedJumpDuration);
        SetJumpHeight(normalJumpHeight);
        boostRoutine = null;
    }

    private void SetJumpHeight(float jumpHeight)
    {
        if (firstPersonController != null)
        {
            firstPersonController.JumpHeight = jumpHeight;
        }

        if (thirdPersonController != null)
        {
            thirdPersonController.JumpHeight = jumpHeight;
        }
    }
}
