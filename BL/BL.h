// BL.h
#include<string>
#pragma once

using namespace DA;
using namespace System;
using namespace std;
namespace BL {

	public ref class bL
	{
	public:
		bL();
		string GetName(string userName, string password);
		void Register(string username, string password, string displayname);
		
	};
}
