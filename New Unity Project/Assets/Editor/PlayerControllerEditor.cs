using UnityEditor;

[CustomEditor(typeof(PlayerController))]
public class PlayerControllerEditor : Editor
{
    # region Serialized Properties
    SerializedProperty keybindSettings;

    SerializedProperty playerType;

    SerializedProperty walkSpeed;
    SerializedProperty runSpeed;

    SerializedProperty canJump;
    SerializedProperty jumpForce;
    SerializedProperty gravity;
    SerializedProperty groundCheckDistance;
    SerializedProperty groundMask;

    SerializedProperty maxHealth;
    SerializedProperty currentHealth;

    SerializedProperty maxStamina;
    SerializedProperty currentStamina;
    SerializedProperty staminaRegenRate;

    SerializedProperty attackRange;
    SerializedProperty attackRate;
    SerializedProperty attackDamage;
    SerializedProperty attackMask;

    SerializedProperty deathEvent;

    bool playerSpeedGroup, playerJumpGroup = false;
    # endregion

    private void OnEnable()
    {

        keybindSettings = serializedObject.FindProperty("keybindSettings");

        playerType = serializedObject.FindProperty("playerType");

        walkSpeed = serializedObject.FindProperty("walkSpeed");
        runSpeed = serializedObject.FindProperty("runSpeed");

        canJump = serializedObject.FindProperty("canJump");
        jumpForce = serializedObject.FindProperty("jumpForce");
        gravity = serializedObject.FindProperty("gravity");
        groundCheckDistance = serializedObject.FindProperty("groundCheckDistance");
        groundMask = serializedObject.FindProperty("groundMask");

        maxHealth = serializedObject.FindProperty("maxHealth");
        currentHealth = serializedObject.FindProperty("currentHealth");

        maxStamina = serializedObject.FindProperty("maxStamina");
        currentStamina = serializedObject.FindProperty("currentStamina");
        staminaRegenRate = serializedObject.FindProperty("staminaRegenRate");
        
        attackRange = serializedObject.FindProperty("attackRange");
        attackRate = serializedObject.FindProperty("attackRate");
        attackDamage = serializedObject.FindProperty("attackDamage");
        attackMask = serializedObject.FindProperty("attackMask");
        
        deathEvent = serializedObject.FindProperty("deathEvent");
    }


    public override void OnInspectorGUI()
    {
        PlayerController _playerController = (PlayerController)target;

        serializedObject.Update();

        EditorGUILayout.PropertyField(keybindSettings);

        EditorGUILayout.PropertyField(playerType);

        playerSpeedGroup = EditorGUILayout.BeginFoldoutHeaderGroup(playerSpeedGroup, "Player Speed");

        if (playerSpeedGroup)
        {
            EditorGUILayout.PropertyField(walkSpeed);
            EditorGUILayout.PropertyField(runSpeed);
        }
        EditorGUILayout.EndFoldoutHeaderGroup();

        playerJumpGroup = EditorGUILayout.BeginFoldoutHeaderGroup(playerJumpGroup, "Player Jump");
        if (playerJumpGroup)
        {
            EditorGUILayout.PropertyField(canJump);
            if (_playerController.canJump)
            {
                EditorGUILayout.PropertyField(jumpForce);
                EditorGUILayout.PropertyField(gravity);
                EditorGUILayout.PropertyField(groundCheckDistance);
                EditorGUILayout.PropertyField(groundMask);
            }
        }
        EditorGUILayout.EndFoldoutHeaderGroup();

        serializedObject.ApplyModifiedProperties();
    }
}