using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Diagnostics;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace CommDataMag
{
    //ͨ�����ݶ���
    public class CommonData
    {
        //�Զ�����ɫ
        public const String Color_Code_Control = "Control";//ϵͳ��ɫ
        public const String Color_Code_Red = "Red";//ϵͳ��
        public const String Color_Code_Orange = "Orange";//ϵͳ��
        public const String Color_Code_Yellow = "Yellow";//ϵͳ��
        public const String Color_Code_Green = "Green";//ϵͳ��
        public const String Color_Code_Blue = "Blue";//ϵͳ��
        public const String Color_Code_OrangeRed = "OrangeRed ";
        public const String Color_Code_SteelBlue = "SteelBlue";//
        public const String Color_Code_Pink = "Pink";//
        public const String Color_Code_Sienna = "Color_Code_Sienna";//

        /// <summary>
        /// objUri: ��ǰ��ΰ���� "XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101"
        /// </summary>
        public const String CCURRENT_SHIFT_INFO_OBJ = "XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101";
        /// <summary>
        /// objUri: ����¯������ "XGMESLogic\\MIXFMag\\CMIF_Unit_Mag\\"
        /// </summary>
        public const string MIF_CLASS_URI = "XGMESLogic\\MIXFMag\\CMIF_Unit_Mag\\";

        /// <summary>
        /// objUri: ת¯������ "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\"
        /// </summary>
        public const string BOF_CLASS_URI = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\";

        /// <summary>
        /// objUri: ת¯������ "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\"
        /// </summary>
        public const string MELT_CLASS_URI = "XGMESLogic\\MELTMag\\CMELT_Unit_Mag\\";
        /// <summary>
        /// objUri: ¯������� "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\"
        /// </summary>
        public const string BOF_SIDE_CLASS_URI = "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\";
        /// <summary>
        /// objUri: LF¯������ "XGMESLogic\\LFMag\\CLF_Unit_Mag\\"
        /// </summary>
        public const string LF_CLASS_URI = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\";
        /// <summary>
        /// objUri: RH¯������ "XGMESLogic\\RHMag\\CRH_Unit_Mag\\"
        /// </summary>
        public const string RH_CLASS_URI = "XGMESLogic\\RHMag\\CRH_Unit_Mag\\";
        /// <summary>
        /// objUri: ���������� "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\"
        /// </summary>
        public const string CCM_CLASS_URI = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\";
        /// <summary>
        /// objUri: LF¯��λ�� "XGMESLogic\\LFMag\\CLF_Prod_Area\\"
        /// </summary>
        public const string LF_CLASS_AREA_URI = "XGMESLogic\\LFMag\\CLF_Prod_Area\\";
        /// <summary>
        /// objUri: RH¯��λ�� "XGMESLogic\\RHMag\\CRH_Prod_Area\\"
        /// </summary>
        public const string RH_CLASS_AREA_URI = "XGMESLogic\\RHMag\\CRH_Prod_Area\\";
        /// <summary>
        /// objUri: LF¯���������� "XGMESLogic\\LFMag\\CLF_Base_Data"
        /// </summary>
        public const string LF_BASE_DATA_URI = "XGMESLogic\\LFMag\\CLF_Base_Data";
        /// <summary>
        /// objUri: RH¯���������� "XGMESLogic\\RHMag\\CRH_Base_Data"
        /// </summary>
        public const string RH_BASE_DATA_URI = "XGMESLogic\\RHMag\\CRH_Base_Data";
        /// <summary>
        /// objUri: �������������� "XGMESLogic\\CCMMag\\CCCM_Base_Data\\"
        /// </summary>
        public const string CCM_BASE_DATA_URI = "XGMESLogic\\CCMMag\\CCCM_Base_Data\\";
        /// <summary>
        /// objUri: �������̴��������� "XGMESLogic\\CCMMag\\CCCM_Process_Data\\"
        /// </summary>
        public const string CCM_PROCESS_DATA_URI = "XGMESLogic\\CCMMag\\CCCM_Process_Data\\";

        //�������
        /// <summary>
        /// �������: 1#����¯ S11
        /// </summary>
        public const String MIF_UNIT_01ID = "S11";
        /// <summary>
        /// �������: 2#����¯ S12
        /// </summary>
        public const String MIF_UNIT_02ID = "S12";

        //add by hyh 2012-03-29
        /// <summary>
        /// �������: 3#����¯ S12
        /// </summary>
        public const String MIF_UNIT_03ID = "S13";
        //end

        /// <summary>
        /// �������: 1#ת¯ S21
        /// </summary>
        public const String BOF_UNIT_01ID = "S21";
        /// <summary>
        /// �������: 2#ת¯ S22
        /// </summary>
        public const String BOF_UNIT_02ID = "S22";
        /// <summary>
        /// �������: 3#ת¯ S23
        /// </summary>
        public const String BOF_UNIT_03ID = "S23";
        /// <summary>
        /// �������: 4#ת¯ S24
        /// </summary>
        public const String BOF_UNIT_04ID = "S24";
        /// �������: 5#ת¯ S25
        /// </summary>
        public const String BOF_UNIT_05ID = "S25";

        /// <summary>
        /// �������: 1#ת¯¯�� S31
        /// </summary>
        public const String TAP_UNIT_01ID = "S31";
        /// <summary>
        /// �������: 2#ת¯¯�� S32
        /// </summary>
        public const String TAP_UNIT_02ID = "S32";
        /// <summary>
        /// �������: 3#ת¯¯�� S33
        /// </summary>
        public const String TAP_UNIT_03ID = "S33";
        /// <summary>
        /// �������: 4#ת¯¯�� S34
        /// </summary>
        public const String TAP_UNIT_04ID = "S34";

        /// <summary>
        /// �������: 1#LF¯ S41
        /// </summary>
        public const String LF_UNIT_01ID = "S41";
        /// <summary>
        /// �������: 2#LF¯ S42
        /// </summary>
        public const String LF_UNIT_02ID = "S42";
        /// <summary>
        /// �������: 3#LF¯ S43
        /// </summary>
        public const String LF_UNIT_03ID = "S43";

        /// <summary>
        /// �������: 1#RH¯ S51
        /// </summary>
        public const String RH_UNIT_01ID = "S51";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (�½�5#LF¯)***********/
        /// <summary>
        /// �������: 5#LF¯ S45
        /// </summary>
        public const String LF_UNIT_05ID = "S45";
        // const �ؼ��������޸��ֶλ�ֲ���������������ָ���ֶλ�ֲ�������ֵ�ǳ��������ܱ��޸ġ�
        /*************END***************/

        //add by hyh 2012-05-09  ����4#LF
        /// <summary>
        /// �������: 4#LF¯ S44
        /// </summary>
        public const String LF_UNIT_04ID = "S44";

        /// <summary>
        /// �������: 1#���� S61
        /// </summary>
        public const String CCM_UNIT_01ID = "S61";
        /// <summary>
        /// �������: 2#���� S62
        /// </summary>
        public const String CCM_UNIT_02ID = "S62";
        /// <summary>
        /// �������: 3#���� S63
        /// </summary>
        public const String CCM_UNIT_03ID = "S63";
        /// <summary>
        /// �������: 4#���� S64
        /// </summary>
        public const String CCM_UNIT_04ID = "S64";
        /// <summary>
        /// �������: 5#���� S65
        /// </summary>
        public const String CCM_UNIT_05ID = "S65";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (�½�7#������)***********/
        /// <summary>
        /// �������: 7#���� S67
        /// </summary>
        public const String CCM_UNIT_07ID = "S67";
        /*************END***************/

        /*************Modfiy Begin at 2012-5-15 By hyh (�½�6#������)***********/
        /// <summary>
        /// �������: 6#���� S66
        /// </summary>
        public const String CCM_UNIT_06ID = "S66";
        /*************END***************/


        //  [12/29/2008 sun]
        /// <summary>
        /// ��װ�Ͻ�ѷŴ�: 1#LF S81Z02
        /// </summary>
        public const String CLF01_GROUND_ALLOY_POSSITION = "S81Z02";
        /// <summary>
        /// ��װ�Ͻ�ѷŴ�: 3#LFRH S81Z04
        /// </summary>
        public const String CLF03RH_GROUND_ALLOY_POSSITION = "S81Z04";
        /// <summary>
        /// ��װ�Ͻ�ѷŴ�: 2#LF S81Z03
        /// </summary>
        public const String CLF02_GROUND_ALLOY_POSSITION = "S81Z03";
        /// <summary>
        /// ��װ�Ͻ�ѷŴ�: ת¯ S81Z01
        /// </summary>
        public const String CBOF_GROUND_ALLOY_POSSITION = "S81Z01";

        //����ȡ���ص�����
        /// <summary>
        /// ȡ���ص�����: ����¯ȡ��H
        /// </summary>
        public const String MIF_SAMPLE_TYPE = "H";
        /// <summary>
        /// ȡ���ص�����: �����ˮȡ��T
        /// </summary>
        public const String IRON_SAMPLE_TYPE = "T";
        /// <summary>
        /// ȡ���ص�����: ת¯ȡ��Z
        /// </summary>
        public const String BOF_SAMPLE_TYPE = "Z";
        /// <summary>
        /// ȡ���ص�����: LF¯ȡ��F
        /// </summary>
        public const String LF_SAMPLE_TYPE = "F";
        /// <summary>
        /// ȡ���ص�����: RH¯ȡ��R
        /// </summary>
        public const String RH_SAMPLE_TYPE = "R";
        /// <summary>
        /// ȡ���ص�����: ����ȡ��C
        /// </summary>
        public const String CCM_SAMPLE_TYPE = "C";

        //�����������QA_Sample_Type
        /// <summary>
        /// �����������: ��¯��ˮ����ZG
        /// </summary>
        public const String QA_Sample_Type_ZG = "ZG";
        /// <summary>
        /// �����������: ������[����û����]TS
        /// </summary>
        public const String QA_Sample_Type_TS = "TS";
        /// <summary>
        /// �����������: �����ˮ��TC
        /// </summary>
        public const String QA_Sample_Type_TC = "TC";
        /// <summary>
        /// �����������: ����¯ȫ������TA
        /// </summary>
        public const String QA_Sample_Type_TA = "TA";
        /// <summary>
        /// �����������: ת¯������TL
        /// </summary>
        public const String QA_Sample_Type_TL = "TL";
        /// <summary>
        /// �����������: ����¯��TH
        /// </summary>
        public const String QA_Sample_Type_TH = "TH";
        /// <summary>
        /// �����������: LF������ZF
        /// </summary>
        public const String QA_Sample_Type_ZF = "ZF";
        /// <summary>
        /// �����������: RH������ZR
        /// </summary>
        public const String QA_Sample_Type_ZR = "ZR";
        /// <summary>
        /// �����������: �����а�����ZL
        /// </summary>
        public const String QA_Sample_Type_ZL = "ZL";
        /// <summary>
        /// �����������: ת¯����ZZ
        /// </summary>
        public const String QA_Sample_Type_ZZ = "ZZ";
        /// <summary>
        /// �����������: �����а���GL
        /// </summary>
        public const String QA_Sample_Type_GL = "GL";
        /// <summary>
        /// �����������: ¯����GZ
        /// </summary>
        public const String QA_Sample_Type_GZ = "GZ";
        /// <summary>
        /// �����������: ������GN
        /// </summary>
        public const String QA_Sample_Type_GN = "GN";
        /// <summary>
        /// �����������: ������GG
        /// </summary>
        public const String QA_Sample_Type_GG = "GG";
        /// <summary>
        /// �����������: ��Ʒ��GP
        /// </summary>
        public const String QA_Sample_Type_GP = "GP";
        /// <summary>
        /// �����������: ����GE
        /// </summary>
        public const String QA_Sample_Type_GE = "GE";
        /// <summary>
        /// �����������: ������GQ
        /// </summary>
        public const String QA_Sample_Type_GQ = "GQ";
        /// <summary>
        /// �����������: �����ͱ���GD
        /// </summary>
        public const String QA_Sample_Type_GD = "GD";

        //���������ص�
        /// <summary>
        /// ���������ص�: 1#��¯	G1
        /// </summary>
        public const String QA_Sample_Addr_G1 = "G1";
        /// <summary>
        /// ���������ص�: 2#��¯	G2
        /// </summary>
        public const String QA_Sample_Addr_G2 = "G2";
        /// <summary>
        /// ���������ص�: 3#��¯	G3
        /// </summary>
        public const String QA_Sample_Addr_G3 = "G3";
        /// <summary>
        /// ���������ص�: 4#��¯	G4
        /// </summary>
        public const String QA_Sample_Addr_G4 = "G4";
        /// <summary>
        /// ���������ص�: 5#��¯	G5
        /// </summary>
        public const String QA_Sample_Addr_G5 = "G5";
        /// <summary>
        /// ���������ص�: 1#����¯	H1
        /// </summary>
        public const String QA_Sample_Addr_H1 = "H1";
        /// <summary>
        /// ���������ص�: 2#����¯  H2
        /// </summary>
        public const String QA_Sample_Addr_H2 = "H2";

        //add by hyh 2012-03-29
        /// <summary>
        /// ���������ص�: 3#����¯  H3
        /// </summary>
        public const String QA_Sample_Addr_H3 = "H3";
        //end
        /// <summary>
        /// ���������ص�: ����TB
        /// </summary>	
        public const String QA_Sample_Addr_TB = "TB";
        /// <summary>
        /// ���������ص�: ����TC
        /// </summary>
        public const String QA_Sample_Addr_TC = "TC";
        /// <summary>
        /// ���������ص�: ת¯��ˮ����TL
        /// </summary>
        public const String QA_Sample_Addr_TL = "TL";
        /// <summary>
        /// ���������ص�: 1#ת¯Z1
        /// </summary>
        public const String QA_Sample_Addr_Z1 = "Z1";
        /// <summary>
        /// ���������ص�: 2#ת¯Z2
        /// </summary>	
        public const String QA_Sample_Addr_Z2 = "Z2";
        /// <summary>
        /// ���������ص�: 3#ת¯Z3
        /// </summary>	
        public const String QA_Sample_Addr_Z3 = "Z3";
        /// <summary>
        /// ���������ص�: 4#ת¯Z4
        /// </summary>	
        public const String QA_Sample_Addr_Z4 = "Z4";

        /// ���������ص�: 5#ת¯Z5
        /// </summary>	
        public const String QA_Sample_Addr_Z5 = "Z5";
        /// <summary>
        /// ���������ص�: 1#LF¯F1
        /// </summary>	
        public const String QA_Sample_Addr_F1 = "F1";
        /// <summary>
        /// ���������ص�: 2#LF¯F2
        /// </summary>	
        public const String QA_Sample_Addr_F2 = "F2";
        /// <summary>
        /// ���������ص�: 3#LF¯F3
        /// </summary>	
        public const String QA_Sample_Addr_F3 = "F3";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (�½�5#LF¯)***********/
        /// <summary>
        /// ���������ص�: 5#LF¯F5
        /// </summary>	
        public const String QA_Sample_Addr_F5 = "F5";
        /*********END********/

        /*************Modfiy Begin at 2012-05-15 By hyh (�½�4#LF¯)***********/
        /// <summary>
        /// ���������ص�: 4#LF¯F4
        /// </summary>	
        public const String QA_Sample_Addr_F4 = "F4";
        /*********END********/


        /// <summary>
        /// ���������ص�: 1RH¯R1
        /// </summary>	
        public const String QA_Sample_Addr_R1 = "R1";
        /// <summary>
        /// ���������ص�: 1#����C1
        /// </summary>
        public const String QA_Sample_Addr_C1 = "C1";
        /// <summary>
        /// ���������ص�: 2#����C2
        /// </summary>	
        public const String QA_Sample_Addr_C2 = "C2";
        /// <summary>
        /// ���������ص�: 3#����C3
        /// </summary>	
        public const String QA_Sample_Addr_C3 = "C3";
        /// <summary>
        /// ���������ص�: 4#����C4
        /// </summary>	
        public const String QA_Sample_Addr_C4 = "C4";
        /// <summary>
        /// ���������ص�: 5#����C5
        /// </summary>	
        public const String QA_Sample_Addr_C5 = "C5";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (�½�7#CCM¯)***********/
        /// <summary>
        /// ���������ص�: 7#����C7
        /// </summary>	
        public const String QA_Sample_Addr_C7 = "C7";
        /*********END**********/


        /*************Modfiy Begin at 2012-05-15 By hyh (�½�6#CCM¯)***********/
        /// <summary>
        /// ���������ص�: 6#����C6
        /// </summary>	
        public const String QA_Sample_Addr_C6 = "C6";
        /*********END**********/


        //��������ԭ��
        /// <summary>
        /// ��������ԭ��: 01:����ճ������,����ճ��
        /// </summary>
        public const String CIRONLADLE_STOPREASON_DREG = "01";
        /// <summary>
        /// ��������ԭ��: 02:���ڻ�����¶ȹ���
        /// </summary>
        public const String CIRONLADLE_STOPREASON_TEMP = "02";

        //����״̬
        /// <summary>
        /// ����״̬: ���01
        /// </summary>
        public const String CIRONLADLE_STATUS_TIE = "01";
        /// <summary>
        /// ����״̬: �䱸(��)02
        /// </summary>
        public const String CIRONLADLE_STATUS_COLD = "02";
        /// <summary>
        /// ����״̬: С��03
        /// </summary>
        public const String CIRONLADLE_STATUS_SMALL_FIRE = "03";
        /// <summary>
        /// ����״̬: �л�04
        /// </summary>
        public const String CIRONLADLE_STATUS_MIDDLE_FIRE = "04";
        /// <summary>
        /// ����״̬: ���05
        /// </summary>
        public const String CIRONLADLE_STATUS_BIG_FIRE = "05";
        /// <summary>
        /// ����״̬: �ȱ�(��)06
        /// </summary>
        public const String CIRONLADLE_STATUS_HOT = "06";
        /// <summary>
        /// ����״̬: �ѷ���07
        /// </summary>
        public const String CIRONLADLE_STATUS_DISTRIBUTE = "07";
        /// <summary>
        /// ����״̬: ʹ��08
        /// </summary>
        public const String CIRONLADLE_STATUS_USE = "08";
        /// <summary>
        /// ����״̬: ͣ��09
        /// </summary>
        public const String CIRONLADLE_STATUS_SUSPEND = "09";
        /// <summary>
        /// ����״̬: ���ߴ���(��)10
        /// </summary>
        public const String CIRONLADLE_STATUS_OFFLINE = "10";


        //�а�״̬
        /// <summary>
        /// �а�״̬: ���ò�����01
        /// </summary>
        public const String CTUNDISH_STATUS_INNER_BUILD = "01";
        /// <summary>
        /// �а�״̬: ���ò�濾02
        /// </summary>
        public const String CTUNDISH_STATUS_INNER_FIRE = "02";
        /// <summary>
        /// �а�״̬: ����������(���)03
        /// </summary>
        public const String CTUNDISH_STATUS_WORK_DAUB = "03";
        /// <summary>
        /// �а�״̬: ������濾04
        /// </summary>
        public const String CTUNDISH_STATUS_WORK_FIRE = "04";
        /// <summary>
        /// �а�״̬: �䱸05
        /// </summary>
        public const String CTUNDISH_STATUS_COLD = "05";
        /// <summary>
        /// �а�״̬: �а��ϼ�06
        /// </summary>
        public const String CTUNDISH_STATUS_ISTALL = "06";
        /// <summary>
        /// �а�״̬: �ȱ��濾07
        /// </summary>
        public const String CTUNDISH_STATUS_HOT_FIRE = "07";
        /// <summary>
        /// �а�״̬: �ȱ�08
        /// </summary>
        public const String CTUNDISH_STATUS_HOT = "08";
        /// <summary>
        /// �а�״̬: ʹ��(��ת)09
        /// </summary>
        public const String CTUNDISH_STATUS_USE = "09";
        /// <summary>
        /// �а�״̬: ���ߴ���10
        /// </summary>
        public const String CTUNDISH_STATUS_OFFLINE = "10";

        //�ְ�״̬
        /// <summary>
        /// �ְ�״̬: ���ò�����(���)01
        /// </summary>
        public const String CLADLE_STATUS_INNER_BUILD = "01";
        /// <summary>
        /// �ְ�״̬: ���ò�濾02
        /// </summary>
        public const String CLADLE_STATUS_INNER_FIRE = "02";
        /// <summary>
        /// �ְ�״̬: ����������(���)03
        /// </summary>
        public const String CLADLE_STATUS_WORK_DAUB = "03";
        /// <summary>
        /// �ְ�״̬: ������濾04
        /// </summary>
        public const String CLADLE_STATUS_WORK_FIRE = "04";
        /// <summary>
        /// �ְ�״̬: �䱸05
        /// </summary>
        public const String CLADLE_STATUS_COLD = "05";
        /// <summary>
        /// �ְ�״̬: �ȱ��濾06
        /// </summary>
        public const String CLADLE_STATUS_HOT_FIRE = "06";
        /// <summary>
        /// �ְ�״̬: �ȱ�07
        /// </summary>
        public const String CLADLE_STATUS_HOT = "07";
        /// <summary>
        /// �ְ�״̬: ����08
        /// </summary>
        public const String CLADLE_STATUS_DESIGN = "08";
        /// <summary>
        /// �ְ�״̬: ʹ��(��ת)09
        /// </summary>
        public const String CLADLE_STATUS_USE = "09";
        /// <summary>
        /// �ְ�״̬: ���ߴ���10
        /// </summary>
        public const String CLADLE_STATUS_OFFLINE = "10";

        //�ְ�����
        /// <summary>
        /// �ְ�����: 50t����ְ�1
        /// </summary>
        public const String LADLE_TYPE_COM_50 = "1";
        /// <summary>
        /// �ְ�����: 50t�����ְ�2
        /// </summary>
        public const String LADLE_TYPE_FIN_50 = "2";
        /// <summary>
        /// �ְ�����: 80t�����ְ�3
        /// </summary>
        public const String LADLE_TYPE_FIN_80 = "3";

        //�ְ��ƻ�״̬
        /// <summary>
        /// �ְ��ƻ�״̬: δ����01
        /// </summary>
        public const String CLADLE_PLAN_STATUS_UNDESIGN = "01";
        /// <summary>
        /// �ְ��ƻ�״̬: ����02
        /// </summary>
        public const String CLADLE_PLAN_STATUS_DESIGN = "02";
        /// <summary>
        /// �ְ��ƻ�״̬: ִ��03
        /// </summary>
        public const String CLADLE_PLAN_STATUS_EXCUTING = "03";
        /// <summary>
        /// �ְ��ƻ�״̬: ִ�н���04
        /// </summary>
        public const String CLADLE_STATUS_WORK_EXCUTED = "04";

        //�ᾧ��״̬
        /// <summary>
        /// �ᾧ��״̬: ��װ01
        /// </summary>
        public const String CMOLD_STATUS_WAIT = "01";
        /// <summary>
        /// �ᾧ��״̬: װ��02
        /// </summary> 
        public const String CMOLD_STATUS_REPAIR = "02";
        /// <summary>
        /// �ᾧ��״̬: ����03
        /// </summary>
        public const String CMOLD_STATUS_FREE = "03";
        /// <summary>
        /// �ᾧ��״̬: ����04
        /// </summary>
        public const String CMOLD_STATUS_USE = "04";
        /// <summary>
        /// �ᾧ��״̬: ���߼��05
        /// </summary>
        public const String CMOLD_STATUS_OFFLINE = "05";

        //�ᾧ������ߴ�
        /// <summary>
        /// �ᾧ������ߴ�: 6��(��1��2#����)6
        /// </summary>
        public const int MOLD_FACEMEA_A = 6;
        /// <summary>
        /// �ᾧ������ߴ�: 9��(��3��4#����)7
        /// </summary>
        public const int MOLD_FACEMEA_B = 9;
        /// <summary>
        /// �ᾧ������ߴ�: 12��(��5#����)12
        /// </summary>
        public const int MOLD_FACEMEA_C = 12;


        //��ǹ״̬
        /// <summary>
        /// ��ǹ״̬: ����01
        /// </summary>
        public const String CLANCE_STATUS_REPAIR = "01";
        /// <summary>
        /// ��ǹ״̬: ����02
        /// </summary>
        public const String CLANCE_STATUS_FREE = "02";
        /// <summary>
        /// ��ǹ״̬: ʹ��03
        /// </summary>
        public const String CLANCE_STATUS_USE = "03";
        /// <summary>
        /// ��ǹ״̬: ���04
        /// </summary>
        public const String CLANCE_STATUS_CHECK = "04";
        /// <summary>
        /// ��ǹ״̬: ���ߴ���05
        /// </summary>
        public const String CLANCE_STATUS_OFFLINE = "05";

        //��ղ�״̬
        /// <summary>
        /// ��ղ�״̬: ά��01
        /// </summary>
        public const String CVACTUBE_STATUS_REPAIR = "01";
        /// <summary>
        /// ��ղ�״̬: �䱸02
        /// </summary>
        public const String CVACTUBE_STATUS_COLD = "02";
        /// <summary>
        /// ��ղ�״̬: Ԥ��03
        /// </summary>
        public const String CVACTUBE_STATUS_PRE_FIRE = "03";
        /// <summary>
        /// ��ղ�״̬: ���04
        /// </summary>
        public const String CVACTUBE_STATUS_BIG_FIRE = "04";
        /// <summary>
        /// ��ղ�״̬: �ȱ�05
        /// </summary>
        public const String CVACTUBE_STATUS_HOT = "05";
        /// <summary>
        /// ��ղ�״̬: ʹ��06
        /// </summary>
        public const String CVACTUBE_STATUS_USE = "06";
        /// <summary>
        /// ��ղ�״̬: ���߼��07
        /// </summary>
        public const String CVACTUBE_STATUS_CHECK = "07";
        /// <summary>
        /// ��ղ�״̬: ���ߴ���08
        /// </summary>
        public const String CVACTUBE_STATUS_OFFLINE = "08";

        //��ղ�λ��
        /// <summary>
        /// ��ղ�λ��: ����λ1
        /// </summary>
        public const String CVACTUBE_POSITION_BUILD = "1";
        /// <summary>
        /// ��ղ�λ��: A�濾λ2
        /// </summary>
        public const String CVACTUBE_POSITION_FIRE_A = "2";
        /// <summary>
        /// ��ղ�λ��: B�濾λ3
        /// </summary>
        public const String CVACTUBE_POSITION_FIRE_B = "3";
        /// <summary>
        /// ��ղ�λ��: A��λA
        /// </summary>
        public const String CVACTUBE_POSITION_WORK_A = "A";
        /// <summary>
        /// ��ղ�λ��: B��λB
        /// </summary>
        public const String CVACTUBE_POSITION_WORK_B = "B";


        /********************ת¯״ֵ̬��״̬����***************************��2009-03-03��*/
        //����״̬
        /// <summary>
        /// ת¯����״̬: �ȴ�0
        /// </summary>
        public const int BOFWaiting = 0;
        /// <summary>
        /// ת¯����״̬: ����1
        /// </summary>
        public const int BOFFeeding = 1;
        /// <summary>
        /// ת¯����״̬: ����2
        /// </summary>
        public const int BOFBlowing = 2;
        /// <summary>
        /// ת¯����״̬: ����3
        /// </summary>
        public const int BOFReBlowing = 3;
        /// <summary>
        /// ת¯����״̬: ����4
        /// </summary>
        public const int BOFTapping = 4;
        /// <summary>
        /// ת¯����״̬: ���ֽ���5
        /// </summary>
        public const int BOFTapped = 5;
        /// <summary>
        /// ת¯����״̬: ����6
        /// </summary>
        public const int BOFSplash = 6;
        /// <summary>
        /// ת¯����״̬: ����7
        /// </summary>
        public const int BOFDumping = 7;

        //����״̬����
        /// <summary>
        /// ת¯����״̬����: �ȴ�
        /// </summary>
        public const String strBOFWaiting = "�ȴ�";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strBOFFeeding = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strBOFBlowing = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strBOFReBlowing = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strBOFTapping = "����";
        /// <summary>
        /// ת¯����״̬����: ���ֽ���
        /// </summary>
        public const String strBOFTapped = "���ֽ���";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strBOFSplash = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strBOFDumping = "����";


        public const int AODWaiting = 0;
        /// <summary>
        /// ת¯����״̬: ����1
        /// </summary>
        public const int AODFeeding = 1;
        /// <summary>
        /// ת¯����״̬: ����2
        /// </summary>
        public const int AODDec = 2;
        /// <summary>
        /// ת¯����״̬: ����3
        /// </summary>
        public const int AODStartBlowing = 3;
        /// <summary>
        /// ת¯����״̬: ����4
        /// </summary>
        public const int AODStopBlowing = 4;
        /// <summary>
        /// ת¯����״̬: ���ֽ���5
        /// </summary>
        public const int AODReturn = 5;
        /// <summary>
        /// ת¯����״̬: ����6
        /// </summary>
        public const int AODTapping = 6;
        /// <summary>
        /// ת¯����״̬: ����7
        /// </summary>
        public const int AODTapped = 7;


        public const String strAODWaiting = "�ȴ�";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strAODFeeding = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strAODDec = "��̼";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strAODStartBlowing = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strAODStopBlowing = "��������";
        /// <summary>
        /// ת¯����״̬����: ���ֽ���
        /// </summary>
        public const String strAODReturn = "��ԭ";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strAODTapping = "���ֿ�ʼ";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strAODTapped = "���ֽ���";


        //�豸״ֵ̬
        /// <summary>
        /// ת¯�豸״̬: ����0
        /// </summary>
        public const int BOFNormal = 0;
        /// <summary>
        /// ת¯�豸״̬: ����-1
        /// </summary>
        public const int BOFRepair = -1;
        /// <summary>
        /// ת¯�豸״̬: �׹�-2
        /// </summary>
        public const int BOFBushing = -2;
        /// <summary>
        /// ת¯�豸״̬: ��¯-3
        /// </summary>
        public const int BOFMaintain = -3;
        /// <summary>
        /// ת¯�豸״̬: ����-4
        /// </summary>
        public const int BOFFailure = -4;
        /***************************************/

        //�豸״̬����	
        /// <summary>
        /// ת¯�豸״̬����: ����
        /// </summary>
        public const String strBOFNormal = "����";
        /// <summary>
        /// ת¯�豸״̬����: ����
        /// </summary>
        public const String strBOFRepair = "����";
        /// <summary>
        /// ת¯�豸״̬����: �׹�
        /// </summary>
        public const String strBOFBushing = "�׹�";
        /// <summary>
        /// ת¯�豸״̬����: ��¯
        /// </summary>
        public const String strBOFMaintain = "��¯";
        /// <summary>
        /// ת¯�豸״̬����: ����
        /// </summary>
        public const String strBOFFailure = "����";
        /******************************BOF********************************/


        /********************�ۻ�¯״ֵ̬��״̬����***************************��2009-03-03��*/
        //����״̬
        /// <summary>
        /// ת¯����״̬: �ȴ�0
        /// </summary>
        public const int MELTWaiting = 0;
        /// <summary>
        /// ת¯����״̬: ����1
        /// </summary>
        public const int MELTFeeding = 1;
        /// <summary>
        /// ת¯����״̬: ����2
        /// </summary>
        public const int MELTBlowing = 2;
        /// <summary>
        /// ת¯����״̬: ����3
        /// </summary>
        public const int MELTReBlowing = 3;
        /// <summary>
        /// ת¯����״̬: ����4
        /// </summary>
        public const int MELTTapping = 4;
        /// <summary>
        /// ת¯����״̬: ���ֽ���5
        /// </summary>
        public const int MELTTapped = 5;
        /// <summary>
        /// ת¯����״̬: ����6
        /// </summary>
        public const int MELTSplash = 6;
        /// <summary>
        /// ת¯����״̬: ����7
        /// </summary>
        public const int MELTDumping = 7;

        //����״̬����
        /// <summary>
        /// ת¯����״̬����: �ȴ�
        /// </summary>
        public const String strMELTWaiting = "�ȴ�";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strMELTFeeding = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strMELTBlowing = "����";
        /// <summary>
        /// ת¯����״̬����: ��������
        /// </summary>
        public const String strMELTReBlowing = "��������";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strMELTTapping = "����";
        /// <summary>
        /// ת¯����״̬����: ���ֽ���
        /// </summary>
        public const String strMELTTapped = "���ֽ���";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strMELTSplash = "����";
        /// <summary>
        /// ת¯����״̬����: ����
        /// </summary>
        public const String strMELTDumping = "����";


       


        //�豸״ֵ̬
        /// <summary>
        /// ת¯�豸״̬: ����0
        /// </summary>
        public const int MELTNormal = 0;
        /// <summary>
        /// ת¯�豸״̬: ����-1
        /// </summary>
        public const int MELTRepair = -1;
        /// <summary>
        /// ת¯�豸״̬: �׹�-2
        /// </summary>
        public const int MELTBushing = -2;
        /// <summary>
        /// ת¯�豸״̬: ��¯-3
        /// </summary>
        public const int MELTMaintain = -3;
        /// <summary>
        /// ת¯�豸״̬: ����-4
        /// </summary>
        public const int MELTFailure = -4;
        /***************************************/

        //�豸״̬����	
        /// <summary>
        /// ת¯�豸״̬����: ����
        /// </summary>
        public const String strMELTNormal = "����";
        /// <summary>
        /// ת¯�豸״̬����: ����
        /// </summary>
        public const String strMELTRepair = "����";
        /// <summary>
        /// ת¯�豸״̬����: �׹�
        /// </summary>
        public const String strMELTBushing = "�׹�";
        /// <summary>
        /// ת¯�豸״̬����: ��¯
        /// </summary>
        public const String strMELTMaintain = "��¯";
        /// <summary>
        /// ת¯�豸״̬����: ����
        /// </summary>
        public const String strMELTFailure = "����";
        /******************************MELT********************************/

        /************************LF¯״ֵ̬��״̬����***********************/
        // ����״ֵ̬
        /// <summary>
        /// LF¯����״̬: �ȴ�0
        /// </summary>
        public const int LFWaiting = 0;
        /// <summary>
        /// LF¯����״̬: ����ʼ1
        /// </summary>
        public const int LFProcBegin = 1;
        /// <summary>
        /// LF¯����״̬: ��ʼ����2
        /// </summary>
        public const int LFHeatBegin = 2;
        /// <summary>
        /// LF¯����״̬: ���Ƚ���3
        /// </summary>
        public const int LFHeatEnd = 3;
        /// <summary>
        /// LF¯����״̬: �������4
        /// </summary>
        public const int LFProcEnd = 4;
        /// <summary>
        /// LF¯����״̬: ����ʼ5
        /// </summary>
        public const int LFBlowBegin = 5;
        /// <summary>
        /// LF¯����״̬: ������6
        /// </summary>
        public const int LFBlowEnd = 6;

        // ����״̬����
        /// <summary>
        /// LF¯����״̬����: �ȴ�
        /// </summary>
        public const String strLFWaiting = "�ȴ�";
        /// <summary>
        /// LF¯����״̬����: ����ʼ
        /// </summary>
        public const String strLFProcBegin = "����ʼ";
        /// <summary>
        /// LF¯����״̬����: ��ʼ����
        /// </summary>
        public const String strLFHeatBegin = "��ʼ����";
        /// <summary>
        /// LF¯����״̬����: ���Ƚ���
        /// </summary>
        public const String strLFHeatEnd = "���Ƚ���";
        /// <summary>
        /// LF¯����״̬����: �������
        /// </summary>
        public const String strLFProcEnd = "�������";
        /// <summary>
        /// LF¯����״̬����: ����ʼ
        /// </summary>
        public const String strLFBlowBegin = "����ʼ";
        /// <summary>
        /// LF¯����״̬����: ������
        /// </summary>
        public const String strLFBlowEnd = "������";

        // �豸״ֵ̬     
        /// <summary>
        /// LF¯�豸״ֵ̬: ����0
        /// </summary>
        public const int LFNormal = 0;
        /// <summary>
        /// LF¯�豸״ֵ̬: ����-1
        /// </summary>
        public const int LFRepair = -1;
        /// <summary>
        /// LF¯�豸״ֵ̬: �׹�-2
        /// </summary>
        public const int LFBushing = -2;
        /// <summary>
        /// LF¯�豸״ֵ̬: ��¯-3
        /// </summary>
        public const int LFMaintain = -3;
        /// <summary>
        /// LF¯�豸״ֵ̬: ����-4
        /// </summary>
        public const int LFFailure = -4;
        /********************/
        // �豸״̬����     
        /// <summary>
        /// LF¯�豸״̬����: ����
        /// </summary>
        public const String strLFNormal = "����";
        /// <summary>
        /// LF¯�豸״̬����: ����
        /// </summary>
        public const String strLFRepair = "����";
        /// <summary>
        /// LF¯�豸״̬����: �׹�
        /// </summary>
        public const String strLFBushing = "�׹�";
        /// <summary>
        /// LF¯�豸״̬����: ��¯
        /// </summary>
        public const String strLFMaintain = "��¯";
        /// <summary>
        /// LF¯�豸״̬����: ����
        /// </summary>
        public const String strLFFailure = "����";
        /****************************LF*************************************/

        /************************RH¯״ֵ̬��״̬����***********************/
        // ����״ֵ̬
        /// <summary>
        /// RH¯����״ֵ̬: �ȴ�0
        /// </summary>
        public const int RHWaiting = 0;
        /// <summary>
        /// RH¯����״ֵ̬: ����ʼ1
        /// </summary>
        public const int RHProcBegin = 1;
        /// <summary>
        /// RH¯����״ֵ̬: ��ʼ��մ���2
        /// </summary>
        public const int RHVacBegin = 2;
        /// <summary>
        /// RH¯����״ֵ̬: �¹ܴ���3
        /// </summary>
        public const int RHOB = 3;
        /// <summary>
        /// RH¯����״ֵ̬: �����Ͻ�4
        /// </summary>
        public const int RHAlloy = 4;
        /// <summary>
        /// RH¯����״ֵ̬: �������5
        /// </summary>
        public const int RHProcEnd = 5;
        /// <summary>
        /// RH¯����״ֵ̬: ����ʼ6
        /// </summary>
        public const int RHBlowBegin = 6;
        /// <summary>
        /// RH¯����״ֵ̬: ������7
        /// </summary>
        public const int RHBlowEnd = 7;

        //����״̬����
        /// <summary>
        /// RH¯����״̬����: �ȴ�
        /// </summary>
        public const String strRHWaiting = "�ȴ�";
        /// <summary>
        /// RH¯����״̬����: ����ʼ
        /// </summary>
        public const String strRHProcBegin = "����ʼ";
        /// <summary>
        /// RH¯����״̬����: ��ʼ��մ���
        /// </summary>
        public const String strRHVacBegin = "��ʼ��մ���";
        /// <summary>
        /// RH¯����״̬����: �¹ܴ���
        /// </summary>
        public const String strRHOB = "�¹ܴ���";
        /// <summary>
        /// RH¯����״̬����: �����Ͻ�
        /// </summary>
        public const String strRHAlloy = "�����Ͻ�";
        /// <summary>
        /// RH¯����״̬����: �������
        /// </summary>
        public const String strRHProcEnd = "�������";
        /// <summary>
        /// RH¯����״̬����: ����ʼ
        /// </summary>
        public const String strRHBlowBegin = "����ʼ";
        /// <summary>
        /// RH¯����״̬����: ������
        /// </summary>
        public const String strRHBlowEnd = "������";

        // �豸״ֵ̬
        /// <summary>
        /// RH¯�豸״ֵ̬: ����0
        /// </summary>
        public const int RHNormal = 0;
        /// <summary>
        /// RH¯�豸״ֵ̬: ����-1
        /// </summary>
        public const int RHRepair = -1;
        /// <summary>
        /// RH¯�豸״ֵ̬: ����-2
        /// </summary>
        public const int RHFailure = -2;

        // �쳣״̬    
        /// <summary>
        /// RH¯�豸״̬����: ����
        /// </summary>           
        public const String strRHNormal = "����";
        /// <summary>
        /// RH¯�豸״̬����: ����
        /// </summary>    
        public const String strRHRepair = "����";
        /// <summary>
        /// RH¯�豸״̬����: ����
        /// </summary>    
        public const String strRHFailure = "����";
        /****************************RH*************************************/

        /************************CCM״ֵ̬��״̬����***********************/
        // ����״ֵ̬
        /// <summary>
        /// CCM����״ֵ̬: �ȴ�״̬0
        /// </summary>    
        public const int CCMWaiting = 0;
        /// <summary>
        /// CCM����״ֵ̬: ����1
        /// </summary>    
        public const int CCMArrivle = 1;
        /// <summary>
        /// CCM����״ֵ̬: ��ע��2
        /// </summary>    
        public const int CCMCasting = 2;
        /// <summary>
        /// CCM����״ֵ̬: ��ע����3
        /// </summary>    
        public const int CCMCasted = 3;

        // ����״̬����
        /// <summary>
        /// CCM����״̬����: �ȴ�
        /// </summary>    
        public const String strCCMWaiting = "�ȴ�";
        /// <summary>
        /// CCM����״̬����: ����
        /// </summary>    
        public const String strCCMArrivle = "����";
        /// <summary>
        /// CCM����״̬����: ��ע��
        /// </summary>    
        public const String strCCMCasting = "��ע��";
        /// <summary>
        /// CCM����״̬����: ��ע����
        /// </summary>    
        public const String strCCMCasted = "��ע����";
        /***********************/
        // �豸״ֵ̬
        /// <summary>
        /// CCM�豸״ֵ̬: ����0
        /// </summary>    
        public const int CCMNormal = 0;
        /// <summary>
        /// CCM�豸״ֵ̬: ������-1
        /// </summary>    
        public const int CCMRepair = -1;
        /// <summary>
        /// CCM�豸״ֵ̬: ����-2
        /// </summary>    
        public const int CCMFailure = -2;

        // �豸״̬����
        /// <summary>
        /// CCM�豸״̬����: ����
        /// </summary>    
        public const String strCCMNormal = "����";
        /// <summary>
        /// CCM�豸״̬����: ����
        /// </summary>    
        public const String strCCMRepair = "����";
        /// <summary>
        /// CCM�豸״̬����: ����
        /// </summary>    
        public const String strCCMFailure = "����";
        /****************************CCM*************************************/
    }

    public class CommonMethed
    {
        //c# winform ���� �Ӵ���ر�ʱ�� �ͷŴ�����ռ�õ��ڴ档
        [DllImport("kernel32.dll")]
        private static extern bool SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);
        public static void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
        }



        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int GetWindowThreadProcessId(IntPtr hwnd, out   int ID);

        /// <summary>
        /// ��dv�е������е�����������ΪNotSortable
        /// </summary>
        /// <param name="dvSort"></param>
        public static void SetdvColumnSortNotSortable(DataGridView dvSort)
        {
            int iColumns = 0;
            while (iColumns < dvSort.Columns.Count)
            {
                dvSort.Columns[iColumns].SortMode = DataGridViewColumnSortMode.NotSortable;
                iColumns++;
            }
        }

        /// <summary>
        /// ���ݴ���������ȡ��Ӧ����
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="strDes"></param>
        /// <returns></returns>
        public static string GetStrCodeByDesc(DataSet ds, String strDes)
        {
            try
            {
                string strID = "";
                string strCondition = "code_des = '" + strDes + "'";
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strID = DataRowTemp["code"].ToString();
                }
                return strID;
            }
            catch { return ""; }
        }


        /// <summary>
        /// ���ݴ���������ȡ��Ӧ����
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="strDes"></param>
        /// <returns></returns>
        public static string GetStrCodeByDesc(DataSet ds, string Code, string CodeDes, String strDes)
        {
            try
            {
                string strID = "";
                string strCondition = CodeDes + "= '" + strDes + "'";
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strID = DataRowTemp[Code].ToString();
                }
                return strID;
            }
            catch { return ""; }
        }

        /// <summary>
        /// ���ݴ����ȡ��Ӧ��������
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="strCode"></param>
        /// <returns></returns>
        public static string GetStrDescByCode(DataSet ds, String strCode)
        {
            try
            {
                string strDes = "";
                string strCondition = "Code = '" + strCode + "'";
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strDes = DataRowTemp["Code_Des"].ToString();
                }
                return strDes;
            }
            catch { return ""; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="iCode"></param>
        /// <returns></returns>
        public static string GetStrDescByCodeValLong(DataSet ds, int iCode)
        {
            try
            {
                string strDes = "";
                string strCondition = "Code_Val_Long = '" + iCode + "'";
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strDes = DataRowTemp["Code_Des"].ToString();
                }
                return strDes;
            }
            catch { return ""; }
        }
        //  [12/25/2008 sun]
        /// <summary>
        /// ���ݴ�������ȡ��Ӧ�����������
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="strCode"></param>
        /// <returns></returns>
        public static string GetErrorDescByErrorCode(DataSet ds, String strErrorCode)
        {
            try
            {
                string strDes = "";
                string strCondition = "ERROR_CODE = '" + strErrorCode + "'";
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strDes = DataRowTemp["ERROR_DES"].ToString();
                }
                return strDes;
            }
            catch { return strErrorCode; }
        }

        /// <summary>
        /// ���ݴ������ʹ����������λ�û�ȡ�����������
        /// </summary>
        /// <param name="adapter">AppSvrHMI.L3Adapter</param>
        /// <param name="strErrorCode">�������</param>
        /// <param name="strOwner">�����������λ��</param>
        /// <returns>���ش����������</returns>
        public static string GetErrorDescByErrorCode(AppSvrHMI.L3Adapter adapter, string strErrorCode, string strOwner)
        {
            try
            {
                if (adapter == null || adapter.Session == null)
                    return "";
                if (strErrorCode == "" || strOwner == "")
                    return "";

                string strSourceMethod = "select * from CBase_Error_Code where ERROR_CODE = '" + strErrorCode + "' and Owner = '" + strOwner + "'";

                AppSvrHMI.L3DataSet ds = GetdsErrorCode(adapter, strSourceMethod);
                if (ds == null || ds.Tables[0].Rows.Count < 1)
                    return "";

                return ds.Tables[0].Rows[0]["Error_Des"].ToString();
            }
            catch
            {
                return "";
            }
        }
        public static AppSvrHMI.L3DataSet GetdsErrorCode(AppSvrHMI.L3Adapter adapter, string strSourceMethod)
        {
            try
            {

                if (adapter == null || adapter.Session == null)
                    return null;

                AppSvrHMI.L3DataSet dsErrorCode = new AppSvrHMI.L3DataSet();
                dsErrorCode.AutoSubscribe = false;
                dsErrorCode.DataSetName = "L3DataSet";
                dsErrorCode.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
                dsErrorCode.SourceMethod = strSourceMethod;
                dsErrorCode.Tables.Add();
                dsErrorCode.Tables[0].TableName = "L3DataTable";
                dsErrorCode.Tables[0].Columns.Add("Error_Code");
                dsErrorCode.Tables[0].Columns.Add("Error_Des");
                dsErrorCode.Tables[0].Columns.Add("Owner");
                dsErrorCode.Tables[0].Columns.Add("Owner_Des");
                dsErrorCode.AcceptChanges();
                dsErrorCode.L3DataAdapter = adapter;
                dsErrorCode.LoadData();
                return dsErrorCode;
            }
            catch { return null; }
        }

        /// <summary>
        /// ���ݴ���������ȡ��Ӧ����
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="strDes"></param>
        /// <returns></returns>
        public static int GetIntCodeByDesc(DataSet ds, String strDes)
        {
            try
            {
                int IRetID = -1;
                string strCondition = "code_des = '" + strDes + "'";
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    IRetID = Convert.ToInt16(DataRowTemp["code_val_long"].ToString());
                }
                return IRetID;
            }
            catch { return -1; }
        }

        /// <summary>
        /// �ж��������Ƿ������ͬԪ��
        /// ���ڷ���true,�����ڷ���false
        /// </summary>
        /// <param name="strArr">����</param>
        /// <returns></returns>
        public static bool GetEqualCount(string[] strArr)
        {
            int iArrLenth = strArr.Length;
            if (iArrLenth < 1)
            {
                return false;
            }
            for (int i = 0; i < iArrLenth - 1; i++)
            {
                if (strArr[i] == strArr[i + 1])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// ��DataGridView�л�����ɫ
        /// </summary>
        /// <param name="dv">��Ҫ������ɫ��DataGridView</param>
        /// <param name="strColName">������������</param>
        /// <param name="strArrValue"></param>
        /// <param name="strArrColor">ָ����ɫ��������</param>
        public static void SetDataGridViewRowColor(DataGridView dv, string strColName, string[] strArrValue, string[] strArrColor)
        {
            try
            {
                //dvΪ�ջ�����С�ڣ������������������ڣ�����ָ����ɫ�������鲻���ڡ����ء�
                if (dv == null || dv.Rows.Count < 1
                    || strColName == null || strColName == ""
                    || strArrValue == null || strArrValue.Length < 1
                    || strArrColor == null || strArrColor.Length < 1)
                {
                    return;
                }
                for (int iRow = 0; iRow < dv.Rows.Count; iRow++)
                {
                    for (int iArr = 0; iArr < strArrValue.Length; iArr++)
                    {
                        if (dv.Rows[iRow].Cells[strColName].Value.ToString() == strArrValue[iArr].ToString())
                        {
                            dv.Rows[iRow].DefaultCellStyle.BackColor = CommonMethed.GetColor(strArrColor[iArr]);
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="strColName"></param>
        /// <param name="strArrValue"></param>
        /// <param name="ColorArr"></param>
        public static void SetDataGridViewRowColor(DataGridView dv, string strColName, string[] strArrValue, Color[] ColorArr)
        {
            try
            {
                //dvΪ�ջ�����С�ڣ������������������ڣ�����ָ����ɫ�������鲻���ڡ����ء�
                if (dv == null || dv.Rows.Count < 1
                    || strColName == null || strColName == ""
                    || strArrValue == null || strArrValue.Length < 1
                    || ColorArr == null || ColorArr.Length < 1)
                {
                    return;
                }
                for (int iRow = 0; iRow < dv.Rows.Count; iRow++)
                {
                    for (int iArr = 0; iArr < strArrValue.Length; iArr++)
                    {
                        if (dv.Rows[iRow].Cells[strColName].Value.ToString() == strArrValue[iArr].ToString())
                        {
                            dv.Rows[iRow].DefaultCellStyle.BackColor = ColorArr[iArr];
                        }
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// ����ָ�����뷵��ϵͳ��ɫ
        /// </summary>
        /// <param name="strColorCode"></param>
        /// <returns></returns>
        public static Color GetColor(string strColorCode)
        {
            switch (strColorCode)
            {
                case CommonData.Color_Code_Control: return SystemColors.Control;

                case CommonData.Color_Code_Yellow: return Color.Yellow;

                case CommonData.Color_Code_Orange: return Color.Orange;

                case CommonData.Color_Code_Red: return Color.Red;

                case CommonData.Color_Code_Green: return Color.Green;

                case CommonData.Color_Code_Blue: return Color.Blue;

                case CommonData.Color_Code_SteelBlue: return Color.SteelBlue;

                case CommonData.Color_Code_OrangeRed: return Color.OrangeRed;

                case CommonData.Color_Code_Pink: return Color.Pink;

                case CommonData.Color_Code_Sienna: return Color.Sienna;


                default: return SystemColors.Control;
            }
        }

        /// <summary>
        /// ����ĳ������ĳ��������ĳ����ɫ
        /// </summary>
        /// <param name="dv">Ŀ��DataGridView</param>
        /// <param name="strColorColumn">��ɫ����</param>
        /// <param name="strValueColumn">�ο�����</param>
        /// <param name="strValueTrue">�ο�ֵ</param>
        public static void SetCellColorByColumnName(DataGridView dv, string strColorColumn, string strValueColumn, string strValueTrue)
        {
            try
            {
                int iRows = dv.Rows.Count;
                if (iRows < 1)
                    return;
                for (int i = 0; i < iRows; i++)
                {
               
                    if (dv.Rows[i].Cells[strValueColumn].Value.ToString() == strValueTrue)
                    {
                        dv.Rows[i].Cells[strColorColumn].Style.BackColor = Color.Green;
                        dv.Rows[i].Cells[strColorColumn].Style.SelectionForeColor = Color.Green;
                        dv.Rows[i].Cells[strColorColumn].Style.SelectionBackColor = Color.Yellow;
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// ����ĳ������ĳ��������ĳ��ĳ��ɫ
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="strColorColumn"></param>
        /// <param name="strValueColumn"></param>
        /// <param name="strValueTrue"></param>
        /// <param name="BackColor"></param>
        /// <param name="SelectionBackColor"></param>
        public static void SetCellColorByColumnName(DataGridView dv, string strColorColumn, string strValueColumn, string strValueTrue, Color BackColor, Color SelectionBackColor)
        {
            try
            {
                int iRows = dv.Rows.Count;
                if (iRows < 1)
                    return;
                for (int i = 0; i < iRows; i++)
                {
                    if (dv.Rows[i].Cells[strValueColumn].Value.ToString() == strValueTrue)
                    {
                        dv.Rows[i].Cells[strColorColumn].Style.BackColor = BackColor;
                        dv.Rows[i].Cells[strColorColumn].Style.SelectionForeColor = BackColor;
                        dv.Rows[i].Cells[strColorColumn].Style.SelectionBackColor = SelectionBackColor;
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// ����ĳ������ĳ��������ĳ����ɫ
        /// </summary>
        /// <param name="dv">Ŀ��DataGridView</param>
        /// <param name="iColorColumn">��ɫ������</param>
        /// <param name="iValueColumn">�ο�������</param>
        /// <param name="strValueTrue">�ο�ֵ</param>
        public static void SetCellColorByColumnName(DataGridView dv, int iColorColumn, int iValueColumn, string strValueTrue)
        {
            try
            {
                int iRows = dv.Rows.Count;
                if (iRows < 1)
                    return;
                for (int i = 0; i < iRows; i++)
                {
                    if (dv.Rows[i].Cells[iValueColumn].Value.ToString() == strValueTrue)
                    {
                        dv.Rows[i].Cells[iColorColumn].Style.BackColor = Color.Green;
                        dv.Rows[i].Cells[iColorColumn].Style.SelectionForeColor = Color.Green;
                        dv.Rows[i].Cells[iColorColumn].Style.SelectionBackColor = Color.Yellow;
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dv"></param>
        /// <param name="strColName"></param>
        /// <param name="strArrColor">ָ����ɫ�����ά����</param>
        public static void SetDataGridViewRowColor(DataGridView dv, string strColName, string[,] strArrColor)
        {
            //dvΪ�ջ�����С�ڣ������������������ڣ�����ָ����ɫ�������鲻���ڡ����ء�
            if (dv == null || dv.Rows.Count < 1
                || strColName == null || strColName == ""
                || strArrColor == null || strArrColor.Length < 1)
            {
                return;
            }
            for (int iRow = 0; iRow < dv.Rows.Count; iRow++)
            {
                for (int iArr = 0; iArr < strArrColor.Length / 2; iArr++)
                {
                    string test = strArrColor[iArr, 0].ToString();
                    if (dv.Rows[iRow].Cells[strColName].Value.ToString() == strArrColor[iArr, 0].ToString())
                    {
                        dv.Rows[iRow].DefaultCellStyle.BackColor = CommonMethed.GetColor(strArrColor[iArr, 1]);
                    }
                }
            }
        }

        /// <summary>
        /// ���������������У��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="errorProvider"></param>
        /// <returns></returns>
        public static bool GetDataValidError(object sender, ErrorProvider errorProvider, int iMany)
        {
            try
            {
                int i = 0;
                Control[] cccccccc = new Control[100];
                Control controlParent = (Control)sender;
                while (controlParent.Parent != null)
                {
                    controlParent = controlParent.Parent;
                    cccccccc[i] = controlParent;
                    i++;
                }

                for (int j = 0; j < i; j++)
                {
                    foreach (Control c in cccccccc[j].Controls)
                    {
                        if (!(GetDataValidError(c, errorProvider)))
                            return false;
                    }
                }
                return true;
            }
            catch { return true; }
        }

        private static bool GetDataValidError(Control control, ErrorProvider errorProvider)
        {
            try
            {
                string strTypeName = (control.GetType()).Name;
                if ((strTypeName == "PxTextBox") || (strTypeName == "PxRichTextBox") || (strTypeName == "PxComboBox"))
                {
                    if (errorProvider.GetError(control) != "")
                        return false;
                }
                else
                {
                    foreach (Control c in control.Controls)
                    {
                        return GetDataValidError(c, errorProvider);
                    }
                }
                return true;
            }
            catch { return true; }
        }

        /// <summary>
        /// һ��������������У��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="errorProvider"></param>
        /// <returns></returns>
        public static bool GetDataValidError(object sender, ErrorProvider errorProvider)
        {
            try
            {
                Control control = ((Control)sender).Parent;
                foreach (Control c in control.Controls)
                {
                    if (errorProvider.GetError(c) != "")
                        return false;
                }
                return true;
            }
            catch { return true; }
        }

        /// <summary>
        /// �������ּǺŻ�ȡ����
        /// </summary>
        /// <param name="Adapter">AppSvrHMI.L3Adapter</param>
        /// <param name="strSteelGradeIndex">���ּǺ�</param>
        /// <returns>����</returns>
        public static string GetSteelGradeBySteelGradeIndex(AppSvrHMI.L3Adapter Adapter, string strSteelGradeIndex)
        {
            try
            {
                if (Adapter == null || strSteelGradeIndex == "")
                    return "";

                object Obj = new object();
                string strUri = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\";
                string strObjUri = strUri + strSteelGradeIndex;
                Adapter.Session.Get(strObjUri, "SteelGrade", ref Obj);
                return Obj.ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// �����������ϺŻ�ȡ����״̬
        /// </summary>
        /// <param name="Adapter">AppSvrHMI.L3Adapter</param>
        /// <param name="strSteelGradeIndex">���ּǺ�</param>
        /// <returns>����</returns>
        public static string GetStatusByMaterialID(AppSvrHMI.L3Adapter Adapter, string strMaterialID)
        {
            try
            {
                if (Adapter == null || strMaterialID == "")
                    return "";

                object Obj = new object();
                string strUri = "XGMESLogic\\DeSMag\\CDeS_Base_Data\\";
                string strObjUri = strUri + strMaterialID;
                Adapter.Session.Get(strObjUri, "Status", ref Obj);
                return Obj.ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// ����DataGridViewѡ���п�����(ĳ������ĳֵʱ,�������޸ĵ�ǰ��Ԫ��(ѡ����)ֵ)
        /// </summary>
        /// <param name="dv">������</param>
        /// <param name="strColName">��������</param>
        /// <param name="strVal">����ֵ</param>
        public static void SetDVSingleColEnable(DataGridView dvSender, string strColName, string strVal)
        {
            try
            {
                if (dvSender.CurrentRow.Cells[strColName].Value.ToString() == strVal)
                {
                    dvSender.CurrentCell.Value = 0;
                    dvSender.EndEdit();
                    return;
                }

                dvSender.EndEdit();
                int iRowCount = dvSender.Rows.Count;//DV������
                int iCurCellColIndex = dvSender.CurrentCell.ColumnIndex;//��ǰ������

                if (dvSender.CurrentCell.Value.ToString() == "1")
                {
                    for (int i = 0; i < dvSender.CurrentRow.Index; i++)
                    {
                        if (dvSender.Rows[i].Cells[iCurCellColIndex].Value.ToString() == "1")
                        {
                            dvSender.Rows[i].Cells[iCurCellColIndex].Value = 0;
                        }
                    }
                    for (int j = dvSender.CurrentRow.Index + 1; j < iRowCount; j++)
                    {
                        if (dvSender.Rows[j].Cells[iCurCellColIndex].Value.ToString() == "1")
                        {
                            dvSender.Rows[j].Cells[iCurCellColIndex].Value = 0;
                        }
                    }
                }
            }
            catch { }

        }
        /// <summary>
        /// ��׼��ӡ(��ӡDV��������ʾ���к���)
        /// </summary>
        /// <param name="name">������</param>
        /// <param name="dv">����ӡ��DataGridView</param>
        //public static void PutIntoExcel(string name, DataGridView dv)
        //{
        //    Microsoft.Office.Interop.Excel.Application MyExcel = new Microsoft.Office.Interop.Excel.Application();
        //    if (MyExcel == null)
        //    {
        //        MessageBox.Show("EXCEL�޷�����!", "��Ϣ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    try
        //    {
        //        MyExcel.Application.Workbooks.Add(true);
        //        Worksheet worksheet = (Worksheet)MyExcel.ActiveSheet;
        //        worksheet.Name = name;
        //        MyExcel.Visible = true;

        //        int dvRowsCount = dv.Rows.Count;//������
        //        int dvColumnCount = 0;//������ʾ��
        //        for (int k = 0; k < dv.Columns.Count; k++)
        //        {
        //            if (dv.Columns[k].Visible == true)
        //            {
        //                dvColumnCount += 1;
        //            }
        //        }
        //        //worksheet.Columns.AutoFit();//����������п�

        //        int iRowCount = 1;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).MergeCells = true;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;// xlHAlignCenter;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Size = 26;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "����";
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //        MyExcel.Cells[iRowCount, 1] = name;

        //        //�����Զ���������
        //        iRowCount = iRowCount + 1;
        //        int p = 0;
        //        for (int i = 0; i < dv.Columns.Count; i++)
        //        {
        //            int j = i - p + 1;
        //            if (dv.Columns[i].Visible == true)
        //            {
        //                MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //                MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //                MyExcel.Cells[iRowCount, j] = dv.Columns[i].HeaderText;
        //                //worksheet.Columns.AutoFit();//�ٴ�����������п�
        //            }
        //            else
        //            {
        //                p += 1;
        //            }
        //        }

        //        //���и�ÿ����Ԫ��ֵ
        //        iRowCount = iRowCount + 1;
        //        for (int i = 0; i < dvRowsCount; i++)
        //        {
        //            int q = 0;
        //            for (int j = 0; j < dv.Columns.Count; j++)
        //            {
        //                if (dv.Columns[j].Visible == true)
        //                {
        //                    MyExcel.Cells[iRowCount + i, j - q + 1] = dv.Rows[i].Cells[j].EditedFormattedValue.ToString();
        //                    MyExcel.get_Range(MyExcel.Cells[iRowCount + i, j - q + 1], MyExcel.Cells[iRowCount + i, j - q + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //                    MyExcel.get_Range(MyExcel.Cells[iRowCount + i, j - q + 1], MyExcel.Cells[iRowCount + i, j - q + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //                }
        //                else
        //                {
        //                    q += 1;
        //                }
        //                //worksheet.Columns.AutoFit();//�ٴ�����������п�
        //            }
        //        }

        //        for (int j = 1; j < dvColumnCount + 1; j++)
        //        {
        //            MyExcel.get_Range(MyExcel.Cells[iRowCount - 1, j], MyExcel.Cells[iRowCount - 1, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //            MyExcel.get_Range(MyExcel.Cells[iRowCount - 1, j], MyExcel.Cells[iRowCount - 1, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //            //worksheet.Columns.AutoFit();//�ٴ�����������п�
        //        }

        //        worksheet.PageSetup.CenterHorizontally = true;//ˮƽ����
        //        worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA3;
        //        worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//ֽ�ŷ���.����
        //        GC.Collect();

        //    }
        //    catch { }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dv"></param>
        public static void PutIntoExcel(string name, DataGridView dv)
        {
            Microsoft.Office.Interop.Excel.Application MyExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();//.Application();
            if (MyExcel == null)
            {
                MessageBox.Show("EXCEL�޷�����!", "��Ϣ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //private Excel.Application m_app;private Excel.Workbook m_workbook;this.m_app = new Excel.ApplicationClass();this.m_app.DisplayAlerts = false;
            //private Excel.Application m_app;private Excel.Workbook m_workbook;this.m_app = new Excel.ApplicationClass();this.m_app.DisplayAlerts = false;m_workbooks = this.m_app.Workbooks;
            //private Excel.Workbooks m_workbooks;
            try
            {
                MyExcel.Application.Workbooks.Add(true);
                Worksheet worksheet = (Worksheet)MyExcel.ActiveSheet;
                worksheet.Name = name;
                MyExcel.Visible = false;

                int dvRowsCount = dv.Rows.Count;//������
                int dvColumnCount = 0;//������ʾ��
                for (int k = 0; k < dv.Columns.Count; k++)
                {
                    if (dv.Columns[k].Visible == true)
                    {
                        dvColumnCount += 1;
                    }
                }

                int iRowCount = 1;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).MergeCells = true;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;// xlHAlignCenter;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Size = 26;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "����";
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                MyExcel.Cells[iRowCount, 1] = name;


                //�����Զ���������
                iRowCount = iRowCount + 1;
                int p = 0;
                for (int i = 0; i < dv.Columns.Count; i++)
                {
                    int j = i - p + 1;
                    if (dv.Columns[i].Visible == true)
                    {
                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        MyExcel.Cells[iRowCount, j] = dv.Columns[i].HeaderText;
                    }
                    else
                    {
                        p += 1;
                    }
                }

                int rowCount = dvRowsCount;

                int colCount = dvColumnCount;

                object[,] dataArray = new object[rowCount, colCount];

                int jclo = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    jclo = 0;
                    for (int j = 0; j < dv.Columns.Count; j++)
                    {
                        if (dv.Columns[j].Visible)
                        {
                            dataArray[i, jclo] =" "+ dv.Rows[i].Cells[j].EditedFormattedValue.ToString();
                            jclo++;
                        }
                    }
                }
                MyExcel.get_Range("A3", worksheet.Cells[rowCount + 2, colCount]).Value2  = dataArray;

                //worksheet.PageSetup.CenterHorizontally = true;//ˮƽ����
                worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA3;
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//ֽ�ŷ���.����
                worksheet.Columns.AutoFit();
                MyExcel.Visible = true;
                GC.Collect();
            }
            catch { }
        }


        public static void PutIntoExcelforsbgl(string name, DataGridView dv)
        {
            Microsoft.Office.Interop.Excel.Application MyExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();//.Application();
            if (MyExcel == null)
            {
                MessageBox.Show("EXCEL�޷�����!", "��Ϣ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //private Excel.Application m_app;private Excel.Workbook m_workbook;this.m_app = new Excel.ApplicationClass();this.m_app.DisplayAlerts = false;
            //private Excel.Application m_app;private Excel.Workbook m_workbook;this.m_app = new Excel.ApplicationClass();this.m_app.DisplayAlerts = false;m_workbooks = this.m_app.Workbooks;
            //private Excel.Workbooks m_workbooks;
            try
            {
                MyExcel.Application.Workbooks.Add(true);
                Worksheet worksheet = (Worksheet)MyExcel.ActiveSheet;
                worksheet.Name = name;
                MyExcel.Visible = false;

                int dvRowsCount = dv.Rows.Count;//������
                int dvColumnCount = 0;//������ʾ��
                for (int k = 0; k < dv.Columns.Count; k++)
                {
                    if (dv.Columns[k].Visible == true)
                    {
                        dvColumnCount += 1;
                    }
                }

                int iRowCount = 1;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).MergeCells = true;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;// xlHAlignCenter;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Size = 26;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "����";
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                MyExcel.Cells[iRowCount, 1] = name;


                //�����Զ���������
                iRowCount = iRowCount + 1;
                int p = 0;
                for (int i = 0; i < dv.Columns.Count; i++)
                {
                    int j = i - p + 1;
                    if (dv.Columns[i].Visible == true)
                    {
                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        MyExcel.Cells[iRowCount, j] = dv.Columns[i].HeaderText;
                    }
                    else
                    {
                        p += 1;
                    }
                }

                int rowCount = dvRowsCount;

                int colCount = dvColumnCount;

                object[,] dataArray = new object[rowCount, colCount];

                int jclo = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    jclo = 0;
                    for (int j = 0; j < dv.Columns.Count; j++)
                    {
                        if (dv.Columns[j].Visible)
                        {
                            dataArray[i, jclo] = " " + dv.Rows[i].Cells[j].EditedFormattedValue.ToString();
                            jclo++;
                        }
                    }
                }
                MyExcel.get_Range("A3", worksheet.Cells[rowCount + 2, colCount]).Value2 = dataArray;

                //worksheet.PageSetup.CenterHorizontally = true;//ˮƽ����
               // worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperUser;
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//ֽ�ŷ���.����
                worksheet.Columns.AutoFit();
                MyExcel.Visible = true;
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// ExcelForFGFL
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dv"></param>
        public static void PutIntoExcelForFGFL(string name, DataGridView dv, DataSet[] arryFG, DataSet[] arryST)
        {

            Microsoft.Office.Interop.Excel.Application MyExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();//.Application();
            if (MyExcel == null)
            {
                MessageBox.Show("EXCEL�޷�����!", "��Ϣ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //private Excel.Application m_app;private Excel.Workbook m_workbook;this.m_app = new Excel.ApplicationClass();this.m_app.DisplayAlerts = false;
            //private Excel.Application m_app;private Excel.Workbook m_workbook;this.m_app = new Excel.ApplicationClass();this.m_app.DisplayAlerts = false;m_workbooks = this.m_app.Workbooks;

            //private Excel.Workbooks m_workbooks;
            int fgMaxCount = 0;
            int stMaxCount = 0;
            if (arryFG != null)
            {
                for (int h = 0; h < arryFG.Length; h++)
                {
                    if (arryFG[h].Tables[0].Rows.Count > fgMaxCount)
                        fgMaxCount = arryFG[h].Tables[0].Rows.Count;
                }
            }

            if (arryST != null)
            {
                for (int s = 0; s < arryST.Length; s++)
                {
                    if (arryST[s].Tables[0].Rows.Count > stMaxCount)
                        stMaxCount = arryST[s].Tables[0].Rows.Count;
                }

            }

            try
            {
                MyExcel.Application.Workbooks.Add(true);//���EXCEL������Ӧ��
                Worksheet worksheet = (Worksheet)MyExcel.ActiveSheet;//��myexce�ĵ�ǰ����Ϊ������
                worksheet.Name = name;
                MyExcel.Visible = false;

                int dvRowsCount = dv.Rows.Count;//������

                int dvColumnCount = 0;//������ʾ��
                for (int k = 0; k < dv.Columns.Count; k++)
                {
                    if (dv.Columns[k].Visible == true)
                    {
                        dvColumnCount += 1;
                    }
                }

                
                //dvColumnCount += 2 * fgMaxCount + 2 * stMaxCount;
                dvColumnCount += fgMaxCount + stMaxCount;
                //�Ե�һ�� �����н��в���
                int iRowCount = 1;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).MergeCells = true;//�ϲ���Ԫ��
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;// xlHAlignCenter;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Size = 18;

                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "����";
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;//����
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                MyExcel.Cells[iRowCount, 1] = name;



                //����
                iRowCount = iRowCount + 1;//�ڶ���
                int p = 0;
                int flagFG = 0;
                int flagST = 0;
                #region "����"
                //int tt = 0;
                //int cc = 0;
                //for (int i = 0; i < dv.Columns.Count + 2 * fgMaxCount + 2 * stMaxCount; i++)
                /*
                for (int i = 0; i < dv.Columns.Count + fgMaxCount + stMaxCount; i++)
                {
                    int j = i + 1;
                    if (flagFG != 0 || flagST != 0)
                    {
                        j += 4;
                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j - 4], MyExcel.Cells[iRowCount, j - 4]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j - 4], MyExcel.Cells[iRowCount, j - 4]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        MyExcel.Cells[iRowCount, j - 4] = dv.Columns[i - 2 * fgMaxCount - 2 * stMaxCount].HeaderText;
                        j++;
                        continue;
                    }
                    else
                    {

                        if (flagFG == 0 && flagST == 0 && !(dv.Columns[i].HeaderText.Equals("�ϸ�")))
                        {
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            MyExcel.Cells[iRowCount, j] = dv.Columns[i].HeaderText;
                            j++;
                            continue;
                        }

                        if ((dv.Columns[i].Visible == true) && ((dv.Columns[i].HeaderText.Equals("�ϸ�"))))
                        {
                            if (arryFG[i].Tables[0].Rows.Count > 0)
                                flagFG = j + 1;
                            if (arryST[i].Tables[0].Rows.Count > 0)
                                flagST = j + 2 * fgMaxCount + 2;
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            MyExcel.Cells[iRowCount, j] = dv.Columns[i].HeaderText;
                            j++;


                            for (int n = 0; n < fgMaxCount; n++)
                            {
                                int tempt = 1;
                                MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                                MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                MyExcel.Cells[iRowCount, j] = "�ϸַ���" + tempt;

                                MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                                MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                MyExcel.Cells[iRowCount, j + 1] = "����" + tempt;
                                tempt++;
                                j += 2;
                                i += 2;
                            }
                        }
                        //if (dv.Columns[i].Visible == true && (dv.Columns[i].HeaderText.Equals("����")))
                        //{

                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        MyExcel.Cells[iRowCount, j] = dv.Columns[i - 1].HeaderText;
                        //flagST = j + 2 * fgMaxCount + 2;
                        j++;
                        i++;

                        for (int m = 0; m < stMaxCount; m++)
                        {
                            int tempt = 1;
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            MyExcel.Cells[iRowCount, j] = "��������" + tempt;

                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            MyExcel.Cells[iRowCount, j + 1] = "����" + tempt;
                            tempt++;
                            j += 2;
                            i += 2;
                        }*/
                        #endregion
                        #region OLD
                        //}
                        //����ϸַ��಻Ϊ0,��������,�������

                        //if ((j == flagFG) && fgMaxCount > 0&&(tt==0))
                        //{
                        //    for (int n = 0; n < fgMaxCount; n++)
                        //    {
                        //        int tempt = 1;
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //        MyExcel.Cells[iRowCount, j] = "�ϸַ���" + tempt;

                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //        MyExcel.Cells[iRowCount, j + 1] = "����" + tempt;
                        //        tempt++;
                        //        j += 2;
                        //    }
                        //    tt++;
                        //}
                        //if ((j+fgMaxCount+1 == flagST) && stMaxCount > 0&&cc==0)
                        //{
                        //    for (int m = 0; m < stMaxCount; m++)
                        //    {
                        //        int tempt = 1;
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //        MyExcel.Cells[iRowCount, j] = "��������" + tempt;

                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //        MyExcel.Cells[iRowCount, j + 1] = "����" + tempt;
                        //        tempt++;
                        //        j += 2;
                        //    }
                        //    cc++;
                        //}
                        //if (dv.Columns[i].Visible == false)
                        //{
                        //    p += 1;
                        //} 
                        #endregion
                #region "����"
                /*}
                }

                int rowCount = dvRowsCount;//��

                int colCount = dvColumnCount;//��

                object[,] dataArray = new object[rowCount, colCount];//��ά����

                int jclo = 0;
                for (int i = 0; i < rowCount; i++)
                {
                    jclo = 0;
                    for (int j = 0; j < dv.Columns.Count + fgMaxCount * 2 + stMaxCount * 2; j++)
                    {
                        if (j < flagFG - 1)
                        {
                            dataArray[i, jclo] = dv.Rows[i].Cells[j].EditedFormattedValue.ToString();
                            jclo++;
                            continue;
                        }
                        else if (j > flagST - 1)
                        {
                            dataArray[i, jclo] = dv.Rows[i].Cells[j - 2 * fgMaxCount - 2 * stMaxCount].EditedFormattedValue.ToString();
                            jclo++;
                        }
                        else if (j == flagFG - 1)
                        {
                            if (arryFG[i].Tables[0].Rows.Count == fgMaxCount)
                            {
                                for (int k = 0; k < fgMaxCount; k++)
                                {
                                    dataArray[i, jclo] = arryFG[i].Tables[0].Rows[k][4].ToString();
                                    jclo++;
                                    dataArray[i, jclo] = arryFG[i].Tables[0].Rows[k][5].ToString();
                                    jclo++;
                                }
                            }
                            else
                            {
                                for (int tt = 0; tt < arryFG[i].Tables[0].Rows.Count; tt++)
                                {
                                    dataArray[i, jclo] = arryFG[i].Tables[0].Rows[tt][4].ToString();
                                    jclo++;
                                    dataArray[i, jclo] = arryFG[i].Tables[0].Rows[tt][5].ToString();
                                    jclo++;
                                }
                                // int tempt = tt + 1;
                                for (int c = 0; c < fgMaxCount - arryFG[i].Tables[0].Rows.Count; c++)
                                {
                                    dataArray[i, jclo] = "----";
                                    jclo++;
                                    dataArray[i, jclo] = "----";
                                    jclo++;
                                }

                            }
                            //jclo++;

                            dataArray[i, jclo] = dv.Rows[i].Cells["pigironwtDataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                            jclo++;
                            j++;
                            j += fgMaxCount;
                        }
                        else if (j == flagST - 1)
                        {

                            if (arryST[i].Tables[0].Rows.Count == stMaxCount)
                            {
                                for (int k = 0; k < stMaxCount; k++)
                                {
                                    dataArray[i, jclo] = arryST[i].Tables[0].Rows[k][4].ToString();
                                    jclo++;
                                    dataArray[i, jclo] = arryST[i].Tables[0].Rows[k][5].ToString();
                                    jclo++;
                                }
                            }
                            else
                            {
                                for (int tt = 0; tt < arryST[i].Tables[0].Rows.Count; tt++)
                                {
                                    dataArray[i, jclo] = arryST[i].Tables[0].Rows[tt][4].ToString();
                                    jclo++;
                                    dataArray[i, jclo] = arryST[i].Tables[0].Rows[tt][5].ToString();
                                    jclo++;
                                }
                                // int tempt = tt + 1;
                                for (int c = 0; c < stMaxCount - arryST[i].Tables[0].Rows.Count; c++)
                                {
                                    dataArray[i, jclo] = "----";
                                    jclo++;
                                    dataArray[i, jclo] = "----";
                                    jclo++;
                                }

                            }
                            j += stMaxCount;
                        }
                    }
                }
                 * */
                #endregion
                string[] strArrayClumnNames = new string[100];
                int[] iArrayClumnNums = new int[100];
                int iCurWiteClumnNum=1;
                int iSaveCount = 0;
                //�����п�ʼ
                iRowCount++;
                for (int i = 0; i < dv.Rows.Count; i++)
                {
                    iCurWiteClumnNum = 0;
                    //�����������ϵ�����
                    for (int j = 0; j < dv.Columns.Count; j++)
                    {
                        MyExcel.Cells[iRowCount + i, j + 1] = dv[j, i].EditedFormattedValue.ToString();
                        iCurWiteClumnNum++;
                    }
                    iCurWiteClumnNum++;
                    //����ϸַ���
                    if(arryFG[i].Tables[0].Rows.Count>0)
                    {
                        for (int j = 0; j < arryFG[i].Tables[0].Rows.Count; j++)
                        {
                            string strName = arryFG[i].Tables[0].Rows[j]["Name"].ToString();
                            int m=-1;
                            for (int k = 0; k < strArrayClumnNames.Length; k++)
                            {
                                if (strArrayClumnNames[k] == "")
                                    break;
                                if (strArrayClumnNames[k] == strName)
                                    m = k;
                            }
                            if (m == -1)
                            {//δ�ҵ�����,��������
                                strArrayClumnNames[iSaveCount] = strName;
                                if (i == 0)
                                    iArrayClumnNums[iSaveCount] = iCurWiteClumnNum;
                                else
                                    iCurWiteClumnNum = iArrayClumnNums[iSaveCount-1] + 1; 
                                MyExcel.Cells[iRowCount + i, iCurWiteClumnNum] = arryFG[i].Tables[0].Rows[j]["Amount"].ToString();
                                //if (i == 0)
                                iArrayClumnNums[iSaveCount] = iCurWiteClumnNum;
                                    iCurWiteClumnNum++;
                                iSaveCount++;
                            }
                            else
                            {//�Ѿ����ڵ�����
                                int ipos = iArrayClumnNums[m];
                                MyExcel.Cells[iRowCount + i, ipos] = arryFG[i].Tables[0].Rows[j]["Amount"].ToString();
                            }
                            
                        }
                    }

                    //������������
                    if (arryST[i].Tables[0].Rows.Count > 0)
                    {
                        for (int j = 0; j < arryST[i].Tables[0].Rows.Count; j++)
                        {
                            string strName = arryST[i].Tables[0].Rows[j]["Name"].ToString();
                            int m = -1;
                            for (int k = 0; k < strArrayClumnNames.Length; k++)
                            {
                                if (strArrayClumnNames[k] == strName)
                                    m = k;
                            }
                            if (m == -1)
                            {//δ�ҵ�����,��������
                                strArrayClumnNames[iSaveCount] = strName;
                                if (i == 0)
                                    iArrayClumnNums[iSaveCount] = iCurWiteClumnNum;
                                else
                                    iCurWiteClumnNum = iArrayClumnNums[iSaveCount-1] + 1;
                                MyExcel.Cells[iRowCount + i, iCurWiteClumnNum] = arryST[i].Tables[0].Rows[j]["Amount"].ToString();
                                //if (i == 0)
                                iArrayClumnNums[iSaveCount] = iCurWiteClumnNum;
                                    iCurWiteClumnNum++;
                                iSaveCount++;
                            }
                            else
                            {//�Ѿ����ڵ�����
                                int ipos = iArrayClumnNums[m];
                                MyExcel.Cells[iRowCount + i, ipos] = arryST[i].Tables[0].Rows[j]["Amount"].ToString();
                            }
                        }
                    }
                    //iRowCount++;

                }

                //����ڶ�������
                iCurWiteClumnNum = 1;
                for (int i = 0; i < dv.Columns.Count; i++)
                {
                    MyExcel.Cells[2, i + 1] = dv.Columns[i].HeaderText;
                    iCurWiteClumnNum++;
                }
                for (int i = 0; i < iSaveCount; i++)
                {
                    MyExcel.Cells[2, iCurWiteClumnNum] = strArrayClumnNames[i];
                    iCurWiteClumnNum++;
                }
                    // MyExcel.get_Range("A3", worksheet.Cells[rowCount + 2, colCount]).Value2 = dataArray;

                    //worksheet.PageSetup.CenterHorizontally = true;//ˮƽ����
                    worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA3;
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//ֽ�ŷ���.����
                worksheet.Columns.AutoFit();
                MyExcel.Visible = true;
                GC.Collect();
            }
            catch { }
        }

        //private int IndexOfByArrayName(string strName)
        //{
        //    for(int i=0;i<strArrayClumnNames.
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAddress"></param>
        /// <param name="startRow"></param>
        /// <param name="startColumn"></param>
        /// <param name="endRow"></param>
        /// <param name="endColumn"></param>
        /// <param name="IsDeleteEntireRow"></param>
        public static void Delete(string strAddress, int startRow, int startColumn, int endRow, int endColumn, bool IsDeleteEntireRow)
        {
            //����Excel����
            Excel.Application myExcel = new Excel.Application();
            if (myExcel == null)
            {
                MessageBox.Show("EXCEL�޷�����!", "��Ϣ��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                myExcel.Application.Workbooks.Open(strAddress, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing);

                myExcel.Visible = true;
                Sheets excelsheets = (Excel.Sheets)myExcel.Worksheets;
                Worksheet excelsheet = (Excel.Worksheet)(excelsheets.get_Item(1));

                Excel.Range range = myExcel.get_Range(myExcel.Cells[startRow, startColumn], myExcel.Cells[endRow, endColumn]);
                range.Select();
                if (IsDeleteEntireRow)//�Ƿ�����ɾ�� 
                    range.EntireRow.Delete(XlDeleteShiftDirection.xlShiftUp);
                else
                    range.Delete(XlDeleteShiftDirection.xlShiftUp);


                excelsheet.SaveAs(strAddress, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                 , Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value);

                //���棿

                int iThreed;
                IntPtr Ptr = new IntPtr(myExcel.Hwnd);
                GetWindowThreadProcessId(Ptr, out iThreed);
                System.Diagnostics.Process ProcessID = System.Diagnostics.Process.GetProcessById(iThreed);
                ProcessID.Kill();

                return;
            }
            catch
            {
                int iThreed;
                IntPtr Ptr = new IntPtr(myExcel.Hwnd);
                GetWindowThreadProcessId(Ptr, out   iThreed);
                System.Diagnostics.Process ProcessID = System.Diagnostics.Process.GetProcessById(iThreed);
                ProcessID.Kill();
            }
        }

        public static bool IsDouble(String strValid)
        {
            string express = @"^[1-9]\d*\.\d+|0\.\d+|0?\.0+|0$";//ƥ��Ǹ�������(�������� + 0)
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            if (!m.Success)
                return false;
            else
                return true;
        }

        /// <summary>
        /// У������������Ƿ�Ϊ�Ǹ�����
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool IsInteger(String strValid)
        {
            string express = @"^(0|[1-9]\d*)$";��//�Ǹ�����
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            if (!m.Success)
                return false;
            else
                return true;
        }

        /// <summary>
        /// ���������������У��־�ĺ���Լ��������һ�����ڴ˷ֱ����У��
        /// ��ȵ�У�飺С��λ��������Ϊ4λ���ҳ������Ϊ10
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool ValidWidth(String strValid)
        {
            //�ж�С����λ��
            string express = @"^[0-9]+(.[0-9]{0,4})?$";
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            //�жϳ����Ƿ񳬹�10
            int length;
            int index = strValid.IndexOf(".");
            if (index == -1)
                length = strValid.Length;
            else
                length = strValid.Length - 1;

            if (!m.Success || length > 10)
                return false;
            else
                return true;
        }

        /// <summary>
        /// ��ȵ�У�飺λ�����ܳ���10�ķǸ�����
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool ValidThick(String strValid)
        {
            //�ж��Ƿ�Ϊ�Ǹ�����
            string express = @"^(0|[1-9]\d*)$";
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            int length = strValid.Length;
            if (!m.Success || length > 10)
                return false;
            else
                return true;
        }

        /// <summary>
        /// ������У�飺С��λ��������Ϊ4λ���ҳ������Ϊ10
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool ValidWeight(String strValid)
        {
            //�ж�С����λ��
            string express = @"^[0-9]+(.[0-9]{0,4})?$";
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            //�жϳ����Ƿ񳬹�10
            int length;
            int index = strValid.IndexOf(".");
            if (index == -1)
                length = strValid.Length;
            else
                length = strValid.Length - 1;

            if (!m.Success || length > 10)
                return false;
            else
                return true;
        }

        /// <summary>
        /// ���ɷֱ�׼���Ƶ�ָ����DataGridView
        /// </summary>
        /// <param name="dvCurrent">��Ҫ���Ƶ�DataGridView</param>
        /// <param name="dsGB">���ʱ�׼</param>
        /// <param name="dsInCtrol">�ڿر�׼</param>
        public static void dv_ElementStd_Draw(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsGB, AppSvrHMI.L3DataSet dsInCtrol)
        {
            try
            {
                //�������DataGridView
                if (dvCurrent.Rows.Count > 0)
                    dvCurrent.Rows.Clear();
                //�������ɷֱ�׼���ڿسɷֱ�׼��¼�����������1���򷵻�
                if (dsGB.Tables[0].Rows.Count != 1 || dsInCtrol.Tables[0].Rows.Count != 1)
                    return;

                string[] strArrayType = new string[12];
                strArrayType[0] = "�������:";
                strArrayType[1] = "_Max";
                strArrayType[2] = "�ڿ����:";
                strArrayType[3] = "_Max";
                strArrayType[4] = "�ڿ�Ŀ��:";
                strArrayType[5] = "_Aim";
                strArrayType[6] = "����Ŀ��:";
                strArrayType[7] = "_Aim";
                strArrayType[8] = "�ڿ���С:";
                strArrayType[9] = "_Min";
                strArrayType[10] = "������С:";
                strArrayType[11] = "_Min";

                DataSet dsElement = dsGB;

                dvCurrent.Rows.Add(6);
                int iRowIndex = 0;
                while (iRowIndex < 6)
                {
                    //��������ʾ��Ϣ
                    dvCurrent.Rows[iRowIndex].Cells[0].Value = strArrayType[2 * iRowIndex];

                    //ȷ��ʹ��ds
                    if (iRowIndex == 1 || iRowIndex == 2 || iRowIndex == 4)
                        dsElement = dsInCtrol;
                    else
                        dsElement = dsGB;

                    if (dsElement.Tables[0].Rows.Count > 0)
                    {


                        /****************************************�����ɷ�*****************************************/
                        dvCurrent.Rows[iRowIndex].Cells[1].Value = dsElement.Tables[0].Rows[0]["C" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[2].Value = dsElement.Tables[0].Rows[0]["Si" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[3].Value = dsElement.Tables[0].Rows[0]["Mn" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[4].Value = dsElement.Tables[0].Rows[0]["P" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[5].Value = dsElement.Tables[0].Rows[0]["S" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[6].Value = dsElement.Tables[0].Rows[0]["Al" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[7].Value = dsElement.Tables[0].Rows[0]["Cr" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[8].Value = dsElement.Tables[0].Rows[0]["Ti" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[9].Value = dsElement.Tables[0].Rows[0]["V" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[10].Value = dsElement.Tables[0].Rows[0]["B" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[11].Value = dsElement.Tables[0].Rows[0]["Mo" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[12].Value = dsElement.Tables[0].Rows[0]["Ni" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[13].Value = dsElement.Tables[0].Rows[0]["Ca" + strArrayType[2 * iRowIndex + 1]].ToString();

                        /****************************************�������ɷ�*****************************************/
                        dvCurrent.Rows[iRowIndex].Cells[14].Value = dsElement.Tables[0].Rows[0]["Cu" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[15].Value = dsElement.Tables[0].Rows[0]["Nb" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[16].Value = dsElement.Tables[0].Rows[0]["Sn" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[17].Value = dsElement.Tables[0].Rows[0]["W" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[18].Value = dsElement.Tables[0].Rows[0]["Pb" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[19].Value = dsElement.Tables[0].Rows[0]["Zn" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[20].Value = dsElement.Tables[0].Rows[0]["N" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[21].Value = dsElement.Tables[0].Rows[0]["H" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[22].Value = dsElement.Tables[0].Rows[0]["O" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[23].Value = dsElement.Tables[0].Rows[0]["AlS" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[24].Value = dsElement.Tables[0].Rows[0]["Sb" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[25].Value = dsElement.Tables[0].Rows[0]["As" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[26].Value = dsElement.Tables[0].Rows[0]["Re" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[27].Value = dsElement.Tables[0].Rows[0]["Ceq" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[28].Value = dsElement.Tables[0].Rows[0]["CrNi" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[29].Value = dsElement.Tables[0].Rows[0]["CrCu" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[30].Value = dsElement.Tables[0].Rows[0]["CrNiCu" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[31].Value = dsElement.Tables[0].Rows[0]["Other1" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[32].Value = dsElement.Tables[0].Rows[0]["Other2" + strArrayType[2 * iRowIndex + 1]].ToString();
                        dvCurrent.Rows[iRowIndex].Cells[33].Value = dsElement.Tables[0].Rows[0]["Other3" + strArrayType[2 * iRowIndex + 1]].ToString();
                    }

                    
                    //������1
                    iRowIndex++;
                }
            }
            catch
            {
                if (dvCurrent.Rows.Count > 0)
                    dvCurrent.Rows.Clear();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="dStdMax"></param>
        /// <param name="dStdMin"></param>
        /// <param name="dReal"></param>
        public static void SetDataGridViewCellBackColor(DataGridViewCell cell, double dStdMax, double dStdMin, double dReal)
        {
            //�����޺�ɫ����
            if (dReal > dStdMax)
            {
                cell.Style.BackColor = Color.Red;
            }
            else if (dReal < dStdMin)//�����޻�ɫ����
            {
                cell.Style.BackColor = Color.Yellow;
            }
            else//����ϵͳɫ
            {
                cell.Style.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// ���ݹ�����ڿػ��Ƴɷֱ���ɫ
        /// </summary>
        /// <param name="dvCurrent"></param>
        /// <param name="dsGB"></param>
        /// <param name="dsInCtrol"></param>
        public static void SetDataGridViewCellBackColor(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsGB, AppSvrHMI.L3DataSet dsInCtrol)
        {
            try
            {
                if (dvCurrent == null || dvCurrent.Rows.Count < 1)
                    return;
                if (dsGB == null || dsInCtrol == null || (dsGB.Tables[0].Rows.Count < 1 && dsInCtrol.Tables[0].Rows.Count < 1))
                    return;

                int CLib = 0, Other3Lib = 0;
                for (int i = 0; i < dvCurrent.Columns.Count; i++)
                {
                    if (dvCurrent.Columns[i].DataPropertyName == "C")
                        CLib = i;
                    if (dvCurrent.Columns[i].DataPropertyName == "Other3")
                        Other3Lib = i;
                }
                double dRealValue = 0, dGBMax = 0, dGBMin = 0, dInCtrolMax = 0, dInCtrolMin = 0;
                string strColumnName = "";
                for (int i = 0; i < dvCurrent.Rows.Count; i++)
                {
                    for (int j = CLib; j < Other3Lib; j++)
                    {
                        DataGridViewCell cell = dvCurrent.Rows[i].Cells[j];
                        try
                        {
                            //��ȡʵ���ɷ�����
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].DataPropertyName;
                            
                            //ȡ������
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }

                            
                            dRealValue = Convert.ToDouble(cell.Value.ToString());



                            //�ж��Ƿ�У��
                            if (dRealValue > 0)
                            {
                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Max"] == null)
                                    dGBMax = -1;
                                else
                                    dGBMax = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Max"].ToString());

                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Min"] == null)
                                    dGBMin = -1;
                                else
                                    dGBMin = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Min"].ToString());

                                if (dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"] == null)
                                    dInCtrolMax = -1;
                                else
                                    dInCtrolMax = Convert.ToDouble(dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"].ToString());

                                if (dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"] == null)
                                    dInCtrolMin = -1;
                                else
                                    dInCtrolMin = Convert.ToDouble(dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"].ToString());
                                

                                if (dGBMax >= 0)
                                {
                                    if (dRealValue > dGBMax)
                                    {
                                        cell.Style.BackColor = Color.Red;
                                        continue;
                                    }
                                    
                                    if (dInCtrolMax >= 0)
                                    {
                                        if (dInCtrolMax < dRealValue)
                                        {
                                            cell.Style.BackColor = Color.LightPink;
                                            continue;
                                        }
                                        if (dGBMin >= 0)
                                        {
                                            if (dRealValue < dGBMin)
                                            {
                                                cell.Style.BackColor = Color.Yellow;
                                                continue;
                                            }
                                            if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                            {
                                                cell.Style.BackColor = Color.Khaki;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                            {
                                                cell.Style.BackColor = Color.Khaki;
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (dGBMin >= 0 && dRealValue < dGBMin)
                                        {
                                            cell.Style.BackColor = Color.Yellow;
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    if (dInCtrolMax >= 0)
                                    {
                                        if (dInCtrolMax > dRealValue)
                                        {
                                            cell.Style.BackColor = Color.LightPink;
                                            continue;
                                        }
                                        if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                        {
                                            cell.Style.BackColor = Color.Khaki;
                                            continue;
                                        }
                                    }
                                }
                                ////add by yuan 2015-5-7

                                //if (strColumnName == "Column2")
                                ////    if (strColumnName == "Cr" && dRealValue > 0.03)
                                //{
                                //    cell.Style.BackColor = Color.Red;
                                //    continue;
                                //}
                                //add by yuan 2015-5-7

                                ////���������޺�ɫ����
                                //if (dRealValue > dGBMax)
                                //{
                                //    cell.Style.BackColor = Color.Red;
                                //}
                                ////���ڿ����޺�ɫ����
                                //else if (dRealValue > dInCtrolMax)
                                //{
                                //    cell.Style.BackColor = Color.LightPink;
                                //}
                                ////���������޻�ɫ����
                                //else if (dRealValue < dGBMin)
                                //{
                                //    cell.Style.BackColor = Color.Yellow;
                                //}
                                ////���ڿ����޻�ɫ����
                                //else if (dRealValue < dInCtrolMin)
                                //{
                                //    cell.Style.BackColor = Color.Khaki;
                                //}
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// ��ֻ�й���ĳɷֱ���
        /// </summary>
        /// <param name="dvCurrent"></param>
        /// <param name="dsGB"></param>
        public static void SetDataGridViewCellBackColor(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsGB)
        {
            try
            {
                if (dvCurrent == null || dvCurrent.Rows.Count < 1)
                    return;
                if (dsGB == null || dsGB.Tables[0].Rows.Count < 1)
                    return;

                int CLib = 0, Other3Lib = 0;
                for (int i = 0; i < dvCurrent.Columns.Count; i++)
                {
                    if (dvCurrent.Columns[i].DataPropertyName == "C")
                        CLib = i;
                    if (dvCurrent.Columns[i].DataPropertyName == "Other3")
                        Other3Lib = i;
                }
                double dRealValue = 0, dGBMax = 0, dGBMin = 0;
                string strColumnName = "";
                for (int i = 0; i < dvCurrent.Rows.Count; i++)
                {
                    for (int j = CLib; j < Other3Lib; j++)
                    {
                        DataGridViewCell cell = dvCurrent.Rows[i].Cells[j];
                        try
                        {
                            //��ȡʵ���ɷ�����
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].DataPropertyName;
                            //ȡ������
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }
                            dRealValue = Convert.ToDouble(cell.Value.ToString());

                            //�ж��Ƿ�У��
                            if (dRealValue > 0)
                            {
                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Max"] == null)
                                    dGBMax = -1;
                                else
                                    dGBMax = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Max"].ToString());

                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Min"] == null)
                                    dGBMin = -1;
                                else
                                    dGBMin = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Min"].ToString());
                                
                                if (dGBMax >= 0)
                                {
                                    if (dRealValue > dGBMax)
                                    {
                                        cell.Style.BackColor = Color.Red;
                                        continue;
                                    }
                                    if (dGBMin >= 0)
                                    {
                                        if (dRealValue < dGBMin)
                                        {
                                            cell.Style.BackColor = Color.Yellow;
                                            continue;
                                        }
                                    }
                                }
                                ////add by yuan 2015-5-7
                                //if (strColumnName == "Column2")
                                ////    if (strColumnName == "Cr" && dRealValue > 0.03)
                                //{
                                //    cell.Style.BackColor = Color.Red;
                                //    continue;
                                //}
                                ////add by yuan 2015-5-7
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }
        //[2009-03-10 sun]
        public static void SetDataGridViewCellBackColorByRow(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsGB, AppSvrHMI.L3DataSet dsInCtrol, int StartRow)
        {
            try
            {
                if (dvCurrent == null || dvCurrent.Rows.Count < 1)
                    return;
                if (dsGB == null || dsInCtrol == null || (dsGB.Tables[0].Rows.Count < 1 && dsInCtrol.Tables[0].Rows.Count < 1))
                    return;

                int CLib = 0, Other3Lib = 0;
                for (int i = 0; i < dvCurrent.Columns.Count; i++)
                {
                    if (dvCurrent.Columns[i].HeaderText == "C")
                        CLib = i;
                    if (dvCurrent.Columns[i].HeaderText == "�������")
                        Other3Lib = i+1;
                }
                double dRealValue = 0, dGBMax = 0, dGBMin = 0, dInCtrolMax = 0, dInCtrolMin = 0;
                string strColumnName = "";
                for (int i = StartRow; i <= dvCurrent.Rows.Count; i++)
                {
                    for (int j = CLib; j < Other3Lib; j++)
                    {
                        
                        DataGridViewCell cell = dvCurrent.Rows[i].Cells[j];
                        string cellstr = Convert.ToString (cell);
                        try
                        {
                            //��ȡʵ���ɷ�����
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].HeaderText.Trim();
                            //ȡ������
                            
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }
                            dRealValue = Convert.ToDouble(cell.Value.ToString());

                            

                            //�ж��Ƿ�У��
                            if (dRealValue > 0 )
                            {
                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Max"] == null || dsGB.Tables[0].Rows[0][strColumnName + "_Max"].ToString() == "")
                                    dGBMax = -1;
                                else
                                    dGBMax = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Max"].ToString());

                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Min"] == null || dsGB.Tables[0].Rows[0][strColumnName + "_Min"].ToString() == "")
                                    dGBMin = -1;
                                else
                                    dGBMin = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Min"].ToString());

                                if (dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"] == null || dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"].ToString() == "")
                                    dInCtrolMax = -1;
                                else
                                    dInCtrolMax = Convert.ToDouble(dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"].ToString());

                                if (dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"] == null || dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"].ToString() == "")
                                    dInCtrolMin = -1;
                                else
                                    dInCtrolMin = Convert.ToDouble(dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"].ToString());
                                //�������0
                                if (dGBMax >= 0)
                                {
                                    //���ڹ��꣬��ɫ
                                    if (dRealValue > dGBMax)
                                    {
                                        cell.Style.BackColor = Color.Red;
                                        continue;
                                    }
                                    //
                                    if (dInCtrolMax >= 0)
                                    {
                                        //�����ڿأ�С�ڹ��꣩,ǳ�ۺ�ɫ
                                        if (dInCtrolMax < dRealValue)
                                        {
                                            cell.Style.BackColor = Color.LightPink;
                                            continue;
                                        }

                                        if (dGBMin >= 0)
                                        {
                                            //С�ڹ������ޣ���ɫ
                                            if (dRealValue < dGBMin)
                                            {
                                                cell.Style.BackColor = Color.Yellow;
                                                continue;
                                            }

                                            if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                            {
                                                cell.Style.BackColor = Color.Khaki;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                            {
                                                cell.Style.BackColor = Color.Khaki;
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (dGBMin >= 0 && dRealValue < dGBMin)
                                        {
                                            cell.Style.BackColor = Color.Yellow;
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    if (dInCtrolMax >= 0)
                                    {
                                        if (dRealValue > dInCtrolMax)
                                        {
                                            cell.Style.BackColor = Color.LightPink;
                                            continue;
                                        }
                                        if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                        {
                                            cell.Style.BackColor = Color.Khaki;
                                            continue;
                                        }
                                    }
                                }
                                
                            }


                            

                        }
                        catch { }

                        #region �������Ϊ����̼
                        if (cell.Value.ToString() == "GT")//�ж�Ϊ¯�ո���̼���Ϳɫ�жϡ�
                        {
                            //if (strColumnName == "Cr" && dRealValue > 0.05)
                            double value1 = 0;//Cr
                            double value2 = 0;//Cu
                            double value3 = 0;//Mo
                            double value4 = 0;//Ni
                            double value5 = 0;//P
                            double value6 = 0;//����P
                            value1 = Convert.ToDouble(dvCurrent.Rows[i].Cells[7].Value.ToString());
                            value2 = Convert.ToDouble(dvCurrent.Rows[i].Cells[14].Value.ToString());
                            value3 = Convert.ToDouble(dvCurrent.Rows[i].Cells[11].Value.ToString());
                            value4 = Convert.ToDouble(dvCurrent.Rows[i].Cells[12].Value.ToString());
                            value5 = Convert.ToDouble(dvCurrent.Rows[i].Cells[4].Value.ToString());
                            value6 = Convert.ToDouble(dvCurrent.Rows[1].Cells[4].Value.ToString());
                            //  double  value1 = value2 - 0.05;
                            if (value1 > 0.05)
                            {
                                dvCurrent.Rows[i].Cells[7].Style.BackColor = Color.Red;

                            }
                            if (value2 > 0.05)
                            {
                                dvCurrent.Rows[i].Cells[14].Style.BackColor = Color.Red;

                            }
                            if (value3 > 0.03)
                            {
                                dvCurrent.Rows[i].Cells[11].Style.BackColor = Color.Red;

                            }
                            if (value4 > 0.03)
                            {
                                dvCurrent.Rows[i].Cells[12].Style.BackColor = Color.Red;

                            }
                            //begin add by yuan 2018-07-12   ���Ӹ���̼¯�����׸�Ԥ�� 
                            //���������ޣ�%��	0.02	0.025	0.03	0.035	0.04
                            //Ԥ�����ޣ�%��	   0.015	0.018	0.020	0.025	0.025
                            if (value6 == 0.02 && value5 >= 0.015)
                            {
                                dvCurrent.Rows[i].Cells[4].Style.BackColor = Color.MediumPurple;
                            }
                            else if (value6 == 0.025 && value5 >= 0.018)
                            {
                                dvCurrent.Rows[i].Cells[4].Style.BackColor = Color.MediumPurple;
                            }
                            else if (value6 == 0.03 && value5 >= 0.02)
                            {
                                dvCurrent.Rows[i].Cells[4].Style.BackColor = Color.MediumPurple;
                            }
                            else if (value6 == 0.035 && value5 >= 0.025)
                            {
                                dvCurrent.Rows[i].Cells[4].Style.BackColor = Color.MediumPurple;
                            }
                            else if (value6 == 0.04 && value5 >= 0.025)
                            {
                                dvCurrent.Rows[i].Cells[4].Style.BackColor = Color.MediumPurple;
                            }
                            //end add by yuan 2018-07-12
                        }
                        #endregion

                        #region �������ΪLF¯��GG 2020-05-11
                        try
                        {
                            if (cell.Value.ToString() == "GG")//�ж�Ϊ¯�ո���̼���Ϳɫ�жϡ�
                            {
                                //if (strColumnName == "Cr" && dRealValue > 0.05)
                                double value1 = 0;//Cr
                                double value2 = 0;//Cu
                                double value3 = 0;//ca

                                value1 = Convert.ToDouble(dvCurrent.Rows[i].Cells[7].Value.ToString());
                                value2 = Convert.ToDouble(dvCurrent.Rows[i].Cells[14].Value.ToString());
                                value3 = Convert.ToDouble(dvCurrent.Rows[i].Cells[13].Value.ToString());
                                //var CrMin = Convert.ToDouble(dsInCtrol.Tables[0].Rows[0]["Cr_Min"].ToString());

                                if (dsInCtrol.Tables[0].Rows[0]["Cr_Min"] != null && dsInCtrol.Tables[0].Rows[0]["Cr_Min"].ToString() != "")
                                {
                                    if (Convert.ToDouble(dsInCtrol.Tables[0].Rows[0]["Cr_Min"].ToString()) <= 0.02)
                                    {
                                        if (value1 > 0.08)
                                        {
                                            dvCurrent.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                        }
                                    }
                                }
                                else
                                {
                                    if (value1 > 0.08)
                                    {
                                        dvCurrent.Rows[i].Cells[7].Style.BackColor = Color.Yellow;
                                    }
                                }


                                if (dsInCtrol.Tables[0].Rows[0]["Cu_Min"] != null && dsInCtrol.Tables[0].Rows[0]["Cu_Min"].ToString() != "")
                                {
                                    if (Convert.ToDouble(dsInCtrol.Tables[0].Rows[0]["Cu_Min"].ToString()) <= 0.02)
                                    {
                                        if (value2 > 0.05)
                                        {
                                            dvCurrent.Rows[i].Cells[14].Style.BackColor = Color.Yellow;

                                        }
                                    }
                                }
                                else
                                {
                                    if (value2 > 0.05)
                                    {
                                        dvCurrent.Rows[i].Cells[14].Style.BackColor = Color.Yellow;

                                    }
                                }
                                //caʹ��AL���ڿر�׼
                                if (dsInCtrol.Tables[0].Rows[0]["Al_Min"] != null && dsInCtrol.Tables[0].Rows[0]["Al_Min"].ToString() != "")
                                {
                                    if (Convert.ToDouble(dsInCtrol.Tables[0].Rows[0]["Al_Min"].ToString()) >= 0.01)
                                    {
                                        if (value3 < 0.001)
                                        {
                                            dvCurrent.Rows[i].Cells[13].Style.BackColor = Color.Yellow;
                                        }
                                    }
                                }
                                //else
                                //{
                                //    if (value3 < 0.001)
                                //    {
                                //        dvCurrent.Rows[i].Cells[13].Style.BackColor = Color.Red;
                                //    }
                                //}
                                //  double  value1 = value2 - 0.05;





                            }
                        }
                        catch
                        { 
                        
                        }
                       
                        #endregion
                    }



                }
                
            }
            catch { }
        }
        //[2009-03-10 sun]
        public static void SetDataGridViewCellBackColorByRow1(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsGB, AppSvrHMI.L3DataSet dsInCtrol, int StartRow)
        {
            try
            {
                if (dvCurrent == null || dvCurrent.Rows.Count < 1)
                    return;
                if (dsGB == null || dsInCtrol == null || (dsGB.Tables[0].Rows.Count < 1 && dsInCtrol.Tables[0].Rows.Count < 1))
                    return;

                int CLib = 0, Other3Lib = 0;
                for (int i = 0; i < dvCurrent.Columns.Count; i++)
                {
                    if (dvCurrent.Columns[i].HeaderText == "C")
                        CLib = i;
                    if (dvCurrent.Columns[i].HeaderText == "Other3")
                        Other3Lib = i;
                }
                double dRealValue = 0, dGBMax = 0, dGBMin = 0, dInCtrolMax = 0, dInCtrolMin = 0;
                string strColumnName = "";
                for (int i = StartRow; i < dvCurrent.Rows.Count; i++)
                {
                    for (int j = CLib; j < Other3Lib; j++)
                    {
                        DataGridViewCell cell = dvCurrent.Rows[i].Cells[j];
                        try
                        {
                            //��ȡʵ���ɷ�����
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].HeaderText.Trim();
                            //ȡ������
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }
                            dRealValue = Convert.ToDouble(cell.Value.ToString());



                            //�ж��Ƿ�У��
                            if (dRealValue > 0)
                            {
                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Max"] == null || dsGB.Tables[0].Rows[0][strColumnName + "_Max"].ToString() == "")
                                    dGBMax = -1;
                                else
                                    dGBMax = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Max"].ToString());

                                if (dsGB.Tables[0].Rows[0][strColumnName + "_Min"] == null || dsGB.Tables[0].Rows[0][strColumnName + "_Min"].ToString() == "")
                                    dGBMin = -1;
                                else
                                    dGBMin = Convert.ToDouble(dsGB.Tables[0].Rows[0][strColumnName + "_Min"].ToString());

                                if (dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"] == null || dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"].ToString() == "")
                                    dInCtrolMax = -1;
                                else
                                    dInCtrolMax = Convert.ToDouble(dsInCtrol.Tables[0].Rows[0][strColumnName + "_Max"].ToString());

                                if (dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"] == null || dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"].ToString() == "")
                                    dInCtrolMin = -1;
                                else
                                    dInCtrolMin = Convert.ToDouble(dsInCtrol.Tables[0].Rows[0][strColumnName + "_Min"].ToString());


                                if (dGBMax >= 0)
                                {
                                    if (dRealValue > dGBMax)
                                    {
                                        cell.Style.BackColor = Color.Red;
                                        continue;
                                    }
                                    if (dInCtrolMax >= 0)
                                    {
                                        if (dInCtrolMax < dRealValue)
                                        {
                                            cell.Style.BackColor = Color.LightPink;
                                            continue;
                                        }
                                        if (dGBMin >= 0)
                                        {
                                            if (dRealValue < dGBMin)
                                            {
                                                cell.Style.BackColor = Color.Yellow;
                                                continue;
                                            }
                                            if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                            {
                                                cell.Style.BackColor = Color.Khaki;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                            {
                                                cell.Style.BackColor = Color.Khaki;
                                                continue;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (dGBMin >= 0 && dRealValue < dGBMin)
                                        {
                                            cell.Style.BackColor = Color.Yellow;
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    if (dInCtrolMax >= 0)
                                    {
                                        if (dRealValue > dInCtrolMax)
                                        {
                                            cell.Style.BackColor = Color.LightPink;
                                            continue;
                                        }
                                        if (dInCtrolMin >= 0 && dRealValue < dInCtrolMin)
                                        {
                                            cell.Style.BackColor = Color.Khaki;
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }
        public static void dv_Element_Draw(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsElement)
        {
            if (dsElement.Tables[0].Rows.Count < 0)
                return;
            try
            {
                int idsRowsCount = dsElement.Tables[0].Rows.Count;

                dvCurrent.Rows.Add(idsRowsCount + 1);
                int iRowIndex = 7;
                dvCurrent.Rows[6].Cells[0].Value = "����ɷ�";
                dvCurrent.Rows[6].DefaultCellStyle.BackColor = Color.Gray;
                while (iRowIndex > 6 && iRowIndex <= idsRowsCount + 6)
                {
                    //��������ʾ��Ϣ
                    dvCurrent.Rows[iRowIndex].Cells[0].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sample_Count"].ToString();

                    /****************************************�����ɷ�*****************************************/
                    dvCurrent.Rows[iRowIndex].Cells[1].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["C"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[2].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Si"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[3].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Mn"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[4].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["P"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[5].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["S"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[6].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Al"].ToString();
                   

                    dvCurrent.Rows[iRowIndex].Cells[7].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Cr"].ToString();
                   
                    dvCurrent.Rows[iRowIndex].Cells[8].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ti"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[9].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["V"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[10].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["B"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[11].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Mo"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[12].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ni"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[13].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ca"].ToString();

                    /****************************************�������ɷ�*****************************************/
                    dvCurrent.Rows[iRowIndex].Cells[14].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Cu"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[15].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Nb"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[16].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sn"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[17].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["W"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[18].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Pb"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[19].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Zn"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[20].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["N"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[21].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["H"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[22].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["O"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[23].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["As"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[24].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["AlS"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[25].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sb"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[26].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Re"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[27].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ceq"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[28].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["CrNi"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[29].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["CrCu"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[30].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["CrNiCu"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[31].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Other1"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[32].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Other2"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[33].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Other3"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[34].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sample_Type"].ToString();
                    
                  
                    //������1
                    iRowIndex++;
                    //dvCurrent.Rows[iRowIndex].Cells[7].Style.BackColor = Color.Red;
                }
            }
            catch(Exception ex)
            {
                if (dvCurrent.Rows.Count > 0)
                    dvCurrent.Rows.Clear();
            }
        }

        public static void dv_CCMElement_Draw(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsElement)
        {
            if (dsElement.Tables[0].Rows.Count < 1)
                return;
            try
            {
                int idsRowsCount = dsElement.Tables[0].Rows.Count;

                dvCurrent.Rows.Add(idsRowsCount + 1);
                int iRowIndex = 7;
                dvCurrent.Rows[6].Cells[0].Value = "����ɷ�";
                dvCurrent.Rows[6].DefaultCellStyle.BackColor = Color.Gray;
                while (iRowIndex > 6 && iRowIndex <= idsRowsCount + 6)
                {
                    //��������ʾ��Ϣ
                    dvCurrent.Rows[iRowIndex].Cells[0].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sample_Count"].ToString();

                    /****************************************�����ɷ�*****************************************/
                    dvCurrent.Rows[iRowIndex].Cells[1].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["C"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[2].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Si"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[3].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Mn"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[4].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["P"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[5].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["S"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[6].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Cu"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[7].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ni"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[8].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Cr"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[9].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Mo"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[10].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["V"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[11].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Nb"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[12].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Al"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[13].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["AlS"].ToString();

                    /****************************************�������ɷ�*****************************************/
                    dvCurrent.Rows[iRowIndex].Cells[14].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ti"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[15].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["B"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[16].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sb"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[17].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sn"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[18].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["As"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[19].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Zn"].ToString();
                    //dvCurrent.Rows[iRowIndex].Cells[20].Value = dsElement.Tables[0].Rows[iRowIndex - 4]["Zr"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[20].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ca"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[21].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["W"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[22].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Pb"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[23].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Re"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[24].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Ceq"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[25].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["N"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[26].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["H"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[27].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["O"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[28].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["CrNi"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[29].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["CrCu"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[30].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["CrNiCu"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[31].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Other1"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[32].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Other2"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[33].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Other3"].ToString();
                    dvCurrent.Rows[iRowIndex].Cells[34].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sample_Type"].ToString();

                    //������1
                    iRowIndex++;
                }
            }
            catch
            {
                if (dvCurrent.Rows.Count > 0)
                    dvCurrent.Rows.Clear();
            }
        }

        /// <summary>
        /// ��DataGridView�ɷ���Ϣ����
        /// </summary>
        /// <param name="adapter">L3Adapter</param>
        /// <param name="dvCurrent">�����Ƶ�dv</param>
        /// <param name="strSteelGradeIndex">�ɷֶ�Ӧ�����ּǺ�</param>
        /// <param name="iUnitTypeID">����ID 2:BOF,4:LF,5:RH,6:CCM</param>
        public static void dv_Info_Element_Cell_BaceColor(AppSvrHMI.L3Adapter adapter, DataGridView dvCurrent, string strSteelGradeIndex, int iUnitTypeID)
        {
            try
            {
                if (adapter == null || adapter.Session == null)
                    return;
                if (dvCurrent == null || dvCurrent.Rows.Count < 1 || strSteelGradeIndex == "" || iUnitTypeID == 0)
                    return;

                string strSourceMethod_GB = "select * from CQA_Product_Sheet where steelgradeindex = '" + strSteelGradeIndex + "'";
                AppSvrHMI.L3DataSet dsGB = GetdsStandard(adapter, strSourceMethod_GB);
                if (dsGB == null || dsGB.Tables[0].Rows.Count < 1)
                    return;

                switch (iUnitTypeID)
                {
                    case 2:
                        string strSourceMethod_BOF_InControl = "select * from CQA_BOF_Std_InCtr_Ele where steelgradeindex = '" + strSteelGradeIndex + "'";
                        AppSvrHMI.L3DataSet ds_BOF_InControl = GetdsStandard(adapter, strSourceMethod_BOF_InControl);
                        SetDataGridViewCellBackColor(dvCurrent, dsGB, ds_BOF_InControl);
                        break;
                    case 4:
                        string strSourceMethod_LF_InControl = "select * from CQA_LF_Std_InCtr_Ele where steelgradeindex = '" + strSteelGradeIndex + "'";
                        AppSvrHMI.L3DataSet ds_LF_InControl = GetdsStandard(adapter, strSourceMethod_LF_InControl);
                        SetDataGridViewCellBackColor(dvCurrent, dsGB, ds_LF_InControl);
                        break;
                    case 5:
                        string strSourceMethod_RH_InControl = "select * from CQA_RH_Std_InCtr_Ele where steelgradeindex = '" + strSteelGradeIndex + "'";
                        AppSvrHMI.L3DataSet ds_RH_InControl = GetdsStandard(adapter, strSourceMethod_RH_InControl);
                        SetDataGridViewCellBackColor(dvCurrent, dsGB, ds_RH_InControl);
                        break;
                    case 6:
                        SetDataGridViewCellBackColor(dvCurrent, dsGB);
                        break;
                }
            }
            catch { }
        }

        /// <summary>
        /// ��ȡ�ɷֱ�׼���ݽṹ
        /// </summary>
        /// <returns>���ر�׼���ݽṹ</returns>
        public static AppSvrHMI.L3DataSet GetdsStandardStructure()
        {
            try
            {
                AppSvrHMI.L3DataSet dsReturn = new AppSvrHMI.L3DataSet();
                dsReturn.AutoSubscribe = false;
                dsReturn.DataSetName = "L3DataSet";
                dsReturn.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
                dsReturn.SourceMethod = "";
                dsReturn.Tables.Add();
                dsReturn.Tables[0].TableName = "L3DataTable";
                dsReturn.Tables[0].Columns.Add("C_Min");
                dsReturn.Tables[0].Columns.Add("C_Max");
                dsReturn.Tables[0].Columns.Add("Si_Min");
                dsReturn.Tables[0].Columns.Add("Si_Max");
                dsReturn.Tables[0].Columns.Add("Mn_Min");
                dsReturn.Tables[0].Columns.Add("Mn_Max");
                dsReturn.Tables[0].Columns.Add("P_Min");
                dsReturn.Tables[0].Columns.Add("P_Max");
                dsReturn.Tables[0].Columns.Add("S_Min");
                dsReturn.Tables[0].Columns.Add("S_Max");
                dsReturn.Tables[0].Columns.Add("Cu_Min");
                dsReturn.Tables[0].Columns.Add("Cu_Max");
                dsReturn.Tables[0].Columns.Add("Ni_Min");
                dsReturn.Tables[0].Columns.Add("Ni_Max");
                dsReturn.Tables[0].Columns.Add("Cr_Min");
                dsReturn.Tables[0].Columns.Add("Cr_Max");
                dsReturn.Tables[0].Columns.Add("Mo_Min");
                dsReturn.Tables[0].Columns.Add("Mo_Max");
                dsReturn.Tables[0].Columns.Add("V_Min");
                dsReturn.Tables[0].Columns.Add("V_Max");
                dsReturn.Tables[0].Columns.Add("Nb_Min");
                dsReturn.Tables[0].Columns.Add("Nb_Max");
                dsReturn.Tables[0].Columns.Add("Al_Min");
                dsReturn.Tables[0].Columns.Add("Al_Max");
                dsReturn.Tables[0].Columns.Add("AlS_Min");
                dsReturn.Tables[0].Columns.Add("AlS_Max");
                dsReturn.Tables[0].Columns.Add("Ti_Min");
                dsReturn.Tables[0].Columns.Add("Ti_Max");
                dsReturn.Tables[0].Columns.Add("B_Min");
                dsReturn.Tables[0].Columns.Add("B_Max");
                dsReturn.Tables[0].Columns.Add("Sb_Min");
                dsReturn.Tables[0].Columns.Add("Sb_Max");
                dsReturn.Tables[0].Columns.Add("Sn_Min");
                dsReturn.Tables[0].Columns.Add("Sn_Max");
                dsReturn.Tables[0].Columns.Add("As_Min");
                dsReturn.Tables[0].Columns.Add("As_Max");
                dsReturn.Tables[0].Columns.Add("Zn_Min");
                dsReturn.Tables[0].Columns.Add("Zn_Max");
                dsReturn.Tables[0].Columns.Add("Zr_Min");
                dsReturn.Tables[0].Columns.Add("Zr_Max");
                dsReturn.Tables[0].Columns.Add("Ca_Min");
                dsReturn.Tables[0].Columns.Add("Ca_Max");
                dsReturn.Tables[0].Columns.Add("W_Min");
                dsReturn.Tables[0].Columns.Add("W_Max");
                dsReturn.Tables[0].Columns.Add("Pb_Min");
                dsReturn.Tables[0].Columns.Add("Pb_Max");
                dsReturn.Tables[0].Columns.Add("Re_Min");
                dsReturn.Tables[0].Columns.Add("Re_Max");
                dsReturn.Tables[0].Columns.Add("Ceq_Min");
                dsReturn.Tables[0].Columns.Add("Ceq_Max");
                dsReturn.Tables[0].Columns.Add("N_Min");
                dsReturn.Tables[0].Columns.Add("N_Max");
                dsReturn.Tables[0].Columns.Add("H_Min");
                dsReturn.Tables[0].Columns.Add("H_Max");
                dsReturn.Tables[0].Columns.Add("O_Min");
                dsReturn.Tables[0].Columns.Add("O_Max");
                dsReturn.Tables[0].Columns.Add("CrNi_Min");
                dsReturn.Tables[0].Columns.Add("CrNi_Max");
                dsReturn.Tables[0].Columns.Add("CrCu_Min");
                dsReturn.Tables[0].Columns.Add("CrCu_Max");
                dsReturn.Tables[0].Columns.Add("CrNiCu_Min");
                dsReturn.Tables[0].Columns.Add("CrNiCu_Max");
                dsReturn.Tables[0].Columns.Add("Other1_Min");
                dsReturn.Tables[0].Columns.Add("Other1_Max");
                dsReturn.Tables[0].Columns.Add("Other2_Min");
                dsReturn.Tables[0].Columns.Add("Other2_Max");
                dsReturn.Tables[0].Columns.Add("Other3_Min");
                dsReturn.Tables[0].Columns.Add("Other3_Max");
                dsReturn.AcceptChanges();
                return dsReturn;
            }
            catch { return null; }
        }

        //�����м� gridView����Huyunhai 2011-03-28
        public static void dataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView ss = (DataGridView)sender;
            //Microsoft.Office.Interop.Excel.Rectangle
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X - 10, e.RowBounds.Location.Y, ss.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), ss.RowHeadersDefaultCellStyle.Font, rectangle, ss.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// ����SQL��ѯ����ȡ�ɷֱ�׼��Ϣ
        /// </summary>
        /// <param name="adapter">L3Adapter</param>
        /// <param name="strSourceMethod">SQL��ѯ���</param>
        /// <returns>���صı�׼��Ϣ</returns>
        public static AppSvrHMI.L3DataSet GetdsStandard(AppSvrHMI.L3Adapter adapter, string strSourceMethod)
        {
            try
            {
                if (adapter == null || adapter.Session == null)
                    return null;
                AppSvrHMI.L3DataSet dsStandard = GetdsStandardStructure();
                dsStandard.SourceMethod = strSourceMethod;
                dsStandard.L3DataAdapter = adapter;
                return dsStandard;
            }
            catch { return null; }

        }


        /******Modfify By Huyunhai 2011-3-17*******/
        /// <summary>
        /// ���÷���   By Huyunhai
        /// </summary>
        /// <param name="dtModified">�޸�</param>
        /// <param name="ds">ԭʼֵ</param>
        /// <returns></returns>
        /// 
        public static bool isModifyForMaterial(System.Data.DataTable dtModified, AppSvrHMI.L3DataSet ds, AppSvrIF.Session session, AppSvrHMI.L3DataSet dsForStoreMagQuery)
        {
            if (dtModified == null)
            {
                return false;
            }
            //string tempt1 = "";
            //string tempt2 = "";
            List<int> tempt1 = new List<int>();
            List<int> tempt2 = new List<int>();
            for (int i = 0; i < dtModified.Rows.Count; i++)
            {
                string Alloy_Area = dtModified.Rows[i]["Alloy_Area"].ToString();//��ȡ���޸ĵĲ�λ
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    if (ds.Tables[0].Rows[j]["Alloy_Area"].Equals(Alloy_Area))
                    {
                        if (ds.Tables[0].Rows[j]["Alloy_Code"] != dtModified.Rows[i]["Alloy_Code"])
                        {
                            tempt1.Add(i);//�޸ĵ�
                            tempt2.Add(j);//ԭʼ��
                            break;
                        }
                    }
                }
            }

            if ((tempt2.Count == tempt1.Count) && (tempt1.Count > 0))
            {
                for (int k = 0; k < tempt1.Count; k++)
                {
                    // DataSet dsTempt = new DataSet();
                    //dsTempt = dsForStoreMagQuery.Clone();
                    DataRow dr = dsForStoreMagQuery.Tables[0].NewRow();

                    dr["StoreID"] = dtModified.Rows[Convert.ToInt32(tempt1[k].ToString())]["Alloy_Area"].ToString();//�洢�ϲֲ�λ��des

                    //dr["StoreID"] = dtModified.Rows[Convert.ToInt32(tempt1[k])]["Alloy_Area"].ToString();//�洢�ϲֲ�λ��des
                    if (ds.Tables[0].Rows[Convert.ToInt32(tempt2[k].ToString())]["Alloy_Code"].ToString().Trim() == "")//���ԭ�������ϱ���Ϊ��
                    {
                        dr["BeforMaterialName"] = "";//ά��ǰ���ϱ���
                        dr["AfterMaterialName"] = dtModified.Rows[Convert.ToInt32(tempt1[k].ToString())]["Alloy_Code"].ToString();// ά�������ϱ���
                        dr["OperateMode"] = "�����Ͻ����";
                        string dateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dr["OperatorTime"] = dateTime;
                        dr["Operater"] = session.User;

                        dsForStoreMagQuery.Tables[0].Rows.Add(dr);
                        //dsTempt.Tables[0].Rows.Clear();
                        try
                        {
                            dsForStoreMagQuery.UpdateData(); //�޸ı�CSTOREOPERATELOG 

                        }
                        catch
                        {
                            return false;
                        }
                        continue;
                    }
                    else
                    {
                        dr["BeforMaterialName"] = ds.Tables[0].Rows[Convert.ToInt32(tempt2[k].ToString())]["Alloy_Code"].ToString();
                        dr["AfterMaterialName"] = dtModified.Rows[Convert.ToInt32(tempt1[k].ToString())]["Alloy_Code"].ToString();// ά�������ϱ���
                        dr["OperateMode"] = "�޸ĺϽ����";
                        string dateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dr["OperatorTime"] = dateTime;
                        dr["Operater"] = session.User;

                        //dsForStoreMagQuery.Tables[0].Rows.Add(dr);
                        dsForStoreMagQuery.Tables[0].ImportRow(dr);
                        //dsTempt.Tables[0].Rows.Clear();
                        try
                        {
                            dsForStoreMagQuery.UpdateData(); //�޸ı�CSTOREOPERATELOG 

                        }
                        catch
                        {
                            return false;
                        }
                        continue;
                    }



                }

            }
            return true;


        }
        /*******Modify END*****/


    }
}


