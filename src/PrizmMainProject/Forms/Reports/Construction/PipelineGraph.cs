using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using construct = Prizm.Domain.Entity.Construction;

namespace Prizm.Main.Forms.Reports.Construction
{
    public class PipelineGraph
    {
        private Dictionary<Guid, PipelineVertex> piecesVertex;


        public PipelineGraph() 
        {
            this.piecesVertex = new Dictionary<Guid, PipelineVertex>();
        }

        public PipelineGraph(Dictionary<Guid, PipelineVertex> piecesVertex)
        {
            this.piecesVertex = piecesVertex;
        }



        public void AddPipelineVertex(construct.PartData partData)
        {
            piecesVertex.Add(partData.Id, new PipelineVertex(partData));
        }

        public void AddJointEdge(construct.Joint joint)
        {
            JointEdge jointEdge = new JointEdge(joint);

            try
            {
                jointEdge.PartsVertex.Add(piecesVertex[joint.FirstElement.Id]);
                jointEdge.PartsVertex.Add(piecesVertex[joint.SecondElement.Id]);

                piecesVertex[joint.FirstElement.Id].JointsEdge.Add(jointEdge);
                piecesVertex[joint.SecondElement.Id].JointsEdge.Add(jointEdge);
            }
            catch
            {

            }
        }



        public List<List<PipelineVertex>> Pathfinder(
            construct.PartData startPartData,
            construct.PartData endPartData)
        {
            var startPiece = piecesVertex[startPartData.Id];
            var endPiece = piecesVertex[endPartData.Id];

            List<List<PipelineVertex>> paths = new List<List<PipelineVertex>>();

            Stack<PipelineVertex> stack = new Stack<PipelineVertex>();

            stack.Push(startPiece);

            List<JointEdge> joints = stack.Peek().JointsEdge;

            int[] path = new int[this.piecesVertex.Count];

            int k = 0;

            while (stack.Count > 0 && paths.Count < 2)
            {
                while (k < joints.Count)
                {
                    for (int i = 0; i < 2; ++i)
                    {
                        if (!stack.Contains(joints[k].PartsVertex[i]))
                        {
                            path[stack.Count - 1] = k;
                            stack.Push(joints[k].PartsVertex[i]);
                            joints = stack.Peek().JointsEdge;
                            k = 0;
                            break;
                        }
                        else if (i == 1)
                        {
                            ++k;
                        }
                    }
                    if (stack.Peek() == endPiece)
                    {
                        paths.Add(stack.ToList<PipelineVertex>());
                        break;
                    }
                }

                if (stack.Count > 1)
                {
                    stack.Pop();
                    joints = stack.Peek().JointsEdge;

                    path[stack.Count - 1]++;

                    k = path[stack.Count - 1];
                }
                else
                    break;
            }
            return paths;
        }
    }



    public class JointEdge
    {
        public construct.Joint Data { get; set; }
        public List<PipelineVertex> PartsVertex { get; set; }

        public JointEdge() { }
        public JointEdge(construct.Joint data)
            : this()
        {
            Data = data;
            PartsVertex = new List<PipelineVertex>();
        }
    }


    public class PipelineVertex
    {
        public construct.PartData Data { get; set; }
        public List<JointEdge> JointsEdge { get; set; }

        public PipelineVertex() { }

        public PipelineVertex(construct.PartData data)
            : this()
        {
            Data = data;
            JointsEdge = new List<JointEdge>();
        }


        public override string ToString()
        {
            return this.Data.Number;
        }
    }
}
