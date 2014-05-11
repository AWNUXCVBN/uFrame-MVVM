using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBCategory("Physics2D")]
public class GetPhysics2DPositionIterations : UBAction {

	[UBRequireVariable] [UBRequired] public UBInt _Result = new UBInt();
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, Physics2D.positionIterations);
		}

	}

	public override string ToString(){
	return string.Format("Get positionIterations from {0}", "Physics2D");
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Result# = Physics2D.positionIterations");
	}

}