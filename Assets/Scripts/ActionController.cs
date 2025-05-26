using UnityEngine;
using UnityEngine.InputSystem;

public class ActionController : MonoBehaviour
{
   public InputActionReference Action;
   public Animator animator;

   private void OnEnable()
   {
       if (Action != null)
       {
           Action.action.Enable();
           Action.action.performed += OnActionPerformed;
       }
   }

   private void OnDisable()
   {
       if (Action != null)
       {
           Action.action.performed -= OnActionPerformed;
           Action.action.Disable();
       }
   }

   private void OnActionPerformed(InputAction.CallbackContext context)
   {
       if (animator != null)
       {
           animator.SetTrigger("ActionTrigger");
       }
   }
}
