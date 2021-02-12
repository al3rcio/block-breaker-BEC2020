using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // config params
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject blockFx;
    [SerializeField] int maxHits;
    [SerializeField] Sprite[] spriteHits; 
    
    // cached reference
    Level level;
    GameStatus gameStatus;
    GameObject fx;

    // state variables
    int timesHit = 0;

    private void Start()
    {
        CountBreakableBlocks();
        gameStatus = FindObjectOfType<GameStatus>();
    }

    private void CountBreakableBlocks()
    {
        level = FindObjectOfType<Level>();
        if (tag == "Breakable")
            level.CountBlocks();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            HandleHit(); 
        }
    }

    private void HandleHit()
    {
        timesHit++;
        SoundFxScore();
        if (timesHit >= maxHits)
        {
            DestroyBlock();
        }
        else
        {
            NextSprite();
        }
    }

    private void SoundFxScore()
    {
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position, 0.4f);
        TriggerFx();
        gameStatus.AddToScore();
    }

    private void NextSprite()
    {
        int spriteIndex = timesHit - 1;
        GetComponent<SpriteRenderer>().sprite = spriteHits[spriteIndex];
    }

    private void DestroyBlock()
    {
        
        Destroy(gameObject);
        level.BreakBlocks();
    }

    private void TriggerFx()
    {
        fx = Instantiate(blockFx, transform.position, transform.rotation);
        Destroy(fx.gameObject, 1f);
    }
}
