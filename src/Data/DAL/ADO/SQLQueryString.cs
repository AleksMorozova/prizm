﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{
    public static class SQLQueryString
    {
        public const string GettAllKP = @"Select distinct(numberKP) From Joint";
        public const string GetAllActivePipesByDate = @"select DISTINCT Pipe.number as number,  PipeMillSizeType.type as type, pipeMillStatus as pipeMillStatus, PurchaseOrder.number as purchaseOrder_number, PurchaseOrder.date as PurchaseOrder_date, wallThickness as wallThickness, weight as weight,length as length,diameter as diameter,Plate.number as Plate_number, Heat.number Heat_number, Pipe.isActive as isActive
          from  Pipe Pipe
          left join Plate on (Plate.id = Pipe.plateId)
          left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
          left  join Heat on (Heat.id = Plate.heatId)
          left  join PipeTestResult on (PipeTestResult.pipeId = Pipe.id)
          left  join PurchaseOrder on (PurchaseOrder.id = Pipe.purchaseOrderId)
          inner  join PipeTest on (PipeTestResult.pipeTestId =  PipeTest.id )
          WHERE productionDate >=  @startDate  and productionDate <= @finalDate and Pipe.isActive=1 and PipeTest.isRequired = 1";

        public const string GetAllShipped =
            @"SELECT Pipe.number,  PipeMillSizeType.type, pipeMillStatus, PurchaseOrder.number, PurchaseOrder.date, wallThickness, weight,length,diameter,Plate.number, Heat.number, Pipe.isActive
              FROM Pipe 
              LEFT  JOIN PipeMillSizeType ON (PipeMillSizeType.id = Pipe.typeId)
              LEFT  JOIN PurchaseOrder ON (PurchaseOrder.id = Pipe.purchaseOrderId) 
              LEFT  JOIN Plate ON (Plate.id = Pipe.plateId)
              LEFT  JOIN Heat ON (Heat.id = Plate.heatId)
	            WHERE pipeMillStatus = 'Shipped' 
	            AND Pipe.isActive = 1
                AND productionDate >=  @startDate  and productionDate <= @finalDate";
        public const string GetAllProduced =
            @"SELECT Pipe.number,  PipeMillSizeType.type, pipeMillStatus, PurchaseOrder.number, PurchaseOrder.date, wallThickness, weight,length,diameter,Plate.number, Heat.number, Pipe.isActive
            FROM Pipe 
            LEFT  JOIN PipeMillSizeType ON (PipeMillSizeType.id = Pipe.typeId)
            LEFT  JOIN PurchaseOrder ON (PurchaseOrder.id = Pipe.purchaseOrderId) 
            LEFT  JOIN Plate ON (Plate.id = Pipe.plateId)
            LEFT  JOIN Heat ON (Heat.id = Plate.heatId)
	            WHERE pipeMillStatus = 'Produced' 
	            AND Pipe.isActive = 1
                AND productionDate >=  @startDate and productionDate <= @finalDate";

        public const string GetAudit =
            @"SELECT [user], auditDate, oldValue, newValue, tableName, fieldName
                FROM AuditLog 
                WHERE auditDate >= @startDate and auditDate <= @finalDate
                AND [user] LIKE @user ESCAPE '\' ";



        #region ---- Get Pipeline Pieces ----

        public const string GetPipelinePieces =

          @"SELECT id, number, N'Pipe' as type, diameter, wallThickness, length,'' as componentTypeName, constructionStatus 
            FROM pipe 
            WHERE isActive = 1 AND isAvailableToJoint = 1
            
            UNION ALL

            SELECT s.id, s.number, N'Spool' as type, p.diameter, p.wallThickness, p.length,'' as componentTypeName, s.constructionStatus 
            FROM spool s 
            INNER JOIN pipe p ON s.pipeId = p.id 
            WHERE s.isActive = 1  AND s.isAvailableToJoint = 1
            
            UNION ALL

            SELECT c.id, c.number, N'Component' as type, con.diameter, con.wallThickness, c.length, ct.name as componentTypeName, c.constructionStatus 
            FROM component c 
            INNER JOIN ComponentType ct on ct.Id = c.componentTypeId
            INNER JOIN connector con ON c.id = con.componentId 

            WHERE   c.isActive = 1 AND 
                    c.isAvailableToJoint = 1 AND 
                    (con.jointId IS NULL OR
                    con.jointId = CAST(CAST(0 AS BINARY) AS UNIQUEIDENTIFIER))
                    
            
            ORDER BY number";
        #endregion



        public const string GetAllPipesFromInspection = @"select Pipe.number as number,  PipeMillSizeType.type as type, Pipe.wallThickness as wallThickness, Pipe.length as length, Heat.number as Heat_number
          from  InspectionTestResult InspectionTestResult
		  inner join Pipe on (Pipe.id = InspectionTestResult.[partId])
          left join Plate on (Plate.id = Pipe.plateId)
          left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
          left  join Heat on (Heat.id = Plate.heatId)
                WHERE InspectionTestResult.inspectionDate >=  @startDate and InspectionTestResult.inspectionDate <= @finalDate";

        public const string GetAllUsedPipe = @"select Pipe.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Pipe on (Pipe.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK
		  union
select Pipe.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Pipe on (Pipe.id = Joint.[part2Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK";

        public const string GetAllUsedSpool = @"select Spool.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Spool on (Spool.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK
		  union 
select Spool.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Spool on (Spool.id = Joint.[part2Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK";

        public const string GetAllUsedComponent = @"select Component.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Component on (Component.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK
		  union
select Component.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Component on (Component.id = Joint.[part2Id])
		  where Joint.numberKP >=@startPK and Joint.numberKP <= @endPK";
    }

    /// <summary>
    /// Factory for creating objects to setup SQL-queries
    /// </summary>
    public static class SQLProvider
    {

        //enumerated names for static SQL-templates
        public enum SQLStatic
        {
            GettAllKP,
            GetAllActivePipesByDate,
            GetAllShipped,
            GetAllProduced,
            GetAudit,
            GetPipelinePieces,
            GetAllPipesFromInspection,
            GetAllUsedPipe,
            GetAllUsedSpool,
            GetAllUsedComponent 
        }
        
        /// <summary>
        /// string constants keeping SQL-query templates
        /// </summary>

        private const string GettAllKP = @"Select distinct(numberKP) From Joint";
        
        private const string GetAllActivePipesByDate = @"select DISTINCT {select_options} Pipe.number as number,  PipeMillSizeType.type as type, pipeMillStatus as pipeMillStatus, PurchaseOrder.number as purchaseOrder_number, PurchaseOrder.date as PurchaseOrder_date, wallThickness as wallThickness, weight as weight,length as length,diameter as diameter,Plate.number as Plate_number, Heat.number Heat_number, Pipe.isActive as isActive
              from  Pipe Pipe
              left join Plate on (Plate.id = Pipe.plateId)
              left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
              left  join Heat on (Heat.id = Plate.heatId)
              left  join PipeTestResult on (PipeTestResult.pipeId = Pipe.id)
              left  join PurchaseOrder on (PurchaseOrder.id = Pipe.purchaseOrderId)
              inner  join PipeTest on (PipeTestResult.pipeTestId =  PipeTest.id )
              WHERE productionDate >=  @startDate  and productionDate <= @finalDate 
              {where_options}";

        private const string GetAllShipped = @"SELECT {select_options} Pipe.number,  PipeMillSizeType.type, pipeMillStatus, PurchaseOrder.number, PurchaseOrder.date, wallThickness, weight,length,diameter,Plate.number, Heat.number, Pipe.isActive
              FROM Pipe 
              LEFT  JOIN PipeMillSizeType ON (PipeMillSizeType.id = Pipe.typeId)
              LEFT  JOIN PurchaseOrder ON (PurchaseOrder.id = Pipe.purchaseOrderId) 
              LEFT  JOIN Plate ON (Plate.id = Pipe.plateId)
              LEFT  JOIN Heat ON (Heat.id = Plate.heatId)
	          WHERE productionDate >=  @startDate  and productionDate <= @finalDate
              {where_options}";

        private const string GetAllProduced = @"SELECT {select_options} Pipe.number,  PipeMillSizeType.type, pipeMillStatus, PurchaseOrder.number, PurchaseOrder.date, wallThickness, weight,length,diameter,Plate.number, Heat.number, Pipe.isActive
            FROM Pipe 
            LEFT  JOIN PipeMillSizeType ON (PipeMillSizeType.id = Pipe.typeId)
            LEFT  JOIN PurchaseOrder ON (PurchaseOrder.id = Pipe.purchaseOrderId) 
            LEFT  JOIN Plate ON (Plate.id = Pipe.plateId)
            LEFT  JOIN Heat ON (Heat.id = Plate.heatId)
	            WHERE productionDate >=  @startDate and productionDate <= @finalDate
                {where_options}";

        private const string GetAudit =
            @"SELECT [user], auditDate, oldValue, newValue, tableName, fieldName
FROM AuditLog 
                WHERE auditDate >= @startDate and auditDate <= @finalDate
                AND [user] LIKE @user ESCAPE '\' ";

        private const string GetPipelinePieces =
          @"SELECT id, number, N'Pipe' as type, diameter, wallThickness, length,'' as componentTypeName FROM pipe WHERE isActive = 1
            UNION ALL
            SELECT s.id, s.number, N'Spool' as type, p.diameter, p.wallThickness, s.length,'' as componentTypeName FROM spool s 
            INNER JOIN pipe p ON s.pipeId = p.id WHERE s.isActive = 1
            UNION ALL
            SELECT c.id, c.number, N'Component' as type, con.diameter, con.wallThickness, c.length, ct.name as componentTypeName 
            FROM component c 
            inner join ComponentType ct on ct.Id = c.componentTypeId
            INNER JOIN connector con ON c.id = con.componentId WHERE c.isActive = 1
            ORDER BY number";

        private const string GetAllPipesFromInspection = @"select Pipe.number as number,  PipeMillSizeType.type as type, Pipe.wallThickness as wallThickness, Pipe.length as length, Heat.number as Heat_number
          from  InspectionTestResult InspectionTestResult
		  inner join Pipe on (Pipe.id = InspectionTestResult.[partId])
          left join Plate on (Plate.id = Pipe.plateId)
          left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
          left  join Heat on (Heat.id = Plate.heatId)
                WHERE InspectionTestResult.inspectionDate >=  @startDate and InspectionTestResult.inspectionDate <= @finalDate";

        private const string GetAllUsedPipe = @"select Pipe.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Pipe on (Pipe.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK
		  union
select Pipe.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Pipe on (Pipe.id = Joint.[part2Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK";

        private const string GetAllUsedSpool = @"select Spool.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Spool on (Spool.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK
		  union 
select Spool.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Spool on (Spool.id = Joint.[part2Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK";

        private const string GetAllUsedComponent = @"select Component.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Component on (Component.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK
		  union
select Component.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Component on (Component.id = Joint.[part2Id])
		  where Joint.numberKP >=@startPK and Joint.numberKP <= @endPK";

        /// <summary>
        /// public method accepting queryName and returning object ready to be setup via interface methods
        /// </summary>
        /// <param name="queryName">queryName</param>
        /// <returns>ISQLFlexible</returns>
        public static ISQLFlexible GetQuery(SQLStatic queryName)
        {
            string queryText;
            switch (queryName)
            {
                case SQLStatic.GettAllKP:
                    queryText = GettAllKP;
                    break;

                case SQLStatic.GetAllActivePipesByDate:
                    queryText = GetAllActivePipesByDate;
                    break;

                case SQLStatic.GetAllShipped:
                    queryText = GetAllShipped;
                    break;

                case SQLStatic.GetAllProduced:
                    queryText = GetAllProduced;
                    break;

                case SQLStatic.GetAudit:
                    queryText = GetAllProduced;
                    break;

                case SQLStatic.GetPipelinePieces:
                    queryText = GetPipelinePieces;
                    break;

                case SQLStatic.GetAllPipesFromInspection:
                    queryText = GetAllPipesFromInspection;
                    break;

                case SQLStatic.GetAllUsedPipe:
                    queryText = GetAllUsedPipe;
                    break;

                case SQLStatic.GetAllUsedSpool:
                    queryText = GetAllUsedSpool;
                    break;

                case SQLStatic.GetAllUsedComponent:
                    queryText = GetAllUsedComponent;
                    break;

                default:
                    queryText = "";
                    break;
            }
            return new SQLFlexible(queryText);
        }


        /// <summary>
        /// implements SQL object and methods to add options, returns interface to controlling methods
        /// </summary>
        private class SQLFlexible : ISQLFlexible
        {
            //storing parts of SQL object
            private Dictionary<SQLParts, string> currentQuery = new Dictionary<SQLParts, string>();

            //enumerated types for parts of SQLFlexible object
            private enum SQLParts
            {
                QueryText,
                SelectOptions,
                WhereOptions
            }

            //private constructor never used
            private SQLFlexible()
            { }

            /// <summary>
            /// public constructor create and initialize keys in Dictionary with default values
            /// </summary>
            /// <param name="queryText"></param>
            public SQLFlexible(string queryText)
            {
                currentQuery[SQLParts.QueryText] = queryText;
                currentQuery[SQLParts.SelectOptions] = "";
                currentQuery[SQLParts.WhereOptions] = "";
            }

            /// <summary>
            /// Inserts TOP # option to "select" area of further request
            /// </summary>
            /// <param name="count"></param>
            /// <returns></returns>
            public ISQLFlexible Top(int count)
            {
                if (count > 0)
                {
                    currentQuery[SQLParts.SelectOptions] += "TOP " + count.ToString();
                }
                return this;
            }

            public ISQLFlexible WhereAnd()
            {
                currentQuery[SQLParts.WhereOptions] += " AND ";
                return this;
            }

            public ISQLFlexible Where(string a, string b, string c)
            {
                currentQuery[SQLParts.WhereOptions] += a + " " + b + " " + c;
                return this;
            }

            public override string ToString()
            {
                string tempVal = currentQuery[SQLParts.QueryText];
                tempVal = tempVal.Replace("{select_options}", currentQuery[SQLParts.SelectOptions]);
                tempVal = tempVal.Replace("{where_options}", currentQuery[SQLParts.WhereOptions]);
                return tempVal;
            }
        }
    }

}
            