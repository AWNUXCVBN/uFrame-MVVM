using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"The rotation of the transform in world space stored as a .")]
[UBCategory("Transform")]
public class SetTransformRotation : UBAction {

	[UBRequired] public UBTransform _Transform = new UBTransform();
	[UBRequired] public UBQuaternion _Value = new UBQuaternion();
	protected override void PerformExecute(IUBContext context){
		if (_Value != null){
			_Transform.GetValue(context).rotation = _Value.GetValue(context);
		}

	}

	public override string ToString(){
	return string.Format("Set {0}'s rotation to {1}", _Transform.ToString(RootContainer), _Value.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Transform#.rotation = #_Value# ");
	}

}