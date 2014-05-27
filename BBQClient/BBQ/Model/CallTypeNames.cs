﻿using System.Collections.Generic;

namespace BBQ.Model
{
    internal class CallTypeNames
    {
        public int CallTypeId { get; set; }
        public string QueueName { get; set; }

        public List<CallTypeNames> ListProductQueues()
        {
            return new List<CallTypeNames>
                       {
                           new CallTypeNames {CallTypeId = 5240, QueueName = "Acct.ENT_AP_CB"},
                           new CallTypeNames {CallTypeId = 5241, QueueName = "Acct.ENT_AP_CL"},
                           new CallTypeNames {CallTypeId = 5242, QueueName = "Acct.ENT_AP_PH"},
                           new CallTypeNames {CallTypeId = 5243, QueueName = "Acct.ENT_Core_CB"},
                           new CallTypeNames {CallTypeId = 5244, QueueName = "Acct.ENT_Core_CL"},
                           new CallTypeNames {CallTypeId = 5245, QueueName = "Acct.ENT_Core_PH"},
                           new CallTypeNames {CallTypeId = 5021, QueueName = "Acct_AP_CB"},
                           new CallTypeNames {CallTypeId = 5203, QueueName = "Acct_AP_CL"},
                           new CallTypeNames {CallTypeId = 5022, QueueName = "Acct_AP_PH"},
                           new CallTypeNames {CallTypeId = 5017, QueueName = "Acct_Core_CB"},
                           new CallTypeNames {CallTypeId = 5016, QueueName = "Acct_Core_CL"},
                           new CallTypeNames {CallTypeId = 5018, QueueName = "Acct_Core_PH"},
                           new CallTypeNames {CallTypeId = 5298, QueueName = "Altru_AP_CB"},
                           new CallTypeNames {CallTypeId = 5299, QueueName = "Altru_AP_CL"},
                           new CallTypeNames {CallTypeId = 5300, QueueName = "Altru_AP_PH"},
                           new CallTypeNames {CallTypeId = 5301, QueueName = "Altru_Core_CB"},
                           new CallTypeNames {CallTypeId = 5302, QueueName = "Altru_Core_CL"},
                           new CallTypeNames {CallTypeId = 5303, QueueName = "Altru_Core_PH"},
                           new CallTypeNames {CallTypeId = 5026, QueueName = "AuctionT_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5027, QueueName = "AuctionT_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5028, QueueName = "AuctionT_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5129, QueueName = "BBA_Menu"},
                           new CallTypeNames {CallTypeId = 5150, QueueName = "BBEC.BBDM_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5151, QueueName = "BBEC.BBDM_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5152, QueueName = "BBEC.BBDM_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5156, QueueName = "BBEC.CRM_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5157, QueueName = "BBEC.CRM_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5158, QueueName = "BBEC.CRM_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5162, QueueName = "BBEC.SDK_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5163, QueueName = "BBEC.SDK_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5164, QueueName = "BBEC.SDK_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5168, QueueName = "BBE_BBNC"},
                           new CallTypeNames {CallTypeId = 5169, QueueName = "BBE_Emergency_Close"},
                           new CallTypeNames {CallTypeId = 5170, QueueName = "BBE_Incoming.Call"},
                           new CallTypeNames {CallTypeId = 5171, QueueName = "BBE_Operator.Error"},
                           new CallTypeNames {CallTypeId = 5172, QueueName = "BBE_PE"},
                           new CallTypeNames {CallTypeId = 5173, QueueName = "BBE_PEO"},
                           new CallTypeNames {CallTypeId = 5174, QueueName = "BBE_RE"},
                           new CallTypeNames {CallTypeId = 5175, QueueName = "BBE_RONA"},
                           new CallTypeNames {CallTypeId = 5176, QueueName = "BBE_RONA_from_CM"},
                           new CallTypeNames {CallTypeId = 5177, QueueName = "BBE_Transfers"},
                           new CallTypeNames {CallTypeId = 5178, QueueName = "BBE_Undefined"},
                           new CallTypeNames {CallTypeId = 5246, QueueName = "BBNC.ENT_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5247, QueueName = "BBNC.ENT_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5248, QueueName = "BBNC.ENT_ALL_PH_Down"},
                           new CallTypeNames {CallTypeId = 5249, QueueName = "BBNC.ENT_ALL_PH_Normal"},
                           new CallTypeNames {CallTypeId = 5146, QueueName = "BBNC_ALL_CB_AB"},
                           new CallTypeNames {CallTypeId = 5147, QueueName = "BBNC_ALL_CL_AB"},
                           new CallTypeNames {CallTypeId = 5179, QueueName = "BBNC_ALL_PH_Down"},
                           new CallTypeNames {CallTypeId = 5148, QueueName = "BBNC_ALL_PH_Normal"},
                           new CallTypeNames {CallTypeId = 5316, QueueName = "BBNC_AP_CL"},
                           new CallTypeNames {CallTypeId = 5317, QueueName = "BBNC_AP_PH"},
                           new CallTypeNames {CallTypeId = 5318, QueueName = "BBNC_Core_CL"},
                           new CallTypeNames {CallTypeId = 5319, QueueName = "BBNC_Core_PH"},
                           new CallTypeNames {CallTypeId = 5312, QueueName = "BBPS.ENT_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5313, QueueName = "BBPS.ENT_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5314, QueueName = "BBPS.ENT_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5233, QueueName = "BBPS_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5234, QueueName = "BBPS_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5232, QueueName = "BBPS_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5315, QueueName = "C.Service_Menu"},
                           new CallTypeNames {CallTypeId = 5037, QueueName = "C.Service_Queue"},
                           new CallTypeNames {CallTypeId = 5133, QueueName = "CSA_Down"},
                           new CallTypeNames {CallTypeId = 5134, QueueName = "CSA_Normal"},
                           new CallTypeNames {CallTypeId = 5131, QueueName = "Callbacks_On_Hold"},
                           new CallTypeNames {CallTypeId = 5125, QueueName = "ClarifyXferToIVR"},
                           new CallTypeNames {CallTypeId = 5123, QueueName = "Clarify_CB_IVRAllocate"},
                           new CallTypeNames {CallTypeId = 5124, QueueName = "Clarify_Callbacks"},
                           new CallTypeNames {CallTypeId = 5030, QueueName = "Class_ALL_CB_AB"},
                           new CallTypeNames {CallTypeId = 5031, QueueName = "Class_ALL_CL_AB"},
                           new CallTypeNames {CallTypeId = 5032, QueueName = "Class_ALL_PH_AB"},
                           new CallTypeNames {CallTypeId = 5046, QueueName = "Crystal_ALL_CB_A"},
                           new CallTypeNames {CallTypeId = 5035, QueueName = "Crystal_ALL_CL_A"},
                           new CallTypeNames {CallTypeId = 5036, QueueName = "Crystal_ALL_PH_A"},
                           new CallTypeNames {CallTypeId = 5289, QueueName = "DAES_AP_CB"},
                           new CallTypeNames {CallTypeId = 5290, QueueName = "DAES_AP_CL"},
                           new CallTypeNames {CallTypeId = 5291, QueueName = "DAES_AP_PH"},
                           new CallTypeNames {CallTypeId = 5038, QueueName = "DAES_Core_CB"},
                           new CallTypeNames {CallTypeId = 5039, QueueName = "DAES_Core_CL"},
                           new CallTypeNames {CallTypeId = 5040, QueueName = "DAES_Core_PH"},
                           new CallTypeNames {CallTypeId = 5042, QueueName = "DSS_ALL_CB_AB"},
                           new CallTypeNames {CallTypeId = 5041, QueueName = "DSS_ALL_CL_AB"},
                           new CallTypeNames {CallTypeId = 5043, QueueName = "DSS_ALL_PH_AB"},
                           new CallTypeNames {CallTypeId = 5054, QueueName = "EE_AP_CB"},
                           new CallTypeNames {CallTypeId = 5207, QueueName = "EE_AP_CL"},
                           new CallTypeNames {CallTypeId = 5055, QueueName = "EE_AP_PH"},
                           new CallTypeNames {CallTypeId = 5052, QueueName = "EE_Core_CB"},
                           new CallTypeNames {CallTypeId = 5053, QueueName = "EE_Core_CL"},
                           new CallTypeNames {CallTypeId = 5056, QueueName = "EE_Core_PH"},
                           new CallTypeNames {CallTypeId = 5006, QueueName = "EMERGENCY_CONTROL_CALL"},
                           new CallTypeNames {CallTypeId = 5256, QueueName = "FW_AP_CB"},
                           new CallTypeNames {CallTypeId = 5257, QueueName = "FW_AP_CL"},
                           new CallTypeNames {CallTypeId = 5258, QueueName = "FW_AP_PH"},
                           new CallTypeNames {CallTypeId = 5259, QueueName = "FW_Core_CB"},
                           new CallTypeNames {CallTypeId = 5260, QueueName = "FW_Core_CL"},
                           new CallTypeNames {CallTypeId = 5261, QueueName = "FW_Core_PH"},
                           new CallTypeNames {CallTypeId = 5167, QueueName = "Front_Desk"},
                           new CallTypeNames {CallTypeId = 5013, QueueName = "HD_AfterHrs_Normal"},
                           new CallTypeNames {CallTypeId = 5066, QueueName = "HD_AfterHrs_Priority"},
                           new CallTypeNames {CallTypeId = 5202, QueueName = "HD_DuringHours"},
                           new CallTypeNames {CallTypeId = 5165, QueueName = "HelpDesk_Menu"},
                           new CallTypeNames {CallTypeId = 5180, QueueName = "Hosting_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5181, QueueName = "Hosting_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5182, QueueName = "Hosting_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5166, QueueName = "Hosting_Internal"},
                           new CallTypeNames {CallTypeId = 5067, QueueName = "Install_AP_CB"},
                           new CallTypeNames {CallTypeId = 5213, QueueName = "Install_AP_CL"},
                           new CallTypeNames {CallTypeId = 5068, QueueName = "Install_AP_PH"},
                           new CallTypeNames {CallTypeId = 5110, QueueName = "Install_Core_CB"},
                           new CallTypeNames {CallTypeId = 5111, QueueName = "Install_Core_CL"},
                           new CallTypeNames {CallTypeId = 5112, QueueName = "Install_Core_PH"},
                           new CallTypeNames {CallTypeId = 5014, QueueName = "MOD"},
                           new CallTypeNames {CallTypeId = 5070, QueueName = "Maint_Credit_Hold"},
                           new CallTypeNames {CallTypeId = 5071, QueueName = "Maint_Internal"},
                           new CallTypeNames {CallTypeId = 5072, QueueName = "Maint_NewCall"},
                           new CallTypeNames {CallTypeId = 5073, QueueName = "Maint_No_Maint"},
                           new CallTypeNames {CallTypeId = 5074, QueueName = "Maint_Support_Hold"},
                           new CallTypeNames {CallTypeId = 5015, QueueName = "Operator"},
                           new CallTypeNames {CallTypeId = 5098, QueueName = "OutboundDialer_To_IVR"},
                           new CallTypeNames {CallTypeId = 5320, QueueName = "PE_AP_CL"},
                           new CallTypeNames {CallTypeId = 5321, QueueName = "PE_AP_PH"},
                           new CallTypeNames {CallTypeId = 5076, QueueName = "PE_All_CB_AB"},
                           new CallTypeNames {CallTypeId = 5075, QueueName = "PE_All_CL_AB"},
                           new CallTypeNames {CallTypeId = 5077, QueueName = "PE_All_PH_AB"},
                           new CallTypeNames {CallTypeId = 5322, QueueName = "PE_Core_CL"},
                           new CallTypeNames {CallTypeId = 5323, QueueName = "PE_Core_PH"},
                           new CallTypeNames {CallTypeId = 5078, QueueName = "POS.RMS_All_CB_AB"},
                           new CallTypeNames {CallTypeId = 5079, QueueName = "POS.RMS_All_CL_AB"},
                           new CallTypeNames {CallTypeId = 5080, QueueName = "POS.RMS_All_PH_AB"},
                           new CallTypeNames {CallTypeId = 5239, QueueName = "PlayCallback"},
                           new CallTypeNames {CallTypeId = 5114, QueueName = "QUEUE_CALLBACK"},
                           new CallTypeNames {CallTypeId = 5250, QueueName = "RE7.ENT_AP_CB"},
                           new CallTypeNames {CallTypeId = 5251, QueueName = "RE7.ENT_AP_CL"},
                           new CallTypeNames {CallTypeId = 5252, QueueName = "RE7.ENT_AP_PH"},
                           new CallTypeNames {CallTypeId = 5253, QueueName = "RE7.ENT_Core_CB"},
                           new CallTypeNames {CallTypeId = 5254, QueueName = "RE7.ENT_Core_CL"},
                           new CallTypeNames {CallTypeId = 5255, QueueName = "RE7.ENT_Core_PH"},
                           new CallTypeNames {CallTypeId = 5084, QueueName = "RE7_AP_CB"},
                           new CallTypeNames {CallTypeId = 5209, QueueName = "RE7_AP_CL"},
                           new CallTypeNames {CallTypeId = 5085, QueueName = "RE7_AP_PH"},
                           new CallTypeNames {CallTypeId = 5081, QueueName = "RE7_Core_CB"},
                           new CallTypeNames {CallTypeId = 5082, QueueName = "RE7_Core_CL"},
                           new CallTypeNames {CallTypeId = 5083, QueueName = "RE7_Core_PH"},
                           new CallTypeNames {CallTypeId = 5122, QueueName = "RONA"},
                           new CallTypeNames {CallTypeId = 5132, QueueName = "RONA_FROM_CM"},
                           new CallTypeNames {CallTypeId = 5115, QueueName = "SB_AP_CB"},
                           new CallTypeNames {CallTypeId = 5211, QueueName = "SB_AP_CL"},
                           new CallTypeNames {CallTypeId = 5116, QueueName = "SB_AP_PH"},
                           new CallTypeNames {CallTypeId = 5117, QueueName = "SB_Core_CB"},
                           new CallTypeNames {CallTypeId = 5118, QueueName = "SB_Core_CL"},
                           new CallTypeNames {CallTypeId = 5119, QueueName = "SB_Core_PH"},
                           new CallTypeNames {CallTypeId = 5306, QueueName = "Sphere.ENT_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5307, QueueName = "Sphere.ENT_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5308, QueueName = "Sphere.ENT_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5309, QueueName = "Sphere_ALL_CB"},
                           new CallTypeNames {CallTypeId = 5310, QueueName = "Sphere_ALL_CL"},
                           new CallTypeNames {CallTypeId = 5311, QueueName = "Sphere_ALL_PH"},
                           new CallTypeNames {CallTypeId = 5324, QueueName = "Sphere_AP_CL"},
                           new CallTypeNames {CallTypeId = 5325, QueueName = "Sphere_AP_PH"},
                           new CallTypeNames {CallTypeId = 5326, QueueName = "Sphere_Core_CL"},
                           new CallTypeNames {CallTypeId = 5327, QueueName = "Sphere_Core_PH"},
                           new CallTypeNames {CallTypeId = 5149, QueueName = "System_Error"},
                           new CallTypeNames {CallTypeId = 5092, QueueName = "TECH_All_CB"},
                           new CallTypeNames {CallTypeId = 5093, QueueName = "TECH_All_CL"},
                           new CallTypeNames {CallTypeId = 5094, QueueName = "TECH_All_PH"},
                           new CallTypeNames {CallTypeId = 5186, QueueName = "Training.Menu"},
                           new CallTypeNames {CallTypeId = 5095, QueueName = "Training.Queue"},
                           new CallTypeNames {CallTypeId = 5107, QueueName = "Undefined"}
                       };
        }
    }
}