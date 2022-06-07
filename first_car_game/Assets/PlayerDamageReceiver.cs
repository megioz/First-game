using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{   protected PlayerCtrl playerCtrl;


    protected void Awake(){
         this.playerCtrl = GetComponent<PlayerCtrl>();
    }
    public override void Receive(int damage){
        base.Receive(damage);
        if(this.IsDead()){
            this.playerCtrl.playerStatus.Dead();
            UiManager.instance.bnGameOver.SetActive(true);
        }
    }
}
