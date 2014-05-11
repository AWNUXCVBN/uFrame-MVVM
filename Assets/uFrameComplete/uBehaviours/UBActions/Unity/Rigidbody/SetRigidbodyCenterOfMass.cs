using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"The center of mass relative to the transform's origin.")]
[UBCategory("Rigidbody")]
public class SetRigidbodyCenterOfMass : UBAction {

	[UBRequired] public UBObject _Rigidbody = new UBObject(typeof(Rigidbody));
	[UBRequired] public UBVector3 _Value = new UBVector3();
	protected override void PerformExecute(IUBContext context){
		if (_Value != null){
			_Rigidbody.GetValueAs<Rigidbody>(context).centerOfMass = _Value.GetValue(context);
		}

	}

	public override string ToString(){
	return string.Format("Set {0}'s centerOfMass to {1}", _Rigidbody.ToString(RootContainer), _Value.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Rigidbody#.centerOfMass = #_Value# ");
	}

}