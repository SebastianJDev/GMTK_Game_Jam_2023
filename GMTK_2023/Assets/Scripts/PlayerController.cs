using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Root
{
    public class PlayerController : MonoBehaviour
    {
        public float Speed;
        public float JumpForce;
        public bool CanJump;
        public LayerMask LayerGround;
        private float _Horizontal;
        private Rigidbody2D _rb;
        public Transform IsGround;
        public float Radius;
        bool facingRight = false;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            _Horizontal = Input.GetAxis("Horizontal");
            CanJump = Physics2D.OverlapCircle(IsGround.transform.position, Radius, LayerGround);
            if (Input.GetKeyDown(KeyCode.Space) && CanJump)
            {
                Jump();
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GameManager.instance.MainMenu();
            }

        }
        private void FixedUpdate()
        {
            if (_Horizontal > 0 && !facingRight)
            {
                Flip();
            }
            if (_Horizontal < 0 && facingRight)
            {
                Flip();
            }
            Move();
        }
        public void Move()
        {
            _rb.velocity = new Vector2(_Horizontal * Speed, _rb.velocity.y);
        }
        public void Jump()
        {
            AudioManager.instance.Play("Jump");
            _rb.velocity = new Vector2(_rb.velocity.x, JumpForce);
        }

        public void Flip()
        {
            Vector3 currentScale = gameObject.transform.localScale;
            currentScale.x *= -1;
            gameObject.transform.localScale = currentScale;
            facingRight = !facingRight;

        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            switch (collision.gameObject.tag)
            {
                case "PlataformaMovil":
                    transform.parent = collision.transform; break;
                case "Victoria":
                    collision.gameObject.GetComponent<Victoria>().VictoriaGame();
                    break;
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "PlataformaMovil")
            {
                transform.parent = null;
            }
        }
    }
}
