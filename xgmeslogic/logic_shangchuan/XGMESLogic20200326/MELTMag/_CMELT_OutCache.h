// 逻辑类CMELT_OutCache头文件
// 本文件是由L3集成开发环境自动生成，在没有充分了解本文件的内容前，请不要随意修改本文件中的内容
// 否则可能带来严重后果。
#pragma once

class CMELT_OutCache :
	public CL3Object
{
public:
	CMELT_OutCache(void);
	virtual ~CMELT_OutCache(void);

	DECLARE_L3CLASS(CMELT_OutCache,XGMESLogic\\MELTMag, GUID)
	DECLARE_L3PROPTABLE()
	DECLARE_L3METHODMAP(CMELT_OutCache)
	DECLARE_L3EVENTSINK_MAP()

	//当对象被装载到系统中时，被调用
	virtual void OnLoaded();
	//当对象被卸载时，被调用
	virtual void OnUnloaded();

};
