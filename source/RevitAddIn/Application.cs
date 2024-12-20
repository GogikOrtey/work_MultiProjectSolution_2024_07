﻿using Nice3point.Revit.Toolkit.External;
using RevitAddIn.Commands;

// ⚠️ Без VPN не запускается NuGet

namespace RevitAddIn;

/// <summary>
///     Application entry point
/// </summary>
[UsedImplicitly]
public class Application : ExternalApplication
{
    public override void OnStartup()
    {
        Host.Start();
        CreateRibbon();
    }

    public override void OnShutdown()
    {
        Host.Stop();
    }

    private void CreateRibbon()
    {
        var panel = Application.CreatePanel("Commands", "RevitAddIn");

        //panel.AddPushButton<ShowModalWindowCommand>("Show\nModal window")
        //    .SetImage("/RevitAddIn;component/Resources/Icons/RibbonIcon16.png")
        //    .SetLargeImage("/RevitAddIn;component/Resources/Icons/RibbonIcon32.png");

        //panel.AddPushButton<ShowModelessWindowCommand>("Show\nModeless window")
        //    .SetImage("/RevitAddIn;component/Resources/Icons/RibbonIcon16.png")
        //    .SetLargeImage("/RevitAddIn;component/Resources/Icons/RibbonIcon32.png");

        panel.AddPushButton<StartupCommand>("Кнопка 1")
            .SetLargeImage("/RevitAddIn;component/Resources/Icons/ico_new_1_32.png");   

        panel.AddPushButton<StartupCommand2>("Кнопка 2")
            .SetLargeImage("/RevitAddIn;component/Resources/Icons/ico_new_2_32.png");
    }
}