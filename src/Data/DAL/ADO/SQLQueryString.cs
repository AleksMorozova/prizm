using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.ADO
{
    public static class SQLQueryString
    {
        public const string GetAllActivePipesByDate = @"select DISTINCT Pipe.number,  PipeMillSizeType.type, pipeMillStatus, PurchaseOrder.number, PurchaseOrder.date, wallThickness, weight,length,diameter,Plate.number, Heat.number, Pipe.isActive
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
                AND productionDate >=  @startDate  and productionDate <= @finalDate";


        public const string GetAllPipesFromInspection = @"select Pipe.number as number,  PipeMillSizeType.type as type, wallThickness as wallThickness, length as length, Heat.number as Heat_number
          from  Pipe Pipe
          left join Plate on (Plate.id = Pipe.plateId)
          left  join PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
          left  join Heat on (Heat.id = Plate.heatId)
          left  join PipeTestResult on (PipeTestResult.pipeId = Pipe.id)
          inner  join PipeTest on (PipeTestResult.pipeTestId =  PipeTest.id )
          WHERE productionDate >=  @startDate and productionDate <= @finalDate";
    }
}
