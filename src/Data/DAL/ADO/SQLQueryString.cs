using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.ADO
{


       
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
            GetPipelinePieces,
            GetAllPipesFromInspection,
            GetAllUsedPipe,
            GetAllUsedSpool,
            GetAllUsedComponent,
            GetWeldedParts,
            CountPipesInformation, 
            GetAllProducedPipesByDate,
            GetPipeByParametersPieces,
            CountPipesWeldInformation,
            GetJointsByDate,
            GetReleaseNotes,
        }
        
        /// <summary>
        /// string constants keeping SQL-query templates
        /// </summary>
        private const string GetReleaseNotes = @"Select n.number releaseNote, r.number railcarNumber, r.certificate railcarCertificate, r.destination railcarDestination,
Count(p.number) pipes, Sum(p.length) length, Sum(p.weight) weight from ReleaseNote n, Railcar r , Pipe p
where n.id=r.releaseNoteId and r.id=p.railcarId and n.date>=  @startDate and n.date <= @finalDate 
group by r.number, n.number, r.certificate, r.destination";
 
        private const string GettAllKP = @"Select distinct(numberKP) From Joint";

        private const string GetAllProducedPipesByDate = @"select DISTINCT {select_options} Pipe.number as number,  PipeMillSizeType.type as type, pipeMillStatus as pipeMillStatus, weight as weight,Pipe.length as length,Plate.number as Plate_number, Heat.number Heat_number, Pipe.isActive as isActive, Pipe.productionDate as shippingDate
              from  Pipe Pipe
              left join Plate on (Plate.id = Pipe.plateId)
              left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
              left  join Heat on (Heat.id = Plate.heatId)
              WHERE productionDate >=  @startDate  and productionDate <= @finalDate 
              {where_options}";

        private const string GetAllActivePipesByDate = @"select DISTINCT {select_options} Pipe.number as number,  PipeMillSizeType.type as type, pipeMillStatus as pipeMillStatus, PurchaseOrder.number as purchaseOrder_number, PurchaseOrder.date as PurchaseOrder_date, wallThickness as wallThickness, weight as weight,Pipe.length as length,Pipe.diameter as diameter,Plate.number as Plate_number, Heat.number Heat_number, Pipe.isActive as isActive
              from  Pipe Pipe
              left join Plate on (Plate.id = Pipe.plateId)
              left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
              left  join Heat on (Heat.id = Plate.heatId)
              left  join PipeTestResult on (PipeTestResult.pipeId = Pipe.id)
              left  join PurchaseOrder on (PurchaseOrder.id = Pipe.purchaseOrderId)
              inner  join PipeTest on (PipeTestResult.pipeTestId =  PipeTest.id )
              WHERE productionDate >=  @startDate  and productionDate <= @finalDate 
              {where_options}";

        private const string CountPipesInformation = @"Select COUNT(Pipe.number) as count, SUM(Pipe.Length) length,SUM(Pipe.Weight) as sum From Pipe Pipe WHERE productionDate >=  @startDate  and productionDate <= @finalDate";

        private const string CountPipesWeldInformation = @"select productionDate as productionDate, 
(select COUNT (number) from Pipe p where p.millWeldSubStatus = 'WithRepair' and p.productionDate = pipe.productionDate)as 'WithRepairWeld',
(select COUNT (number) from Pipe p where p.millWeldSubStatus = 'Repair' and p.productionDate = pipe.productionDate) as 'RepairWeld',
(select COUNT (number) from Pipe p where p.millWeldSubStatus = 'Scheduled' and p.productionDate = pipe.productionDate) as 'ScheduledWeld',
(select COUNT (number) from Pipe p where p.millWeldSubStatus = 'Failed' and p.productionDate = pipe.productionDate) as 'FailedWeld',
(select COUNT (number) from Pipe p where p.millWeldSubStatus = 'Passed' and p.productionDate = pipe.productionDate) as 'PassedWeld',

(select COUNT (number) from Pipe p where p.millExtCoatSubStatus = 'WithRepair' and p.productionDate = pipe.productionDate)as 'WithRepairExternalCoat',
(select COUNT (number) from Pipe p where p.millExtCoatSubStatus = 'Repair' and p.productionDate = pipe.productionDate) as 'RepairExternalCoat',
(select COUNT (number) from Pipe p where p.millExtCoatSubStatus = 'Scheduled' and p.productionDate = pipe.productionDate) as 'ScheduledExternalCoat',
(select COUNT (number) from Pipe p where p.millExtCoatSubStatus = 'Failed' and p.productionDate = pipe.productionDate) as 'FailedExternalCoat',
(select COUNT (number) from Pipe p where p.millExtCoatSubStatus = 'Passed' and p.productionDate = pipe.productionDate) as 'PassedExternalCoat',

