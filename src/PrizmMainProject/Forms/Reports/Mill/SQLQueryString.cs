
namespace PrizmMain.Forms.Reports.Mill
{
    class SQLQueryString
    {
       // public const string GetAllPipesOnMill = "Select number From Pipe";

        public const string GetAllPipesOnMill = @"select Pipe.wallThickness as wallThickness, Pipe.diameter as diameter, 
       Pipe.weight as weight, Pipe.mill as mill, Pipe.pipeMillStatus as pipeMillStatus, Pipe.number
       as Pipe_number, Pipe.isActive as Pipe_isActive, Pipe.typeId as typeId, Pipe.plateId
       as plateId, Pipe.purchaseOrderId as purchaseOrderId, Pipe.length as length,
       Plate.number as Plate_number, Plate.thickness as thickness, Plate.heatId as heatId,
       PipeMillSizeType.type as type, Heat.number as Heat_number, Heat.steelGrade
       as steelGrade, Heat.plateManufacturer as plateManufacturer, PipeTestResult.testResultId
       as testResultId, PipeTestResult.pipeId as pipeId, PipeTestResult.pipeTestId
       as pipeTestId, PipeTestResult.date as PipeTestResult_date, PipeTestResult.status
       as PipeTestResult_status, PipeTestResult.value as PipeTestResult_value,
       PurchaseOrder.number as number, PurchaseOrder.date as PurchaseOrder_date,
       TestResult.date as date, TestResult.value as value, TestResult.status as status
  from ((((((dbo.Pipe Pipe
  inner join dbo.Plate Plate on (Plate.id = Pipe.plateId))
  inner join dbo.PipeMillSizeType PipeMillSizeType on (PipeMillSizeType.id = Pipe.typeId))
  inner join dbo.Heat Heat on (Heat.id = Plate.heatId))
  inner join dbo.PipeTestResult PipeTestResult on (PipeTestResult.pipeId = Pipe.id))
  inner join dbo.PurchaseOrder PurchaseOrder on (PurchaseOrder.id = Pipe.purchaseOrderId))
  inner join dbo.TestResult TestResult on (TestResult.id = PipeTestResult.testResultId))";

    }
}
