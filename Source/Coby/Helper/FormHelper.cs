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
        manager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey50, Accent.Red200, TextShade.WHITE);
        manager.Theme = Themes.DARK;
        return manager;
    }
}