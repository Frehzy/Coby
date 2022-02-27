using MaterialSkin;
using MaterialSkin.Controls;
using static MaterialSkin.MaterialSkinManager;

namespace Office.Helper;

internal static class FormHelper
{
    public static MaterialSkinManager CreateMaterialSkinManager(MaterialForm form)
    {
        MaterialSkinManager manager = Instance;
        manager.EnforceBackcolorOnAllComponents = true;
        manager.AddFormToManage(form);
        manager.Theme = Themes.LIGHT;
        return manager;
    }
}