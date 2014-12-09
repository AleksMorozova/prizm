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
                AND productionDate >=  @startDate and productionDate <= @finalDate";

        public const string GetAudit =
            @"SELECT [user], auditDate, oldValue, newValue, entity = 
CASE tableName
WHEN 'Domain.Entity.Mill.Pipe' THEN N'Труба'
WHEN 'Domain.Entity.Mill.Plate' THEN N'Лист'
WHEN 'Domain.Entity.Mill.Category' THEN N'Категория'
WHEN 'Domain.Entity.Mill.ChemicalComposition' THEN N'Химический состав'
WHEN 'Domain.Entity.Mill.Coat' THEN N'Покрытие'
WHEN 'Domain.Entity.Mill.Heat' THEN N'Плавка'
WHEN 'Domain.Entity.Mill.Mill' THEN N'Завод'
WHEN 'Domain.Entity.Mill.PhysicalParameters' THEN N'Физические параметры'
WHEN 'Domain.Entity.Mill.PipeTestResult' THEN N'Результат контольной операции трубы'
WHEN 'Domain.Entity.Mill.PlateManufacturer' THEN N'Производитель листа'
WHEN 'Domain.Entity.Mill.PurchaseOrder' THEN N'Наряд-заказ'
WHEN 'Domain.Entity.Mill.Railcar' THEN N'Вагон'
WHEN 'Domain.Entity.Mill.Weld' THEN N'Сварка'
WHEN 'Domain.Entity.Inspector' THEN N'Инспектор'
WHEN 'Domain.Entity.Setup.InspectorCertificate' THEN N'Сертификат инспектора'
WHEN 'Domain.Entity.Setup.PipeMillSizeType' THEN N'Типоразмер трубы'
WHEN 'Domain.Entity.Project' THEN N'Настройки проекта'
WHEN 'Domain.Entity.Setup.Role' THEN N'Роли пользователя'
WHEN 'Domain.Entity.Setup.User' THEN N'Пользователь'
WHEN 'Domain.Entity.Setup.Welder' THEN N'Сварщик'
WHEN 'Domain.Entity.Setup.PipeTest' THEN N'Контольная операция трубы'
ELSE tableName
END,
fieldName
FROM AuditLog 
                WHERE auditDate >= @startDate and auditDate <= @finalDate
                AND [user] LIKE @user";
    }
}
