using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppDemo.Navigation
{
    public class NavigationService : INavigationService
    {
        public NavigationService()
        {
        }

        public Task InitializeAsync()
        {
            return NavigateToAsync("//Main/Catalog");
        }

        public Task NavigateToAsync(string route, IDictionary<string, string> routeParameters = null)
        {
            var uri = new StringBuilder(route);

            if (routeParameters != null)
            {
                uri.Append('?');

                foreach (var routeParameter in routeParameters)
                {
                    uri.Append($"{routeParameter.Key}={Uri.EscapeDataString(routeParameter.Value)}&");
                }
                uri.Remove(uri.Length - 1, 1);
            }

            return Shell.Current.GoToAsync(uri.ToString());
        }

        private Type GetPageTypeForViewModel(Type viewModelType)
        {
            var viewName = viewModelType.FullName.Replace("Model", string.Empty);
            var viewModelAssemblyName = viewModelType.GetTypeInfo().Assembly.FullName;
            var viewAssemblyName = string.Format(CultureInfo.InvariantCulture, "{0}, {1}", viewName, viewModelAssemblyName);
            var viewType = Type.GetType(viewAssemblyName);
            return viewType;
        }

        private Page CreatePage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);
            if (pageType == null)
            {
                throw new Exception($"Cannot locate page type for {viewModelType}");
            }

            Page page = Activator.CreateInstance(pageType) as Page;
            return page;
        }
    }
}
