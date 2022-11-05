﻿using FluentAssertions;
using NopCommerce.Core;
using NopCommerce.Core.Elements;
using OpenQA.Selenium;
using Pages;

namespace NopCommerce.UI.Frame.Pages;
public class GiftCardsPage : BasePage
{
    #region Properties

    private Button AddToWishListButton => new Button(By.CssSelector("button[class='button-2 add-to-wishlist-button']"));

    #endregion

    #region Constructors

    public GiftCardsPage(WebExecutionTool executionTool) : base(executionTool)
    {
    }

    #endregion

    /// <summary>
    /// Navigate user to the Wish list form of the gift card
    /// </summary>
    /// <returns></returns>
    public GiftCardPage ClickOnWishListButtonForItem()
    {
        AddToWishListButton.Click();

        return new GiftCardPage(Browser);
    }

    #region Actions

    #endregion

    #region Verifications

    #endregion
}
