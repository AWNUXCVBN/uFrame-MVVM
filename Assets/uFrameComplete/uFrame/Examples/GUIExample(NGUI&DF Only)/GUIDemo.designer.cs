// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;
using UnityEngine;


[DiagramInfoAttribute("GUIDemo")]
public partial class GUIMainMenuScreenViewModel : ViewModel {
    
    public readonly P<System.String> _PlayerNameProperty = new P<string>();
    
    private ICommand _RandomName;
    
    public virtual string PlayerName {
        get {
            return _PlayerNameProperty.Value;
        }
        set {
            _PlayerNameProperty.Value = value;
        }
    }
    
    public virtual ICommand RandomName {
        get {
            return _RandomName;
        }
        set {
            _RandomName = value;
        }
    }
}

[DiagramInfoAttribute("GUIDemo")]
public partial class GUIMainMenuViewModel : ViewModel {
    
    public readonly P<GUIMainMenuScreenViewModel> _MainMenuScreenProperty = new P<GUIMainMenuScreenViewModel>();
    
    private ICommand _Play;
    
    public virtual GUIMainMenuScreenViewModel MainMenuScreen {
        get {
            return _MainMenuScreenProperty.Value;
        }
        set {
            _MainMenuScreenProperty.Value = value;
        }
    }
    
    public virtual ICommand Play {
        get {
            return _Play;
        }
        set {
            _Play = value;
        }
    }
}

[DiagramInfoAttribute("GUIDemo")]
public partial class GUIGameViewModel : ViewModel {
    
    public readonly P<System.String> _CurrentPlayerNameProperty = new P<string>();
    
    private ICommand _QuitGame;
    
    public virtual string CurrentPlayerName {
        get {
            return _CurrentPlayerNameProperty.Value;
        }
        set {
            _CurrentPlayerNameProperty.Value = value;
        }
    }
    
    public virtual ICommand QuitGame {
        get {
            return _QuitGame;
        }
        set {
            _QuitGame = value;
        }
    }
}
