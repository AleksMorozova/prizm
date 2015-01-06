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
        private const int maximumPathsNumber = 2;
        private Dictionary<Guid, PipelineVertex> piecesVertex;

        public PipelineGraph(int capacity) 
        {
            this.piecesVertex = new Dictionary<Guid, PipelineVertex>(capacity);
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
                if (piecesVertex.ContainsKey(joint.FirstElement.Id) &&
                    piecesVertex.ContainsKey(joint.SecondElement.Id))
                {
                    jointEdge.PartsVertex.Add(piecesVertex[joint.FirstElement.Id]);
                    jointEdge.PartsVertex.Add(piecesVertex[joint.SecondElement.Id]);

                    piecesVertex[joint.FirstElement.Id].JointsEdge.Add(jointEdge);
                    piecesVertex[joint.SecondElement.Id].JointsEdge.Add(jointEdge);
                }
            }
            catch
            {
                //TODO: NullReference
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

            while (stack.Count > 0 && paths.Count < maximumPathsNumber)
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

        public List<PipelineVertex> ShortestPath(List<List<PipelineVertex>> paths)
        {
            var shortestPath = paths.First();

            foreach (var p in paths)
            {
                if (p.Count < shortestPath.Count)
                {
                    shortestPath = p;
                }
            }

            return shortestPath;
        }
    }

    public class JointEdge
    {
        public construct.Joint Data { get; set; }
        public List<PipelineVertex> PartsVertex { get; set; }

        public JointEdge(construct.Joint data)
        {
            Data = data;
            PartsVertex = new List<PipelineVertex>();
        }
    }

    public class PipelineVertex
    {
        public construct.PartData Data { get; set; }
        public List<JointEdge> JointsEdge { get; set; }

        public PipelineVertex(construct.PartData data)
        {
            Data = data;
            JointsEdge = new List<JointEdge>();
        }

        public JointEdge GetCommonJoint(PipelineVertex pipelineVertex)
        {
            JointEdge commonJoint = null;

            foreach (var thisJoint in this.JointsEdge)
            {
                if (commonJoint == null)
                {
                    foreach (var thatJoint in pipelineVertex.JointsEdge)
                    {
                        if (thatJoint == thisJoint)
                        {
                            commonJoint = thisJoint;
                            break;
                        }
                    }
                }
            }

            return commonJoint;
        }
    }
}
