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


public abstract class FPSDamageableViewBase : ViewBase {
    
    [UFToggleGroup("Health")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("HealthChanged")]
    public bool _BindHealth;
    
    [UFGroup("Health")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetHealthTwoWayValue")]
    public bool _HealthIsTwoWay;
    
    [UFToggleGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("StateChanged")]
    public bool _BindState;
    
    [UFGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetStateTwoWayValue")]
    public bool _StateIsTwoWay;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _Health;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public FPSPlayerState _State;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSDamageableViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public FPSDamageableViewModel FPSDamageable {
        get {
            return ((FPSDamageableViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void HealthChanged(float value) {
    }
    
    public virtual float GetHealthTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void StateChanged(FPSPlayerState value) {
    }
    
    public virtual FPSPlayerState GetStateTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public override void Bind() {
        if (this._BindHealth) {
            if (this._HealthIsTwoWay) {
                this.BindProperty(()=>FPSDamageable._HealthProperty, this.HealthChanged, this.GetHealthTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSDamageable._HealthProperty, this.HealthChanged);
            }
        }
        if (this._BindState) {
            if (this._StateIsTwoWay) {
                this.BindProperty(()=>FPSDamageable._StateProperty, this.StateChanged, this.GetStateTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSDamageable._StateProperty, this.StateChanged);
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSDamageableController>());
    }
    
    public virtual void ExecuteApplyDamage(int arg) {
        this.ExecuteCommand(FPSDamageable.ApplyDamage, arg);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        FPSDamageableViewModel fPSDamageable = ((FPSDamageableViewModel)(viewModel));
        fPSDamageable.Health = this._Health;
        fPSDamageable.State = this._State;
    }
}

public abstract class FPSEnemyViewBase : FPSDamageableViewBase {
    
    [UFToggleGroup("Speed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SpeedChanged")]
    public bool _BindSpeed;
    
    [UFGroup("Speed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetSpeedTwoWayValue")]
    public bool _SpeedIsTwoWay;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _Speed;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSEnemyViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public FPSEnemyViewModel FPSEnemy {
        get {
            return ((FPSEnemyViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void SpeedChanged(float value) {
    }
    
    public virtual float GetSpeedTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindSpeed) {
            if (this._SpeedIsTwoWay) {
                this.BindProperty(()=>FPSEnemy._SpeedProperty, this.SpeedChanged, this.GetSpeedTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSEnemy._SpeedProperty, this.SpeedChanged);
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSEnemyController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        FPSEnemyViewModel fPSEnemy = ((FPSEnemyViewModel)(viewModel));
        fPSEnemy.Speed = this._Speed;
    }
}

public abstract class FPSGameViewBase : ViewBase {
    
    [UFToggleGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    public bool _BindCurrentPlayer;
    
    [UFGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetCurrentPlayerTwoWayValue")]
    public bool _CurrentPlayerIsTwoWay;
    
    [UFGroup("CurrentPlayer")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.GameObject _CurrentPlayerPrefab;
    
    [UFToggleGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("StateChanged")]
    public bool _BindState;
    
    [UFGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetStateTwoWayValue")]
    public bool _StateIsTwoWay;
    
    [UFToggleGroup("Score")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("ScoreChanged")]
    public bool _BindScore;
    
    [UFGroup("Score")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetScoreTwoWayValue")]
    public bool _ScoreIsTwoWay;
    
    [UFToggleGroup("Kills")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("KillsChanged")]
    public bool _BindKills;
    
    [UFGroup("Kills")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetKillsTwoWayValue")]
    public bool _KillsIsTwoWay;
    
    [UFToggleGroup("Enemies")]
    [UnityEngine.HideInInspector()]
    public bool _BindEnemies;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<FPSEnemyViewBase> _EnemiesList;
    
    [UFGroup("Enemies")]
    [UnityEngine.HideInInspector()]
    public bool _EnemiesSceneFirst;
    
    [UFGroup("Enemies")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _EnemiesContainer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public FPSPlayerViewBase _CurrentPlayer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public FPSGameState _State;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _Score;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _Kills;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public FPSGameViewModel FPSGame {
        get {
            return ((FPSGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void CurrentPlayerChanged(FPSPlayerViewModel value) {
        if (value == null) {
            Destroy(_CurrentPlayer.gameObject);
        }
        if (_CurrentPlayerPrefab == null) {
            this._CurrentPlayer = ((FPSPlayerViewBase)(this.InstantiateView(value)));
        }
        else {
            this._CurrentPlayer = ((FPSPlayerViewBase)(this.InstantiateView(this._CurrentPlayerPrefab, value)));
        }
    }
    
    public virtual FPSPlayerViewModel GetCurrentPlayerTwoWayValue() {
        if (this._CurrentPlayer == null || this._CurrentPlayer.ViewModelObject == null) {
            return null;
        }
        return ((FPSPlayerViewModel)(this._CurrentPlayer.ViewModelObject));
    }
    
    public virtual void StateChanged(FPSGameState value) {
    }
    
    public virtual FPSGameState GetStateTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void ScoreChanged(int value) {
    }
    
    public virtual int GetScoreTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void KillsChanged(int value) {
    }
    
    public virtual int GetKillsTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void EnemiesAdded(FPSEnemyViewBase fPSEnemy) {
        this._EnemiesList.Add(fPSEnemy);
    }
    
    public virtual void EnemiesRemoved(FPSEnemyViewBase fPSEnemy) {
        this._EnemiesList.Remove(fPSEnemy);
        UnityEngine.Object.Destroy(fPSEnemy.gameObject);
    }
    
    public virtual ViewBase CreateEnemiesView(FPSEnemyViewModel fPSEnemy) {
        return this.InstantiateView(fPSEnemy);
    }
    
    public override void Bind() {
        if (this._BindCurrentPlayer) {
            if (this._CurrentPlayerIsTwoWay) {
                this.BindProperty(()=>FPSGame._CurrentPlayerProperty, this.CurrentPlayerChanged, this.GetCurrentPlayerTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSGame._CurrentPlayerProperty, this.CurrentPlayerChanged);
            }
        }
        if (this._BindState) {
            if (this._StateIsTwoWay) {
                this.BindProperty(()=>FPSGame._StateProperty, this.StateChanged, this.GetStateTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSGame._StateProperty, this.StateChanged);
            }
        }
        if (this._BindScore) {
            if (this._ScoreIsTwoWay) {
                this.BindProperty(()=>FPSGame._ScoreProperty, this.ScoreChanged, this.GetScoreTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSGame._ScoreProperty, this.ScoreChanged);
            }
        }
        if (this._BindKills) {
            if (this._KillsIsTwoWay) {
                this.BindProperty(()=>FPSGame._KillsProperty, this.KillsChanged, this.GetKillsTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSGame._KillsProperty, this.KillsChanged);
            }
        }
        if (this._BindEnemies) {
            var binding = this.BindToViewCollection(() => FPSGame._EnemiesProperty);
            binding.SetAddHandler(item=>EnemiesAdded(item as FPSEnemyViewBase));
            binding.SetRemoveHandler(item=>EnemiesRemoved(item as FPSEnemyViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreateEnemiesView(viewModel as FPSEnemyViewModel); }); ;
            if ((_EnemiesContainer == null)) {
            }
            else {
                binding.SetParent(_EnemiesContainer);
            }
            if (_EnemiesSceneFirst) {
                binding.ViewFirst();
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSGameController>());
    }
    
    public virtual void ExecuteMainMenu() {
        this.ExecuteCommand(FPSGame.MainMenu);
    }
    
    public virtual void ExecuteQuitGame() {
        this.ExecuteCommand(FPSGame.QuitGame);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        FPSGameViewModel fPSGame = ((FPSGameViewModel)(viewModel));
        fPSGame.CurrentPlayer = this._CurrentPlayer == null ? null : this._CurrentPlayer.ViewModelObject as FPSPlayerViewModel;
        fPSGame.State = this._State;
        fPSGame.Score = this._Score;
        fPSGame.Kills = this._Kills;
    }
}

public abstract class FPSPlayerViewBase : FPSDamageableViewBase {
    
    [UFToggleGroup("CurrentWeaponIndex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentWeaponIndexChanged")]
    public bool _BindCurrentWeaponIndex;
    
    [UFGroup("CurrentWeaponIndex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetCurrentWeaponIndexTwoWayValue")]
    public bool _CurrentWeaponIndexIsTwoWay;
    
    [UFToggleGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public bool _BindWeapons;
    
    [UnityEngine.HideInInspector()]
    public System.Collections.Generic.List<FPSWeaponViewBase> _WeaponsList;
    
    [UFGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public bool _WeaponsSceneFirst;
    
    [UFGroup("Weapons")]
    [UnityEngine.HideInInspector()]
    public UnityEngine.Transform _WeaponsContainer;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _CurrentWeaponIndex;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSPlayerViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public FPSPlayerViewModel FPSPlayer {
        get {
            return ((FPSPlayerViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void CurrentWeaponIndexChanged(int value) {
    }
    
    public virtual int GetCurrentWeaponIndexTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void WeaponsAdded(FPSWeaponViewBase fPSWeapon) {
        this._WeaponsList.Add(fPSWeapon);
    }
    
    public virtual void WeaponsRemoved(FPSWeaponViewBase fPSWeapon) {
        this._WeaponsList.Remove(fPSWeapon);
        UnityEngine.Object.Destroy(fPSWeapon.gameObject);
    }
    
    public virtual ViewBase CreateWeaponsView(FPSWeaponViewModel fPSWeapon) {
        return this.InstantiateView(fPSWeapon);
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindCurrentWeaponIndex) {
            if (this._CurrentWeaponIndexIsTwoWay) {
                this.BindProperty(()=>FPSPlayer._CurrentWeaponIndexProperty, this.CurrentWeaponIndexChanged, this.GetCurrentWeaponIndexTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSPlayer._CurrentWeaponIndexProperty, this.CurrentWeaponIndexChanged);
            }
        }
        if (this._BindWeapons) {
            var binding = this.BindToViewCollection(() => FPSPlayer._WeaponsProperty);
            binding.SetAddHandler(item=>WeaponsAdded(item as FPSWeaponViewBase));
            binding.SetRemoveHandler(item=>WeaponsRemoved(item as FPSWeaponViewBase));
            binding.SetCreateHandler(viewModel=>{ return CreateWeaponsView(viewModel as FPSWeaponViewModel); }); ;
            if ((_WeaponsContainer == null)) {
            }
            else {
                binding.SetParent(_WeaponsContainer);
            }
            if (_WeaponsSceneFirst) {
                binding.ViewFirst();
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSPlayerController>());
    }
    
    public virtual void ExecuteNextWeapon() {
        this.ExecuteCommand(FPSPlayer.NextWeapon);
    }
    
    public virtual void ExecutePickupWeapon(FPSWeaponViewModel fPSWeapon) {
        this.ExecuteCommand(FPSPlayer.PickupWeapon, fPSWeapon);
    }
    
    public virtual void ExecutePreviousWeapon() {
        this.ExecuteCommand(FPSPlayer.PreviousWeapon);
    }
    
    public virtual void ExecuteSelectWeapon(int arg) {
        this.ExecuteCommand(FPSPlayer.SelectWeapon, arg);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        FPSPlayerViewModel fPSPlayer = ((FPSPlayerViewModel)(viewModel));
        fPSPlayer.CurrentWeaponIndex = this._CurrentWeaponIndex;
    }
}

public abstract class FPSWeaponViewBase : ViewBase {
    
    [UnityEngine.SerializeField()]
    private FPSWeaponFire _FPSWeaponFire;
    
    [UnityEngine.SerializeField()]
    private FPSCrosshair _FPSCrosshair;
    
    [UFToggleGroup("Ammo")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("AmmoChanged")]
    public bool _BindAmmo;
    
    [UFGroup("Ammo")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetAmmoTwoWayValue")]
    public bool _AmmoIsTwoWay;
    
    [UFToggleGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("StateChanged")]
    public bool _BindState;
    
    [UFGroup("State")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetStateTwoWayValue")]
    public bool _StateIsTwoWay;
    
    [UFToggleGroup("ZoomIndex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("ZoomIndexChanged")]
    public bool _BindZoomIndex;
    
    [UFGroup("ZoomIndex")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetZoomIndexTwoWayValue")]
    public bool _ZoomIndexIsTwoWay;
    
    [UFToggleGroup("MaxZooms")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("MaxZoomsChanged")]
    public bool _BindMaxZooms;
    
    [UFGroup("MaxZooms")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetMaxZoomsTwoWayValue")]
    public bool _MaxZoomsIsTwoWay;
    
    [UFToggleGroup("WeaponType")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("WeaponTypeChanged")]
    public bool _BindWeaponType;
    
    [UFGroup("WeaponType")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetWeaponTypeTwoWayValue")]
    public bool _WeaponTypeIsTwoWay;
    
    [UFToggleGroup("ReloadTime")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("ReloadTimeChanged")]
    public bool _BindReloadTime;
    
    [UFGroup("ReloadTime")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetReloadTimeTwoWayValue")]
    public bool _ReloadTimeIsTwoWay;
    
    [UFToggleGroup("RoundSize")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("RoundSizeChanged")]
    public bool _BindRoundSize;
    
    [UFGroup("RoundSize")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetRoundSizeTwoWayValue")]
    public bool _RoundSizeIsTwoWay;
    
    [UFToggleGroup("MinSpread")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("MinSpreadChanged")]
    public bool _BindMinSpread;
    
    [UFGroup("MinSpread")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetMinSpreadTwoWayValue")]
    public bool _MinSpreadIsTwoWay;
    
    [UFToggleGroup("BurstSize")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BurstSizeChanged")]
    public bool _BindBurstSize;
    
    [UFGroup("BurstSize")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetBurstSizeTwoWayValue")]
    public bool _BurstSizeIsTwoWay;
    
    [UFToggleGroup("Spread")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SpreadChanged")]
    public bool _BindSpread;
    
    [UFGroup("Spread")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetSpreadTwoWayValue")]
    public bool _SpreadIsTwoWay;
    
    [UFToggleGroup("RecoilSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("RecoilSpeedChanged")]
    public bool _BindRecoilSpeed;
    
    [UFGroup("RecoilSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetRecoilSpeedTwoWayValue")]
    public bool _RecoilSpeedIsTwoWay;
    
    [UFToggleGroup("FireSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("FireSpeedChanged")]
    public bool _BindFireSpeed;
    
    [UFGroup("FireSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetFireSpeedTwoWayValue")]
    public bool _FireSpeedIsTwoWay;
    
    [UFToggleGroup("BurstSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BurstSpeedChanged")]
    public bool _BindBurstSpeed;
    
    [UFGroup("BurstSpeed")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetBurstSpeedTwoWayValue")]
    public bool _BurstSpeedIsTwoWay;
    
    [UFToggleGroup("SpreadMultiplier")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("SpreadMultiplierChanged")]
    public bool _BindSpreadMultiplier;
    
    [UFGroup("SpreadMultiplier")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetSpreadMultiplierTwoWayValue")]
    public bool _SpreadMultiplierIsTwoWay;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _Ammo;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public FPSWeaponState _State;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _ZoomIndex;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _MaxZooms;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public WeaponType _WeaponType;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _ReloadTime;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _RoundSize;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _MinSpread;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _BurstSize;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _Spread;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _RecoilSpeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _FireSpeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _BurstSpeed;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public float _SpreadMultiplier;
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSWeaponViewModel);
        }
    }
    
    public virtual FPSWeaponFire FPSWeaponFire {
        get {
            return _FPSWeaponFire ?? (_FPSWeaponFire = GetComponent<FPSWeaponFire>());
        }
        set {
            this._FPSWeaponFire = value;
        }
    }
    
    public virtual FPSCrosshair FPSCrosshair {
        get {
            return _FPSCrosshair ?? (_FPSCrosshair = GetComponent<FPSCrosshair>());
        }
        set {
            this._FPSCrosshair = value;
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return true;
        }
    }
    
    public FPSWeaponViewModel FPSWeapon {
        get {
            return ((FPSWeaponViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void AmmoChanged(int value) {
    }
    
    public virtual int GetAmmoTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void StateChanged(FPSWeaponState value) {
    }
    
    public virtual FPSWeaponState GetStateTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void ZoomIndexChanged(int value) {
    }
    
    public virtual int GetZoomIndexTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void MaxZoomsChanged(int value) {
    }
    
    public virtual int GetMaxZoomsTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void WeaponTypeChanged(WeaponType value) {
    }
    
    public virtual WeaponType GetWeaponTypeTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void ReloadTimeChanged(float value) {
    }
    
    public virtual float GetReloadTimeTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void RoundSizeChanged(int value) {
    }
    
    public virtual int GetRoundSizeTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void MinSpreadChanged(int value) {
    }
    
    public virtual int GetMinSpreadTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void BurstSizeChanged(int value) {
    }
    
    public virtual int GetBurstSizeTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void SpreadChanged(float value) {
    }
    
    public virtual float GetSpreadTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void RecoilSpeedChanged(float value) {
    }
    
    public virtual float GetRecoilSpeedTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void FireSpeedChanged(float value) {
    }
    
    public virtual float GetFireSpeedTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void BurstSpeedChanged(float value) {
    }
    
    public virtual float GetBurstSpeedTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void SpreadMultiplierChanged(float value) {
    }
    
    public virtual float GetSpreadMultiplierTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public override void Bind() {
        if (this._BindAmmo) {
            if (this._AmmoIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._AmmoProperty, this.AmmoChanged, this.GetAmmoTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._AmmoProperty, this.AmmoChanged);
            }
        }
        if (this._BindState) {
            if (this._StateIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._StateProperty, this.StateChanged, this.GetStateTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._StateProperty, this.StateChanged);
            }
        }
        if (this._BindZoomIndex) {
            if (this._ZoomIndexIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._ZoomIndexProperty, this.ZoomIndexChanged, this.GetZoomIndexTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._ZoomIndexProperty, this.ZoomIndexChanged);
            }
        }
        if (this._BindMaxZooms) {
            if (this._MaxZoomsIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._MaxZoomsProperty, this.MaxZoomsChanged, this.GetMaxZoomsTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._MaxZoomsProperty, this.MaxZoomsChanged);
            }
        }
        if (this._BindWeaponType) {
            if (this._WeaponTypeIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._WeaponTypeProperty, this.WeaponTypeChanged, this.GetWeaponTypeTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._WeaponTypeProperty, this.WeaponTypeChanged);
            }
        }
        if (this._BindReloadTime) {
            if (this._ReloadTimeIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._ReloadTimeProperty, this.ReloadTimeChanged, this.GetReloadTimeTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._ReloadTimeProperty, this.ReloadTimeChanged);
            }
        }
        if (this._BindRoundSize) {
            if (this._RoundSizeIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._RoundSizeProperty, this.RoundSizeChanged, this.GetRoundSizeTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._RoundSizeProperty, this.RoundSizeChanged);
            }
        }
        if (this._BindMinSpread) {
            if (this._MinSpreadIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._MinSpreadProperty, this.MinSpreadChanged, this.GetMinSpreadTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._MinSpreadProperty, this.MinSpreadChanged);
            }
        }
        if (this._BindBurstSize) {
            if (this._BurstSizeIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._BurstSizeProperty, this.BurstSizeChanged, this.GetBurstSizeTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._BurstSizeProperty, this.BurstSizeChanged);
            }
        }
        if (this._BindSpread) {
            if (this._SpreadIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._SpreadProperty, this.SpreadChanged, this.GetSpreadTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._SpreadProperty, this.SpreadChanged);
            }
        }
        if (this._BindRecoilSpeed) {
            if (this._RecoilSpeedIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._RecoilSpeedProperty, this.RecoilSpeedChanged, this.GetRecoilSpeedTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._RecoilSpeedProperty, this.RecoilSpeedChanged);
            }
        }
        if (this._BindFireSpeed) {
            if (this._FireSpeedIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._FireSpeedProperty, this.FireSpeedChanged, this.GetFireSpeedTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._FireSpeedProperty, this.FireSpeedChanged);
            }
        }
        if (this._BindBurstSpeed) {
            if (this._BurstSpeedIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._BurstSpeedProperty, this.BurstSpeedChanged, this.GetBurstSpeedTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._BurstSpeedProperty, this.BurstSpeedChanged);
            }
        }
        if (this._BindSpreadMultiplier) {
            if (this._SpreadMultiplierIsTwoWay) {
                this.BindProperty(()=>FPSWeapon._SpreadMultiplierProperty, this.SpreadMultiplierChanged, this.GetSpreadMultiplierTwoWayValue);
            }
            else {
                this.BindProperty(()=>FPSWeapon._SpreadMultiplierProperty, this.SpreadMultiplierChanged);
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSWeaponController>());
    }
    
    public virtual void ExecuteBeginFire() {
        this.ExecuteCommand(FPSWeapon.BeginFire);
    }
    
    public virtual void ExecuteNextZoom() {
        this.ExecuteCommand(FPSWeapon.NextZoom);
    }
    
    public virtual void ExecuteReload() {
        this.ExecuteCommand(FPSWeapon.Reload);
    }
    
    public virtual void ExecuteEndFire() {
        this.ExecuteCommand(FPSWeapon.EndFire);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        FPSWeaponViewModel fPSWeapon = ((FPSWeaponViewModel)(viewModel));
        fPSWeapon.Ammo = this._Ammo;
        fPSWeapon.State = this._State;
        fPSWeapon.ZoomIndex = this._ZoomIndex;
        fPSWeapon.MaxZooms = this._MaxZooms;
        fPSWeapon.WeaponType = this._WeaponType;
        fPSWeapon.ReloadTime = this._ReloadTime;
        fPSWeapon.RoundSize = this._RoundSize;
        fPSWeapon.MinSpread = this._MinSpread;
        fPSWeapon.BurstSize = this._BurstSize;
        fPSWeapon.Spread = this._Spread;
        fPSWeapon.RecoilSpeed = this._RecoilSpeed;
        fPSWeapon.FireSpeed = this._FireSpeed;
        fPSWeapon.BurstSpeed = this._BurstSpeed;
        fPSWeapon.SpreadMultiplier = this._SpreadMultiplier;
    }
}

public abstract class WavesFPSGameViewBase : FPSGameViewBase {
    
    [UFToggleGroup("KillsToNextWave")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("KillsToNextWaveChanged")]
    public bool _BindKillsToNextWave;
    
    [UFGroup("KillsToNextWave")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetKillsToNextWaveTwoWayValue")]
    public bool _KillsToNextWaveIsTwoWay;
    
    [UFToggleGroup("WaveKills")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("WaveKillsChanged")]
    public bool _BindWaveKills;
    
    [UFGroup("WaveKills")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetWaveKillsTwoWayValue")]
    public bool _WaveKillsIsTwoWay;
    
    [UFToggleGroup("CurrentWave")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("CurrentWaveChanged")]
    public bool _BindCurrentWave;
    
    [UFGroup("CurrentWave")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetCurrentWaveTwoWayValue")]
    public bool _CurrentWaveIsTwoWay;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _KillsToNextWave;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _WaveKills;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public int _CurrentWave;
    
    public override System.Type ViewModelType {
        get {
            return typeof(WavesFPSGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public WavesFPSGameViewModel WavesFPSGame {
        get {
            return ((WavesFPSGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void KillsToNextWaveChanged(int value) {
    }
    
    public virtual int GetKillsToNextWaveTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void WaveKillsChanged(int value) {
    }
    
    public virtual int GetWaveKillsTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void CurrentWaveChanged(int value) {
    }
    
    public virtual int GetCurrentWaveTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindKillsToNextWave) {
            if (this._KillsToNextWaveIsTwoWay) {
                this.BindProperty(()=>WavesFPSGame._KillsToNextWaveProperty, this.KillsToNextWaveChanged, this.GetKillsToNextWaveTwoWayValue);
            }
            else {
                this.BindProperty(()=>WavesFPSGame._KillsToNextWaveProperty, this.KillsToNextWaveChanged);
            }
        }
        if (this._BindWaveKills) {
            if (this._WaveKillsIsTwoWay) {
                this.BindProperty(()=>WavesFPSGame._WaveKillsProperty, this.WaveKillsChanged, this.GetWaveKillsTwoWayValue);
            }
            else {
                this.BindProperty(()=>WavesFPSGame._WaveKillsProperty, this.WaveKillsChanged);
            }
        }
        if (this._BindCurrentWave) {
            if (this._CurrentWaveIsTwoWay) {
                this.BindProperty(()=>WavesFPSGame._CurrentWaveProperty, this.CurrentWaveChanged, this.GetCurrentWaveTwoWayValue);
            }
            else {
                this.BindProperty(()=>WavesFPSGame._CurrentWaveProperty, this.CurrentWaveChanged);
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<WavesFPSGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        WavesFPSGameViewModel wavesFPSGame = ((WavesFPSGameViewModel)(viewModel));
        wavesFPSGame.KillsToNextWave = this._KillsToNextWave;
        wavesFPSGame.WaveKills = this._WaveKills;
        wavesFPSGame.CurrentWave = this._CurrentWave;
    }
}

public abstract class FPSMenuViewBase : ViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(FPSMenuViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public FPSMenuViewModel FPSMenu {
        get {
            return ((FPSMenuViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override void Bind() {
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<FPSMenuController>());
    }
    
    public virtual void ExecutePlay() {
        this.ExecuteCommand(FPSMenu.Play);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
    }
}

public abstract class DeathMatchGameViewBase : FPSGameViewBase {
    
    public override System.Type ViewModelType {
        get {
            return typeof(DeathMatchGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public DeathMatchGameViewModel DeathMatchGame {
        get {
            return ((DeathMatchGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public override void Bind() {
        base.Bind();
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<DeathMatchGameController>());
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
    }
}

public partial class FPSGameView : FPSGameViewBase {
}

public partial class FPSWeaponView : FPSWeaponViewBase {
}

public partial class FPSPlayerView : FPSPlayerViewBase {
}

public partial class FPSPlayerHUDView : FPSPlayerViewBase {
}

public partial class WavesHUDView : WavesFPSGameViewBase {
}

public partial class FPSHUDView : FPSGameViewBase {
}

public partial class FPSEnemyView : FPSEnemyViewBase {
}

public partial class NewView1 : FPSWeaponView {
}

public partial class FPSMainMenuView : FPSMenuViewBase {
}

public partial class FPSWeaponFire : ViewComponent {
    
    public virtual FPSWeaponViewModel FPSWeapon {
        get {
            return ((FPSWeaponViewModel)(this.View.ViewModelObject));
        }
    }
}

public partial class FPSCrosshair : ViewComponent {
    
    public virtual FPSWeaponViewModel FPSWeapon {
        get {
            return ((FPSWeaponViewModel)(this.View.ViewModelObject));
        }
    }
}

public partial class RocketLauncher : FPSWeaponFire {
}
