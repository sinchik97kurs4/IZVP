// ClassLibrary1.h

#pragma once

using namespace System;

namespace ClassLibrary1 {



	public ref class  GetSqrt :  public   VBLibrary::BasicO
	{




	public:

		float Volume(float a, int mod)
		{
			if (mod == 1) 
			{

				float ans;
				ans = 6 * a*a;

				return ans;
			}

		};

		/*
		static	float _sqrt(float a) // Використовуючи статичний метод, повертаємо результат.
		{
			float ans;
			ans = 6 * a*a;

			return ans;

		};*/

	};



	public ref class Class1
	{
		// TODO: Add your methods for this class here.
	};
}
