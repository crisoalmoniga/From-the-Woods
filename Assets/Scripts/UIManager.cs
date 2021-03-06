﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Player player;
    public GameObject weaponHolder;
    [Space]
    public GameObject winMenu;
    public GameObject deathMenu;
    [Space]
    public TextMeshProUGUI ammoText;
    public GameObject enemyData;
    public TextMeshProUGUI waveState;
    [Space]
    public Image aim;
    public Image sprintBar;
    public Image bloodImage;

    void Start()
    {
        weaponHolder.SetActive(true);

        winMenu.SetActive(false);
        deathMenu.SetActive(false);

        ammoText.gameObject.SetActive(true);
        enemyData.SetActive(true);
        waveState.gameObject.SetActive(true);

        aim.gameObject.SetActive(true);
        sprintBar.gameObject.SetActive(true);
        bloodImage.gameObject.SetActive(false);
    }

    void Update()
    {
        if (player.isDead)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            weaponHolder.SetActive(false);

            deathMenu.SetActive(true);
            
            ammoText.gameObject.SetActive(false);
            enemyData.SetActive(false);
            waveState.gameObject.SetActive(false);

            aim.gameObject.SetActive(false);
            sprintBar.gameObject.SetActive(false);
            bloodImage.gameObject.SetActive(true);
        }

        if(GameManager.Instance.won)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            winMenu.SetActive(true);

            enemyData.SetActive(false);
        }
    }
}