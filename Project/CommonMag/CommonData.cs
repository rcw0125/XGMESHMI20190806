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
    //通用数据定义
    public class CommonData
    {
        //自定义颜色
        public const String Color_Code_Control = "Control";//系统颜色
        public const String Color_Code_Red = "Red";//系统红
        public const String Color_Code_Orange = "Orange";//系统橙
        public const String Color_Code_Yellow = "Yellow";//系统黄
        public const String Color_Code_Green = "Green";//系统绿
        public const String Color_Code_Blue = "Blue";//系统蓝
        public const String Color_Code_OrangeRed = "OrangeRed ";
        public const String Color_Code_SteelBlue = "SteelBlue";//
        public const String Color_Code_Pink = "Pink";//
        public const String Color_Code_Sienna = "Color_Code_Sienna";//

        /// <summary>
        /// objUri: 当前班次班别类 "XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101"
        /// </summary>
        public const String CCURRENT_SHIFT_INFO_OBJ = "XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101";
        /// <summary>
        /// objUri: 混铁炉管理类 "XGMESLogic\\MIXFMag\\CMIF_Unit_Mag\\"
        /// </summary>
        public const string MIF_CLASS_URI = "XGMESLogic\\MIXFMag\\CMIF_Unit_Mag\\";

        /// <summary>
        /// objUri: 转炉管理类 "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\"
        /// </summary>
        public const string BOF_CLASS_URI = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\";

        /// <summary>
        /// objUri: 转炉管理类 "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\"
        /// </summary>
        public const string MELT_CLASS_URI = "XGMESLogic\\MELTMag\\CMELT_Unit_Mag\\";
        /// <summary>
        /// objUri: 炉后管理类 "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\"
        /// </summary>
        public const string BOF_SIDE_CLASS_URI = "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\";
        /// <summary>
        /// objUri: LF炉管理类 "XGMESLogic\\LFMag\\CLF_Unit_Mag\\"
        /// </summary>
        public const string LF_CLASS_URI = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\";
        /// <summary>
        /// objUri: RH炉管理类 "XGMESLogic\\RHMag\\CRH_Unit_Mag\\"
        /// </summary>
        public const string RH_CLASS_URI = "XGMESLogic\\RHMag\\CRH_Unit_Mag\\";
        /// <summary>
        /// objUri: 连铸管理类 "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\"
        /// </summary>
        public const string CCM_CLASS_URI = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\";
        /// <summary>
        /// objUri: LF炉工位类 "XGMESLogic\\LFMag\\CLF_Prod_Area\\"
        /// </summary>
        public const string LF_CLASS_AREA_URI = "XGMESLogic\\LFMag\\CLF_Prod_Area\\";
        /// <summary>
        /// objUri: RH炉工位类 "XGMESLogic\\RHMag\\CRH_Prod_Area\\"
        /// </summary>
        public const string RH_CLASS_AREA_URI = "XGMESLogic\\RHMag\\CRH_Prod_Area\\";
        /// <summary>
        /// objUri: LF炉基本数据类 "XGMESLogic\\LFMag\\CLF_Base_Data"
        /// </summary>
        public const string LF_BASE_DATA_URI = "XGMESLogic\\LFMag\\CLF_Base_Data";
        /// <summary>
        /// objUri: RH炉基本数据类 "XGMESLogic\\RHMag\\CRH_Base_Data"
        /// </summary>
        public const string RH_BASE_DATA_URI = "XGMESLogic\\RHMag\\CRH_Base_Data";
        /// <summary>
        /// objUri: 连铸基本数据类 "XGMESLogic\\CCMMag\\CCCM_Base_Data\\"
        /// </summary>
        public const string CCM_BASE_DATA_URI = "XGMESLogic\\CCMMag\\CCCM_Base_Data\\";
        /// <summary>
        /// objUri: 连铸过程处理数据类 "XGMESLogic\\CCMMag\\CCCM_Process_Data\\"
        /// </summary>
        public const string CCM_PROCESS_DATA_URI = "XGMESLogic\\CCMMag\\CCCM_Process_Data\\";

        //机组代码
        /// <summary>
        /// 机组代码: 1#混铁炉 S11
        /// </summary>
        public const String MIF_UNIT_01ID = "S11";
        /// <summary>
        /// 机组代码: 2#混铁炉 S12
        /// </summary>
        public const String MIF_UNIT_02ID = "S12";

        //add by hyh 2012-03-29
        /// <summary>
        /// 机组代码: 3#混铁炉 S12
        /// </summary>
        public const String MIF_UNIT_03ID = "S13";
        //end

        /// <summary>
        /// 机组代码: 1#转炉 S21
        /// </summary>
        public const String BOF_UNIT_01ID = "S21";
        /// <summary>
        /// 机组代码: 2#转炉 S22
        /// </summary>
        public const String BOF_UNIT_02ID = "S22";
        /// <summary>
        /// 机组代码: 3#转炉 S23
        /// </summary>
        public const String BOF_UNIT_03ID = "S23";
        /// <summary>
        /// 机组代码: 4#转炉 S24
        /// </summary>
        public const String BOF_UNIT_04ID = "S24";
        /// 机组代码: 5#转炉 S25
        /// </summary>
        public const String BOF_UNIT_05ID = "S25";

        /// <summary>
        /// 机组代码: 1#转炉炉后 S31
        /// </summary>
        public const String TAP_UNIT_01ID = "S31";
        /// <summary>
        /// 机组代码: 2#转炉炉后 S32
        /// </summary>
        public const String TAP_UNIT_02ID = "S32";
        /// <summary>
        /// 机组代码: 3#转炉炉后 S33
        /// </summary>
        public const String TAP_UNIT_03ID = "S33";
        /// <summary>
        /// 机组代码: 4#转炉炉后 S34
        /// </summary>
        public const String TAP_UNIT_04ID = "S34";

        /// <summary>
        /// 机组代码: 1#LF炉 S41
        /// </summary>
        public const String LF_UNIT_01ID = "S41";
        /// <summary>
        /// 机组代码: 2#LF炉 S42
        /// </summary>
        public const String LF_UNIT_02ID = "S42";
        /// <summary>
        /// 机组代码: 3#LF炉 S43
        /// </summary>
        public const String LF_UNIT_03ID = "S43";

        /// <summary>
        /// 机组代码: 1#RH炉 S51
        /// </summary>
        public const String RH_UNIT_01ID = "S51";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (新建5#LF炉)***********/
        /// <summary>
        /// 机组代码: 5#LF炉 S45
        /// </summary>
        public const String LF_UNIT_05ID = "S45";
        // const 关键字用于修改字段或局部变量的声明。它指定字段或局部变量的值是常数，不能被修改。
        /*************END***************/

        //add by hyh 2012-05-09  新增4#LF
        /// <summary>
        /// 机组代码: 4#LF炉 S44
        /// </summary>
        public const String LF_UNIT_04ID = "S44";

        /// <summary>
        /// 机组代码: 1#铸机 S61
        /// </summary>
        public const String CCM_UNIT_01ID = "S61";
        /// <summary>
        /// 机组代码: 2#铸机 S62
        /// </summary>
        public const String CCM_UNIT_02ID = "S62";
        /// <summary>
        /// 机组代码: 3#铸机 S63
        /// </summary>
        public const String CCM_UNIT_03ID = "S63";
        /// <summary>
        /// 机组代码: 4#铸机 S64
        /// </summary>
        public const String CCM_UNIT_04ID = "S64";
        /// <summary>
        /// 机组代码: 5#铸机 S65
        /// </summary>
        public const String CCM_UNIT_05ID = "S65";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (新建7#连铸机)***********/
        /// <summary>
        /// 机组代码: 7#铸机 S67
        /// </summary>
        public const String CCM_UNIT_07ID = "S67";
        /*************END***************/

        /*************Modfiy Begin at 2012-5-15 By hyh (新建6#连铸机)***********/
        /// <summary>
        /// 机组代码: 6#铸机 S66
        /// </summary>
        public const String CCM_UNIT_06ID = "S66";
        /*************END***************/


        //  [12/29/2008 sun]
        /// <summary>
        /// 袋装合金堆放处: 1#LF S81Z02
        /// </summary>
        public const String CLF01_GROUND_ALLOY_POSSITION = "S81Z02";
        /// <summary>
        /// 袋装合金堆放处: 3#LFRH S81Z04
        /// </summary>
        public const String CLF03RH_GROUND_ALLOY_POSSITION = "S81Z04";
        /// <summary>
        /// 袋装合金堆放处: 2#LF S81Z03
        /// </summary>
        public const String CLF02_GROUND_ALLOY_POSSITION = "S81Z03";
        /// <summary>
        /// 袋装合金堆放处: 转炉 S81Z01
        /// </summary>
        public const String CBOF_GROUND_ALLOY_POSSITION = "S81Z01";

        //简化验取样地点类型
        /// <summary>
        /// 取样地点类型: 混铁炉取样H
        /// </summary>
        public const String MIF_SAMPLE_TYPE = "H";
        /// <summary>
        /// 取样地点类型: 抽查铁水取样T
        /// </summary>
        public const String IRON_SAMPLE_TYPE = "T";
        /// <summary>
        /// 取样地点类型: 转炉取样Z
        /// </summary>
        public const String BOF_SAMPLE_TYPE = "Z";
        /// <summary>
        /// 取样地点类型: LF炉取样F
        /// </summary>
        public const String LF_SAMPLE_TYPE = "F";
        /// <summary>
        /// 取样地点类型: RH炉取样R
        /// </summary>
        public const String RH_SAMPLE_TYPE = "R";
        /// <summary>
        /// 取样地点类型: 连铸取样C
        /// </summary>
        public const String CCM_SAMPLE_TYPE = "C";

        //质量试样类别QA_Sample_Type
        /// <summary>
        /// 质量试样类别: 高炉铁水渣样ZG
        /// </summary>
        public const String QA_Sample_Type_ZG = "ZG";
        /// <summary>
        /// 质量试样类别: 铁包样[现在没有用]TS
        /// </summary>
        public const String QA_Sample_Type_TS = "TS";
        /// <summary>
        /// 质量试样类别: 抽查铁水样TC
        /// </summary>
        public const String QA_Sample_Type_TC = "TC";
        /// <summary>
        /// 质量试样类别: 混铁炉全分析样TA
        /// </summary>
        public const String QA_Sample_Type_TA = "TA";
        /// <summary>
        /// 质量试样类别: 转炉铁包样TL
        /// </summary>
        public const String QA_Sample_Type_TL = "TL";
        /// <summary>
        /// 质量试样类别: 混铁炉样TH
        /// </summary>
        public const String QA_Sample_Type_TH = "TH";
        /// <summary>
        /// 质量试样类别: LF精渣样ZF
        /// </summary>
        public const String QA_Sample_Type_ZF = "ZF";
        /// <summary>
        /// 质量试样类别: RH精渣样ZR
        /// </summary>
        public const String QA_Sample_Type_ZR = "ZR";
        /// <summary>
        /// 质量试样类别: 连铸中包渣样ZL
        /// </summary>
        public const String QA_Sample_Type_ZL = "ZL";
        /// <summary>
        /// 质量试样类别: 转炉渣样ZZ
        /// </summary>
        public const String QA_Sample_Type_ZZ = "ZZ";
        /// <summary>
        /// 质量试样类别: 连铸中包样GL
        /// </summary>
        public const String QA_Sample_Type_GL = "GL";
        /// <summary>
        /// 质量试样类别: 炉终样GZ
        /// </summary>
        public const String QA_Sample_Type_GZ = "GZ";
        /// <summary>
        /// 质量试样类别: 氮后样GN
        /// </summary>
        public const String QA_Sample_Type_GN = "GN";
        /// <summary>
        /// 质量试样类别: 过程样GG
        /// </summary>
        public const String QA_Sample_Type_GG = "GG";
        /// <summary>
        /// 质量试样类别: 成品样GP
        /// </summary>
        public const String QA_Sample_Type_GP = "GP";
        /// <summary>
        /// 质量试样类别: 割样GE
        /// </summary>
        public const String QA_Sample_Type_GE = "GE";
        /// <summary>
        /// 质量试样类别: 气体样GQ
        /// </summary>
        public const String QA_Sample_Type_GQ = "GQ";
        /// <summary>
        /// 质量试样类别: 钢坯低倍样GD
        /// </summary>
        public const String QA_Sample_Type_GD = "GD";

        //质量试样地点
        /// <summary>
        /// 质量试样地点: 1#高炉	G1
        /// </summary>
        public const String QA_Sample_Addr_G1 = "G1";
        /// <summary>
        /// 质量试样地点: 2#高炉	G2
        /// </summary>
        public const String QA_Sample_Addr_G2 = "G2";
        /// <summary>
        /// 质量试样地点: 3#高炉	G3
        /// </summary>
        public const String QA_Sample_Addr_G3 = "G3";
        /// <summary>
        /// 质量试样地点: 4#高炉	G4
        /// </summary>
        public const String QA_Sample_Addr_G4 = "G4";
        /// <summary>
        /// 质量试样地点: 5#高炉	G5
        /// </summary>
        public const String QA_Sample_Addr_G5 = "G5";
        /// <summary>
        /// 质量试样地点: 1#混铁炉	H1
        /// </summary>
        public const String QA_Sample_Addr_H1 = "H1";
        /// <summary>
        /// 质量试样地点: 2#混铁炉  H2
        /// </summary>
        public const String QA_Sample_Addr_H2 = "H2";

        //add by hyh 2012-03-29
        /// <summary>
        /// 质量试样地点: 3#混铁炉  H3
        /// </summary>
        public const String QA_Sample_Addr_H3 = "H3";
        //end
        /// <summary>
        /// 质量试样地点: 铁包TB
        /// </summary>	
        public const String QA_Sample_Addr_TB = "TB";
        /// <summary>
        /// 质量试样地点: 铁罐TC
        /// </summary>
        public const String QA_Sample_Addr_TC = "TC";
        /// <summary>
        /// 质量试样地点: 转炉铁水铁包TL
        /// </summary>
        public const String QA_Sample_Addr_TL = "TL";
        /// <summary>
        /// 质量试样地点: 1#转炉Z1
        /// </summary>
        public const String QA_Sample_Addr_Z1 = "Z1";
        /// <summary>
        /// 质量试样地点: 2#转炉Z2
        /// </summary>	
        public const String QA_Sample_Addr_Z2 = "Z2";
        /// <summary>
        /// 质量试样地点: 3#转炉Z3
        /// </summary>	
        public const String QA_Sample_Addr_Z3 = "Z3";
        /// <summary>
        /// 质量试样地点: 4#转炉Z4
        /// </summary>	
        public const String QA_Sample_Addr_Z4 = "Z4";

        /// 质量试样地点: 5#转炉Z5
        /// </summary>	
        public const String QA_Sample_Addr_Z5 = "Z5";
        /// <summary>
        /// 质量试样地点: 1#LF炉F1
        /// </summary>	
        public const String QA_Sample_Addr_F1 = "F1";
        /// <summary>
        /// 质量试样地点: 2#LF炉F2
        /// </summary>	
        public const String QA_Sample_Addr_F2 = "F2";
        /// <summary>
        /// 质量试样地点: 3#LF炉F3
        /// </summary>	
        public const String QA_Sample_Addr_F3 = "F3";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (新建5#LF炉)***********/
        /// <summary>
        /// 质量试样地点: 5#LF炉F5
        /// </summary>	
        public const String QA_Sample_Addr_F5 = "F5";
        /*********END********/

        /*************Modfiy Begin at 2012-05-15 By hyh (新建4#LF炉)***********/
        /// <summary>
        /// 质量试样地点: 4#LF炉F4
        /// </summary>	
        public const String QA_Sample_Addr_F4 = "F4";
        /*********END********/


        /// <summary>
        /// 质量试样地点: 1RH炉R1
        /// </summary>	
        public const String QA_Sample_Addr_R1 = "R1";
        /// <summary>
        /// 质量试样地点: 1#铸机C1
        /// </summary>
        public const String QA_Sample_Addr_C1 = "C1";
        /// <summary>
        /// 质量试样地点: 2#铸机C2
        /// </summary>	
        public const String QA_Sample_Addr_C2 = "C2";
        /// <summary>
        /// 质量试样地点: 3#铸机C3
        /// </summary>	
        public const String QA_Sample_Addr_C3 = "C3";
        /// <summary>
        /// 质量试样地点: 4#铸机C4
        /// </summary>	
        public const String QA_Sample_Addr_C4 = "C4";
        /// <summary>
        /// 质量试样地点: 5#铸机C5
        /// </summary>	
        public const String QA_Sample_Addr_C5 = "C5";

        /*************Modfiy Begin at 2011-02-16 By Huyunhai (新建7#CCM炉)***********/
        /// <summary>
        /// 质量试样地点: 7#铸机C7
        /// </summary>	
        public const String QA_Sample_Addr_C7 = "C7";
        /*********END**********/


        /*************Modfiy Begin at 2012-05-15 By hyh (新建6#CCM炉)***********/
        /// <summary>
        /// 质量试样地点: 6#铸机C6
        /// </summary>	
        public const String QA_Sample_Addr_C6 = "C6";
        /*********END**********/


        //铁包下线原因
        /// <summary>
        /// 铁包下线原因: 01:包壁粘渣严重,处理粘渣
        /// </summary>
        public const String CIRONLADLE_STOPREASON_DREG = "01";
        /// <summary>
        /// 铁包下线原因: 02:包壁或包底温度过高
        /// </summary>
        public const String CIRONLADLE_STOPREASON_TEMP = "02";

        //铁包状态
        /// <summary>
        /// 铁包状态: 打结01
        /// </summary>
        public const String CIRONLADLE_STATUS_TIE = "01";
        /// <summary>
        /// 铁包状态: 冷备(蓝)02
        /// </summary>
        public const String CIRONLADLE_STATUS_COLD = "02";
        /// <summary>
        /// 铁包状态: 小火03
        /// </summary>
        public const String CIRONLADLE_STATUS_SMALL_FIRE = "03";
        /// <summary>
        /// 铁包状态: 中火04
        /// </summary>
        public const String CIRONLADLE_STATUS_MIDDLE_FIRE = "04";
        /// <summary>
        /// 铁包状态: 大火05
        /// </summary>
        public const String CIRONLADLE_STATUS_BIG_FIRE = "05";
        /// <summary>
        /// 铁包状态: 热备(绿)06
        /// </summary>
        public const String CIRONLADLE_STATUS_HOT = "06";
        /// <summary>
        /// 铁包状态: 已分配07
        /// </summary>
        public const String CIRONLADLE_STATUS_DISTRIBUTE = "07";
        /// <summary>
        /// 铁包状态: 使用08
        /// </summary>
        public const String CIRONLADLE_STATUS_USE = "08";
        /// <summary>
        /// 铁包状态: 停用09
        /// </summary>
        public const String CIRONLADLE_STATUS_SUSPEND = "09";
        /// <summary>
        /// 铁包状态: 离线待修(黄)10
        /// </summary>
        public const String CIRONLADLE_STATUS_OFFLINE = "10";


        //中包状态
        /// <summary>
        /// 中包状态: 永久层砌筑01
        /// </summary>
        public const String CTUNDISH_STATUS_INNER_BUILD = "01";
        /// <summary>
        /// 中包状态: 永久层烘烤02
        /// </summary>
        public const String CTUNDISH_STATUS_INNER_FIRE = "02";
        /// <summary>
        /// 中包状态: 工作层砌筑(打结)03
        /// </summary>
        public const String CTUNDISH_STATUS_WORK_DAUB = "03";
        /// <summary>
        /// 中包状态: 工作层烘烤04
        /// </summary>
        public const String CTUNDISH_STATUS_WORK_FIRE = "04";
        /// <summary>
        /// 中包状态: 冷备05
        /// </summary>
        public const String CTUNDISH_STATUS_COLD = "05";
        /// <summary>
        /// 中包状态: 中包上件06
        /// </summary>
        public const String CTUNDISH_STATUS_ISTALL = "06";
        /// <summary>
        /// 中包状态: 热备烘烤07
        /// </summary>
        public const String CTUNDISH_STATUS_HOT_FIRE = "07";
        /// <summary>
        /// 中包状态: 热备08
        /// </summary>
        public const String CTUNDISH_STATUS_HOT = "08";
        /// <summary>
        /// 中包状态: 使用(周转)09
        /// </summary>
        public const String CTUNDISH_STATUS_USE = "09";
        /// <summary>
        /// 中包状态: 离线待修10
        /// </summary>
        public const String CTUNDISH_STATUS_OFFLINE = "10";

        //钢包状态
        /// <summary>
        /// 钢包状态: 永久层砌筑(打结)01
        /// </summary>
        public const String CLADLE_STATUS_INNER_BUILD = "01";
        /// <summary>
        /// 钢包状态: 永久层烘烤02
        /// </summary>
        public const String CLADLE_STATUS_INNER_FIRE = "02";
        /// <summary>
        /// 钢包状态: 工作层砌筑(打结)03
        /// </summary>
        public const String CLADLE_STATUS_WORK_DAUB = "03";
        /// <summary>
        /// 钢包状态: 工作层烘烤04
        /// </summary>
        public const String CLADLE_STATUS_WORK_FIRE = "04";
        /// <summary>
        /// 钢包状态: 冷备05
        /// </summary>
        public const String CLADLE_STATUS_COLD = "05";
        /// <summary>
        /// 钢包状态: 热备烘烤06
        /// </summary>
        public const String CLADLE_STATUS_HOT_FIRE = "06";
        /// <summary>
        /// 钢包状态: 热备07
        /// </summary>
        public const String CLADLE_STATUS_HOT = "07";
        /// <summary>
        /// 钢包状态: 分配08
        /// </summary>
        public const String CLADLE_STATUS_DESIGN = "08";
        /// <summary>
        /// 钢包状态: 使用(周转)09
        /// </summary>
        public const String CLADLE_STATUS_USE = "09";
        /// <summary>
        /// 钢包状态: 离线待修10
        /// </summary>
        public const String CLADLE_STATUS_OFFLINE = "10";

        //钢包类型
        /// <summary>
        /// 钢包类型: 50t常规钢包1
        /// </summary>
        public const String LADLE_TYPE_COM_50 = "1";
        /// <summary>
        /// 钢包类型: 50t精炼钢包2
        /// </summary>
        public const String LADLE_TYPE_FIN_50 = "2";
        /// <summary>
        /// 钢包类型: 80t精炼钢包3
        /// </summary>
        public const String LADLE_TYPE_FIN_80 = "3";

        //钢包计划状态
        /// <summary>
        /// 钢包计划状态: 未分配01
        /// </summary>
        public const String CLADLE_PLAN_STATUS_UNDESIGN = "01";
        /// <summary>
        /// 钢包计划状态: 分配02
        /// </summary>
        public const String CLADLE_PLAN_STATUS_DESIGN = "02";
        /// <summary>
        /// 钢包计划状态: 执行03
        /// </summary>
        public const String CLADLE_PLAN_STATUS_EXCUTING = "03";
        /// <summary>
        /// 钢包计划状态: 执行结束04
        /// </summary>
        public const String CLADLE_STATUS_WORK_EXCUTED = "04";

        //结晶器状态
        /// <summary>
        /// 结晶器状态: 待装01
        /// </summary>
        public const String CMOLD_STATUS_WAIT = "01";
        /// <summary>
        /// 结晶器状态: 装配02
        /// </summary> 
        public const String CMOLD_STATUS_REPAIR = "02";
        /// <summary>
        /// 结晶器状态: 备用03
        /// </summary>
        public const String CMOLD_STATUS_FREE = "03";
        /// <summary>
        /// 结晶器状态: 在线04
        /// </summary>
        public const String CMOLD_STATUS_USE = "04";
        /// <summary>
        /// 结晶器状态: 下线检测05
        /// </summary>
        public const String CMOLD_STATUS_OFFLINE = "05";

        //结晶器断面尺寸
        /// <summary>
        /// 结晶器断面尺寸: 6米(上1、2#铸机)6
        /// </summary>
        public const int MOLD_FACEMEA_A = 6;
        /// <summary>
        /// 结晶器断面尺寸: 9米(上3、4#铸机)7
        /// </summary>
        public const int MOLD_FACEMEA_B = 9;
        /// <summary>
        /// 结晶器断面尺寸: 12米(上5#铸机)12
        /// </summary>
        public const int MOLD_FACEMEA_C = 12;


        //氧枪状态
        /// <summary>
        /// 氧枪状态: 制作01
        /// </summary>
        public const String CLANCE_STATUS_REPAIR = "01";
        /// <summary>
        /// 氧枪状态: 空闲02
        /// </summary>
        public const String CLANCE_STATUS_FREE = "02";
        /// <summary>
        /// 氧枪状态: 使用03
        /// </summary>
        public const String CLANCE_STATUS_USE = "03";
        /// <summary>
        /// 氧枪状态: 检查04
        /// </summary>
        public const String CLANCE_STATUS_CHECK = "04";
        /// <summary>
        /// 氧枪状态: 离线待修05
        /// </summary>
        public const String CLANCE_STATUS_OFFLINE = "05";

        //真空槽状态
        /// <summary>
        /// 真空槽状态: 维修01
        /// </summary>
        public const String CVACTUBE_STATUS_REPAIR = "01";
        /// <summary>
        /// 真空槽状态: 冷备02
        /// </summary>
        public const String CVACTUBE_STATUS_COLD = "02";
        /// <summary>
        /// 真空槽状态: 预热03
        /// </summary>
        public const String CVACTUBE_STATUS_PRE_FIRE = "03";
        /// <summary>
        /// 真空槽状态: 大火04
        /// </summary>
        public const String CVACTUBE_STATUS_BIG_FIRE = "04";
        /// <summary>
        /// 真空槽状态: 热备05
        /// </summary>
        public const String CVACTUBE_STATUS_HOT = "05";
        /// <summary>
        /// 真空槽状态: 使用06
        /// </summary>
        public const String CVACTUBE_STATUS_USE = "06";
        /// <summary>
        /// 真空槽状态: 下线检查07
        /// </summary>
        public const String CVACTUBE_STATUS_CHECK = "07";
        /// <summary>
        /// 真空槽状态: 离线待修08
        /// </summary>
        public const String CVACTUBE_STATUS_OFFLINE = "08";

        //真空槽位置
        /// <summary>
        /// 真空槽位置: 砌筑位1
        /// </summary>
        public const String CVACTUBE_POSITION_BUILD = "1";
        /// <summary>
        /// 真空槽位置: A烘烤位2
        /// </summary>
        public const String CVACTUBE_POSITION_FIRE_A = "2";
        /// <summary>
        /// 真空槽位置: B烘烤位3
        /// </summary>
        public const String CVACTUBE_POSITION_FIRE_B = "3";
        /// <summary>
        /// 真空槽位置: A工位A
        /// </summary>
        public const String CVACTUBE_POSITION_WORK_A = "A";
        /// <summary>
        /// 真空槽位置: B工位B
        /// </summary>
        public const String CVACTUBE_POSITION_WORK_B = "B";


        /********************转炉状态值及状态描述***************************【2009-03-03】*/
        //生产状态
        /// <summary>
        /// 转炉生产状态: 等待0
        /// </summary>
        public const int BOFWaiting = 0;
        /// <summary>
        /// 转炉生产状态: 兑铁1
        /// </summary>
        public const int BOFFeeding = 1;
        /// <summary>
        /// 转炉生产状态: 主吹2
        /// </summary>
        public const int BOFBlowing = 2;
        /// <summary>
        /// 转炉生产状态: 补吹3
        /// </summary>
        public const int BOFReBlowing = 3;
        /// <summary>
        /// 转炉生产状态: 出钢4
        /// </summary>
        public const int BOFTapping = 4;
        /// <summary>
        /// 转炉生产状态: 出钢结束5
        /// </summary>
        public const int BOFTapped = 5;
        /// <summary>
        /// 转炉生产状态: 溅渣6
        /// </summary>
        public const int BOFSplash = 6;
        /// <summary>
        /// 转炉生产状态: 倒渣7
        /// </summary>
        public const int BOFDumping = 7;

        //生产状态描述
        /// <summary>
        /// 转炉生产状态描述: 等待
        /// </summary>
        public const String strBOFWaiting = "等待";
        /// <summary>
        /// 转炉生产状态描述: 兑铁
        /// </summary>
        public const String strBOFFeeding = "兑铁";
        /// <summary>
        /// 转炉生产状态描述: 吹炼
        /// </summary>
        public const String strBOFBlowing = "吹炼";
        /// <summary>
        /// 转炉生产状态描述: 补吹
        /// </summary>
        public const String strBOFReBlowing = "补吹";
        /// <summary>
        /// 转炉生产状态描述: 出钢
        /// </summary>
        public const String strBOFTapping = "出钢";
        /// <summary>
        /// 转炉生产状态描述: 出钢结束
        /// </summary>
        public const String strBOFTapped = "出钢结束";
        /// <summary>
        /// 转炉生产状态描述: 溅渣
        /// </summary>
        public const String strBOFSplash = "溅渣";
        /// <summary>
        /// 转炉生产状态描述: 倒渣
        /// </summary>
        public const String strBOFDumping = "倒渣";


        public const int AODWaiting = 0;
        /// <summary>
        /// 转炉生产状态: 兑铁1
        /// </summary>
        public const int AODFeeding = 1;
        /// <summary>
        /// 转炉生产状态: 主吹2
        /// </summary>
        public const int AODDec = 2;
        /// <summary>
        /// 转炉生产状态: 补吹3
        /// </summary>
        public const int AODStartBlowing = 3;
        /// <summary>
        /// 转炉生产状态: 出钢4
        /// </summary>
        public const int AODStopBlowing = 4;
        /// <summary>
        /// 转炉生产状态: 出钢结束5
        /// </summary>
        public const int AODReturn = 5;
        /// <summary>
        /// 转炉生产状态: 溅渣6
        /// </summary>
        public const int AODTapping = 6;
        /// <summary>
        /// 转炉生产状态: 倒渣7
        /// </summary>
        public const int AODTapped = 7;


        public const String strAODWaiting = "等待";
        /// <summary>
        /// 转炉生产状态描述: 兑铁
        /// </summary>
        public const String strAODFeeding = "兑铁";
        /// <summary>
        /// 转炉生产状态描述: 吹炼
        /// </summary>
        public const String strAODDec = "脱碳";
        /// <summary>
        /// 转炉生产状态描述: 补吹
        /// </summary>
        public const String strAODStartBlowing = "吹炼";
        /// <summary>
        /// 转炉生产状态描述: 出钢
        /// </summary>
        public const String strAODStopBlowing = "吹炼结束";
        /// <summary>
        /// 转炉生产状态描述: 出钢结束
        /// </summary>
        public const String strAODReturn = "还原";
        /// <summary>
        /// 转炉生产状态描述: 溅渣
        /// </summary>
        public const String strAODTapping = "出钢开始";
        /// <summary>
        /// 转炉生产状态描述: 倒渣
        /// </summary>
        public const String strAODTapped = "出钢结束";


        //设备状态值
        /// <summary>
        /// 转炉设备状态: 正常0
        /// </summary>
        public const int BOFNormal = 0;
        /// <summary>
        /// 转炉设备状态: 检修-1
        /// </summary>
        public const int BOFRepair = -1;
        /// <summary>
        /// 转炉设备状态: 套管-2
        /// </summary>
        public const int BOFBushing = -2;
        /// <summary>
        /// 转炉设备状态: 护炉-3
        /// </summary>
        public const int BOFMaintain = -3;
        /// <summary>
        /// 转炉设备状态: 故障-4
        /// </summary>
        public const int BOFFailure = -4;
        /***************************************/

        //设备状态描述	
        /// <summary>
        /// 转炉设备状态描述: 正常
        /// </summary>
        public const String strBOFNormal = "正常";
        /// <summary>
        /// 转炉设备状态描述: 检修
        /// </summary>
        public const String strBOFRepair = "检修";
        /// <summary>
        /// 转炉设备状态描述: 套管
        /// </summary>
        public const String strBOFBushing = "套管";
        /// <summary>
        /// 转炉设备状态描述: 护炉
        /// </summary>
        public const String strBOFMaintain = "护炉";
        /// <summary>
        /// 转炉设备状态描述: 故障
        /// </summary>
        public const String strBOFFailure = "故障";
        /******************************BOF********************************/


        /********************熔化炉状态值及状态描述***************************【2009-03-03】*/
        //生产状态
        /// <summary>
        /// 转炉生产状态: 等待0
        /// </summary>
        public const int MELTWaiting = 0;
        /// <summary>
        /// 转炉生产状态: 兑铁1
        /// </summary>
        public const int MELTFeeding = 1;
        /// <summary>
        /// 转炉生产状态: 主吹2
        /// </summary>
        public const int MELTBlowing = 2;
        /// <summary>
        /// 转炉生产状态: 补吹3
        /// </summary>
        public const int MELTReBlowing = 3;
        /// <summary>
        /// 转炉生产状态: 出钢4
        /// </summary>
        public const int MELTTapping = 4;
        /// <summary>
        /// 转炉生产状态: 出钢结束5
        /// </summary>
        public const int MELTTapped = 5;
        /// <summary>
        /// 转炉生产状态: 溅渣6
        /// </summary>
        public const int MELTSplash = 6;
        /// <summary>
        /// 转炉生产状态: 倒渣7
        /// </summary>
        public const int MELTDumping = 7;

        //生产状态描述
        /// <summary>
        /// 转炉生产状态描述: 等待
        /// </summary>
        public const String strMELTWaiting = "等待";
        /// <summary>
        /// 转炉生产状态描述: 兑铁
        /// </summary>
        public const String strMELTFeeding = "兑铁";
        /// <summary>
        /// 转炉生产状态描述: 吹炼
        /// </summary>
        public const String strMELTBlowing = "吹炼";
        /// <summary>
        /// 转炉生产状态描述: 吹炼结束
        /// </summary>
        public const String strMELTReBlowing = "吹炼结束";
        /// <summary>
        /// 转炉生产状态描述: 出钢
        /// </summary>
        public const String strMELTTapping = "出钢";
        /// <summary>
        /// 转炉生产状态描述: 出钢结束
        /// </summary>
        public const String strMELTTapped = "出钢结束";
        /// <summary>
        /// 转炉生产状态描述: 溅渣
        /// </summary>
        public const String strMELTSplash = "溅渣";
        /// <summary>
        /// 转炉生产状态描述: 倒渣
        /// </summary>
        public const String strMELTDumping = "倒渣";


       


        //设备状态值
        /// <summary>
        /// 转炉设备状态: 正常0
        /// </summary>
        public const int MELTNormal = 0;
        /// <summary>
        /// 转炉设备状态: 检修-1
        /// </summary>
        public const int MELTRepair = -1;
        /// <summary>
        /// 转炉设备状态: 套管-2
        /// </summary>
        public const int MELTBushing = -2;
        /// <summary>
        /// 转炉设备状态: 护炉-3
        /// </summary>
        public const int MELTMaintain = -3;
        /// <summary>
        /// 转炉设备状态: 故障-4
        /// </summary>
        public const int MELTFailure = -4;
        /***************************************/

        //设备状态描述	
        /// <summary>
        /// 转炉设备状态描述: 正常
        /// </summary>
        public const String strMELTNormal = "正常";
        /// <summary>
        /// 转炉设备状态描述: 检修
        /// </summary>
        public const String strMELTRepair = "检修";
        /// <summary>
        /// 转炉设备状态描述: 套管
        /// </summary>
        public const String strMELTBushing = "套管";
        /// <summary>
        /// 转炉设备状态描述: 护炉
        /// </summary>
        public const String strMELTMaintain = "护炉";
        /// <summary>
        /// 转炉设备状态描述: 故障
        /// </summary>
        public const String strMELTFailure = "故障";
        /******************************MELT********************************/

        /************************LF炉状态值及状态描述***********************/
        // 生产状态值
        /// <summary>
        /// LF炉生产状态: 等待0
        /// </summary>
        public const int LFWaiting = 0;
        /// <summary>
        /// LF炉生产状态: 处理开始1
        /// </summary>
        public const int LFProcBegin = 1;
        /// <summary>
        /// LF炉生产状态: 开始加热2
        /// </summary>
        public const int LFHeatBegin = 2;
        /// <summary>
        /// LF炉生产状态: 加热结束3
        /// </summary>
        public const int LFHeatEnd = 3;
        /// <summary>
        /// LF炉生产状态: 处理结束4
        /// </summary>
        public const int LFProcEnd = 4;
        /// <summary>
        /// LF炉生产状态: 软吹开始5
        /// </summary>
        public const int LFBlowBegin = 5;
        /// <summary>
        /// LF炉生产状态: 软吹结束6
        /// </summary>
        public const int LFBlowEnd = 6;

        // 生产状态描述
        /// <summary>
        /// LF炉生产状态描述: 等待
        /// </summary>
        public const String strLFWaiting = "等待";
        /// <summary>
        /// LF炉生产状态描述: 处理开始
        /// </summary>
        public const String strLFProcBegin = "处理开始";
        /// <summary>
        /// LF炉生产状态描述: 开始加热
        /// </summary>
        public const String strLFHeatBegin = "开始加热";
        /// <summary>
        /// LF炉生产状态描述: 加热结束
        /// </summary>
        public const String strLFHeatEnd = "加热结束";
        /// <summary>
        /// LF炉生产状态描述: 处理结束
        /// </summary>
        public const String strLFProcEnd = "处理结束";
        /// <summary>
        /// LF炉生产状态描述: 软吹开始
        /// </summary>
        public const String strLFBlowBegin = "软吹开始";
        /// <summary>
        /// LF炉生产状态描述: 软吹结束
        /// </summary>
        public const String strLFBlowEnd = "软吹结束";

        // 设备状态值     
        /// <summary>
        /// LF炉设备状态值: 正常0
        /// </summary>
        public const int LFNormal = 0;
        /// <summary>
        /// LF炉设备状态值: 检修-1
        /// </summary>
        public const int LFRepair = -1;
        /// <summary>
        /// LF炉设备状态值: 套管-2
        /// </summary>
        public const int LFBushing = -2;
        /// <summary>
        /// LF炉设备状态值: 护炉-3
        /// </summary>
        public const int LFMaintain = -3;
        /// <summary>
        /// LF炉设备状态值: 故障-4
        /// </summary>
        public const int LFFailure = -4;
        /********************/
        // 设备状态描述     
        /// <summary>
        /// LF炉设备状态描述: 正常
        /// </summary>
        public const String strLFNormal = "正常";
        /// <summary>
        /// LF炉设备状态描述: 检修
        /// </summary>
        public const String strLFRepair = "检修";
        /// <summary>
        /// LF炉设备状态描述: 套管
        /// </summary>
        public const String strLFBushing = "套管";
        /// <summary>
        /// LF炉设备状态描述: 护炉
        /// </summary>
        public const String strLFMaintain = "护炉";
        /// <summary>
        /// LF炉设备状态描述: 故障
        /// </summary>
        public const String strLFFailure = "故障";
        /****************************LF*************************************/

        /************************RH炉状态值及状态描述***********************/
        // 生产状态值
        /// <summary>
        /// RH炉生产状态值: 等待0
        /// </summary>
        public const int RHWaiting = 0;
        /// <summary>
        /// RH炉生产状态值: 处理开始1
        /// </summary>
        public const int RHProcBegin = 1;
        /// <summary>
        /// RH炉生产状态值: 开始真空处理2
        /// </summary>
        public const int RHVacBegin = 2;
        /// <summary>
        /// RH炉生产状态值: 下管吹氧3
        /// </summary>
        public const int RHOB = 3;
        /// <summary>
        /// RH炉生产状态值: 脱氧合金化4
        /// </summary>
        public const int RHAlloy = 4;
        /// <summary>
        /// RH炉生产状态值: 处理结束5
        /// </summary>
        public const int RHProcEnd = 5;
        /// <summary>
        /// RH炉生产状态值: 软吹开始6
        /// </summary>
        public const int RHBlowBegin = 6;
        /// <summary>
        /// RH炉生产状态值: 软吹结束7
        /// </summary>
        public const int RHBlowEnd = 7;

        //生产状态描述
        /// <summary>
        /// RH炉生产状态描述: 等待
        /// </summary>
        public const String strRHWaiting = "等待";
        /// <summary>
        /// RH炉生产状态描述: 处理开始
        /// </summary>
        public const String strRHProcBegin = "处理开始";
        /// <summary>
        /// RH炉生产状态描述: 开始真空处理
        /// </summary>
        public const String strRHVacBegin = "开始真空处理";
        /// <summary>
        /// RH炉生产状态描述: 下管吹氧
        /// </summary>
        public const String strRHOB = "下管吹氧";
        /// <summary>
        /// RH炉生产状态描述: 脱氧合金化
        /// </summary>
        public const String strRHAlloy = "脱氧合金化";
        /// <summary>
        /// RH炉生产状态描述: 处理结束
        /// </summary>
        public const String strRHProcEnd = "处理结束";
        /// <summary>
        /// RH炉生产状态描述: 软吹开始
        /// </summary>
        public const String strRHBlowBegin = "软吹开始";
        /// <summary>
        /// RH炉生产状态描述: 软吹结束
        /// </summary>
        public const String strRHBlowEnd = "软吹结束";

        // 设备状态值
        /// <summary>
        /// RH炉设备状态值: 正常0
        /// </summary>
        public const int RHNormal = 0;
        /// <summary>
        /// RH炉设备状态值: 检修-1
        /// </summary>
        public const int RHRepair = -1;
        /// <summary>
        /// RH炉设备状态值: 故障-2
        /// </summary>
        public const int RHFailure = -2;

        // 异常状态    
        /// <summary>
        /// RH炉设备状态描述: 正常
        /// </summary>           
        public const String strRHNormal = "正常";
        /// <summary>
        /// RH炉设备状态描述: 检修
        /// </summary>    
        public const String strRHRepair = "检修";
        /// <summary>
        /// RH炉设备状态描述: 故障
        /// </summary>    
        public const String strRHFailure = "故障";
        /****************************RH*************************************/

        /************************CCM状态值及状态描述***********************/
        // 生产状态值
        /// <summary>
        /// CCM生产状态值: 等待状态0
        /// </summary>    
        public const int CCMWaiting = 0;
        /// <summary>
        /// CCM生产状态值: 到达1
        /// </summary>    
        public const int CCMArrivle = 1;
        /// <summary>
        /// CCM生产状态值: 浇注中2
        /// </summary>    
        public const int CCMCasting = 2;
        /// <summary>
        /// CCM生产状态值: 浇注结束3
        /// </summary>    
        public const int CCMCasted = 3;

        // 生产状态描述
        /// <summary>
        /// CCM生产状态描述: 等待
        /// </summary>    
        public const String strCCMWaiting = "等待";
        /// <summary>
        /// CCM生产状态描述: 到达
        /// </summary>    
        public const String strCCMArrivle = "到达";
        /// <summary>
        /// CCM生产状态描述: 浇注中
        /// </summary>    
        public const String strCCMCasting = "浇注中";
        /// <summary>
        /// CCM生产状态描述: 浇注结束
        /// </summary>    
        public const String strCCMCasted = "浇注结束";
        /***********************/
        // 设备状态值
        /// <summary>
        /// CCM设备状态值: 正常0
        /// </summary>    
        public const int CCMNormal = 0;
        /// <summary>
        /// CCM设备状态值: 检修中-1
        /// </summary>    
        public const int CCMRepair = -1;
        /// <summary>
        /// CCM设备状态值: 故障-2
        /// </summary>    
        public const int CCMFailure = -2;

        // 设备状态描述
        /// <summary>
        /// CCM设备状态描述: 正常
        /// </summary>    
        public const String strCCMNormal = "正常";
        /// <summary>
        /// CCM设备状态描述: 检修
        /// </summary>    
        public const String strCCMRepair = "检修";
        /// <summary>
        /// CCM设备状态描述: 故障
        /// </summary>    
        public const String strCCMFailure = "故障";
        /****************************CCM*************************************/
    }

    public class CommonMethed
    {
        //c# winform 程序 子窗体关闭时， 释放窗体所占用的内存。
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
        /// 将dv中的所有列的列排序锁定为NotSortable
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
        /// 根据代码描述获取对应代码
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
        /// 根据代码描述获取对应代码
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
        /// 根据代码获取对应代码描述
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
        /// 根据错误代码获取对应错误代码描述
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
        /// 根据错误代码和错误代码所属位置获取错误代码描述
        /// </summary>
        /// <param name="adapter">AppSvrHMI.L3Adapter</param>
        /// <param name="strErrorCode">错误代码</param>
        /// <param name="strOwner">错误代码所属位置</param>
        /// <returns>返回错误代码描述</returns>
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
        /// 根据代码描述获取对应代码
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
        /// 判断数组中是否存在相同元素
        /// 存在返回true,不存在返回false
        /// </summary>
        /// <param name="strArr">数组</param>
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
        /// 给DataGridView行绘制颜色
        /// </summary>
        /// <param name="dv">需要绘制颜色的DataGridView</param>
        /// <param name="strColName">绘制依据列名</param>
        /// <param name="strArrValue"></param>
        /// <param name="strArrColor">指定颜色代码数组</param>
        public static void SetDataGridViewRowColor(DataGridView dv, string strColName, string[] strArrValue, string[] strArrColor)
        {
            try
            {
                //dv为空或行数小于，或则依据列名不存在，或者指定颜色代码数组不存在《返回》
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
                //dv为空或行数小于，或则依据列名不存在，或者指定颜色代码数组不存在《返回》
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
        /// 根据指定代码返回系统颜色
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
        /// 根据某列满足某条件设置某列颜色
        /// </summary>
        /// <param name="dv">目标DataGridView</param>
        /// <param name="strColorColumn">颜色列名</param>
        /// <param name="strValueColumn">参考列名</param>
        /// <param name="strValueTrue">参考值</param>
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
        /// 根据某列满足某条件设置某列某颜色
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
        /// 根据某列满足某条件设置某列颜色
        /// </summary>
        /// <param name="dv">目标DataGridView</param>
        /// <param name="iColorColumn">颜色列索引</param>
        /// <param name="iValueColumn">参考列索引</param>
        /// <param name="strValueTrue">参考值</param>
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
        /// <param name="strArrColor">指定颜色代码二维数组</param>
        public static void SetDataGridViewRowColor(DataGridView dv, string strColName, string[,] strArrColor)
        {
            //dv为空或行数小于，或则依据列名不存在，或者指定颜色代码数组不存在《返回》
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
        /// 多个父容器的数据校验
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
        /// 一个父容器的数据校验
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
        /// 根据炼钢记号获取钢种
        /// </summary>
        /// <param name="Adapter">AppSvrHMI.L3Adapter</param>
        /// <param name="strSteelGradeIndex">炼钢记号</param>
        /// <returns>钢种</returns>
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
        /// 根据脱硫物料号获取工作状态
        /// </summary>
        /// <param name="Adapter">AppSvrHMI.L3Adapter</param>
        /// <param name="strSteelGradeIndex">炼钢记号</param>
        /// <returns>钢种</returns>
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
        /// 设置DataGridView选择列可用性(某列满足某值时,不允许修改当前单元格(选择列)值)
        /// </summary>
        /// <param name="dv">被设置</param>
        /// <param name="strColName">依据列名</param>
        /// <param name="strVal">依据值</param>
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
                int iRowCount = dvSender.Rows.Count;//DV总行数
                int iCurCellColIndex = dvSender.CurrentCell.ColumnIndex;//当前列索引

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
        /// 标准打印(打印DV中所有显示的行和列)
        /// </summary>
        /// <param name="name">标题名</param>
        /// <param name="dv">所打印的DataGridView</param>
        //public static void PutIntoExcel(string name, DataGridView dv)
        //{
        //    Microsoft.Office.Interop.Excel.Application MyExcel = new Microsoft.Office.Interop.Excel.Application();
        //    if (MyExcel == null)
        //    {
        //        MessageBox.Show("EXCEL无法启动!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    try
        //    {
        //        MyExcel.Application.Workbooks.Add(true);
        //        Worksheet worksheet = (Worksheet)MyExcel.ActiveSheet;
        //        worksheet.Name = name;
        //        MyExcel.Visible = true;

        //        int dvRowsCount = dv.Rows.Count;//所有行
        //        int dvColumnCount = 0;//所有显示列
        //        for (int k = 0; k < dv.Columns.Count; k++)
        //        {
        //            if (dv.Columns[k].Visible == true)
        //            {
        //                dvColumnCount += 1;
        //            }
        //        }
        //        //worksheet.Columns.AutoFit();//设置最合适列宽

        //        int iRowCount = 1;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).MergeCells = true;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;// xlHAlignCenter;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Size = 26;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "宋体";
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;
        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //        MyExcel.Cells[iRowCount, 1] = name;

        //        //换行自动设置列名
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
        //                //worksheet.Columns.AutoFit();//再次设置最合适列宽
        //            }
        //            else
        //            {
        //                p += 1;
        //            }
        //        }

        //        //换行给每个单元格赋值
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
        //                //worksheet.Columns.AutoFit();//再次设置最合适列宽
        //            }
        //        }

        //        for (int j = 1; j < dvColumnCount + 1; j++)
        //        {
        //            MyExcel.get_Range(MyExcel.Cells[iRowCount - 1, j], MyExcel.Cells[iRowCount - 1, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
        //            MyExcel.get_Range(MyExcel.Cells[iRowCount - 1, j], MyExcel.Cells[iRowCount - 1, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //            //worksheet.Columns.AutoFit();//再次设置最合适列宽
        //        }

        //        worksheet.PageSetup.CenterHorizontally = true;//水平居中
        //        worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA3;
        //        worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//纸张方向.横向
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
                MessageBox.Show("EXCEL无法启动!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                int dvRowsCount = dv.Rows.Count;//所有行
                int dvColumnCount = 0;//所有显示列
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
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "宋体";
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                MyExcel.Cells[iRowCount, 1] = name;


                //换行自动设置列名
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

                //worksheet.PageSetup.CenterHorizontally = true;//水平居中
                worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA3;
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//纸张方向.横向
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
                MessageBox.Show("EXCEL无法启动!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                int dvRowsCount = dv.Rows.Count;//所有行
                int dvColumnCount = 0;//所有显示列
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
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "宋体";
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                MyExcel.Cells[iRowCount, 1] = name;


                //换行自动设置列名
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

                //worksheet.PageSetup.CenterHorizontally = true;//水平居中
               // worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperUser;
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//纸张方向.横向
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
                MessageBox.Show("EXCEL无法启动!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MyExcel.Application.Workbooks.Add(true);//添加EXCEL工作簿应用
                Worksheet worksheet = (Worksheet)MyExcel.ActiveSheet;//把myexce的当前表作为工作表
                worksheet.Name = name;
                MyExcel.Visible = false;

                int dvRowsCount = dv.Rows.Count;//所有行

                int dvColumnCount = 0;//所有显示列
                for (int k = 0; k < dv.Columns.Count; k++)
                {
                    if (dv.Columns[k].Visible == true)
                    {
                        dvColumnCount += 1;
                    }
                }

                
                //dvColumnCount += 2 * fgMaxCount + 2 * stMaxCount;
                dvColumnCount += fgMaxCount + stMaxCount;
                //对第一行 标题行进行操作
                int iRowCount = 1;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).MergeCells = true;//合并单元格
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;// xlHAlignCenter;
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Size = 18;

                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Name = "宋体";
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).Font.Bold = true;//黑体
                MyExcel.get_Range(MyExcel.Cells[iRowCount, 1], MyExcel.Cells[iRowCount, dvColumnCount]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                MyExcel.Cells[iRowCount, 1] = name;



                //列名
                iRowCount = iRowCount + 1;//第二行
                int p = 0;
                int flagFG = 0;
                int flagST = 0;
                #region "屏蔽"
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

                        if (flagFG == 0 && flagST == 0 && !(dv.Columns[i].HeaderText.Equals("废钢")))
                        {
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            MyExcel.Cells[iRowCount, j] = dv.Columns[i].HeaderText;
                            j++;
                            continue;
                        }

                        if ((dv.Columns[i].Visible == true) && ((dv.Columns[i].HeaderText.Equals("废钢"))))
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
                                MyExcel.Cells[iRowCount, j] = "废钢分类" + tempt;

                                MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                                MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                MyExcel.Cells[iRowCount, j + 1] = "重量" + tempt;
                                tempt++;
                                j += 2;
                                i += 2;
                            }
                        }
                        //if (dv.Columns[i].Visible == true && (dv.Columns[i].HeaderText.Equals("生铁")))
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
                            MyExcel.Cells[iRowCount, j] = "生铁分类" + tempt;

                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                            MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            MyExcel.Cells[iRowCount, j + 1] = "重量" + tempt;
                            tempt++;
                            j += 2;
                            i += 2;
                        }*/
                        #endregion
                        #region OLD
                        //}
                        //如果废钢分类不为0,并到此列,添加列名

                        //if ((j == flagFG) && fgMaxCount > 0&&(tt==0))
                        //{
                        //    for (int n = 0; n < fgMaxCount; n++)
                        //    {
                        //        int tempt = 1;
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j], MyExcel.Cells[iRowCount, j]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //        MyExcel.Cells[iRowCount, j] = "废钢分类" + tempt;

                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //        MyExcel.Cells[iRowCount, j + 1] = "重量" + tempt;
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
                        //        MyExcel.Cells[iRowCount, j] = "生铁分类" + tempt;

                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic, null);
                        //        MyExcel.get_Range(MyExcel.Cells[iRowCount, j + 1], MyExcel.Cells[iRowCount, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //        MyExcel.Cells[iRowCount, j + 1] = "重量" + tempt;
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
                #region "屏蔽"
                /*}
                }

                int rowCount = dvRowsCount;//行

                int colCount = dvColumnCount;//列

                object[,] dataArray = new object[rowCount, colCount];//二维数组

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
                //数据行开始
                iRowCount++;
                for (int i = 0; i < dv.Rows.Count; i++)
                {
                    iCurWiteClumnNum = 0;
                    //处理主窗体上的数据
                    for (int j = 0; j < dv.Columns.Count; j++)
                    {
                        MyExcel.Cells[iRowCount + i, j + 1] = dv[j, i].EditedFormattedValue.ToString();
                        iCurWiteClumnNum++;
                    }
                    iCurWiteClumnNum++;
                    //处理废钢分类
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
                            {//未找到数据,是新列名
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
                            {//已经存在的列名
                                int ipos = iArrayClumnNums[m];
                                MyExcel.Cells[iRowCount + i, ipos] = arryFG[i].Tables[0].Rows[j]["Amount"].ToString();
                            }
                            
                        }
                    }

                    //处理生铁分类
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
                            {//未找到数据,是新列名
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
                            {//已经存在的列名
                                int ipos = iArrayClumnNums[m];
                                MyExcel.Cells[iRowCount + i, ipos] = arryST[i].Tables[0].Rows[j]["Amount"].ToString();
                            }
                        }
                    }
                    //iRowCount++;

                }

                //处理第二行列名
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

                    //worksheet.PageSetup.CenterHorizontally = true;//水平居中
                    worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA3;
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;//纸张方向.横向
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
            //建立Excel对象
            Excel.Application myExcel = new Excel.Application();
            if (myExcel == null)
            {
                MessageBox.Show("EXCEL无法启动!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (IsDeleteEntireRow)//是否整行删除 
                    range.EntireRow.Delete(XlDeleteShiftDirection.xlShiftUp);
                else
                    range.Delete(XlDeleteShiftDirection.xlShiftUp);


                excelsheet.SaveAs(strAddress, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value
                 , Excel.XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value);

                //保存？

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
            string express = @"^[1-9]\d*\.\d+|0\.\d+|0?\.0+|0$";//匹配非负浮点数(正浮点数 + 0)
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            if (!m.Success)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 校验该数据类型是否为非负整数
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool IsInteger(String strValid)
        {
            string express = @"^(0|[1-9]\d*)$";　//非负整数
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            if (!m.Success)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 在整个生产工序中，钢卷的厚宽长以及重量规格都一样，在此分别进行校验
        /// 厚度的校验：小数位数最多可以为4位并且长度最多为10
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool ValidWidth(String strValid)
        {
            //判断小数点位数
            string express = @"^[0-9]+(.[0-9]{0,4})?$";
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            //判断长度是否超过10
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
        /// 厚度的校验：位数不能超过10的非负整数
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool ValidThick(String strValid)
        {
            //判断是否为非负整数
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
        /// 重量的校验：小数位数最多可以为4位并且长度最多为10
        /// </summary>
        /// <param name="strValid"></param>
        /// <returns></returns>
        public static bool ValidWeight(String strValid)
        {
            //判断小数点位数
            string express = @"^[0-9]+(.[0-9]{0,4})?$";
            Regex r = new Regex(express);
            Match m = r.Match(strValid);
            //判断长度是否超过10
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
        /// 将成分标准绘制到指定的DataGridView
        /// </summary>
        /// <param name="dvCurrent">需要绘制的DataGridView</param>
        /// <param name="dsGB">国际标准</param>
        /// <param name="dsInCtrol">内控标准</param>
        public static void dv_ElementStd_Draw(DataGridView dvCurrent, AppSvrHMI.L3DataSet dsGB, AppSvrHMI.L3DataSet dsInCtrol)
        {
            try
            {
                //首先清空DataGridView
                if (dvCurrent.Rows.Count > 0)
                    dvCurrent.Rows.Clear();
                //如果国标成分标准或内控成分标准记录行数不恒等于1，则返回
                if (dsGB.Tables[0].Rows.Count != 1 || dsInCtrol.Tables[0].Rows.Count != 1)
                    return;

                string[] strArrayType = new string[12];
                strArrayType[0] = "国标最大:";
                strArrayType[1] = "_Max";
                strArrayType[2] = "内控最大:";
                strArrayType[3] = "_Max";
                strArrayType[4] = "内控目标:";
                strArrayType[5] = "_Aim";
                strArrayType[6] = "国标目标:";
                strArrayType[7] = "_Aim";
                strArrayType[8] = "内控最小:";
                strArrayType[9] = "_Min";
                strArrayType[10] = "国标最小:";
                strArrayType[11] = "_Min";

                DataSet dsElement = dsGB;

                dvCurrent.Rows.Add(6);
                int iRowIndex = 0;
                while (iRowIndex < 6)
                {
                    //行首列显示信息
                    dvCurrent.Rows[iRowIndex].Cells[0].Value = strArrayType[2 * iRowIndex];

                    //确定使用ds
                    if (iRowIndex == 1 || iRowIndex == 2 || iRowIndex == 4)
                        dsElement = dsInCtrol;
                    else
                        dsElement = dsGB;

                    if (dsElement.Tables[0].Rows.Count > 0)
                    {


                        /****************************************常见成分*****************************************/
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

                        /****************************************不常见成分*****************************************/
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

                    
                    //行数加1
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
            //超上限红色报警
            if (dReal > dStdMax)
            {
                cell.Style.BackColor = Color.Red;
            }
            else if (dReal < dStdMin)//超下限黄色报警
            {
                cell.Style.BackColor = Color.Yellow;
            }
            else//正常系统色
            {
                cell.Style.BackColor = SystemColors.Window;
            }
        }

        /// <summary>
        /// 根据国标和内控绘制成分报警色
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
                            //获取实绩成分列名
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].DataPropertyName;
                            
                            //取出数据
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }

                            
                            dRealValue = Convert.ToDouble(cell.Value.ToString());



                            //判断是否校验
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

                                ////超国标上限红色报警
                                //if (dRealValue > dGBMax)
                                //{
                                //    cell.Style.BackColor = Color.Red;
                                //}
                                ////超内控上限红色报警
                                //else if (dRealValue > dInCtrolMax)
                                //{
                                //    cell.Style.BackColor = Color.LightPink;
                                //}
                                ////超国标下限黄色报警
                                //else if (dRealValue < dGBMin)
                                //{
                                //    cell.Style.BackColor = Color.Yellow;
                                //}
                                ////超内控下限黄色报警
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
        /// 对只有国标的成分报警
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
                            //获取实绩成分列名
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].DataPropertyName;
                            //取出数据
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }
                            dRealValue = Convert.ToDouble(cell.Value.ToString());

                            //判断是否校验
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
                    if (dvCurrent.Columns[i].HeaderText == "试样类别")
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
                            //获取实绩成分列名
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].HeaderText.Trim();
                            //取出数据
                            
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }
                            dRealValue = Convert.ToDouble(cell.Value.ToString());

                            

                            //判断是否校验
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
                                //国标大于0
                                if (dGBMax >= 0)
                                {
                                    //大于国标，红色
                                    if (dRealValue > dGBMax)
                                    {
                                        cell.Style.BackColor = Color.Red;
                                        continue;
                                    }
                                    //
                                    if (dInCtrolMax >= 0)
                                    {
                                        //大于内控（小于国标）,浅粉红色
                                        if (dInCtrolMax < dRealValue)
                                        {
                                            cell.Style.BackColor = Color.LightPink;
                                            continue;
                                        }

                                        if (dGBMin >= 0)
                                        {
                                            //小于国标下限，黄色
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

                        #region 试样类别为高拉碳
                        if (cell.Value.ToString() == "GT")//判断为炉终高拉碳则表单涂色判断。
                        {
                            //if (strColumnName == "Cr" && dRealValue > 0.05)
                            double value1 = 0;//Cr
                            double value2 = 0;//Cu
                            double value3 = 0;//Mo
                            double value4 = 0;//Ni
                            double value5 = 0;//P
                            double value6 = 0;//国标P
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
                            //begin add by yuan 2018-07-12   增加高拉碳炉终样磷高预警 
                            //国标磷上限（%）	0.02	0.025	0.03	0.035	0.04
                            //预警上限（%）	   0.015	0.018	0.020	0.025	0.025
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

                        #region 试样类别为LF炉的GG 2020-05-11
                        try
                        {
                            if (cell.Value.ToString() == "GG")//判断为炉终高拉碳则表单涂色判断。
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
                                //ca使用AL的内控标准
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
                            //获取实绩成分列名
                            strColumnName = dvCurrent.Columns[cell.ColumnIndex].HeaderText.Trim();
                            //取出数据
                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.BackColor = SystemColors.Window;
                                continue;
                            }
                            dRealValue = Convert.ToDouble(cell.Value.ToString());



                            //判断是否校验
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
                dvCurrent.Rows[6].Cells[0].Value = "化验成分";
                dvCurrent.Rows[6].DefaultCellStyle.BackColor = Color.Gray;
                while (iRowIndex > 6 && iRowIndex <= idsRowsCount + 6)
                {
                    //行首列显示信息
                    dvCurrent.Rows[iRowIndex].Cells[0].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sample_Count"].ToString();

                    /****************************************常见成分*****************************************/
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

                    /****************************************不常见成分*****************************************/
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
                    
                  
                    //行数加1
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
                dvCurrent.Rows[6].Cells[0].Value = "化验成分";
                dvCurrent.Rows[6].DefaultCellStyle.BackColor = Color.Gray;
                while (iRowIndex > 6 && iRowIndex <= idsRowsCount + 6)
                {
                    //行首列显示信息
                    dvCurrent.Rows[iRowIndex].Cells[0].Value = dsElement.Tables[0].Rows[iRowIndex - 7]["Sample_Count"].ToString();

                    /****************************************常见成分*****************************************/
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

                    /****************************************不常见成分*****************************************/
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

                    //行数加1
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
        /// 给DataGridView成分信息报警
        /// </summary>
        /// <param name="adapter">L3Adapter</param>
        /// <param name="dvCurrent">所绘制的dv</param>
        /// <param name="strSteelGradeIndex">成分对应的炼钢记号</param>
        /// <param name="iUnitTypeID">工序ID 2:BOF,4:LF,5:RH,6:CCM</param>
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
        /// 获取成分标准数据结构
        /// </summary>
        /// <returns>返回标准数据结构</returns>
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

        //绘制行级 gridView　　Huyunhai 2011-03-28
        public static void dataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView ss = (DataGridView)sender;
            //Microsoft.Office.Interop.Excel.Rectangle
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X - 10, e.RowBounds.Location.Y, ss.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), ss.RowHeadersDefaultCellStyle.Font, rectangle, ss.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 根据SQL查询语句获取成分标准信息
        /// </summary>
        /// <param name="adapter">L3Adapter</param>
        /// <param name="strSourceMethod">SQL查询语句</param>
        /// <returns>返回的标准信息</returns>
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
        /// 公用方法   By Huyunhai
        /// </summary>
        /// <param name="dtModified">修改</param>
        /// <param name="ds">原始值</param>
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
                string Alloy_Area = dtModified.Rows[i]["Alloy_Area"].ToString();//获取被修改的仓位
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    if (ds.Tables[0].Rows[j]["Alloy_Area"].Equals(Alloy_Area))
                    {
                        if (ds.Tables[0].Rows[j]["Alloy_Code"] != dtModified.Rows[i]["Alloy_Code"])
                        {
                            tempt1.Add(i);//修改的
                            tempt2.Add(j);//原始的
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

                    dr["StoreID"] = dtModified.Rows[Convert.ToInt32(tempt1[k].ToString())]["Alloy_Area"].ToString();//存储料仓仓位　des

                    //dr["StoreID"] = dtModified.Rows[Convert.ToInt32(tempt1[k])]["Alloy_Area"].ToString();//存储料仓仓位　des
                    if (ds.Tables[0].Rows[Convert.ToInt32(tempt2[k].ToString())]["Alloy_Code"].ToString().Trim() == "")//如果原来的物料编码为空
                    {
                        dr["BeforMaterialName"] = "";//维护前物料编码
                        dr["AfterMaterialName"] = dtModified.Rows[Convert.ToInt32(tempt1[k].ToString())]["Alloy_Code"].ToString();// 维护后物料编码
                        dr["OperateMode"] = "新增合金编码";
                        string dateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dr["OperatorTime"] = dateTime;
                        dr["Operater"] = session.User;

                        dsForStoreMagQuery.Tables[0].Rows.Add(dr);
                        //dsTempt.Tables[0].Rows.Clear();
                        try
                        {
                            dsForStoreMagQuery.UpdateData(); //修改表CSTOREOPERATELOG 

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
                        dr["AfterMaterialName"] = dtModified.Rows[Convert.ToInt32(tempt1[k].ToString())]["Alloy_Code"].ToString();// 维护后物料编码
                        dr["OperateMode"] = "修改合金编码";
                        string dateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        dr["OperatorTime"] = dateTime;
                        dr["Operater"] = session.User;

                        //dsForStoreMagQuery.Tables[0].Rows.Add(dr);
                        dsForStoreMagQuery.Tables[0].ImportRow(dr);
                        //dsTempt.Tables[0].Rows.Clear();
                        try
                        {
                            dsForStoreMagQuery.UpdateData(); //修改表CSTOREOPERATELOG 

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


