// �߼���CCCM_Runtime_DataԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CCCM_Runtime_Data.h"

IMPLEMENT_L3CLASS(CCCM_Runtime_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CCCM_Runtime_Data,CL3Object)
	L3PROP_STRING(CCMID)
	L3PROP_STRING(TreatNo)
	L3PROP_STRING(HeatID)
	L3PROP_LONG(Cooling_MeterNo)
	L3PROP_LONG(Oscillate_MeterNo)
	L3PROP_DOUBLE(Flow_BlowAr_ProtectCasting)
	L3PROP_DOUBLE(Flow_BlowAr_PlugBar_1ST)
	L3PROP_DOUBLE(Flow_BlowAr_PlugBar_2ST)
	L3PROP_DOUBLE(Flow_BlowAr_PlugBar_3ST)
	L3PROP_DOUBLE(Flow_BlowAr_PlugBar_4ST)
	L3PROP_DOUBLE(Position_Act_PlugBar_1ST)
	L3PROP_DOUBLE(Position_Act_PlugBar_2ST)
	L3PROP_DOUBLE(Position_Act_PlugBar_3ST)
	L3PROP_DOUBLE(Position_Act_PlugBar_4ST)
	L3PROP_DOUBLE(Position_Init_PlugBar_1ST)
	L3PROP_DOUBLE(Position_Init_PlugBar_2ST)
	L3PROP_DOUBLE(Position_Init_PlugBar_3ST)
	L3PROP_DOUBLE(Position_Init_PlugBar_4ST)
	L3PROP_DOUBLE(Level_Act_Mold_1ST)
	L3PROP_DOUBLE(Level_Act_Mold_2ST)
	L3PROP_DOUBLE(Level_Act_Mold_3ST)
	L3PROP_DOUBLE(Level_Act_Mold_4ST)
	L3PROP_LONG(Temp_In_Cooling)
	L3PROP_DOUBLE(Flow_Cooling_1stSect_1ST)
	L3PROP_DOUBLE(Flow_Cooling_2ndSect_1ST)
	L3PROP_DOUBLE(Flow_Cooling_3rdSect_1ST)
	L3PROP_DOUBLE(Flow_Cooling_4thSect_1ST)
	L3PROP_DOUBLE(Flow_Cooling_1stSect_2ST)
	L3PROP_DOUBLE(Flow_Cooling_2ndSect_2ST)
	L3PROP_DOUBLE(Flow_Cooling_3rdSect_2ST)
	L3PROP_DOUBLE(Flow_Cooling_4thSect_2ST)
	L3PROP_DOUBLE(Flow_Cooling_1stSect_3ST)
	L3PROP_DOUBLE(Flow_Cooling_2ndSect_3ST)
	L3PROP_DOUBLE(Flow_Cooling_3rdSect_3ST)
	L3PROP_DOUBLE(Flow_Cooling_4thSect_3ST)
	L3PROP_DOUBLE(Flow_Cooling_1stSect_4ST)
	L3PROP_DOUBLE(Flow_Cooling_2ndSect_4ST)
	L3PROP_DOUBLE(Flow_Cooling_3rdSect_4ST)
	L3PROP_DOUBLE(Flow_Cooling_4thSect_4ST)
	L3PROP_DOUBLE(Flow_Cooling)
	L3PROP_LONG(Temp_Out_Mold_1ST)
	L3PROP_LONG(Temp_Out_Mold_2ST)
	L3PROP_LONG(Temp_Out_Mold_3ST)
	L3PROP_LONG(Temp_Out_Mold_4ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_1ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_2ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_3ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_4ST)
	L3PROP_DOUBLE(Freq_Setup_1ST)
	L3PROP_DOUBLE(Freq_Setup_2ST)
	L3PROP_DOUBLE(Freq_Setup_3ST)
	L3PROP_DOUBLE(Freq_Setup_4ST)
	L3PROP_DOUBLE(Freq_Act_1ST)
	L3PROP_DOUBLE(Freq_Act_2ST)
	L3PROP_DOUBLE(Freq_Act_3ST)
	L3PROP_DOUBLE(Freq_Act_4ST)
	L3PROP_DOUBLE(Ampl_Setup_1ST)
	L3PROP_DOUBLE(Ampl_Setup_2ST)
	L3PROP_DOUBLE(Ampl_Setup_3ST)
	L3PROP_DOUBLE(Ampl_Setup_4ST)
	L3PROP_DOUBLE(Ampl_Act_1ST)
	L3PROP_DOUBLE(Ampl_Act_2ST)
	L3PROP_DOUBLE(Ampl_Act_3ST)
	L3PROP_DOUBLE(Ampl_Act_4ST)
	L3PROP_LONG(Temp_In_ElectMix)
	L3PROP_LONG(Temp_Out_ElectMix_1ST)
	L3PROP_LONG(Temp_Out_ElectMix_2ST)
	L3PROP_LONG(Temp_Out_ElectMix_3ST)
	L3PROP_LONG(Temp_Out_ElectMix_4ST)
	L3PROP_DOUBLE(Temp_Def_ElectMix_1ST)
	L3PROP_DOUBLE(Temp_Def_ElectMix_2ST)
	L3PROP_DOUBLE(Temp_Def_ElectMix_3ST)
	L3PROP_DOUBLE(Temp_Def_ElectMix_4ST)
	L3PROP_DOUBLE(Current_Setup_ElectMix_1ST)
	L3PROP_DOUBLE(Current_Setup_ElectMix_2ST)
	L3PROP_DOUBLE(Current_Setup_ElectMix_3ST)
	L3PROP_DOUBLE(Current_Setup_ElectMix_4ST)
	L3PROP_DOUBLE(Current_Act_ElectMix_1ST)
	L3PROP_DOUBLE(Current_Act_ElectMix_2ST)
	L3PROP_DOUBLE(Current_Act_ElectMix_3ST)
	L3PROP_DOUBLE(Current_Act_ElectMix_4ST)
	L3PROP_DOUBLE(Freq_Setup_ElectMix_1ST)
	L3PROP_DOUBLE(Freq_Setup_ElectMix_2ST)
	L3PROP_DOUBLE(Freq_Setup_ElectMix_3ST)
	L3PROP_DOUBLE(Freq_Setup_ElectMix_4ST)
	L3PROP_DOUBLE(Freq_Act_ElectMix_1ST)
	L3PROP_DOUBLE(Freq_Act_ElectMix_2ST)
	L3PROP_DOUBLE(Freq_Act_ElectMix_3ST)
	L3PROP_DOUBLE(Freq_Act_ElectMix_4ST)
	L3PROP_LONG(Direction_ElectMix_1ST)
	L3PROP_LONG(Direction_ElectMix_2ST)
	L3PROP_LONG(Direction_ElectMix_3ST)
	L3PROP_LONG(Direction_ElectMix_4ST)
	L3PROP_DOUBLE(Pressure_Oxygen_Cut)
	L3PROP_DOUBLE(Pressure_Oxygen_PreHeat)
	L3PROP_DOUBLE(Pressure_CokeGas)
	L3PROP_LONG(Catch_Count)
	L3PROP_DATETIME(LogTime)
	L3PROP_LONG(Auto_Level_1ST)
	L3PROP_LONG(Auto_Level_2ST)
	L3PROP_LONG(Auto_Level_3ST)
	L3PROP_LONG(Auto_Level_4ST)
	L3PROP_LONG(Mode_Cooling_1ST)
	L3PROP_LONG(Mode_Cooling_2ST)
	L3PROP_LONG(Mode_Cooling_3ST)
	L3PROP_LONG(Mode_Cooling_4ST)
	L3PROP_DOUBLE(Flow_Out_Mold_1ST)
	L3PROP_DOUBLE(Flow_Out_Mold_2ST)
	L3PROP_DOUBLE(Flow_Out_Mold_3ST)
	L3PROP_DOUBLE(Flow_Out_Mold_4ST)
    L3PROP_LONG(Temp_In_Mold)
	L3PROP_LONG(C_Setup_End_ElectMix_1ST)//2009-05-09
	L3PROP_LONG(C_Setup_End_ElectMix_2ST)//2009-05-09
	L3PROP_LONG(C_Setup_End_ElectMix_3ST)//2009-05-09
	L3PROP_LONG(C_Setup_End_ElectMix_4ST)//2009-05-09
	L3PROP_LONG(C_Act_End_ElectMix_1ST)//2009-05-09
	L3PROP_LONG(C_Act_End_ElectMix_2ST)//2009-05-09
	L3PROP_LONG(C_Act_End_ElectMix_3ST)//2009-05-09
	L3PROP_LONG(C_Act_End_ElectMix_4ST)//2009-05-09
	L3PROP_DOUBLE(F_Setup_End_ElectMix_1ST)//2009-05-09
	L3PROP_DOUBLE(F_Setup_End_ElectMix_2ST)//2009-05-09
	L3PROP_DOUBLE(F_Setup_End_ElectMix_3ST)//2009-05-09
	L3PROP_DOUBLE(F_Setup_End_ElectMix_4ST)//2009-05-09
	L3PROP_DOUBLE(F_Act_End_ElectMix_1ST)//2009-05-09
	L3PROP_DOUBLE(F_Act_End_ElectMix_2ST)//2009-05-09
	L3PROP_DOUBLE(F_Act_End_ElectMix_3ST)//2009-05-09
	L3PROP_DOUBLE(F_Act_End_ElectMix_4ST)//2009-05-09
	L3PROP_LONG(D_Act_End_ElectMix_1ST)//2009-05-09
	L3PROP_LONG(D_Act_End_ElectMix_2ST)//2009-05-09
	L3PROP_LONG(D_Act_End_ElectMix_3ST)//2009-05-09
	L3PROP_LONG(D_Act_End_ElectMix_4ST)//2009-05-09
END_L3PROPTABLE(CCCM_Runtime_Data)

BEGIN_L3METHODMAP(CCCM_Runtime_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CCCM_Runtime_Data,CL3Object)
END_L3EVENTSINK_MAP(CCCM_Runtime_Data)

CCCM_Runtime_Data::CCCM_Runtime_Data(void)
{
}

CCCM_Runtime_Data::~CCCM_Runtime_Data(void)
{
}