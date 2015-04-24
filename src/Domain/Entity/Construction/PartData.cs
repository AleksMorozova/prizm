using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using construction = Prizm.Domain.Entity.Construction;


namespace Prizm.Domain.Entity.Construction
{
    public class PartData : Item
    {
        public virtual PartType PartType { get; set; }

        public string Number { get; set; }
        public string PartTypeDescription { get; set; }
        public int Length { get; set; }
        public float WallThickness { get; set; }
        public float Diameter { get; set; }
        public IList<Connector> Connectors { get; set; }
        public PartConstructionStatus ConstructionStatus { get; set; }
        public string ConnectorsCount { get; set; }

        public int NumberOfConnectors { get { return Connectors.Count; } }
        public string AvailableDiameters
        {
            get
            {
                string str = string.Empty;

                foreach (var c in Connectors)
                {
                    if (!string.IsNullOrEmpty(str)) str += ", ";

                    str += Convert.ToString(c.Diameter);
                }

                return str;
            }
        }

        public PartData() 
        {
           if (Id == Guid.Empty)
              Id = Guid.NewGuid();
           this.Connectors = new List<Connector>(); 
        }
        /// <summary>
        /// Creates the PartData element on the corresponding Row
        /// </summary>
        /// <param name="row">The Row taken from a database, its element of DataTable</param>
        public PartData(DataRow row)
            : this()
        {
            Id = row.Field<Guid>("id");
            Number = row.Field<string>("number");
            PartType = (PartType)Enum.Parse(typeof(PartType), row.Field<string>("type"));
            Length = row.Field<int>("length");
            PartTypeDescription = row.Field<string>("typeTranslated");
            WallThickness = Convert.ToSingle(row.Field<double>("wallThickness"));
            Diameter = row.Field<float>("diameter");

            ConstructionStatus = (PartConstructionStatus)Enum
                    .Parse(typeof(PartConstructionStatus),
                    row.Field<string>("constructionStatus"));
        }
        /// <summary>
        /// Creates the PartData element on the corresponding jointing 
        /// element Part and respective joint Id 
        /// </summary>
        /// <param name="part">Connected part of Joint</param>
        /// <param name="jointId">Guid of Joint</param>
        public PartData(Part part, Guid jointId)
            : this()
        {
            Id = part.Id;
            Number = part.Number;
            ConstructionStatus = part.ConstructionStatus;
            Connectors = new List<construction.Connector>();

            var connector = new construction.Connector();

            if (part is construction.Component)
            {
                PartType = PartType.Component;
                Length = part.Length;

                connector.Diameter = ((construction.Component)part)
                    .Connectors
                    .First<Connector>(x => x.Joint != null && x.Joint.Id == jointId)
                    .Diameter;
                connector.WallThickness = ((construction.Component)part)
                    .Connectors
                    .First<Connector>(x => x.Joint != null && x.Joint.Id == jointId)
                    .WallThickness;
               
                PartTypeDescription
                    = ((construction.Component)part).Type.Name;
            }
            else if (part is Pipe)
            {
                PartType = PartType.Pipe;
                Length = part.Length;

                connector.Diameter = ((Pipe)part).Diameter;
            }
            else
            {
                PartType = PartType.Spool;
                Length = part.Length;

                connector.Diameter = ((construction.Spool)part).Pipe.Diameter;
            }

            Connectors.Add(connector);
        }
        /// <summary>
        /// Set the connector of PartData element by coresponding Row
        /// </summary>
        /// <param name="row">The Row gives the diameter of components connector</param>
        public void SetPartConnectors(DataRow row)
        {
            var cnt = new Connector();

            if (this.PartType == PartType.Component)
            {
                cnt.Diameter = row.Field<float>("diameter");
                cnt.WallThickness = Convert.ToSingle(row.Field<double>("wallThickness"));

                this.Connectors.Add(cnt);

                SetConnectorsCountString(this);
            }
            else
            {
                cnt.Diameter = this.Diameter;
                cnt.WallThickness = this.WallThickness;

                this.Connectors.Add(cnt);

                if (this.ConstructionStatus != PartConstructionStatus.Welded)
                {
                    this.Connectors.Add(cnt);
                }

                SetConnectorsCountString(this);
            }
        }
        /// <summary>
        /// Bild the ConnectorsCount string according 
        /// to format: "free connectors count = N"("diameter_1", "diameter_2", ... "diameter_N")
        /// </summary>
        /// <param name="partData"></param>
        private void SetConnectorsCountString(PartData partData)
        {
            string diameterList = string.Empty;

            foreach (var c in partData.Connectors)
            {
                if (diameterList == string.Empty)
                {
                    diameterList = Convert.ToString(c.Diameter);
                }
                else
                {
                    diameterList = string.Concat(diameterList, ", ", Convert.ToString(c.Diameter));
                }
            }

            partData.ConnectorsCount = string.Concat(partData.Connectors.Count, "(", diameterList, ")");
        }
    }
}
