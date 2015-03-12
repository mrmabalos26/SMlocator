// DA.h
#include "stdafx.h"
#include<iostream>
#include<fstream>
#include<string>

#pragma once

using namespace std;
using namespace System;

namespace DA {
	public ref class dA
	{
	public: dA();
	string GetFullName(string userName, string password);
	void Register(string username, string password, string displayname);
	};	
}
