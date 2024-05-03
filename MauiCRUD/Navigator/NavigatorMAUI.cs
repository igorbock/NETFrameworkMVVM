using VisualBasicLib.Interfaces;

namespace MauiCRUD.Navigator;

public class NavigatorMAUI : INavigationManager
{
    public void ShowPage(string pageName)
    {
        var formName = $"MauiCRUD.Pages.{pageName}";
        var formType = Type.GetType(formName);
        if (formType == null)
            throw new NullReferenceException(nameof(formType));
        var mauiPage = Activator.CreateInstance(formType) as Page;
        if (mauiPage == null)
            throw new NullReferenceException(nameof(mauiPage));

        var page = new Window(mauiPage);
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
        Application.Current.OpenWindow(page);
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
    }
}
