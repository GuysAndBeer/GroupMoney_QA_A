using GroupMoney_QA_A.Attributes;
using GroupMoney_QA_A.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GroupMoney_QA_A.BaseClasses;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.Factories
{
    public class PagesFactory
    {
        private static readonly Dictionary<AliasAttribute, Type> PagesMap = 
            new Dictionary<AliasAttribute, Type>();

        private static Dictionary<AliasAttribute, Type> GetPagesMap()
        {
            if (PagesMap.Any()) return PagesMap;
            var assembly = AppDomain.CurrentDomain.GetAssemblies().
                FirstOrDefault(a => a.FullName.Contains("GroupMoney_QA_A"));
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsDefined(typeof(AliasAttribute), true) && typeof(PageBase).IsAssignableFrom(type))
                {
                    var aliasAttr =
                        (AliasAttribute) Attribute.GetCustomAttribute(type, typeof(AliasAttribute));
                    if(PagesMap.Keys.Contains(aliasAttr))
                        throw new Exception($"Duplicated alias: {aliasAttr.Alias}");
                    PagesMap.Add(aliasAttr, type);
                }
            }
            return PagesMap;
        }

        public static Dictionary<FieldInfo, object> GetPageControls(PageBase page)
        {
            Dictionary<FieldInfo, object> contolsOfPage = new Dictionary<FieldInfo, object>();
            foreach (var field in page.GetType().GetFields())
            {
                if (field.FieldType.Equals(typeof(CustomWebElement)) 
                    && field.IsDefined(typeof(AliasAttribute), true))
                    contolsOfPage.Add(field, field.GetValue(page));
            }
            return contolsOfPage;
        }

        public static PageBase GetPage(string pageName)
        {
            var item = GetPagesMap().FirstOrDefault(pair =>
                pair.Key.Alias.Equals(pageName) &&
                typeof(PageBase).IsAssignableFrom(pair.Value)).Value;
            if (item != null) return (PageBase)Activator.CreateInstance(item);
            throw new Exception($"Alias not found: '{pageName}'");
        }

        public static CustomWebElement GetElement(string elementName, PageBase page)
        {
            var controls = GetPageControls(page);
            foreach (var control in controls)
            {
                var alias = (string) control.Key.GetCustomAttribute(typeof(AliasAttribute)).GetType()
                    .GetProperty("Alias")
                    ?.GetValue(control.Key.GetCustomAttribute(typeof(AliasAttribute)));
                if (alias.Equals(elementName))
                    return (CustomWebElement)control.Value;
            }
            throw new Exception($"Alias not found: '{elementName}'");
        }
    }
}
