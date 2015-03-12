// This is the main DLL file.

#include "stdafx.h"
#include<iostream>
#include<fstream>
#include<string>
#include"DA.h"
using namespace std;
namespace DA
{
	dA::dA()
	{}
	
string dA::GetFullName(string userName, string password)
	{
		bool flag = true;
		string str;
		string txt;
		ifstream ifs;
		string tempStr[2];
		ifs.open("C:\\Users\\Mark\\Desktop\\MP_Variant1\\DataAccess\\users.txt");
		if (ifs)
		{
			//str = "file existing";
			while (flag && !ifs.eof())
			{

				//input for username matches with username in the data file
				getline(ifs, txt, ';');
				tempStr[0] = txt;
				if (tempStr[0] == userName)
				{

					if (tempStr[0] == userName)
					{
						getline(ifs, txt, ';');
						tempStr[1] = txt;
						//check if password is okay
						if (tempStr[1] == password)
						{
							getline(ifs, txt, ';');
							str = txt;
								flag = false;
						}

					}
					//input for username does not match with username
					//in the users file

				}

			}

		}
		else
			str = "File not found!!!";
		return str;

	}


 void dA::Register(string username, string password, string displayname)
	{
		//   string variable = "";
		//  string userpath = ;
		ofstream sr;
		sr.open("C:\\Users\\Mark\\Desktop\\MP_Variant1\\DataAccess\\users.txt",ios_base::app);
		sr << endl;
		sr << username << ";";
		sr << password << ";";
		sr << displayname;
	/*	sr << ";;";*/
		sr.close();

	}





}