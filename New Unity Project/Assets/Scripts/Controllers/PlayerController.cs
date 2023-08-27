using Assets.Scripts.MySettings;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private KeybindSettings keybindSettings;

    private enum PlayerType { None, Warior, Wizard, Archer, Rogue }

    [SerializeField] private PlayerType playerType = PlayerType.None;
    
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float runSpeed = 10f;

    public bool canJump = true;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;
    [SerializeField] private float groundCheckDistance = 0.1f;
    [SerializeField] private LayerMask groundMask;

    [SerializeField] private int maxStamina = 100;
    [SerializeField] private int currentStamina = 100;
    [SerializeField] private float staminaRegenRate = 1f;

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth = 100;

    [SerializeField] private int maxMana = 100;
    [SerializeField] private int currentMana = 100;
    [SerializeField] private float manaRegenRate = 1f;
    [SerializeField] private int spellDamage = 10;
    [SerializeField] private float spellRange = 10f;

    [SerializeField] private float attackRange = 1f;
    [SerializeField] private float attackRate = 1f;
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private LayerMask attackMask;

    [SerializeField] private UnityEvent deathEvent;
}