using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"The far clipping plane distance.")]
[UBCategory("Camera")]
public class SetCameraFarClipPlane : UBAction {

	[UBRequired] public UBObject _Camera = new UBObject(typeof(Camera));
	[UBRequired] public UBFloat _Value = new UBFloat();
	protected override void PerformExecute(IUBContext context){
		if (_Value != null){
			_Camera.GetValueAs<Camera>(context).farClipPlane = _Value.GetValue(context);
		}

	}

	public override string ToString(){
	return string.Format("Set {0}'s farClipPlane to {1}", _Camera.ToString(RootContainer), _Value.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Camera#.farClipPlane = #_Value# ");
	}

}