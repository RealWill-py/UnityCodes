using UnityEngine;

public class NPCControl : MonoBehaviour
{
    public Transform player;
    private Animator animator;
    private bool isFollowingPlayer = false;
    private Vector3 offset;

    void Start()
    {
        animator = GetComponent<Animator>();
        offset = transform.position - player.position;
    }

    void Update()
    {
        if (isFollowingPlayer)
        {
            // Atualiza a posição do NPC para a posição atual do jogador
            transform.position = player.position + offset;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            animator.speed = 0f; // Pausa a animação.
            isFollowingPlayer = true; // Inicia o seguimento do NPC
            offset = transform.position - player.position; // Calcula o deslocamento inicial
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            animator.speed = 1f; // Reseta a velocidade da animação.
            isFollowingPlayer = false; // Para de seguir o jogador
        }
    }
}
