using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Common
{
    public class LengthLimit
    {
        /// <summary>
        /// Heat limits
        /// </summary>
        /// 
        #region HeatLimits
        public const int MaxHeatNumber = 20;
        public const int MaxSteelGrade = 20;
        public const int MaxPlateManufacturerName = 50;
        #endregion HeatLimits

        /// <summary>
        /// Inspector Limits
        /// </summary>
        /// 
        #region InspectorLimits
        public const int MaxInspectorFirstName = 30;
        public const int MaxInspectorLastName = 30;
        public const int MaxInspectorMiddleName = 30;
        public const int MaxInspectorCertificate = 30;
        #endregion InspectorLimits

        /// <summary>
        /// Category limits
        /// </summary>
        /// 
        #region CategoryLimits
        public const int MaxCategoryName = 40;
        #endregion CategoryLimits

        /// <summary>
        /// Pipe limits
        /// </summary>
        /// 
        #region PipeLimits

        public const int MaxPipeMill = 250;
        public const int MaxPipeNumber = 20;

        public const int MaxPipeMillSizeType = 50;

        #endregion PipeLimits

        /// <summary>
        /// Control operation limits
        /// </summary>
        /// 
        #region ControlOperationLimits
        public const int MaxPipeTestCode = 20;
        public const int MaxPipeTestName = 50;
        public const int MaxPipeTestControlType = 15;
        public const int MaxPipetestResultType = 10;

        public const int MaxPipeTestResultStatus = 25;
        public const int MaxPipeTestResultValue = 20;
        #endregion ControlOperationLimits

        /// <summary>
        /// Plate limits
        /// </summary>
        /// 
        #region PlateLimits
        public const int MaxPlateNumber = 20;
        #endregion PlateLimits

        /// <summary>
        /// User Limits
        /// </summary>
        /// 
        #region UsersLimits
        public const int UserFirstName = 30;
        public const int UserMiddleName = 30;
        public const int UserLastName = 30;
        public const int UserLogin = 30;
        #endregion UsersLimits


        /// <summary>
        /// Purchase Order Limit
        /// </summary>
        /// 
        #region PurchaseOrderLimit
        public const int MaxPurchaseOrderNumber = 20;
        #endregion PurchaseOrderLimit
        
    
        /// <summary>
        /// RailCar limits
        /// </summary>
        #region RailcarLimits
        public const int MaxRailcarNumber = 20;
        public const int MaxReleaseNoteNumber = 20;
        public const int MaxRailcarCertificate = 20;
        public const int MaxRailcarDestination = 50;
        #endregion RailcarLimits

        public const int MaxTestResultValue = 25;
        public const int MaxTestResultStatus = 25;

        /// <summary>
        /// Welder Limit
        /// </summary>
        /// 
        #region WelderLimits
        public const int MaxWelderFirstName = 30;
        public const int MaxWelderLastName = 30;
        public const int MaxWelderMiddleName = 30;
        public const int MaxWelderCertificate = 30;
        public const int MaxWelderStamp = 50;
        #endregion WelderLimits

        /// <summary>
        /// Project limits
        /// </summary>
        /// 
        #region ProjectLimits
        public const int MaxProjectClient = 100;
        public const int MaxProjectMillName = 100;
        public const int MaxProjectTitle = 20;
        #endregion ProjectLimits

        public const int MaxAuditlogUser = 50;
        public const int MaxAuditlogTableName = 200;
        public const int MaxAuditlogFieldName = 50;
        public const int MaxAuditlogOldvalue = 100;
        public const int MaxAuditlogNewValue = 100;

        /// <summary>
        /// Joint Limit
        /// </summary>
        /// 
        #region JointLimits
        public const int MaxJointNumber = 20;
        public const int MaxJointTestResultValue = 20;
        #endregion JointLimits

        /// <summary>
        /// Settings Limits
        /// </summary>
        /// 
        #region SettingsLimits
        public const int MaxSeamTypeName = 20;
        public const int MaxPipelineOperationLength = 50;
        public const int MaxComponentTypeName = 20;
        public const int CertificateType = 30;
        #endregion SettingsLimits

        /// <summary>
        /// Role limits
        /// </summary>
        /// 
        #region RoleLimits
        public const int RoleName = 30;
        public const int RoleDescription = 255;
        #endregion RoleLimits

        /// <summary>
        /// Component limits
        /// </summary>
        /// 
        #region ComponentLimits
        public const int ComponentNumber = 20;
        public const int ComponentCertificate = 20;
        #endregion ComponentLimits

        /// <summary>
        /// Spool limits
        /// </summary>
        /// 
        #region SpoolLimits
        public const int SpoolNumber = 20;
        #endregion SpoolLimits

    }
}
