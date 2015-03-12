// This is the main DLL file.

#include "stdafx.h"
#include"BL.h"
using namespace std;


namespace BL
{
	bL::bL()
	{}
	string bL::GetName(string userName, string password)
	{
		{
			string nn;
			DA::dA obj;
			//DataAccess.DataAccess.GetFullName(userName, password);
			
			return obj.GetFullName(userName, password);
		}
	}

	void bL::Register(string username, string password, string displayname)
	{
		DA::dA obj;
		obj.Register(username,password,displayname);
		//return DataAccess.DataAccess.Register(username, password, displayname);
	}
}