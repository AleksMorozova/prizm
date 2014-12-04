using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.ADO
{
    public static class SQLQueryString
    {
        public const string GetAllActivePipesByDate = @"select DISTINCT Pipe.wallThickness as wallThickness, Pipe.diameter as diameter, 
               Pipe.weight as weight, Pipe.mill as mill, Pipe.pipeMillStatus as pipeMillStatus, Pipe.number
               as number, Pipe.isActive as isActive, Pipe.typeId as typeId, Pipe.plateId
               as plateId, Pipe.purchaseOrderId as purchaseOrderId, Pipe.length as length,
               Plate.number as Plate_number, Plate.thickness as thickness, Plate.heatId as heatId,
               PipeMillSizeType.type as type, Heat.number as Heat_number, Heat.steelGrade
               as steelGrade, Heat.plateManufacturer as plateManufacturer, PipeTestResult.testResultId
               as testResultId, PipeTestResult.pipeId as pipeId, PipeTestResult.pipeTestId
               as pipeTestId, PipeTestResult.date as PipeTestResult_date, PipeTestResult.status
               as PipeTestResult_status, PipeTestResult.value as PipeTestResult_value,
               PurchaseOrder.number as purchaseOrder_number, PurchaseOrder.date as PurchaseOrder_date 
          from  Pipe Pipe
          left join Plate Plate on (Plate.id = Pipe.plateId)
          left  join PipeMillSizeType PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId)
          left  join Heat Heat on (Heat.id = Plate.heatId)
          left  join PipeTestResult PipeTestResult on (PipeTestResult.pipeId = Pipe.id)
          left  join PurchaseOrder PurchaseOrder on (PurchaseOrder.id = Pipe.purchaseOrderId)
          left  join PipeTest PipeTest on (PipeTestResult.pipeTestId =  PipeTest.id )
          WHERE productionDate >=  @startDate  and productionDate <= @finalDate and Pipe.isActive=1";

    }
}
