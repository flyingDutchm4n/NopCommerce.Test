﻿using NopCommerce.Core.Interfaces;
using OpenQA.Selenium;

namespace NopCommerce.Core.Elements;
public class Field : IField
{
    private readonly IWebElement _element;
    public string Id { get; private set; }
    private WebExecutionTool WebExecutionTool => WebExecutionTool.Instance;
    public Field(By by)
    {
        Id = Guid.NewGuid().ToString();
        _element = WebExecutionTool.GetWebExecutionTool().FindElement(by);
    }

    public Field(IWebElement element)
    {
        Id = Guid.NewGuid().ToString();
        _element = element;
    }
    public bool Exists(int timeout)
    {
        return _element.Displayed;
    }
    public string GetValue()
    {
        return _element.GetAttribute("value");
    }

    public string Read()
    {
        return _element.Text;
    }

    public bool Write(string text)
    {
        _element.SendKeys(text);
        return true;
    }

    public bool ClearValue()
    {
        _element.Clear();
        return true;
    }
}
