// �߼���CCCM5_Runtime1_DataԴ�ļ�
// ���ļ�����L3���ɿ��������Զ����ɣ���û�г���˽Ȿ�ļ�������ǰ���벻Ҫ�����޸ı��ļ��е�����
// ������ܴ������غ����

#include "StdAfx.h"
#include "_CCCM5_Runtime1_Data.h"

IMPLEMENT_L3CLASS(CCCM5_Runtime1_Data,CL3Object,1)

BEGIN_L3PROPTABLE(CCCM5_Runtime1_Data,CL3Object)
	L3PROP_STRING(CCMID)
	L3PROP_STRING(TreatNo)
	L3PROP_STRING(HeatID)
	L3PROP_LONG(Catch_Count)
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
	L3PROP_DOUBLE(Flow_Cool_Wdh_1stSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_2ndSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_3rdSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_4thSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_5thSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_1stSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_2ndSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_3rdSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_4thSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_5thSect_1ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_1stSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_2ndSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_3rdSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_4thSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_5thSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_1stSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_2ndSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_3rdSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_4thSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_5thSect_2ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_1stSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_2ndSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_3rdSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_4thSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_5thSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_1stSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_2ndSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_3rdSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_4thSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_5thSect_3ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_1stSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_2ndSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_3rdSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_4thSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Wdh_5thSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_1stSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_2ndSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_3rdSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_4thSect_4ST)
	L3PROP_DOUBLE(Flow_Cool_Nrw_5thSect_4ST)
	L3PROP_DOUBLE(Flow_Cooling)
	L3PROP_LONG(Temp_Out_Mold_1ST)
	L3PROP_LONG(Temp_Out_Mold_2ST)
	L3PROP_LONG(Temp_Out_Mold_3ST)
	L3PROP_LONG(Temp_Out_Mold_4ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_1ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_2ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_3ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_4ST)
	L3PROP_LONG(Flow_Cool_Wdh_1ST)
	L3PROP_LONG(Flow_Cool_Wdh_2ST)
	L3PROP_LONG(Flow_Cool_Wdh_3ST)
	L3PROP_LONG(Flow_Cool_Wdh_4ST)
	L3PROP_LONG(Flow_Cool_Nrw_1ST)
	L3PROP_LONG(Flow_Cool_Nrw_2ST)
	L3PROP_LONG(Flow_Cool_Nrw_3ST)
	L3PROP_LONG(Flow_Cool_Nrw_4ST)
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
	L3PROP_DATETIME(LogTime)
	L3PROP_LONG(Temp_In_Mold_12ST)
	L3PROP_LONG(Temp_In_Mold_34ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_N_1ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_N_2ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_N_3ST)
	L3PROP_DOUBLE(Temp_Dif_Mold_N_4ST)
	L3PROP_DOUBLE(Pressure_Cooling)
END_L3PROPTABLE(CCCM5_Runtime1_Data)

BEGIN_L3METHODMAP(CCCM5_Runtime1_Data,CL3Object)
END_L3METHODMAP()

BEGIN_L3EVENTSINK_MAP(CCCM5_Runtime1_Data,CL3Object)
END_L3EVENTSINK_MAP(CCCM5_Runtime1_Data)

CCCM5_Runtime1_Data::CCCM5_Runtime1_Data(void)
{
}

CCCM5_Runtime1_Data::~CCCM5_Runtime1_Data(void)
{
}