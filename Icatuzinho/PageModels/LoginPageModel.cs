using System;
using Xamarin.Forms;
using FreshMvvm;

namespace Icatuzinho
{
    public class LoginPageModel : FreshBasePageModel
    {
        public LoginPageModel()
        {
        }

        public Command Click
        {
            get
            {
                return new Command(() =>
                    {
                        var tabPage = new FreshMvvm.FreshTabbedNavigationContainer("HomeContainer");
                        tabPage.AddTab<HomePageModel>("Home","",null);
                        tabPage.AddTab<RotasPageModel>("Rotas", "",null);

                        CoreMethods.SwitchOutRootNavigation("HomeContainer");
                    });
            }
        }
    }
}