(select COUNT (number) from Pipe p where p.millInterCoatSubStatus = 'WithRepair' and p.productionDate = pipe.productionDate)as 'WithRepairInternalCoat',
(select COUNT (number) from Pipe p where p.millInterCoatSubStatus = 'Repair' and p.productionDate = pipe.productionDate) as 'RepairInternal',
(select COUNT (number) from Pipe p where p.millInterCoatSubStatus = 'Scheduled' and p.productionDate = pipe.productionDate) as 'ScheduledInternal',
(select COUNT (number) from Pipe p where p.millInterCoatSubStatus = 'Failed' and p.productionDate = pipe.productionDate) as 'FailedInternal',
(select COUNT (number) from Pipe p where p.millInterCoatSubStatus = 'Passed' and p.productionDate = pipe.productionDate) as 'PassedInternal'
 from Pipe pipe WHERE pipe.productionDate >=  @startDate  and pipe.productionDate <= @finalDate
group by productionDate  ";

        private const string GetAllShipped = @"SELECT {select_options} Pipe.number,  PipeMillSizeType.type, pipeMillStatus, PurchaseOrder.number, PurchaseOrder.date, wallThickness, weight,Pipe.length,Pipe.diameter,Plate.number, Heat.number, Pipe.isActive
              FROM Pipe 
              LEFT  JOIN PipeMillSizeType ON (PipeMillSizeType.id = Pipe.typeId)
              LEFT  JOIN PurchaseOrder ON (PurchaseOrder.id = Pipe.purchaseOrderId) 
              LEFT  JOIN Plate ON (Plate.id = Pipe.plateId)
              LEFT  JOIN Heat ON (Heat.id = Plate.heatId)
	          WHERE productionDate >=  @startDate  and productionDate <= @finalDate
              {where_options}";

        private const string GetAllProduced = @"SELECT {select_options} Pipe.number,  PipeMillSizeType.type, pipeMillStatus, PurchaseOrder.number, PurchaseOrder.date, wallThickness, weight,Pipe.length, Pipe.diameter,Plate.number, Heat.number, Pipe.isActive
            FROM Pipe 
            LEFT  JOIN PipeMillSizeType ON (PipeMillSizeType.id = Pipe.typeId)
            LEFT  JOIN PurchaseOrder ON (PurchaseOrder.id = Pipe.purchaseOrderId) 
            LEFT  JOIN Plate ON (Plate.id = Pipe.plateId)
            LEFT  JOIN Heat ON (Heat.id = Plate.heatId)
	            WHERE productionDate >=  @startDate and productionDate <= @finalDate
                {where_options}";

        public const string GetPipelinePieces =

          @"SELECT id, number, N'Pipe' as type, diameter, wallThickness, length,'' as componentTypeName, constructionStatus 
            FROM pipe 
            WHERE isActive = 1 AND isAvailableToJoint = 1 AND isCutOnSpool = 0
            
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

        private const string GetAllPipesFromInspection = @"select Pipe.number as number,  PipeMillSizeType.type as type, Pipe.wallThickness as wallThickness, Pipe.length as length, Heat.number as Heat_number
          from  InspectionTestResult InspectionTestResult

          INNER JOIN 
		    (SELECT partId,MAX (inspectionDate) as insprctionDate FROM InspectionTestResult 
			    WHERE inspectionDate >= @startDate and inspectionDate <= @finalDate
				GROUP BY partId) a
				ON InspectionTestResult.partId = a.partId AND InspectionTestResult.inspectionDate = a.insprctionDate

		  inner join Pipe on (Pipe.id = InspectionTestResult.[partId])
          left join Plate on (Plate.id = Pipe.plateId)
          left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
          left  join Heat on (Heat.id = Plate.heatId)
            WHERE  Pipe.isActive=1";

        private const string GetAllUsedPipe = @"select Pipe.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Pipe on (Pipe.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK AND Pipe.isActive=1
		  union
