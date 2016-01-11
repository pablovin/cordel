static function PasswordField(password : String, maskChar : String) : String {
	if (Event.current.type == EventType.repaint || Event.current.type == EventType.mouseDown)
	{
	    strPasswordMask = "";
	    for (i = 0; i <password.Length; i++)
	    {
	        strPasswordMask += maskChar;
	    }
	}
	else
	{
	    strPasswordMask = password;
	}
	GUI.changed = false;
	strPasswordMask = GUILayout.TextField(strPasswordMask, GUILayout.Width(150));
	if (GUI.changed)
	{
	    password = strPasswordMask;
	}
return password;
}