// dllmain.h: объявление класса модуля.

class CCOMServerModule : public ATL::CAtlDllModuleT< CCOMServerModule >
{
public :
	DECLARE_LIBID(LIBID_COMServerLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_COMSERVER, "{99755F9E-D483-4EC9-B3A4-9719B29F4C12}")
};

extern class CCOMServerModule _AtlModule;