select Pipe.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Pipe on (Pipe.id = Joint.[part2Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK AND Pipe.isActive=1";

        private const string GetAllUsedSpool = @"select Spool.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Spool on (Spool.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK AND Spool.isActive=1
		  union 
select Spool.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Spool on (Spool.id = Joint.[part2Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK AND Spool.isActive=1";

        private const string GetAllUsedComponent = @"select Component.number as number, Joint.part1Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Component on (Component.id = Joint.[part1Id]) 
		  where Joint.numberKP >= @startPK and Joint.numberKP <= @endPK AND Component.isActive=1
		  union
select Component.number as number, Joint.part2Type as type, Joint.numberKP
          from  Joint Joint
		  inner join Component on (Component.id = Joint.[part2Id])
		  where Joint.numberKP >=@startPK and Joint.numberKP <= @endPK  AND Component.isActive=1";

        private const string GetWeldedParts =
          @"SELECT 
                id, 
                number, 
                length,
                N'Pipe' as type,
                '' as componentTypeName 
            FROM 
                Pipe 
            WHERE isActive = 1 
                AND constructionStatus 
                    IN (N'Welded', N'Lowered', N'Filled', N'AlongTrench', N'Undefined')

            UNION ALL

            SELECT 
                S.id, 
                S.number, 
                S.length,
                N'Spool' as type,
                '' as componentTypeName 
            FROM 
                Spool S 
            INNER JOIN 
                Pipe P ON S.pipeId = P.id 
            WHERE S.isActive = 1 
                AND S.constructionStatus 
                    IN (N'Welded', N'Lowered', N'Filled', N'AlongTrench', N'Undefined')

            UNION ALL

            SELECT 
                C.id, 
                C.number, 
                C.length, 
                N'Component' as type,
                CT.name as componentTypeName 
            FROM 
                Component c 
            INNER JOIN 
                ComponentType CT ON CT.Id = C.componentTypeId
            WHERE C.isActive = 1 
                AND C.constructionStatus 
                    IN (N'Welded', N'Lowered', N'Filled', N'AlongTrench', N'Undefined', N'Pending')

            ORDER BY number";


        public const string GetPipeByParametersPieces = @"

              SELECT 
                p.number as Number, 
                p.[length] as [Length],
                p.diameter as Diameter, 
                p.wallThickness as Thickness,
                ST.name as Seam,
                h.steelGrade as Grade,
				j1.number as Joint1,
				j2.number as Joint2

            FROM
                pipe p
            INNER JOIN 
                Plate pl ON pl.Id = p.plateId
            INNER JOIN 
                Heat h ON h.Id = pl.heatId

            LEFT JOIN 
               [PipeMillSizeType] PmSt ON (PmSt.Id = p.typeId)
            LEFT JOIN 
              [SeamType] ST ON (st.Id = PmSt.seamTypeId)
			LEFT JOIN 
              Joint j1 on j1.part1Id = p.id
			LEFT JOIN 
              Joint j2 on j2.part2Id = p.id
            
            WHERE 
                p.isActive = 1
            {where_options}";


        private const string GetJointsByDate = @"
              SELECT 
				wr.MinDate as [Date],
                j.number as JointNumber,
                fp.number as FipstPartNumber,
                sp.number as SecondPartNumber,
                fp.[length] as FipstPartLength,
                sp.[length] as SecondPartLength
            FROM 
                Joint j 
            INNER JOIN
				 (
				   SELECT jointId, MIN([date]) as MinDate
				   FROM [JointWeldResult]
				   GROUP BY jointId
				 ) 
				 wr ON wr.jointId = j.id 
            INNER JOIN
				 (
				   SELECT id, number, [length]
				   FROM [Pipe]

				   UNION ALL

				   SELECT id, number, [length]
				   FROM [Component]

				   UNION ALL

				   SELECT id, number, [length]
				   FROM [Spool]
				 ) 
				 fp ON (fp.id = j.[part1Id])
            INNER JOIN
				 (
				   SELECT id, number, [length]
				   FROM [Pipe]

				   UNION ALL

				   SELECT id, number, [length]
				   FROM [Component]

				   UNION ALL

				   SELECT id, number, [length]
				   FROM [Spool]
				 ) 
			     sp ON (sp.id = j.[part2Id])
            WHERE
                j.isActive = 1
                {where_options} ";


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

                case SQLStatic.GetReleaseNotes:
                    queryText = GetReleaseNotes;
                    break;

                case SQLStatic.CountPipesWeldInformation:
                    queryText = CountPipesWeldInformation;
                    break;

                case SQLStatic.GettAllKP:
                    queryText = GettAllKP;
                    break;

                case SQLStatic.GetAllProducedPipesByDate:
                    queryText = GetAllProducedPipesByDate;
                    break;

                case SQLStatic.CountPipesInformation:
                    queryText = CountPipesInformation;
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

                case SQLStatic.GetWeldedParts:
                    queryText = GetWeldedParts;
                    break;

                case SQLStatic.GetPipeByParametersPieces:
                    queryText = GetPipeByParametersPieces;
                    break;

                    

                case SQLStatic.GetJointsByDate:
                    queryText = GetJointsByDate;
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
            