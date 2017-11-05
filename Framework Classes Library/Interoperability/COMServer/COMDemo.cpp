// COMDemo.cpp: реализация CCOMDemo

#include "stdafx.h"
#include "COMDemo.h"


// CCOMDemo


STDMETHODIMP CCOMDemo::Greeting(BSTR name, BSTR* message)
{
   CComBSTR tmp("Welcome, ");
   tmp.Append(name);
   *message = tmp;

   return S_OK;
}

STDMETHODIMP CCOMDemo::Add(long val1, long val2, long* result)
{
   *result = val1 + val2;
   return S_OK;
}

HRESULT CCOMDemo::Sub(long val1, long val2, long* result)
{
   *result = val1 - val2;
   return S_OK;
}
