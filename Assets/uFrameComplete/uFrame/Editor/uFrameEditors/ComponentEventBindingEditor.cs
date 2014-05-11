﻿using UnityEditor;

[CustomEditor(typeof(EventBinding), true)]
public class ComponentEventBindingEditor : ComponentCommandBindingEditor
{
    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        if (!ViewModelInspector()) return;

        EditorGUILayout.PropertyField(serializedObject.FindProperty("_EventName"));

        serializedObject.ApplyModifiedProperties();
    }
}