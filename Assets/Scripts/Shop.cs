using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject shop;
    public void OnOpenShop()
    {
        ShopEnable();
        animator.Play("OpenShop");
    }

    public void OnCloseShop()
    {
        animator.Play("CloseShop");
    }

    public void ShopEnable()
    {
        shop.SetActive(true);
    }

    public void ShopDisable()
    {
        shop.SetActive(false);
    }
}
